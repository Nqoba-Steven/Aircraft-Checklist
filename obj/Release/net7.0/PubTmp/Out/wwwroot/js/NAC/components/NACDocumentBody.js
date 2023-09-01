const tmplNACDocumentBody = document.createElement('template');

tmplNACDocumentBody.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-grow:1;
                flex-wrap:wrap;
            }
        </style>

        <div id="container" class="container">
            <slot name="content"></slot>
        </div>
    `

class NACDocumentBody extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentBody.content.cloneNode(true))
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case '':

                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['']
    }
}

window.customElements.define('nac-document-body', NACDocumentBody);

