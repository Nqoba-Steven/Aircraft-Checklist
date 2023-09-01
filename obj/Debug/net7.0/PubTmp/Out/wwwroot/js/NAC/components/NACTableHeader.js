const tmplNACTableHeader = document.createElement('template');

tmplNACTableHeader.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:row;
                flex-grow:1;
                min-width:30vw;
                justify-content:space-evenly;
                border-bottom:1px solid black;
            }
            ::slotted(*:not(:last-child)) {
                border-right: 1px solid black;
            }
        </style>

        <div id="container" class="container">
            <slot name="header-item"></slot>
        </div>
    `

class NACTableHeader extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTableHeader.content.cloneNode(true))
        this.container = this.$('container');
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'title':
                this.container.innerHTML = newVal;
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['title']
    }
}



window.customElements.define('nac-table-header', NACTableHeader);

