const tmplNACEmailer = document.createElement('template');

tmplNACEmailer.innerHTML =
    `
        <style>
            .container{
                display:flex;
                justify-content:space-around;
                flex-direction:column;
                align-items: center;
                align-content:center;
                width:480px;
                height:480px;
                background-color:#fff;
                box-shadow:rgba(0,0,0,0.25) 0px 0px 4px 1px;
                border-radius:4px; 
                margin:8px;
                scroll-snap-align: start;
            }
            .address{
                min-width:60%;
                display:flex;
            }
            .msg{
                min-height:80px;
                display:flex;
                min-width:80%;
            }
            .btn{
                border-radius:4px;
                background-color:#00bcd4;
                min-width: 80px;
                max-width: 80px;
                text-align: center;
            }
        </style>

        <div id="container" class="container">
            <h1>Emailer</h1>
            <lable>To</lable>
            <input title="address" id="address" class="address" type="email"/>
            <lable>Subject</lable>
            <input title="subject" id="subject" class="address" type="text"/>
            <lable>Message</lable>
            <input title="msg" id="msg" class="msg" type="textarea"/>
            <div id="btn" class="btn" >Send</div>
        </div>
    `

class NACEmailer extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACEmailer.content.cloneNode(true))
        this.btn = this.$('btn');
        this.target = '';
    }
    $(id) { return this.shadowRoot.getElementById(id) }
    connectedCallback() {
        this.btn.addEventListener('click', e => {
            var mail = this.getMail();

            console.log(mail)
            var obj = {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: (JSON.stringify(mail))
            }
            fetch(this.target, obj)
                .then(res => {
                    console.log(res);
                }).catch(err => {
                    console.error(err);
                })
        });
    }
    getMail() {
        var mail = {
            To: ''+this.$('address').value,
            Subject:''+ this.$('subject').value,
            Message :''+ this.$('msg').value
        }
        return mail;
    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'target':
                this.target = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['target']
    }
}



window.customElements.define('nac-emailer', NACEmailer);

