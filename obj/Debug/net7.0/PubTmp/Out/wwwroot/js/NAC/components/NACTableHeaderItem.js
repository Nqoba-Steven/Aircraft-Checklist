const tmplNACTableHeaderItem = document.createElement('template');

tmplNACTableHeaderItem.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-wrap:wrap;
                flex-grow:1;
                text-align:center;
            }
        </style>

        <div id="container" class="container">
        </div>
    `

class NACTableHeaderItem extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTableHeaderItem.content.cloneNode(true))
        this.container = this.$('container');
        this.type = '';
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'title':
                this.container.innerHTML = newVal;
                break;
            case 'type':
                if (newVal)
                    switch (newVal.toLowerCase()) {
                        case 'date':
                            this.type = 'date';
                            break;
                        case 'bool':
                            this.type = 'bool';
                            break;
                        case 'text':
                            this.type = 'text';
                            break;
                        case 'number':
                            this.type = 'number';
                            break;
                        default:
                            this.type = 'text';
                            break;
                    }
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['title', 'type']
    }
}

window.customElements.define('nac-table-header-item', NACTableHeaderItem);

