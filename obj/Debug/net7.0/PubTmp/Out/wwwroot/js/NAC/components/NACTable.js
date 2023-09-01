const tmplNACTable = document.createElement('template');

tmplNACTable.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-wrap:wrap;
                flex-direction:row;
                border:1px solid black;
                flex-grow:1;
            }
        </style>

        <div id="container" class="container">
            <slot name="table-body"></slot>
            <slot name="table-header"></slot>
        </div>
    `

class NACTable extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTable.content.cloneNode(true))
        this.addEventListener('build', (evt) => {
            console.log(evt);
        });
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {

        
    }
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



window.customElements.define('nac-table', NACTable);

