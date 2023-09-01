const tmplNACDocument = document.createElement('template');

tmplNACDocument.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:column;
            }
        </style>

        <div id="container" class="container">
            <slot name="doc-header"></slot>
            <slot name="doc-body"></slot>
            <slot name="doc-footer"></slot>
        </div>
    `

class NACDocument extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocument.content.cloneNode(true))
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



window.customElements.define('nac-document', NACDocument);

