const tmplNACAdminAircraft = document.createElement('template');

tmplNACAdminAircraft.innerHTML =
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
            <div id='sheet' class='hidden'>
            </div>
            <div class="hidden" id="addForm">
                <div class="toolbarTitle">Add Aircraft</div>
                <form>
                    <lable>Aircraft Reg</lable>
                    <input id="aircraftReg" type="text" name="aircraftReg"  />
                    <lable>Base Manager Email Address</lable>
                    <input id="email" type="email" name="email"  />  
                    <lable>Aircraft Type</lable>
                    <input id="aircraftType" type="text" name="aircraftType"  />
                    <lable>Base</lable>
                    <input id="aircraftBase" type="text" name="aircraftBase"  />
                </form>
                <div id="errorMsg" class="hidden"></div>
                <div class="formButtons">
                    <div id="cancelBtn" class="action formAction cancelBtn">Cancel</div>
                    <div id="postBtn" class="action formAction postBtn">Add</div>
                </div>
            </div>
            
            <div id="list" class="list">
                <div id='headers' class='headerContainer'>
                    
                </div>
                
            <div id="msg" class="hidden"></div>
                <slot name="aircraft"><slot>
            </div>
        </div>
    `

class NACAdminAircraft extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACAdminAircraft.content.cloneNode(true))
        this.container = this.$('container');
        this.getTarget = '';
        this.postTarget = '';
        this.toolbarTitle = this.$('toolbarTitle');
        this.addForm = this.$('addForm');
        this.addBtn = this.$('addBtn');
        this.headers = this.$('headers');
        this.msg = this.$('msg');
        this.cancelBtn = this.$('cancelBtn');
        this.postBtn = this.$('postBtn');
        this.sheet = this.$('sheet');
        this.errorMsg = this.$('errorMsg');
        this.isAddFormVisible = false;
        this.aircraftPayload = {
            Reg: null,
            Type: null,
            EmailAddress: null,
            BaseOfOperations: null
        }
    }

    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        this.addBtn.addEventListener('click', evt => {
            this.openForm()
        })
        this.cancelBtn.addEventListener('click', e => {
            //Discard json object
            this.closeForm();
        });
        this.postBtn.addEventListener('click', evt => {
            this.postNewAircraft()
        })
        this.addForm.addEventListener('animationend', e => {
            this.addForm.classList.remove('shake');
        })
        this.checkForContent();
    }
    buildPayload() {
        this.aircraftPayload.Reg = this.$('aircraftReg').value.toLowerCase();
        this.aircraftPayload.EmailAddress = this.$('email').value.toLowerCase();
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

    openForm() {
        this.isAddFormVisible = true;
        this.sheet.className = 'sheet';
        this.addForm.classList.remove('hidden');
        this.addForm.className = "card addForm";
    }
    closeForm() {
        this.sheet.className = 'hidden';
        this.aircraftPayload.Reg = null;
        this.aircraftPayload.Type = null;
        this.aircraftPayload.BaseOfOperations = null;
        this.isAddFormVisible = false;
        this.addForm.className = 'hidden';
    }
    postNewAircraft() {
        this.buildPayload();
        console.log(this.aircraftPayload)
        fetch(this.postTarget, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }, body: JSON.stringify(this.aircraftPayload)
        }).then(res => {
            console.log(res)
            switch (res.status) {
                case 201: //Created
                    console.log('Aircraft successfully created');
                    this.closeForm();
                    window.location.reload();
                    break;
                case 202: //Accepted
                    break;

                case 400: //Already Exits
                    res.json()
                        .then(obj => {
                            console.log(obj);
                            this.showError(obj.error)
                        })
                    break;
            }
           
        }).catch(err => {
            console.trace(err);
        })
    }
    shake() {
        this.addForm.classList.add('shake');
    }
    showError(error) {
        if (error) {
            this.errorMsg.className = 'errMsg';
            this.errorMsg.innerHTML = error;
            this.shake();
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
        return ['get-target', 'card-title', 'post-target', 'msg-empty','headers']
    }
}



window.customElements.define('nac-admin-aircraft', NACAdminAircraft);

