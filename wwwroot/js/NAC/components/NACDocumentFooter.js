const tmplNACDocumentFooter = document.createElement('template');

tmplNACDocumentFooter.innerHTML =
    `
        <style>
            .container{
                max-height:24px;
                margin-bottom:16px;
            }
            .container > *:not (:first-child) {
                border-left: solid green 2px;
            }
            .footerText{
                text-align:center;
            }
            table {
                width: 100%;
                border-collapse: collapse;
                margin-top: 24px;
                margin-bottom: 24px;
            }
            th, td {
                border: 1px solid black;
                padding: 4px;
            }
            td {
                text-align: center;
                font-size: 9pt;
                position: relative;
            }
            th {
                text-align: center;
            }
        </style>
       
        <div id="container" class="container">
            <table>
                <thead>
                    <tr>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td id="revision" class="footerText"></td>
                        <td id="date" class="footerText"></td>
                        <td id="pages" class="footerText"></td>
                    </tr>
                </tbody>
            </table>
        </div>
    `

class NACDocumentFooter extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentFooter.content.cloneNode(true))
        this.revision = this.$('revision');
        this.date = this.$('date');
        this.pages = this.$('pages');
        this.pageIndex = 0;
        this.pageTotal = 0;
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        this.date.innerHTML = `Date: ${this.formattedDate(new Date())}`;

    }
    formattedDate(d = new Date) {
        let month = String(d.getMonth() + 1);
        let day = String(d.getDate());
        const year = String(d.getFullYear());
        if (month.length < 2) month = '0' + month;
        if (day.length < 2) day = '0' + day;
        return `${day}-${month}-${year}`;
    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'revision':
                this.revision.innerHTML = `Rev No: ${newVal}`;
                break;
            case 'date':
                this.date.innerHTML = `Date: ${newVal}`;
                break;
            case 'page-index':
                this.pageIndex = newVal;
                this.pages.innerHTML = `Page ${this.pageIndex} of ${this.pageTotal}`
                break;
            case 'page-total':
                this.pageTotal = newVal;
                this.pages.innerHTML = `Page ${this.pageIndex} of ${this.pageTotal}`
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['revision', 'date', 'page-index', 'page-total']
    }
}

window.customElements.define('nac-document-footer', NACDocumentFooter);

