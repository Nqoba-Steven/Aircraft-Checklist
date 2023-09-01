const tmplNACAuditTable = document.createElement('template');


tmplNACAuditTable.innerHTML =
    `
        <style>
            .container{

            }
            
    table {
        border-collapse: collapse;
        margin-top: 24px;
        margin-bottom: 24px;
    }

    th, td {
        border: 1px solid black;
        padding: 4px;
    }

    td {
        text-align: left;
        font-size: 9pt;
    }

    th {
        text-align: center;
    }

    td {
        position: relative;
    }
   
    input {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        border: none;
    }

    textarea {
        border: none;
        resize: none;
    }

    .colspan-3 {
        width: 100px;
    }

    .rowspan-2 {
        height: 25px;
    }

 

        </style>

        <div id="container" class="container">
            <table>
                  <thead id="header"></thead>
                  <tbody id="tbody">
                        <td>
                            <slot name="field"></slot>
                        </td>
                  </tbody>
            </table>
        </div>
    `

class NACAuditTable extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACAuditTable.content.cloneNode(true))
        this.header = this.$('header')
        this.tbody = this.$('tbody')
        this.tableName = '';
        this.counter = 1;
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        console.log(this.children);

    }

    buildField(questionID, question) {
        //create fields
        //append
        //how to cn
        let content = ``;
        switch (this.tableName) {

            case 'interior':
                content =
                    `
                    <tr>
                         <td class="rowName">
                             ${this.counter}. ${question}
                             <input name="${questionID}" value="${questionID}" type="hidden" />
                         </td>
                         <td>
                              <textarea name="Status" rows="3" maxlength="150"></textarea>
                         </td>
                         <td>
                              <textarea name="Comments" rows="3" placeholder="" type="text" maxlength="150"></textarea>
                         </td>
                      </tr>
                `;
                break;
            case 'exterior':
                content =
                    `
                    <tr>
                        <td class="rowName">
                            ${this.counter}. ${question}
                            <input name="${questionID}" value="${questionID}" type="hidden" />
                        </td>
                        <td>
                            <textarea name="Status" rows="3" maxlength="150"></textarea>
                        </td>
                        <td>
                            <textarea name="Comments" rows="3" placeholder="" type="text" maxlength="150"></textarea>
                        </td>
                    </tr>
                `;
            case 'cockpit':
                content =
                    `
                    <tr>
                         <td class="rowName">
                             ${this.counter}. ${question}
                             <input name="${questionID}" value="${questionID}" type="hidden" />
                         </td>
                         <td>
                            <input name="ExpiryDate" placeholder="" type="date" maxlength="150" />
                         </td>
                         <td>
                            <textarea name="Status" rows="3" maxlength="150"></textarea>
                         </td>
                         <td>
                            <textarea name="Comments" rows="3" placeholder="" type="text" maxlength="150"></textarea>
                         </td>
                      </tr>
                `;
                break;
            default:
                break;
        }
        this.tbody.innerHTML = this.tbody.innerHTML + content;
        this.counter = this.counter + 1;
    }

    buildHeader(tableName) {
        let content = ``;

        switch (tableName) {

            case 'interior':
                content = `
                            <tr>
                                <th colspan="4">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th>Status</th>
                                <th>Comments</th>
                            </tr>
                `;
                break;
            case 'exterior':
                content = `
                         <tr>
                                <th colspan="4">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th>Expiry Date</th>
                                <th>Status</th>
                                <th>Comments</th>
                            </tr>
                `;
                break;
            case 'cockpit':
                content = `
                        
                            <tr>
                                <th colspan="4">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th>Expiry Date</th>
                                <th>Status</th>
                                <th>Comments</th>
                            </tr>
                `;
                break;

            case 'cabin':
                content = `
                            <tr>
                                <th colspan="4">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th>Expiry Date</th>
                                <th>Status</th>
                                <th>Comments</th>
                            </tr>
                `;
                break;
            case 'flightFolder':
                content = `
                            <tr>
                                <th colspan="4">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th>Date (if appl.)</th>
                                <th>Rev Status</th>
                                <th>Comments</th>
                            </tr>
                `;
                break;
            case 'ipadManuals':
                content = `
                            <tr>
                            <th colspan="7">${tableName}</th>
                        </tr>
                        <tr>
                            <th></th>
                            <th rowspan="1" colspan="2">Manual Ref Number</th>
                            <th rowspan="1" colspan="1">IPAD FO</th>
                            <th rowspan="1" colspan="1">IPAD PIC</th>
                            <th rowspan="2" colspan="1">Rev Status</th>
                            <th rowspan="2" colspan="1">Comments</th>
                        </tr>
                        <tr>
                            <th></th>
                            <th rowspan="1" colspan="1">Pub No.</th>
                            <th rowspan="1" colspan="1">Vol No.</th>
                            <th rowspan="1" colspan="1">Set No.</th>
                            <th rowspan="1" colspan="1">Set No.</th>
                        </tr>
                `;
                break;
            case 'opsDocs':
                content = `
                            <tr>
                                <th colspan="7">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th rowspan="1">Date (if appl.)</th>
                                <th rowspan="1">Rev Status / Form or Manual #</th>
                                <th rowspan="1">Comments</th>
                            </tr>
                `;
                break;
            case 'aircraftFlipFile':
                content = `
                             <tr>
                                <th colspan="7">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th rowspan="1">Date (if appl.)</th>
                                <th rowspan="1"> Rev Status / QTY</th>
                                <th rowspan="1">Comments</th>
                            </tr>
                `;
                break;
            case 'aircraftFlipFile':
                content = `
                            <tr>
                                <th colspan="7">${tableName}</th>
                            </tr>
                            <tr>
                                <th></th>
                                <th rowspan="1">Date (if appl.)</th>
                                <th rowspan="1">QTY</th>
                                <th rowspan="1">Comments</th>
                            </tr>
                `;
                break;
            default:
                content = `Incorrect Table name ${tableName}`;
                break;
        }
        this.header.innerHTML = content;
    }

    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'table-name':
                this.tableName = newVal;
                this.buildHeader(newVal);
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['table-name']
    }
    static get knownTables() {
        return ['interior', 'exterior', 'cockpit ', 'cabin', 'flightFolder', 'manuals', 'ipadManuals', 'opsDocs', 'aircraftFlipFile', 'equipment']
    }

}



window.customElements.define('nac-audit-table', NACAuditTable);

