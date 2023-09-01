const tmplNacDropdownItem = document.createElement('template');

tmplNacDropdownItem.innerHTML =
    `
        <style>
            .container{

            }
        </style>

        <div id="container" class="container">
        </div>
    `

class NACDropdownItem extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNacDropdownItem.content.cloneNode(true))
        this.value = '';
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'value':
                this.value = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['value']
    }
}



window.customElements.define('nac-dropdown-item', NACDropdownItem);

