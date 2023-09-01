const tmplNACDocumentList= document.createElement('template');

tmplNACDocumentList.innerHTML =
    `
        <style>
             .container{
                display:flex;
                flex-direction:column;
                max-height:80%;
                max-width:90vw;
                background-color:#fffffff0;
                background-filter:blur(48px);
                box-shadow:rgba(0,0,0,0.25) 0px 0px 4px 1px;
                border-radius:8px; 
                margin:8px;

                scroll-snap-align: start;
                -webkit-touch-callout: none; /* iOS Safari */
                -webkit-user-select: none; /* Safari */
                -khtml-user-select: none; /* Konqueror HTML */
                -moz-user-select: none; /* Old versions of Firefox */
                -ms-user-select: none; /* Internet Explorer/Edge */
            }
            .card{
                max-height:80%;
                max-width:90vw;
                background-color:#fffffff0;
                box-shadow:rgba(0,0,0,0.25) 0px 0px 4px 1px;
                border-radius:8px; 
                margin:8px;
            }
            .name{
                font-size: 12pt;
                font-weight: 600;
                font-variant: all-petite-caps;
                overflow-x:auto;
            }
           .list{
                border-top:0.25px solid #00000024;
                padding:8px;
                display:flex;
                flex-direction:column;
                overflow-y: auto;
                max-height:590px;
                height: fit-content;
            }
            .toolbar{
                box-shadow: rgba(0, 0, 0, 0.12) 0px 1px 3px, rgba(0, 0, 0, 0.24) 0px 1px 2px;
                display:flex;
                flex-direction: row;
                justify-content: space-between;   
                align-items: center;
                padding:8px;
            }
            .toolbarTitle{
                font-size:18pt;
                color: #646464;
            }
            .headerContainer{
                display:flex;
                justify-content:space-between;
                padding-bottom:8px;
                border-bottom:1px solid #0000002b;
            }
            .header{
                font-weight:600;
                text-align:left;
                width:25%;
            }
            .addForm{
                z-index:100;
                position:relative;
                margin:auto;
                display:flex;
                flex-direction:column;
                height:400px;
                width:400px;
                align-items: center;
                justify-content: space-between;
                padding:8px;
            }
            .addForm form{
                display:flex;
                flex-direction:column;
                height: 50%;
                flex-direction: column;
                justify-content: space-around;
            }
            .action{
                display:flex;
                min-width:64px;
                min-height:32px;
                max-height:32px;
                align-items: center;
                justify-content: center;
                border-radius: 20px;
                box-shadow: 0px 0px 1px 1px #1e191942;
            }
            .action:hover{
                  box-shadow: 0px 0px 2px 2px #1e191942;
            }
            .hidden{
                display:none;
            }
            .msg{
                display: block; 
                text-align: center;
                align-items: center;
                align-content: center;
                color: #E0E0E0;
                font-size: 24pt;
            }
            .formButtons{
                display:flex;
                flex-direction:row;
                justify-content: space-between;
                width: 100%;
                border-radius:2px;
            }
            .formAction{
                width:49%;
                border-radius: 8px;
            }
            input{
                height:20pt;
                font-size:20pt;
                border-radius:20px;
                text-align:center;
                border:1px solid #455A64;
            }
            lable{
                text-align: center;
            }
            .cancelBtn{
                background-color:#E0E0E0;
            }
            .postBtn{
                background-color:#2196f3;
                color:#FAFAFA;
            }
            .errMsg{
                display: block; 
                text-align: center;
                align-items: center;
                align-content: center;
                color: #f44336;
                font-size: 16pt;
            }
            @keyframes shake {
              10% { transform: translateX(0); }
              20% { transform: translateX(-5px); }
              30% { transform: translateX(5px); }
              40% { transform: translateX(-5px); }
              50% { transform: translateX(5px); }
              60% { transform: translateX(-5px); }
              70% { transform: translateX(5px); }
              80% { transform: translateX(-5px); }
              90% { transform: translateX(5px); }
              100% { transform: translateX(-5px); }
            }

            .shake {
              animation: shake 0.5s linear;
            }
            .sheet{
                z-index:90;
                top:0;
                left:0;
                width:100vw;
                height:100vh;
                position:absolute;
                background-color:#000000ba;
                display: flex;
            }
        </style>

        <div id="container" class="container">
            <div class="toolbar" id="toolbar">
                <div class="toolbarTitle" id="toolbarTitle">Title</div>    
                <div id="addBtn" class="action">Add</div>
            </div>
            <div id="list" class="list">
                <div id='headers' class='headerContainer'>
                </div>
                
            <div id="msg" class="hidden"></div>
                <slot name="item"><slot>
            </div>
        </div>
    `

class NACDocumentList extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACDocumentList.content.cloneNode(true))
        this.container = this.$('container');
        this.getTarget = '';
        this.postTarget = '';
        this.toolbarTitle = this.$('toolbarTitle');
        this.headers = this.$('headers');
        this.msg = this.$('msg');
        this.addBtn = this.$('addBtn');
        this.aircraftPayload = {
            Reg: null,
            Type: null,
            BaseOfOperations: null
        }
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        this.addBtn.addEventListener('click', evt => {
            console.log('Redirect to Create Page');
            window.location = this.postTarget;
        });
        this.checkForContent();
    }
    buildPayload() {
        this.aircraftPayload.Reg = this.$('aircraftReg').value.toLowerCase();
        this.aircraftPayload.Type = this.$('aircraftType').value.toLowerCase();
        this.aircraftPayload.BaseOfOperations = this.$('aircraftBase').value.toLowerCase();
    }
    checkForContent() {
        let slots = this.shadowRoot.querySelectorAll('slot');
        console.log("slots")
        console.log()
        if (slots[1].assignedNodes().length == 0) {
            this.msg.className = "msg";
        } else {
            this.msg.className = "hidden";
        }
    }
    
    createHeaders(list) {
        var headers = list.split(',')
        headers.forEach(header => {
            var headerDiv = document.createElement('div');
            headerDiv.className = 'header';
            headerDiv.innerHTML = header;
            this.headers.appendChild(headerDiv);
        })
    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            //The action for a get 
            case 'card-title':
                this.toolbarTitle.innerHTML = "" + newVal;
                break;
            case 'get-target':
                this.getTarget = newVal;
                break;
            case 'post-target':
                this.postTarget = newVal;
                break;
            case 'msg-empty':
                this.msg.innerHTML = newVal;
                break;

            case 'headers':
                console.log(newVal)
                this.createHeaders(newVal)
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['get-target', 'card-title', 'post-target', 'msg-empty', 'headers']
    }
}



window.customElements.define('nac-document-list', NACDocumentList);

