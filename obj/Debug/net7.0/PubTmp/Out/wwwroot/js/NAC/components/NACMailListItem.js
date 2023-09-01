const tmplNACMailListItem = document.createElement('template');

tmplNACMailListItem.innerHTML =
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
            input{
                display:flex;
            }
        </style>

        <div id="container" class="container">
             <div id="displayName" class="name"></div>
             <div id="email" class="name"></div>
             <input disabled id="isActive" type="checkbox" class="name"/>
             <input disabled id="b1900Revison" type="checkbox" class="name"/>
             <input disabled id="b1900Review" type="checkbox" class="name"/>
             <input disabled id="b1900Upload" type="checkbox" class="name"/>
             <input disabled id="learjetRevison" type="checkbox" class="name"/>
             <input disabled id="learjetReview" type="checkbox" class="name"/>
             <input disabled id="learjetUpload" type="checkbox" class="name"/>
        </div>
    `

class NACMailListItem extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACMailListItem.content.cloneNode(true))
        this.container = this.$('container');
        this.action = '';
        this.displayName = this.$('displayName');
        this.email = this.$('email');
        this.isActive = this.$('isActive');
        this.b1900 = {
            revision: this.$('b1900Revison'),
            review: this.$('b1900Review'),
            upload: this.$('b1900Upload'),
        }
        this.learjet = {
            revision: this.$('learjetevison'),
            review: this.$('learjetReview'),
            upload: this.$('learjetUpload'),
        }
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
            case 'display-name':
                this.displayName.innerHTML = newVal;
                break;
            case 'email':
                this.email.innerHTML = newVal;
                break;
            case 'is-active':
                this.isActive.checked = newVal ? 1 : 0;
                break;
            case 'b1900-revision':
                this.b1900.revision.checked = newVal ? 1 : 0;
                break;
            case 'b1900-review':
                this.b1900.review.checked = newVal ? 1 : 0;
                break;
            case 'b1900-upload':
                this.b1900.upload.checked = newVal ? 1 : 0;
                break;
            case 'learjet-revision':
                this.learjet.revision.checked = newVal ? 1 : 0;
                break;
            case 'learjet-review':
                this.learjet.review.checked = newVal ? 1 : 0;
                break;
            case 'learjet-upload':
                this.learjet.upload.checked = newVal ? 1 : 0;
                break;
            case 'action':
                this.action = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['display-name', 'email', 'is-active', 'b1900-revision', 'b1900-review', 'b1900-upload', 'learjet-revision', 'learjet-review', 'learjet-upload', 'action']
    }
}



window.customElements.define('nac-mail-list-item', NACMailListItem);

