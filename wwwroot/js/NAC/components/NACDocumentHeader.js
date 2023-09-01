const tmplNACDocumentHeader = document.createElement('template');

tmplNACDocumentHeader.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:row;
                border:2px solid black;
                justify-content: space-between;
                height:96px;
            }
            .logo{
                display:flex;
                flex-direction:row;
                justify-content: center;
                height:48px;
            }
           
            .docTitle{
                font-size: 14pt;
                font-weight: bold;
                align-items: center;
                justify-content: center;
                align-self: center;
            }
            .logoContainer{
                border-right: 2px solid black;
                align-items: center;
                display: flex;
            }
            .docNumber{
                display: flex;
                border-left: 2px solid black;
                flex-direction: column;
                height: 100%;
                max-width: 128px;
                text-align: center;
                justify-content: center;
                margin: 0;
            }
        </style>

        <div id="container" class="container">
            <div class="logoContainer">
                <img id="logo" class="logo"  alt="NAC logo"/>
            </div>
            <div id="docTitle" class="docTitle"></div>
            <div class="docNumber">
                <div >Document Number:</div>
                <div id="docNumber">#000</div>
            </div>
        </div>
    `

class NACDocumentHeader extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentHeader.content.cloneNode(true))
        this.logo = this.$('logo');
        this.docTitle = this.$('docTitle');
        this.docNumber = this.$('docNumber');
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    loadLogo(src) {
        this.logo.setAttribute('src',src) 
    }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'src':
                this.loadLogo(newVal)
                break;
            case 'document-title':
                console.log(5)
                this.docTitle.innerHTML = newVal;
                break;
            case 'document-number':
                this.docNumber.innerHTML = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['document-title','document-number','src']
    }
}

window.customElements.define('nac-document-header', NACDocumentHeader);

