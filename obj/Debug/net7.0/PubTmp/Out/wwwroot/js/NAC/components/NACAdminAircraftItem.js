const tmplNacAdminAircraftItem = document.createElement('template');

tmplNacAdminAircraftItem.innerHTML =
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
             <div id="reg" class="name"></div>
             <div id="baseOps" class="name"></div>
             <div id="type" class="name"></div>
             <div id="email" class="name"></div>

        </div>
    `

class NacAdminAircraftItem extends HTMLElement {
    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNacAdminAircraftItem.content.cloneNode(true))
        this.reg = this.$('reg');
        this.baseOps = this.$('baseOps');
        this.type = this.$('type');
        this.email = this.$('email');
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() { }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'reg':
                this.reg.innerHTML = "" + newVal;
                break;
            case 'email':
                this.email.innerHTML = "" + newVal;
                break;
            case 'type':
                this.type.innerHTML = "" + newVal;
                break;
            case 'base-ops':
                this.baseOps.innerHTML = "" + newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['reg','email', 'type', 'base-ops']
    }
}

window.customElements.define('nac-admin-aircraft-item', NacAdminAircraftItem);

