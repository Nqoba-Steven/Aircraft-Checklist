using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Data.Services.Revision;
using NAC_Aircraft_Checklist.Util.Table;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Data.Services.Documents;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Data.Services.ProofRead;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Data.Services.Proof;
using NAC_Aircraft_Checklist.Data.Services.Email;
using NAC_Aircraft_Checklist.Models.Email.Mail;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Services.Mail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Identity;
using NAC_Aircraft_Checklist.Models.Users;
using System.Security.Claims;

namespace NAC_Aircraft_Checklist.Controllers
{
    [Authorize(Roles = "Admin,BaseManager,Manager,Planner")]

    public class B1900Controller : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly IEmailService _emailService;
        private readonly INACEmailSender _emailSender;
        private readonly IProofReadService _proofReadService;
        private readonly IB1900ProofService _b1900ProofService;
        private readonly IRevisionService _RevisionService;
        private readonly IB1900DocumentService _documentService;

        private readonly IAircraftService _aircraftService;
        private readonly IMasterListService _masterListService;

        public B1900Controller(
            UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            INACEmailSender emailSender,
            IEmailService emailService,
            IProofReadService proofReadService,
            IRevisionService mRevisionService,
            IB1900DocumentService documentService,
            IAircraftService aircraftService,
            IMasterListService masterListService
          )
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailSender = emailSender;
            _emailService = emailService;
            _proofReadService = proofReadService;
            _documentService = documentService;
            _RevisionService = mRevisionService;

            _aircraftService = aircraftService;

            _masterListService = masterListService;

        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //Get the revision Number
            //Then compose the document based on the revision number
            //Then 

            B1900Revision revision = _RevisionService.GetLatestB1900Revision();
            ViewData["Revision"] = revision;

            ApplicationUser u = await _userManager.GetUserAsync(User);
            ViewData["Username"] = u.UserName;

            B1900Document model = new B1900Document();
            model.B1900Entry = new B1900Entry();
            model.B1900Entry.Date = DateTime.Now;
            model.B1900Entry.Revision = revision.RevisionNumber;
            //Aircraft ID is create server side
            System.Diagnostics.Debug.WriteLine($"Revision Number: {revision.RevisionNumber}");
            ViewData["Aircrafts"] = await _aircraftService.GetByType("1900");

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(revision.RevisionNumber);

            ViewData["Interior"] = masterList.Interior;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsIPad"] = masterList.ManualsIPad;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            return View(model);
        }

        async void NewB1900UploadEmail()
        {
            //Send the
            var recipients = await _emailService.GetAllPlannerRecipients();
            NACMail mail = new NACMail();
            mail.Subject = "New B1900 Checklist Uploaded";
            //Remove from wait list
            List<string> address = new List<string>();

            foreach (var r in recipients)
            {
                address.Add(r.EmailAddress);
            }
            await _emailSender.SendEmailsAsync(address, mail);
        }

        

        [HttpPost]
        public async Task<ActionResult> Create(B1900Document document)
        {
            //Create Document Entry
            //Save to DB
            //Get Latest Document ID
            //Append to the entries 
            //Save Entries to Tables



            NACMail mail = new NACMail();
            mail.Message = "\nExterior\n";
            foreach (var item in document.Exteriors)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n Interiors \n";

            foreach (var item in document.Interiors)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";

            }
            mail.Message = mail.Message + "\n Cockpits \n";

            foreach (var item in document.Cockpits)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n Cabins \n";

            foreach (var item in document.Cabins)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n FlightFolders \n";

            foreach (var item in document.FlightFolders)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n OperationDocuments \n";

            foreach (var item in document.OperationDocuments)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n AircraftFlipFiles \n";

            foreach (var item in document.AircraftFlipFiles)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n Equipment \n";

            foreach (var item in document.Equipment)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n Manuals \n";

            foreach (var item in document.Manuals)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }
            mail.Message = mail.Message + "\n ManualsIPad \n";

            foreach (var item in document.ManualsIPad)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }

            SendAdminEmail(mail);
            await _documentService.Add(document);
            Aircraft aircraft = _aircraftService.GetById(document.B1900Entry.AircraftId);

            SendPlannerEmail(aircraft.Reg,document.B1900Entry.CompletedBy);
            //Find User email address and send mai
            //SendSuccessfulMail(aircraft.Reg,User.);

            //Run a Proof check

            //await ApplyProofDocument(document);

            //NewB1900UploadEmail();
            return Redirect("/");
        }

        void SendAdminEmail(NACMail mail)
        {
            _emailSender.SendEmailAsync("steven.novukuza@nac.co.za", mail);
        }
        void SendPlannerEmail(string aircraft,string completedBy) {
            ChecklistUploadMail mail = new ChecklistUploadMail(completedBy, aircraft,"");
            _emailSender.SendUploadMail("steven.novukuza@nac.co.za", mail);
            _emailSender.SendUploadMail("tiaan.nieuwoudt@nac.co.za", mail);
            _emailSender.SendUploadMail("tersia.smit@nac.co.za", mail);
        }
        void SendSuccessfulMail(string aircraft,string completedBy) {
            ChecklistUploadMail mail = new ChecklistUploadMail(completedBy, aircraft,"");
            _emailSender.SendUploadMail("steven.novukuza@nac.co.za", mail);
            _emailSender.SendUploadMail("tersia.smit@nac.co.za", mail);
        }

       
        async Task ApplyProofDocument(B1900Document document)
        {
            //Get a proof
            //If there is no proof then put the document on pending
            B1900ProofDocument proof = await _b1900ProofService.GetLatestProofDocument(document.Aircraft.Id);
            B1900ProofReadDocument proofReadDocument = new B1900ProofReadDocument(proof, document);
            _proofReadService.AddB1900ProofReadDocument(proofReadDocument);
        }
        
        public async Task<IActionResult> Documents()
        {
            //Get a list of all loaded documents
            ViewData["Aircrafts"] = await _aircraftService.GetAll();
            ViewData["Entries"] =  _documentService.GroupEntriesByDate();
            return View();
        }
        public async Task<IActionResult> Document(int id)
        {
            B1900Document document = await _documentService.GetByID(id);
            B1900Entry entry = document.B1900Entry;

            B1900Revision revision = _RevisionService.GetB1900Revision(document.B1900Entry.Revision);
            System.Diagnostics.Debug.WriteLine(entry);

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(revision.RevisionNumber);
            if (revision == null || document == null)
            {
                string msg = "Error Document not found";
                return View("/error", msg);
            }

            ViewData["Aircraft"] = _aircraftService.GetById(document.B1900Entry.AircraftId);
            ViewData["Entry"] = entry;
            ViewData["Revision"] = revision;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Interior"] = masterList.Interior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsIPad"] = masterList.ManualsIPad;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;
            //Populate Data in B1900 Document

            return View(document);
        }
        public async Task<IActionResult> Print(int id)
        {
            //Rebuild to ProofRead Document
            System.Diagnostics.Debug.WriteLine("Im here");
            //B1900Revision revision = _RevisionService.GetLatestB1900Revision();
            //ViewData["Aircraft"] = _aircraftService.GetById(;
            B1900Document document = await _documentService.GetByID(id);
            B1900Entry entry = document.B1900Entry;

            B1900Revision revision = _RevisionService.GetB1900Revision(document.B1900Entry.Revision);
            System.Diagnostics.Debug.WriteLine(entry);

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(revision.RevisionNumber);
            if (revision == null || document == null)
            {
                string msg = "Error Document not found";
                return View("/error", msg);
            }

            ViewData["Aircraft"] = _aircraftService.GetById(document.B1900Entry.AircraftId);
            ViewData["Entry"] = entry;
            ViewData["Revision"] = revision;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Interior"] = masterList.Interior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsIPad"] = masterList.ManualsIPad;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;
            //Populate Data in B1900 Document

            return View(document);
        }
    }
}
