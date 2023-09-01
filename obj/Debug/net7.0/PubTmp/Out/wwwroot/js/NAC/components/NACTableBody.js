const tmplNACTableBody = document.createElement('template');

tmplNACTableBody.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:column;
                flex-wrap:wrap;
                flex-grow:1;
                border:1px solid red;
                min-height:100px;
                min-width:100px;
            }
            .title{
                text-decoration:underline;
            }
            ::slotted(*:not(:last-child)) {
                border-bottom: 1px solid black;
            }
        </style>

        <div id="container" class="container">
            <div id="title" class="title"></div>
            <slot name="body-item"></slot>
        </div>
    `

class NACTableBody extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTableBody.content.cloneNode(true));
        this.Title = this.$('title');
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        let map = new Map();
        map.set('1', 'Some Value');

        var buildEvt = new CustomEvent('build', {
            bubbles: true,
            detail: {
                fields: map
            },
            composed: true
        })
        this.dispatchEvent(buildEvt);
        console.log(`${this.parentElement.localName}`)
        console.log(`${buildEvt.detail}`)
    }
    build() {
        //Build the tabled elements

    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'title':
                this.Title.innerHTML = newVal;
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['title']
    }
}



window.customElements.define('nac-table-body', NACTableBody);

