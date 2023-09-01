const tmplNACDocumentFooter = document.createElement('template');

tmplNACDocumentFooter.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:row;
                border:2px solid black;
                max-height:24px;
                justify-content: space-between;
                padding: 32px;
                padding-top:4px;
                padding-bottom:4px;
            }
            .container > *:not (:first-child) {
                border-left: solid green 2px;
            }
            .footerText{
                text-align:center;
            }
        </style>

        <div id="container" class="container">
            <div id="revision" class="footerText"></div>
            <div id="date" class="footerText"></div>
            <div id="pages" class="footerText"></div>
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
                this.date.innerHTML = `Date: ${Date.now()}`;
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

