const tmplNacDropdown = document.createElement('template');

tmplNacDropdown.innerHTML =
    `
        <style>
            .selector{
                width:100%;
                text-align:center;
            }
        </style>
        <slot name="option"></slot>
        <select value="" class="selector" id='selector'><option value="" disabled selected value>-Select-</option>
        </select>
    `

class NACDropdown extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({mode:'open'})
        this.shadowRoot.appendChild(tmplNacDropdown.content.cloneNode(true))
        this.selector = this.$('selector');

    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        var slots = this.shadowRoot.querySelectorAll('slot');
        this.selector.addEventListener('change', e => {
            console.log(e)
            this.setAttribute('selected', this.selector.value)
        })
        slots[0].addEventListener('slotchange', e => {
            let nodes = slots[0].assignedNodes();
            this.build(nodes)
        })
    }
    build(nodes) {
        for (var i = 0; i < nodes.length; i++) {
            var option = document.createElement('option');
            option.setAttribute('value',nodes[i].getAttribute('value'))
            option.innerHTML = nodes[i].getAttribute('value');
            this.selector.appendChild(option)
        }
    }
    disconnectedCallback() { }
    attributeChangedCallback(name,oldVal,newVal){
        switch (name) {
            case '':
                
                break;
        
            default:
                break;
        }
    }
    static get observedAttributes(){
        return ['value']
    }
}



window.customElements.define('nac-dropdown', NACDropdown);

