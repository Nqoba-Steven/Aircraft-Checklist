
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Data.Services.Revision;
using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Util.Table;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Data.Services.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Data.Services.Email;
using NAC_Aircraft_Checklist.Services.Mail;
using NAC_Aircraft_Checklist.Data.Services.Proof;
using NAC_Aircraft_Checklist.Models.Users;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.ProofRead.Learjet;
using NAC_Aircraft_Checklist.Data.Services.ProofRead;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using NAC_Aircraft_Checklist.Models.Users;
using System.Security.Claims;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Email.Mail;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class LearjetController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IEmailService _emailService;
        private readonly INACEmailSender _emailSender;
        private readonly IRevisionService _RevisionService;
        private readonly IProofReadService _proofReadService;
        private readonly ILearjetProofService _learjetProofService;
        // GET: LearjetController
        private readonly IAircraftService _aircraftService;
        private readonly ILearjetDocumentService _documentService;
        private readonly IMasterListService _masterListService;

        public LearjetController(
             UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            IProofReadService proofReadService,
            ILearjetProofService learjetProofService,
            INACEmailSender emailSender,
            IEmailService emailService,
            IRevisionService revisionService,
            IAircraftService aircraftService,
            ILearjetDocumentService documentService,
            IMasterListService masterListService
          )
        {
            _userManager = userManager;
            _proofReadService = proofReadService;
            _learjetProofService = learjetProofService;
            _emailSender = emailSender;
            _emailService = emailService;
            _RevisionService = revisionService;
            _aircraftService = aircraftService;
            _documentService = documentService;
            _masterListService = masterListService;

        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {

            //Get the revision Number
            //Then compose the document based on the revision number
            //Then 
            ApplicationUser u = await _userManager.GetUserAsync(User);
            ViewData["Username"] = u.UserName;

            LearjetRevision revision = _RevisionService.GetLatestLearjetRevision();
            ViewData["Revision"] = revision;

            LearjetDocument model = new LearjetDocument();
            model.LearjetEntry = new LearjetEntry();
            model.LearjetEntry.Revision = revision.RevisionNumber;
            model.LearjetEntry.Date = DateTime.Now;

            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(revision.RevisionNumber);

            //Aircraft ID is create server side
            //Get by Revision
            ViewData["Aircrafts"] = await _aircraftService.GetByType("Learjet");

            ViewData["Interior"] = masterList.Interior;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            return View(model);
        }
        public async Task<IActionResult> Documents()
        {
            //Get a list of all loaded documents
            ViewData["Aircrafts"] = await _aircraftService.GetAll();
            ViewData["Entries"] = _documentService.GroupEntriesByDate();


            return View();
        }
        public async Task<IActionResult> Document(int documentId)
        {

            LearjetDocument document = await _documentService.GetByID(documentId);
            LearjetEntry entry = document.LearjetEntry;

            LearjetRevision revision = _RevisionService.GetLearjetRevision(document.LearjetEntry.Revision);
            System.Diagnostics.Debug.WriteLine(entry);

            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(revision.RevisionNumber);

            //ViewData["Aircraft"] = _aircraftService.GetById(;
            ViewData["Aircraft"] = _aircraftService.GetById(document.LearjetEntry.AircraftId);
            ViewData["Entry"] = entry;
            ViewData["Revision"] = revision;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Interior"] = masterList.Interior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;
            return View(document);
        }
        async Task ApplyProofDocument(LearjetDocument document)
        {
            //Get a proof
            LearjetProofDocument proof = await _learjetProofService.GetLatestProofDocument();
            LearjetProofReadDocument proofReadDocument = new LearjetProofReadDocument(proof, document);
            _proofReadService.AddLearjetProofReadDocument(proofReadDocument);
        }

        // GET: LearjetController/Create
        [HttpPost]
        public async Task<ActionResult> Create(LearjetDocument document)
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

            foreach (var item in document.ManualsEFB)
            {
                System.Diagnostics.Debug.WriteLine(item);
                mail.Message = mail.Message + "\n" + item.ToString() + "\n";
            }

            SendAdminEmail(mail);

            _documentService.Add(document);
            //await ApplyProofDocument(document);
            Aircraft aircraft = _aircraftService.GetById(document.LearjetEntry.AircraftId);
            SendPlannerEmail(aircraft.Reg, document.LearjetEntry.CompletedBy);

            return Redirect("/");
        }
        void SendPlannerEmail(string aircraft, string completedBy)
        {
            ChecklistUploadMail mail = new ChecklistUploadMail(completedBy, aircraft, "");
            _emailSender.SendUploadMail("steven.novukuza@nac.co.za", mail);
            _emailSender.SendUploadMail("tiaan.nieuwoudt@nac.co.za", mail);
            _emailSender.SendUploadMail("tersia.smit@nac.co.za", mail);
        }
        void SendAdminEmail(NACMail mail)
        {
            _emailSender.SendEmailAsync("steven.novukuza@nac.co.za", mail);
        }

        async void NewLearjetUploadEmail()
        {
            //Send the
            var recipients = await _emailService.GetAllPlannerRecipients();
            NACMail mail = new NACMail();
            mail.Subject = "New Learjet Checklist Uploaded";
            //Remove from wait list
            List<string> address = new List<string>();

            foreach (var r in recipients)
            {
                address.Add(r.EmailAddress);
            }
            await _emailSender.SendEmailsAsync(address, mail);
        }

        public async Task<IActionResult> Print(int id)
        {
            //Rebuild to ProofRead Document
            System.Diagnostics.Debug.WriteLine("Im here");
            //B1900Revision revision = _RevisionService.GetLatestB1900Revision();
            //ViewData["Aircraft"] = _aircraftService.GetById(;
            LearjetDocument document = await _documentService.GetByID(id);
            LearjetEntry entry = document.LearjetEntry;

            LearjetRevision revision = _RevisionService.GetLearjetRevision(document.LearjetEntry.Revision);
            System.Diagnostics.Debug.WriteLine(entry);

            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(revision.RevisionNumber);
            if (revision == null || document == null)
            {
                string msg = "Error Document not found";
                return View("/error", msg);
            }

            ViewData["Aircraft"] = _aircraftService.GetById(document.LearjetEntry.AircraftId);
            ViewData["Entry"] = entry;
            ViewData["Revision"] = revision;
            ViewData["Exterior"] = masterList.Exterior;
            ViewData["Interior"] = masterList.Interior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;
            //Populate Data in B1900 Document

            return View(document);
        }

    }
}
