const tmplNACAuditTableField = document.createElement('template');

tmplNACAuditTableField.innerHTML =
    `
        <style>
            .container{

            }
             textarea{
               resize:none ;
            }
    </style>
           <td id="question">Question</td>
           <td>
                <textarea rows="3" maxlength="150"></textarea>
           </td>
           <td>
               <textarea rows="3" placeholder="" type="text" maxlength="150"></textarea>
           </td>
    `

class NACAuditTableField extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACAuditTableField.content.cloneNode(true))
    }
    $(id) { return this.shadowRoot.getElementById(id) }



    connectedCallback() { }


    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'question-id':
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['question-id','question']
    }
}



window.customElements.define('nac-audit-table-field', NACAuditTableField);

