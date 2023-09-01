const tmplNACTablePager = document.createElement('template');

tmplNACTablePager.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:column;
                align-items: center;
            }
            .hidden{
                display:none;
            }
            .content{
                align-items: center;
                justify-content: center;
                width: 90%;
                overflow-y: auto;
                display: flex;
            }
            .controls{
                width:80%;
                user-select: none;
               -moz-user-select: none;
                -khtml-user-select: none;
                -webkit-user-select: none;
                -ms-user-select: none;
                padding:16px;
                margin:24px;
                box-shadow:0px 0px 3px 2px rgba(0,0,0,0.25);
                display:flex;
                flex-direction:row;
                align-items: center;
                justify-content: space-between;
            }
             .action{
                user-select: none;
                -moz-user-select: none;
                -khtml-user-select: none;
                -webkit-user-select: none;
                -ms-user-select: none;
                display:flex;
                min-width:64px;
                min-height:32px;
                max-height:32px;
                align-items: center;
                justify-content: center;
                border-radius: 20px;
                box-shadow: 0px 0px 1px 1px #0000006e;
            }
            .action:hover{
                  box-shadow: 0px 0px 2px 2px #1e191942;
            }
            .hidden{
                display:none;
            }
            .pageIndexer{
               
                display:flex;
                width: 80%;
                flex-direction:row;
                justify-content:space-around;
                align-items: inherit;
            }
            .pageIndex{
                width:8px;
                height:8px;
                min-width:8px;
                min-height:8px;
                background-color:#fff;
                border:1px solid white;
                border-radius:20px;
            }
            .activePageIndex{
                border:1px solid white;
                background-color:white;
                width:12px;
                height:12px;
            }
            .foot{
                display:flex;
            }
             .footerText{
                text-align:center;
                font-size: 12pt;
                font-weight: 700;
            }
            table {
                width: 100%;
                border-collapse: collapse;
                margin-top: 24px;
                margin-bottom: 24px;
            }
            th, td {
                border: 1px solid black;
                padding: 4px;
            }
            td {
                text-align: center;
                font-size: 9pt;
                position: relative;
            }
            th {
                text-align: center;
            }
            .uploadBtn{
                border: 2px solid #0065a3;
                background-color: #106ebe;
                color: #fff;
                width: fit-content;
                display: flex;
                padding: 8px;
                box-shadow: 0px 1px 4px 1px rgb(0 0 0 / 46%);
                font-weight: 500;
            }
            .h{
                visibility:hidden;
            }
        </style>
       
        
           
            <div id="container" class="container">
                 <div class="controls">
                    <div class="action" id="prevBtn0">Previous</div>
                    <div id="uploadBtn0" class="h"></div>
                    <div class="action" id="nextBtn0">Next</div>
                </div>
                    <div id="pageIndexer0" class="pageIndexer"></div>

                <div class="content">
                    <slot name="table"></slot>
                </div>
                <div id="pageIndexer1" class="pageIndexer"></div>
            <div class="controls">
                <div class="action" id="prevBtn1">Previous</div>
            <div id="uploadBtn1" class="h"></div>
                <div class="action" id="nextBtn1">Next</div>
            </div>
            <div id="footer" class="hidden"><slot name="footer"></slot></div>

            <table>
                <thead>
                    <tr></tr>
                </thead>
                <tbody>
                    <tr>
                        <td id="revision" width="33%" class="footerText"></td>
                        <td id="date" width="33%" class="footerText"></td>
                        <td id="pages" width="33%" class="footerText"></td>
                    </tr>
                </tbody>
            </table>

        </div>

    `

class NACTablePager extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTablePager.content.cloneNode(true))
        this.date = this.$('date');
        this.revision = this.$('revision');
        this.pages = this.$('pages');
        this.isValidated = true;
        this.index = 0;
        this.numberOfPages = 0;
        this.showFooter = false;
        this.footer = this.$('footer');
        this.activePage = 0;
        this.uploadDate = null;
        this.pageIndexer0 = this.$('pageIndexer0');
        this.pageIndexer1 = this.$('pageIndexer1');
        this.prevBtn0 = this.$('prevBtn0');
        this.prevBtn1 = this.$('prevBtn1');
        this.nextBtn0 = this.$('nextBtn0');
        this.nextBtn1 = this.$('nextBtn1');
        this.isNextAllowed = false;
        this.isUploadBtnVisible = false;
        this.uploadBtn0 = this.$('uploadBtn0');
        this.uploadBtn1 = this.$('uploadBtn1');
        this.Tables = new Map();
    }
    $(id) { return this.shadowRoot.getElementById(id) }
    createTables(tablesSlot) {
        tablesSlot.addEventListener('slotchange', e => {
            this.Tables.clear();
            console.log(e)
            this.pageIndexer0.innerHTML = "";
            this.pageIndexer1.innerHTML = "";
            console.log(tablesSlot);

            let slottedTables = tablesSlot.assignedElements();
            for (var i = 0; i < slottedTables.length; i++) {
                //Check slotted name
                if (slottedTables[i].getAttribute('slot').toLocaleLowerCase() == 'table') {
                    console.log('Table Added');
                    this.Tables.set(i, slottedTables[i])
                    slottedTables[i].classList.add('hidden');
                    if (this.pageIndexer0 !== null && this.pageIndexer1 !== null)
                        this.addPageIndex(i);
                }
            }
            this.pages.innerHTML = `Page ${this.index + 1} of  ${this.Tables.size}`;
            this.index = 0;
            slottedTables[this.index].classList.remove('hidden');
            this.pageIndexer0.children[this.index].classList.add('activePageIndex');
            this.pageIndexer1.children[this.index].classList.add('activePageIndex');
            this.showFooter = this.index == this.Tables.size - 1;
            if (this.showFooter) {
                this.footer.className = 'footer';
            } else {
                this.footer.className = 'hidden';
            }
        });
    }
    connectedCallback() {
        //Check the amount of slotted items
        //Use the
        //Get all the tables
        var slots = this.shadowRoot.querySelectorAll('slot');
        //Get slot by name
        if (slots) {
            slots.forEach(slot => {
                switch (slot.name.toLocaleLowerCase()) {
                    case 'table':
                        this.createTables(slot);
                        break;

                }
            })
        }

        this.prevBtn0.addEventListener('click', e => {
            this.changeIndex(-1)
        })

        this.prevBtn1.addEventListener('click', e => {
            this.changeIndex(-1)
            window.scrollTo(0, 0);
        })
        this.nextBtn0.addEventListener('click', e => {
            this.changeIndex(1)
        })
        this.nextBtn1.addEventListener('click', e => {
            this.changeIndex(1)
            window.scrollTo(0, 0);

        });
        this.uploadBtn0.addEventListener('click', e => {
            if (!this.isUploadBtnVisible || this.uploadDate == null) {
                console.error("No Upload Date found")
                return;
            }
            console.log('click')
            let monthIndex = this.uploadDate.getMonth();
            let year = this.uploadDate.getFullYear();

            let monthNames = ["January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"];

            var month = monthNames[monthIndex];
            var link = `https://nacza.sharepoint.com/sites/nac/flynac/aircraft/${this.aircraft}/Other Documents/Aircraft Checklists/${year}/${month}`;
            //var =  "/ Other Documents/Aircraft Checklists/" + oDate.ToString("yyyy") + "/" + oDate.ToString("MMMM")
            console.log(link)
            window.open(link, '_blank');
        });
        this.uploadBtn1.addEventListener('click', e => {
            if (!this.isUploadBtnVisible)
                return;
            console.log('click')
            var date = new Date();
            let monthIndex = date.getMonth();
            let year = date.getFullYear();

            let monthNames = ["January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"];

            var month = monthNames[monthIndex];
            var link = `https://nacza.sharepoint.com/sites/nac/flynac/aircraft/${this.aircraft}/Other Documents/Aircraft Checklists/${year}/${month}`;
            //var =  "/ Other Documents/Aircraft Checklists/" + oDate.ToString("yyyy") + "/" + oDate.ToString("MMMM")
            console.log(link)
            window.open(link, '_blank');
        });
        if (this.index == 0) {
            //Hidde previious btn
            this.prevBtn0.className = 'h';
            this.prevBtn1.className = 'h';
        }
    }

    addPageIndex(i) {
        var pageIndex = document.createElement('div');
        pageIndex.className = 'pageIndex';
        pageIndex.setAttribute('index', i);
        pageIndex.addEventListener('click', e => {
            console.log(e)
        })
        var pageIndex2 = document.createElement('div');
        pageIndex2.className = 'pageIndex';
        pageIndex2.setAttribute('index', i);
        pageIndex2.addEventListener('click', e => {
            console.log(e)
        })
        this.pageIndexer0.appendChild(pageIndex);
        this.pageIndexer1.appendChild(pageIndex2);
    }
    hideTables() {

    }

    ValidateFields() {
        if (!this.isValidated)
            return true;
        var selects = this.Tables.get(this.index).querySelectorAll('select');
        var textareas = this.Tables.get(this.index).querySelectorAll('textarea');
        var inputs = this.Tables.get(this.index).querySelectorAll('input');
        for (var i = 0; i < textareas.length; i++) {
            if (textareas[i].hasAttribute('required')) {
                if (textareas[i].value.length <= 0) {
                    //console.log(textareas[i])
                    textareas[i].focus();
                    return false;
                }
            }
        }
        for (var i = 0; i < inputs.length; i++) {
            if (inputs[i].hasAttribute('required')) {
                if (inputs[i].value.length <= 0) {
                    //console.log(inputs[i])
                    inputs[i].focus();
                    return false;
                }
            }
        }
        for (var i = 0; i < selects.length; i++) {
            if (selects[i].hasAttribute('required')) {
                if (selects[i].value.length <= 0) {
                    //console.log(inputs[i])
                    selects[i].focus();
                    return false;
                }
            }
        }
        return true;
    }
    changeIndex(direction) {

        if (direction > 0) {
            if (this.ValidateFields()) {
                if (this.index < this.Tables.size - 1) {
                    var prevTable = this.Tables.get(this.index);
                    this.pageIndexer0.children[this.index].classList.remove('activePageIndex');
                    this.pageIndexer1.children[this.index].classList.remove('activePageIndex');
                    prevTable.classList.add('hidden');
                    this.index = this.index + 1;
                    var currentTable = this.Tables.get(this.index);
                    this.pageIndexer0.children[this.index].classList.add('activePageIndex');
                    this.pageIndexer1.children[this.index].classList.add('activePageIndex');
                    currentTable.classList.remove('hidden');
                }
            } else {
                console.log("Incomplete form")
            }
            //if (this.isNextAllowed)

        } else {
            if (this.index > 0) {
                var prevTable = this.Tables.get(this.index);
                this.pageIndexer0.children[this.index].classList.remove('activePageIndex');
                this.pageIndexer1.children[this.index].classList.remove('activePageIndex');
                prevTable.classList.add('hidden');
                this.index = this.index - 1;
                var currentTable = this.Tables.get(this.index);
                currentTable.classList.remove('hidden');
                this.pageIndexer0.children[this.index].classList.add('activePageIndex');
                this.pageIndexer1.children[this.index].classList.add('activePageIndex');
            }
        }
        this.showFooter = this.index == this.Tables.size - 1;
        if (this.showFooter) {
            this.footer.className = 'footer';
            this.nextBtn0.className = 'h';
            this.nextBtn1.className = 'h';

        } else {
            this.footer.className = 'hidden';
            this.nextBtn0.className = 'action';
            this.nextBtn1.className = 'action';
        }
        if (this.aircraft && this.index > 0) {
            this.uploadBtn0.className = 'uploadBtn action';
            this.uploadBtn1.className = 'uploadBtn action';
            this.isUploadBtnVisible = true;
        }
        else {
            this.isUploadBtnVisible = false;
            this.uploadBtn0.className = 'h';
            this.uploadBtn1.className = 'h';
        }
        //this.setAttribute('current-index');
        this.pages.innerHTML = `Page ${this.index + 1} of  ${this.Tables.size}`;
        if (this.index == 0) {
            //Hidde previious btn
            this.prevBtn0.className = 'h';
            this.prevBtn1.className = 'h';
        } else {
            this.prevBtn0.className = 'action';
            this.prevBtn1.className = 'action';

        }
    }
    disconnectedCallback() { }

    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case 'revision':
                this.revision.innerHTML = `Rev No: ${newVal}`;
                break;
            case 'validate':
                this.isValidated = newVal == null ? true : false;
                break;
            case 'date':
                this.date.innerHTML = `Date: ${newVal}`;
                break;
            
            case 'aircraft':
                this.aircraft = newVal;
                console.log(this.aircraft)
                
                break;
            case 'upload-title':
                this.uploadBtn0.innerHTML = newVal;
                this.uploadBtn1.innerHTML = newVal;
                break;
            case 'show-upload-btn':
                this.isUploadBtnVisible = newVal == null ? false : true;
                console.log('Show upload btn ')
                console.log(this.isUploadBtnVisible)
                if (this.isUploadBtnVisible) {
                    this.uploadBtn0.className = 'uploadBtn action';
                    this.uploadBtn1.className = 'uploadBtn action';
                }
                break;
            case 'upload-date':
                console.log('upload-date')
                if (newVal)
                    this.uploadDate = new Date(newVal);
                else
                    this.uploadDate = null;
                console.log(this.uploadDate)
                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['date', 'revision', 'validate', 'aircraft','upload-title','show-upload-btn','upload-date']
    }
}



window.customElements.define('nac-table-pager', NACTablePager);

