const tmplNACAuditForm= document.createElement('template');

tmplNACAuditForm.innerHTML =
    `
        <style>
            .container{

            }
        </style>

        <div id="container" class="container">
            <nac-document-details id="documentDetails">
            </nac-document-details>
            <div id="content">
                <slot name="auditTable"></slot>
            </div>
        </div>
    `

class NACAuditForm extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACAuditForm.content.cloneNode(true))
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



window.customElements.define('nac-audit-form', NACAuditForm);

