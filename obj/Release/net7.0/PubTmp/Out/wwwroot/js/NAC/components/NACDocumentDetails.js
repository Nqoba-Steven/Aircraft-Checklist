const tmplNACDocumentDetails = document.createElement('template');

tmplNACDocumentDetails.innerHTML =
    `
        <style>
            .container{
                display: flex;
                flex-direction: column;
                padding: 2px;
            }
            .logo{
                display:flex;
                flex-direction:row;
                justify-content: center;
                height:48px;
            }
           
            .docTitle{
                font-size: 14pt;
                font-weight: bold;
                align-items: center;
                justify-content: center;
                align-self: center;
            }
            .logoContainer{
                border-right: 2px solid black;
                align-items: center;
                display: flex;
            }
            .docNumber{
                display: flex;
                border-left: 2px solid black;
                flex-direction: column;
                height: 100%;
                max-width: 128px;
                text-align: center;
                justify-content: center;
                margin: 0;
            }
            .field{
                display: flex;
                flex-direction: row;
                justify-content: space-between;
            }
            td{
                font-weight:bold;
                font-size: 9pt;
            }
            .row{
                display:flex;
                flex-direction:row;
                justify-content: space-between;
            }
            input{
                width:90%;
            }
            :slotted{
                color:red;
            }
            .x{
                font-size:9pt;
                display:flex;
                flex-direction:row;
            }
            .y{
                font-size:9pt;
                display:flex;
                flex-direction:column;
            }
        </style>

        <div id="container" class="container">
        <!-- 
        <div class="y">
            <div class='x'>
                <div class='x'>
                    <td >Aircraft registration</td>
                    <slot id="aircraftReg"  name="dropdown"> </slot>
                </div>
                <div class='x'>
                    <td style="text-align:end;">Date</td>
                    <input name="date" type="date" />
                </div>
            </div>    
            <div class='x'>
                <td>Base of Operations</td>
                <input name="baseOfOperations" type="text" />
                <td>Completed By</td>
               <input name="completedBy" type="text" />
            </div>    
       </div>    
            <div class="x"></div>
            -->
            <table>
                <tbody>
                     <tr>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>   
                    <tr>
                        <td >Aircraft registration</td>
                        <td>
                        <slot id="aircraftReg"  name="dropdown"> </slot>
                        </td>
                        <td style="text-align:end;">Date</td>
                        <td>
                            <input name="date" type="date" />
                        </td>
                       
                    </tr>
                    <tr>
                        <td>Base of Operations</td>
                        <td>
                            <input name="baseOfOperations" type="text" />
                        </td>
                        <td>Completed By</td>
                        <td>
                            <input name="completedBy" type="text" />
                        </td>
                    </tr>
                </tbody>
             </table>

        </div>
    `

class NACDocumentDetails extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentDetails.content.cloneNode(true))
        this.aircraftReg = this.$('aircraftReg');
        this.date = this.$('date');
        this.completedBy = this.$('completedBy');
        this.baseOfOperations = this.$('baseOfOperations');
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        this.populateDropDown();
    }

    populateDropDown() {
        let slots = this.shadowRoot.querySelectorAll('slot');
        //For ever element slotted in create a drop down in the value
        if (slots.length > 0)
            slots[0].assignedNodes().forEach(node => {
                console.log(node);
            })
        else
            console.error('ERRR')
    }

    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'aircraft-reg':
                this.aircraftReg.innerHTML = newVal;
                break;
            case 'base-of-operations':
                console.log(5)
                this.baseOfOperations.innerHTML = newVal;
                break;
            case 'date':
                this.date.innerHTML = newVal;
                break;
            case 'completed-by':
                this.completedBy.innerHTML = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['aircraft-reg', 'base-of-operations', 'date', 'completed-by']
    }
}

window.customElements.define('nac-document-details', NACDocumentDetails);

