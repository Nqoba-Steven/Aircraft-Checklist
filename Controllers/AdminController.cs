using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Data.Services.Revision;
using NAC_Aircraft_Checklist.Models.Entry.Revisions;
using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Util;

namespace NAC_Aircraft_Checklist.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IRevisionService _RevisionService;

        private readonly IMasterBaseService<B1900InteriorMaster> _B1900InteriorMasterService;
        private readonly IMasterBaseService<B1900ExteriorMaster> _B1900ExteriorMasterService;
        private readonly IMasterBaseService<B1900CockpitMaster> _B1900CockpitMasterService;
        private readonly IMasterBaseService<B1900CabinMaster> _B1900CabinMasterService;
        private readonly IMasterBaseService<B1900FlightRedFolderMaster> _B1900FlightFolderMasterService;
        private readonly IMasterBaseService<B1900ManualsMaster> _B1900ManualsMasterService;
        private readonly IMasterBaseService<B1900ManualsIPadMaster> _B1900ManualsIPadMasterService;
        private readonly IMasterBaseService<B1900OpsDocsEquipmentMaster> _B1900OpsDocsMasterService;
        private readonly IMasterBaseService<B1900AircraftFlipFileMaster> _B1900AircraftFlipFileMasterService;
        private readonly IMasterBaseService<B1900EquipmentMaster> _B1900EquipmentMasterService;

        private readonly IMasterBaseService<LearjetInteriorMaster> _LearjetInteriorMasterService;
        private readonly IMasterBaseService<LearjetExteriorMaster> _LearjetExteriorMasterService;
        private readonly IMasterBaseService<LearjetCockpitMaster> _LearjetCockpitMasterService;
        private readonly IMasterBaseService<LearjetCabinMaster> _LearjetCabinMasterService;
        private readonly IMasterBaseService<LearjetFlightFolderMaster> _LearjetFlightFolderMasterService;
        private readonly IMasterBaseService<LearjetManualsMaster> _LearjetManualsMasterService;
        private readonly IMasterBaseService<LearjetManualsEFBMaster> _LearjetManualsEFBMasterService;
        private readonly IMasterBaseService<LearjetOperationDocumentsEquipmentMaster> _LearjetOpsDocsMasterService;
        private readonly IMasterBaseService<LearjetAircraftFlipFileMaster> _LearjetAircraftFlipFileMasterService;
        private readonly IMasterBaseService<LearjetEquipmentMaster> _LearjetEquipmentMasterService;



        private readonly IAircraftService _aircraftService;


        public AdminController(
            IRevisionService revisionService,
            IAircraftService aircrafService,
            IMasterBaseService<B1900InteriorMaster> b1900interior,
            IMasterBaseService<B1900ExteriorMaster> b1900exterior,
            IMasterBaseService<B1900CockpitMaster> b1900cockpit,
            IMasterBaseService<B1900CabinMaster> b1900cabin,
            IMasterBaseService<B1900FlightRedFolderMaster> b1900flightFolder,
            IMasterBaseService<B1900ManualsMaster> b1900manuals,
            IMasterBaseService<B1900ManualsIPadMaster> b1900manualsIPad,
            IMasterBaseService<B1900OpsDocsEquipmentMaster> b1900opsDocs,
            IMasterBaseService<B1900AircraftFlipFileMaster> b1900flipFile,
            IMasterBaseService<B1900EquipmentMaster> b1900equipment,

            IMasterBaseService<LearjetInteriorMaster> learjetinterior,
            IMasterBaseService<LearjetExteriorMaster> learjetexterior,
            IMasterBaseService<LearjetCockpitMaster> learjetcockpit,
            IMasterBaseService<LearjetCabinMaster> learjetcabin,
            IMasterBaseService<LearjetFlightFolderMaster> learjetflightFolder,
            IMasterBaseService<LearjetManualsMaster> learjetmanuals,
            IMasterBaseService<LearjetManualsEFBMaster> learjetmanualsEFB,
            IMasterBaseService<LearjetOperationDocumentsEquipmentMaster> learjetopsDocs,
            IMasterBaseService<LearjetAircraftFlipFileMaster> learjetflipFile,
            IMasterBaseService<LearjetEquipmentMaster> learjetequipment

          )
        {
            _RevisionService = revisionService;
            _aircraftService = aircrafService;
            _B1900InteriorMasterService = b1900interior;
            _B1900ExteriorMasterService = b1900exterior;
            _B1900CockpitMasterService = b1900cockpit;
            _B1900CabinMasterService = b1900cabin;
            _B1900FlightFolderMasterService = b1900flightFolder;
            _B1900ManualsMasterService = b1900manuals;
            _B1900ManualsIPadMasterService = b1900manualsIPad;
            _B1900OpsDocsMasterService = b1900opsDocs;
            _B1900AircraftFlipFileMasterService = b1900flipFile;
            _B1900EquipmentMasterService = b1900equipment;

            _LearjetInteriorMasterService = learjetinterior;
            _LearjetExteriorMasterService = learjetexterior;
            _LearjetCockpitMasterService = learjetcockpit;
            _LearjetCabinMasterService = learjetcabin;
            _LearjetFlightFolderMasterService = learjetflightFolder;
            _LearjetManualsMasterService = learjetmanuals;
            _LearjetManualsEFBMasterService = learjetmanualsEFB;
            _LearjetOpsDocsMasterService = learjetopsDocs;
            _LearjetAircraftFlipFileMasterService = learjetflipFile;
            _LearjetEquipmentMasterService = learjetequipment;

            _aircraftService = aircrafService;

        }
        public async Task<ActionResult> Index()
        {
            ViewData["B1900Revisions"] = await _RevisionService.GetAllB1900Revisions();
            ViewData["LearjetRevisions"] = await _RevisionService.GetAllLearjetRevisions();

            return View();
        }
        public async Task<ActionResult> BuildMasterTables()
        {

            return View();

        }
        public ActionResult CreateB1900Revision()
        {
            B1900Revision model = new B1900Revision();
            return View(model);
        }
        public ActionResult CreateLearjetRevision()
        {
            LearjetRevision model = new LearjetRevision();
            return View(model);
        }

        public async Task<ActionResult> BuildB1900TableMaster(B1900Revision rev)
        {
          
            Dictionary<string, List<string>> b1900Dictionary = DocumentBuilder.Build('b', rev.RevisionNumber);
            if (b1900Dictionary != null)
            {
                B1900Revision revision = new B1900Revision();
                revision.RevisionNumber = rev.RevisionNumber;
                revision.Date = DateTime.Now;

                bool success = _RevisionService.AddB1900Revision(revision);
                if (success)
                {
                    _B1900InteriorMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Interior], revision.RevisionNumber);
                    _B1900ExteriorMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Exterior], revision.RevisionNumber);
                    _B1900CabinMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Cabin], revision.RevisionNumber);
                    _B1900CockpitMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Cockpit], revision.RevisionNumber);
                    _B1900FlightFolderMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.FlightFolder], revision.RevisionNumber);
                    _B1900ManualsMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Manuals], revision.RevisionNumber);
                    _B1900ManualsIPadMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.ManualsIPad], revision.RevisionNumber);
                    _B1900OpsDocsMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.OPSDocsEquipment], revision.RevisionNumber);
                    _B1900AircraftFlipFileMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.AircraftFlipFile], revision.RevisionNumber);
                    _B1900EquipmentMasterService.Build(b1900Dictionary[Names.Tables.B1900.TableNames.Equipment], revision.RevisionNumber);
                    return Redirect("/Admin/");
                }
                else
                {
                    return Ok("Failed to build revision");
                }
            }
            else
            {
                return Ok("Failed to build revision");
            }
        }
        public  ActionResult BuildLearjetTableMaster(LearjetRevision rev)
        {
            
            Dictionary<string, List<string>> learjetDictionary = DocumentBuilder.Build('l', rev.RevisionNumber);
            if (learjetDictionary != null)
            {
                LearjetRevision revision = new LearjetRevision();
                revision.RevisionNumber = rev.RevisionNumber;
                revision.Date = rev.Date;
               
                bool success = _RevisionService.AddLearjetRevision(revision);
                if (success)
                {
                    _LearjetInteriorMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Interior], revision.RevisionNumber);
                    _LearjetExteriorMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Exterior], revision.RevisionNumber);
                    _LearjetCabinMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Cabin], revision.RevisionNumber);
                    _LearjetCockpitMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Cockpit], revision.RevisionNumber);
                    _LearjetFlightFolderMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.FlightFolder], revision.RevisionNumber);
                    _LearjetManualsMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Manuals], revision.RevisionNumber);
                    _LearjetManualsEFBMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.ManualsEFB], revision.RevisionNumber);
                    _LearjetOpsDocsMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.OPSDocsEquipment], revision.RevisionNumber);
                    _LearjetAircraftFlipFileMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.AircraftFlipFile], revision.RevisionNumber);
                    _LearjetEquipmentMasterService.Build(learjetDictionary[Names.Tables.Learjet.TableNames.Equipment], revision.RevisionNumber);
                    return Redirect("/Admin/");
                }

                else
                {
                    return Redirect("/Admin/");
                }
            }
            else
            {
                return Ok("Failed to build revision");
            }

        }

    }
}
