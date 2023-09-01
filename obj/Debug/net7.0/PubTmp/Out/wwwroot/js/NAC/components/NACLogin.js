const tmplNACLogin = document.createElement('template');

tmplNACLogin.innerHTML =
    `
        <style>
            .isHidden{
                opacity: 0;
                transition: opacity 1s;
                display: flex;
                flex-direction: column;
                justify-content: space-between;
                max-width: 256px;
                justify-items: center;
                align-items: center;
            }
            .container{
                opacity: 1;
                transition: opacity 0.5s;
                display: flex;
                flex-direction: column;
                justify-content: space-between;
                max-width: 256px;
                justify-items: center;
                align-items: center;
            }
            @keyframes shake{
            
            }
            .profilePic
            {
                border-radius: 100%;
                min-width: 164px;
                align-items: center;
                width: 164px;
                align-content: center;
                height: 164px;
                display: flex;
                max-height: 164px;
                background-color: #fff;
                box-shadow: 2px 3px 5px 1px rgb(0 0 0 / 37%);
                justify-content: center;
            }
            .profilePic svg{
                max-width: 128px;
                display: flex;
                stroke:#fff;
            }
            .loginBtn{
                display:flex;
                width:24px;
                height:32px;
                overflow:hidden;
                align-items:center;
                background-color:#00000065;
                border-radius:0px 4px 4px 0px;
            }
            .password
            {
                display:flex;
                flex-direction:row;
                border-radius:4px;
                box-shadow: 2px 3px 5px 1px rgb(0 0 0 / 37%);
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
            .error{
                display:flex;
            }
            #username{
                box-shadow: 2px 3px 5px 1px rgb(0 0 0 / 37%);
            }
            .fields
            {
                background-color:#00000080;
                border:none;
                width:200px;
                height:32px;
                border-radius:4px;
                font-size:14pt;
                color:white;
                text-align:center;
            }
            textarea:focus, input:focus{
                outline: none;
            }
            .focused{
                border:none;
                border-bottom:solid 2px blue;
                background-color:#00000080;
                width:200px;
                height:32px;
                border-radius:4px;
                font-size:14pt;
                color:white;
                text-align:center;
            }
            .password input
            {
                width:176px;
                border-radius:4px 1px 1px 4px;
            }
            form
            {
                margin: 48px;
                display:flex;
                flex-direction:column;
                justify-content: space-between;
                flex-wrap: wrap;
                align-items: center;
                flex: 0 0 50%;
            }
            #error{
                color:#fff;
                font-family: cursive;
            }
        </style>

        <div id="container" class="isHidden">
            <div id="profilePic" class="profilePic" >
            <svg viewBox="0 0 2048 2048"><path fill="#565656" d="M1568 384q40 0 68 28t28 68v1472q0 40-28 68t-68 28H480q-40 0-68-28t-28-68V480q0-40 28-68t68-28h312L600 0h144l192 384h176L1304 0h144l-192 384h312zm-32 128h-536l81 163q7 16 7 29 0 26-19 45t-45 19q-18 0-33-9t-24-26L856 512H512v1408h1024V512zm-768 640q0-53 20-99t55-82 81-55 100-20q53 0 99 20t82 55 55 81 20 100q0 49-18 95t-52 81q46 25 82 61t62 80 40 93 14 102h-128q0-53-20-99t-55-82-81-55-100-20q-53 0-99 20t-82 55-55 81-20 100H640q0-52 14-101t39-94 62-80 83-61q-33-35-51-81t-19-95zm384 0q0-27-10-50t-27-40-41-28-50-10q-27 0-50 10t-40 27-28 41-10 50q0 27 10 50t27 40 41 28 50 10q27 0 50-10t40-27 28-41 10-50z" fill="#333333"></path></svg>
            </div>
            <form>
                <div>
                    <input id="username" type="text" class="fields" style="margin-bottom:32px;"  lable="username" name="username" placeholder="Username"/>
                </div>
                <div class="password" id="passwordParent" >
                    <input id="password" class="fields" min-width="176px" type="password" lable="password" name="password" placeholder="Password"/>
                     <div id="loginBtn" class="loginBtn" >
                            <svg xmlns="http://www.w3.org/2000/svg" height="24" viewBox="0 -960 960 960" width="24"><path fill="#ffffff8f" d="m480-200-20-20 246-246H200v-28h506L460-740l20-20 280 280-280 280Z"/></svg>
                        </div>
                   </div>
            </form>
            <div class="isHidden" id="error">Incorrect User Details</div>
        </div>
    `

class NACLogin extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACLogin.content.cloneNode(true));
        this.target = '';
        this.isVisible = false
        this.container = this.$('container');
        this.error = this.$('error');
        this.profilePic = this.$('profilePic');
        this.username = this.$('username');
        this.password = this.$('password');
        this.passwordParent = this.$('passwordParent');
        this.loginBtn = this.$('loginBtn');
        this.payload = {
            Username: '',
            Password: ''
        }
        this.container.addEventListener('animationend', e => {
            this.container.classList.remove('shake');
        })
    }
    $(id) { return this.shadowRoot.getElementById(id) }
    composeJSON() {
        this.payload.Username = this.username.value;
        this.payload.Password = this.password.value;
    }
    login() {
        this.composeJSON();
        if (this.payload.Username.length > 0 && this.payload.Password.length > 0) {
            fetch(this.target, {
                method: 'POST',
                headers: {
                    'Content-Type':'application/json'
                },
                body: JSON.stringify(this.payload)
            }).then(res => {
                if (res.ok)
                    window.location = '/';
            }).catch(err => {
                console.error(err);
            })
        } else {
            //Play shake animation
            this.shake();
            this.error.classList.remove('isHidden');
            console.log('Please enter username and password');
        }
    }
    shake() {
        this.container.classList.add('shake');
    }
    connectedCallback() {
        this.loginBtn.addEventListener('click', e => {
            this.login();
        });
        this.password.addEventListener('keypress', e => {
            if (e.key === 'Enter')
                this.login();
        });
        this.username.addEventListener('keypress', e => {
            if (e.key === 'Enter')
                this.login();
        });
        this.username.onfocus = () => {
            this.username.style.borderBottom = "solid 2px blue";
        }
        this.username.onblur = () => {
            this.username.style.border = "none";
        }
        this.password.onfocus = () => {
            this.passwordParent.style.borderBottom = "solid 2px blue";
        }
        this.password.onblur = () => {
            this.passwordParent.style.border = "none";
        }
    }
    disconnectedCallback() { }
    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'is-visible':
                this.container.className = 'container';
                break;
            case 'src':

                break;
            case 'target':
                this.target = newVal;
                break;
            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['is-visible', 'src', 'target']
    }
}



window.customElements.define('nac-login', NACLogin);

