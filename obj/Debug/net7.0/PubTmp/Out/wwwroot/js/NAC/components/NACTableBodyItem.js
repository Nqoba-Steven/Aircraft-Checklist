const tmplNACTableBodyItem= document.createElement('template');

tmplNACTableBodyItem.innerHTML =
    `
        <style>
            .container{

            }
        </style>

        <div id="container" class="container">
        </div>
    `

class NACTableBodyItem extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTableBodyItem.content.cloneNode(true))
        this.container = this.$('container'); 
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'item-title':
                this.container.innerHTML = newVal;
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['item-title']
    }
}



window.customElements.define('nac-table-body-item', NACTableBodyItem);

