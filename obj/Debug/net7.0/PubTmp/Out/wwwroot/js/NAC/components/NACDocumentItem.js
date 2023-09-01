const tmplNACDocumentItem = document.createElement('template');

tmplNACDocumentItem.innerHTML =
    `
         <style>
            #container:hover{
                cursor:pointer;
                box-shadow: rgba(0, 0, 0, 0.12) 0px 1px 3px, rgba(0, 0, 0, 0.24) 0px 1px 2px;
            }
            not:hover{
                background-color:#fff;
            }
            .container{
                display:flex;
                flex-direction:row;
                flex-wrap: wrap;
                align-items:center;
                width:inherit;
                min-width:fit-content;
                min-height:48px;
                height:fit-content;
                margin-bottom:4px;
                scroll-snap-align: start;
                padding-left:8px;
                justify-content:space-between;
            }
            
            .name{
                display:flex;
                flex-direction:row;
                align-content: center;
                flex-wrap: wrap;
                font-weight:650;
                width:25%;
                min-wdth:25%;
                max-wdth:25%;
                text-align:center;
                text-transform: uppercase;
            }
        </style>

        <div id="container" class="container">
             <div id="createdBy" class="name"></div>
             <div id="dateUploaded" class="name"></div>
             <div id="revision" class="name"></div>
        </div>
    `

class NACDocumentItem extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentItem.content.cloneNode(true))
        this.container = this.$('container');
        this.action = '';
        this.itemId = null;
        this.createdBy = this.$('createdBy');
        this.dateUploaded = this.$('dateUploaded');
        this.revision = this.$('revision');
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        this.container.addEventListener('click', evt => {
            //Make a request to get Item from Action
            window.location = this.action;
        })
    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'item-id':
                this.itemId = newVal;
                break;
            case 'date-uploaded':
                this.dateUploaded.innerHTML = "" + newVal;
                break;
            case 'created-by':
                this.createdBy.innerHTML = "" + newVal;
                break;
            case 'revision':
                this.revision.innerHTML = "" + newVal;
                break;
            case 'action':
                this.action = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['item-id', 'date-uploaded', 'created-by', 'revision', 'action']
    }
}



window.customElements.define('nac-document-item', NACDocumentItem);

