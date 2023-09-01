const tmplNACTablePager = document.createElement('template');

tmplNACTablePager.innerHTML =
    `
        <style>
            .container{
                display:flex;
                flex-direction:column-reverse;
            }
            .content{
                overflow-y:auto;
                width:fit-content;
            }
            .controls{
                user-select: none;
               -moz-user-select: none;
                -khtml-user-select: none;
                -webkit-user-select: none;
                -ms-user-select: none;
                padding:16px;
                margin:24px;
                box-shadow:1px 1px 1px 1px rgba(0,0,0,0.25);
                display:flex;
                flex-direction:row;
                align-items: center;
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
                box-shadow: 0px 0px 1px 1px #1e191942;
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
                border:1px solid black;
                border-radius:20px;
            }
            .activePageIndex{
                background-color:#00f;
                width:12px;
                height:12px;
            }
        </style>

        <div id="container" class="container">
            <div class="content">
                <slot name="table"></slot>
            </div>
            <div class="controls">
                <div class="action" id="prevBtn">Previous</div>
                <div id="pageIndexer" class="pageIndexer"></div>
                <div class="action" id="nextBtn">Next</div>
            </div>
        </div>
    `

class NACTablePager extends HTMLElement {

    constructor() {
        super()
        this.attachShadow({ mode: 'open' })
        this.shadowRoot.appendChild(tmplNACTablePager.content.cloneNode(true))
        this.index = 0;
        this.numberOfPages = 0;
        this.activePage = 0;
        this.pageIndexer = this.$('pageIndexer');
        this.prevBtn = this.$('prevBtn');
        this.nextBtn = this.$('nextBtn');
        this.isNextAllowed = false;
        this.Tables = new Map();
    }
    $(id) { return this.shadowRoot.getElementById(id) }

    connectedCallback() {
        //Check the amount of slotted items
        //Use the
        //Get all the tables
        var slots = this.shadowRoot.querySelectorAll('slot');
        slots[0].addEventListener('slotchange', e => {
            this.Tables.clear();
            console.log(e)
            this.pageIndexer.innerHTML = "";
            let slottedTables = slots[0].assignedElements();
            for (var i = 0; i < slottedTables.length; i++) {
                this.Tables.set(i, slottedTables[i])
                slottedTables[i].classList.add('hidden');
                this.addPageIndex(i);
            }
            this.index = 0;
            slottedTables[this.index].classList.remove('hidden');
            this.pageIndexer.children[this.index].classList.add('activePageIndex');
        });

        this.prevBtn.addEventListener('click', e => {
            this.changeIndex(-1)
        })
        this.nextBtn.addEventListener('click', e => {
            this.changeIndex(1)
        })
    }

    addPageIndex(i) {
        var pageIndex = document.createElement('div');
        pageIndex.className = 'pageIndex';
        pageIndex.setAttribute('index', i);
        pageIndex.addEventListener('click', e => {
            console.log(e)
        })
        this.pageIndexer.appendChild(pageIndex);
    }
    hideTables() {

    }
    changeIndex(direction) {
        if (direction > 0) {
            //if (this.isNextAllowed)
            if (this.index < this.Tables.size - 1) {
                var prevTable = this.Tables.get(this.index);
                this.pageIndexer.children[this.index].classList.remove('activePageIndex');
                prevTable.classList.add('hidden');
                this.index = this.index + 1;
                var currentTable = this.Tables.get(this.index);
                this.pageIndexer.children[this.index].classList.add('activePageIndex');
                currentTable.classList.remove('hidden');
            }
        } else {
            if (this.index > 0) {
                var prevTable = this.Tables.get(this.index);
                this.pageIndexer.children[this.index].classList.remove('activePageIndex');
                prevTable.classList.add('hidden');
                this.index = this.index - 1;
                var currentTable = this.Tables.get(this.index);
                currentTable.classList.remove('hidden');
                this.pageIndexer.children[this.index].classList.add('activePageIndex');
            }
        }
        console.log(this.index)
    }
    disconnectedCallback() { }

    attributeChangedCallback(name, oldVal, newVal) {
        switch (name) {
            case '':

                break;

            default:
                break;
        }
    }
    static get observedAttributes() {
        return ['']
    }
}



window.customElements.define('nac-table-pager', NACTablePager);

