using Microsoft.AspNetCore.Mvc;
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Data.Services.Proof;
using NAC_Aircraft_Checklist.Data.Services.Revision;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Util.Table;
using Microsoft.AspNetCore.Identity.UI.Services;
using NAC_Aircraft_Checklist.Data.Services.Email;
using NAC_Aircraft_Checklist.Services.Mail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NAC_Aircraft_Checklist.Models.Users;
using NAC_Aircraft_Checklist.Data.Services.Documents;
using NAC_Aircraft_Checklist.Data.Services.ProofRead;
using NAC_Aircraft_Checklist.Models.Entities;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class ProofController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly INACEmailSender _emailSender;
        private readonly IEmailService _emailService;
        private readonly IMasterListService _masterListService;
        private readonly IAircraftService _aircraftService;
        private readonly IRevisionService _revisionService;
        private readonly IB1900ProofService _b1900ProofService;
        private readonly IB1900DocumentService _b1900DocumentService;
        private readonly ILearjetDocumentService _learjetDocumentService;
        private readonly IProofReadService _proofReadService;
        private readonly ILearjetProofService _learjetProofService;

        public ProofController(
             UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            INACEmailSender emailSender,
            IEmailService emailService,
            IMasterListService masterListService,
            IRevisionService revisionService,
            IAircraftService aircraftService,
            IB1900ProofService b1900proofService,
            IB1900DocumentService b1900DocumentService,
            ILearjetDocumentService learjetDocumentService,
            IProofReadService proofReadService,
            ILearjetProofService learjetProofService)
        {
            _userManager = userManager;
            _userStore = userStore;

            _emailSender = emailSender;
            _emailService = emailService;

            _revisionService = revisionService;

            _masterListService = masterListService;
            _aircraftService = aircraftService;
            _b1900ProofService = b1900proofService;
            _proofReadService = proofReadService;
            _b1900DocumentService = b1900DocumentService;
            _learjetDocumentService = learjetDocumentService;
            _learjetProofService = learjetProofService;

        }
        public async Task<IActionResult> Index()
        {
            //Get Create Proof or view Current Proof
            if (_b1900ProofService != null)
            {
                List<B1900Proof> b1900proofs = (List<B1900Proof>)await _b1900ProofService.GetAll();
                System.Diagnostics.Debug.WriteLine($"Proofs found {b1900proofs.Count}");
                ViewData["B1900Proofs"] = b1900proofs;
            }
            if (_learjetProofService != null)
            {
                List<LearjetProof> learjetProofs = (List<LearjetProof>)await _learjetProofService.GetAll();
                System.Diagnostics.Debug.WriteLine($"Proofs found {learjetProofs.Count}");
                ViewData["LearjetProofs"] = learjetProofs;
            }
            return View();
        }

        public async Task<IActionResult> B1900Proofs()
        {
            if (_b1900ProofService != null)
            {
                ViewData["Aircrafts"] = await _aircraftService.GetAll();
                ViewData["B1900Proofs"] = _b1900ProofService.GroupByMonths();
            }
            return View();
        }

        public async Task<IActionResult> LearjetProofs()
        {
            if (_learjetProofService != null)
            {
                ViewData["Aircrafts"] = await _aircraftService.GetAll();
                ViewData["LearjetProofs"] = _learjetProofService.GroupByMonths();

                //List<LearjetProof> learjetProofs = (List<LearjetProof>)await _learjetProofService.GetAll();
                //System.Diagnostics.Debug.WriteLine($"Proofs found {learjetProofs.Count}");
               // ViewData["LearjetProofs"] = learjetProofs;
            }
            return View();
        }
        public async Task<IActionResult> B1900Create()
        {
            //Document Proof Model
            B1900ProofDocument model = new B1900ProofDocument();
            ViewData["Aircrafts"] = await _aircraftService.GetByType("1900");
            //B1900Proof latestProof = _b1900ProofService.GetLatestProof();
            B1900Revision revision = _revisionService.GetLatestB1900Revision();

            ApplicationUser u = await _userManager.GetUserAsync(User);
            ViewData["Username"] = u.UserName;

            model.Revision = revision.RevisionNumber;
            model.Date = revision.Date;
            ViewData["Revision"] = revision;

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(revision.RevisionNumber);

            //ViewData["Interior"] = masterList.Interior;
            //ViewData["Exterior"] = masterList.Exterior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsIPad"] = masterList.ManualsIPad;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            System.Diagnostics.Debug.WriteLine($"Latest ID: {revision.Id} Revision Number {revision.RevisionNumber}");
            return View(model);
        }
        public async Task<IActionResult> LearjetCreate()
        {
            //Document Proof Model
            LearjetProofDocument model = new LearjetProofDocument();
            ViewData["Aircrafts"] = await _aircraftService.GetByType("Learjet");
            LearjetRevision revision = _revisionService.GetLatestLearjetRevision();

            ApplicationUser u = await _userManager.GetUserAsync(User);
            ViewData["Username"] = u.UserName;

            model.Revision = revision.RevisionNumber;
            model.Date = revision.Date;
            ViewData["Revision"] = revision;

            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(revision.RevisionNumber);
           // ViewData["Interior"] = masterList.Interior;
           // ViewData["Exterior"] = masterList.Exterior;
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            System.Diagnostics.Debug.WriteLine($"Latest ID: {revision.Id} Revision Number {revision.RevisionNumber}");

            return View(model);
        }

        //New Proof Email
        void NewB1900ProofEmail()
        {
            //Get aircraft reg
            //
        }
        void NewLearjetProofEmail() { }
        void SendAdminEmail(NACMail mail)
        {
            _emailSender.SendEmailAsync("steven.novukuza@nac.co.za", mail);
        }

        public IActionResult B1900UploadProof(B1900ProofDocument document)
        {

            B1900Proof proof = new B1900Proof();

            proof.AircraftId = document.AircraftID;
            proof.BaseOfOperations = document.BaseOfOperations;
            proof.Revision = document.Revision;


            proof.Date = document.Date;
            //Get current revision from latest revision table
            proof.User = document.CompletedBy;

            //Send to the email address based on the aircraft
            //_b1900ProofService.Add(proof);
            //Get the proof ID
            B1900Proof latestProof = _b1900ProofService.Add(proof);
            if (latestProof != null)
            {
                document.ProofID = latestProof.Id;
                System.Diagnostics.Debug.WriteLine($"Latest ID: {latestProof.Id}");
                //_b1900ProofService.AddProofDocument(document);
            }
            NACMail mail = new NACMail();

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
            //NewB1900ProofEmail();
            //Get the proof to write to the 
            //Write the proof Id into the records
            _b1900ProofService.AddProofDocument(document);
            //_proofService.AddProofDocument
            //Write Email to bases and let them know a new review is up

            // if (latestProof != null)
            //   return Redirect($"/Proof/B1900Proof?id={latestProof.Id}");
            // System.Diagnostics.Debug.WriteLine("Failed to Upload");
            return Redirect("/");

        }
        public IActionResult LearjetUploadProof(LearjetProofDocument document)
        {
            LearjetProof proof = new LearjetProof();

            proof.AircraftId = document.AircraftID;
            proof.BaseOfOperations = document.BaseOfOperations;
            proof.Revision = document.Revision;


            proof.Date = document.Date;
            //Get current revision from latest revision table
            proof.User = document.CompletedBy;

            //Send to the email address based on the aircraft
            //_b1900ProofService.Add(proof);
            //Get the proof ID
            LearjetProof latestProof = _learjetProofService.Add(proof);
            if (latestProof != null)
            {
                document.ProofID = latestProof.Id;
                System.Diagnostics.Debug.WriteLine($"Latest ID: {latestProof.Id}");
                //_b1900ProofService.AddProofDocument(document);
            }
            NACMail mail = new NACMail();

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
            //NewB1900ProofEmail();
            //Get the proof to write to the 
            //Write the proof Id into the records
            _learjetProofService.AddProofDocument(document);
            //_proofService.AddProofDocument
            //Write Email to bases and let them know a new review is up

            // if (latestProof != null)
            //   return Redirect($"/Proof/B1900Proof?id={latestProof.Id}");
            // System.Diagnostics.Debug.WriteLine("Failed to Upload");
            return Redirect("/");

        }
        public async Task<IActionResult> ProofRead1900(int entryId, int aircraftId, DateTime date)
        {

            try
            {
                //Get proof and compare revisions
                //If revisions do not match then create a banner comparing different revisions
                //Get the entry id
                var proof = _b1900ProofService.GetProofByMonth(aircraftId, date);
                var aircraft = _aircraftService.GetById(aircraftId);
                ViewData["Aircraft"] = aircraft;

                var revision = _revisionService.GetB1900Revision(proof.Revision);
                ViewData["Revision"] = revision;
              
                if (proof == null)
                {
                    ViewData["Error"] = $"No proof found for {aircraft.Reg} for Date: {date}";
                    return View();
                }
                else
                {
                    //Create a proof read document and send it to the view
                    var proofDocument = await _b1900ProofService.GetProofDocument(proof);
                    var checklistDocument = await _b1900DocumentService.GetByID(entryId);
                    B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(revision.RevisionNumber);

                    ViewData["Cockpit"] = masterList.Cockpits;
                    ViewData["Cabin"] = masterList.Cabin;
                    ViewData["FlightFolder"] = masterList.FlightFolder;
                    ViewData["Manuals"] = masterList.Manuals;
                    ViewData["ManualsIPad"] = masterList.ManualsIPad;
                    ViewData["OpsDocs"] = masterList.OperationDocuments;
                    ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
                    ViewData["Equipment"] = masterList.Equipment;
                    if (proofDocument != null && checklistDocument != null)
                    {
                        var document = _proofReadService.CreateProofRead1900(proofDocument, checklistDocument);

                        return View(document);
                    }
                    else
                    {
                        if (proofDocument == null)
                        {
                            ViewData["Error"] = $"Error could not find proof document {aircraft.Reg} for Date: {date}";

                        }
                        if (checklistDocument == null)
                        {
                            ViewData["Error"] = $"Error could not find for {entryId} for Date: {date}";
                        }

                    }

                }

            }
            catch (Exception e)
            {

            }
            //Get Proof by aircraft and month
            //
            return View();
        }
        public async Task<IActionResult> ProofReadLearjet(int entryId, int aircraftId, DateTime date)
        {

            try
            {
                //Get proof and compare revisions
                //If revisions do not match then create a banner comparing different revisions
                //Get the entry id
                var proof = _learjetProofService.GetProofByMonth(aircraftId, date);
                var aircraft = _aircraftService.GetById(aircraftId);
                ViewData["Aircraft"] = aircraft;

                var revision = _revisionService.GetLearjetRevision(proof.Revision);
                ViewData["Revision"] = revision;

                if (proof == null)
                {
                    ViewData["Error"] = $"No proof found for {aircraft.Reg} for Date: {date}";
                    return View();
                }
                else
                {
                    //Create a proof read document and send it to the view
                    var proofDocument = await _learjetProofService.GetProofDocument(proof);
                    var checklistDocument = await _learjetDocumentService.GetByID(entryId);
                    LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(revision.RevisionNumber);

                    ViewData["Cockpit"] = masterList.Cockpits;
                    ViewData["Cabin"] = masterList.Cabin;
                    ViewData["FlightFolder"] = masterList.FlightFolder;
                    ViewData["Manuals"] = masterList.Manuals;
                    ViewData["ManualsEFB"] = masterList.ManualsEFB;
                    ViewData["OpsDocs"] = masterList.OperationDocuments;
                    ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
                    ViewData["Equipment"] = masterList.Equipment;
                    if (proofDocument != null && checklistDocument != null)
                    {
                        var document = _proofReadService.CreateProofReadLearjet(proofDocument, checklistDocument);

                        return View(document);
                    }
                    else
                    {
                        if (proofDocument == null)
                        {
                            ViewData["Error"] = $"Error could not find proof document {aircraft.Reg} for Date: {date}";

                        }
                        if (checklistDocument == null)
                        {
                            ViewData["Error"] = $"Error could not find for {entryId} for Date: {date}";
                        }

                    }

                }

            }
            catch (Exception e)
            {

            }
            //Get Proof by aircraft and month
            //
            return View();
        }
        //Upload document

        public async Task<IActionResult> B1900Proof(int id)
        {
            B1900Proof proof = _b1900ProofService.GetById(id);
            B1900Revision revision = _revisionService.GetB1900Revision(proof.Revision);

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(proof.Revision);

            //Select Proof vi ID
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

            B1900ProofDocument document = await _b1900ProofService.GetProofDocument(proof);
            ViewData["Revision"] = revision;

            ViewData["Aircraft"] = _aircraftService.GetById(proof.AircraftId);
            ViewData["Proof"] = proof;
            return View(document);
        }
        public async Task<IActionResult> LearjetProof(int id)
        {
            LearjetProof proof = _learjetProofService.GetById(id);
            LearjetRevision revision = _revisionService.GetLearjetRevision(proof.Revision);

            ViewData["Revision"] = revision;
            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(proof.Revision);

            //Select Proof vi ID
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            LearjetProofDocument document = await _learjetProofService.GetProofDocument(proof);
            ViewData["Aircraft"] = _aircraftService.GetById(proof.AircraftId);
            ViewData["Proof"] = proof;

            return View(document);
        }
        public async Task<IActionResult> LearjetProofEdit(int id)
        {
            LearjetProof proof = _learjetProofService.GetById(id);
            LearjetRevision revision = _revisionService.GetLearjetRevision(proof.Revision);

            LearjetMasterListPayload masterList = await _masterListService.GetLearjetMasterLists(proof.Revision);

            //Select Proof vi ID
            ViewData["Cockpit"] = masterList.Cockpits;
            ViewData["Cabin"] = masterList.Cabin;
            ViewData["FlightFolder"] = masterList.FlightFolder;
            ViewData["Manuals"] = masterList.Manuals;
            ViewData["ManualsEFB"] = masterList.ManualsEFB;
            ViewData["OpsDocs"] = masterList.OperationDocuments;
            ViewData["AircraftFlipFile"] = masterList.AircraftFlipFile;
            ViewData["Equipment"] = masterList.Equipment;

            LearjetProofDocument document = await _learjetProofService.GetProofDocument(proof);
            ViewData["Revision"] = revision;

            ViewData["Aircraft"] = _aircraftService.GetById(proof.AircraftId);
            ViewData["Proof"] = proof;
            return View(document);
        }
        public async Task<IActionResult> B1900ProofEdit(int id)
        {
            B1900Proof proof = _b1900ProofService.GetById(id);
            B1900Revision revision = _revisionService.GetB1900Revision(proof.Revision);

            B1900MasterListPayload masterList = await _masterListService.GetB1900MasterLists(proof.Revision);

            //Select Proof vi ID
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

            B1900ProofDocument document = await _b1900ProofService.GetProofDocument(proof);
            ViewData["Revision"] = revision;

            ViewData["Aircraft"] = _aircraftService.GetById(proof.AircraftId);
            ViewData["Proof"] = proof;
            return View(document);
        }
        
        //TODO Create ProofRead funciton


    }
}
