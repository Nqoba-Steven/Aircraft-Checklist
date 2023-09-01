using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;

namespace NAC_Aircraft_Checklist.Models.Documents
{
    public class LearjetDocument
    {
        public Aircraft Aircraft{ get; set; } 
        public LearjetEntry LearjetEntry { get; set; }
        public List<LearjetInterior> Interiors { get; set; } = new List<LearjetInterior>();
        public List<LearjetExterior> Exteriors { get; set; } = new List<LearjetExterior>();
        public List<LearjetCockpit> Cockpits { get; set; } = new List<LearjetCockpit>();
        public List<LearjetCabin> Cabins { get; set; } = new List<LearjetCabin>();
        public List<LearjetFlightFolder> FlightFolders { get; set; } = new List<LearjetFlightFolder>();
        public List<LearjetManuals> Manuals { get; set; } = new List<LearjetManuals>();
        public List<LearjetManualsEFB> ManualsEFB { get; set; } = new List<LearjetManualsEFB>();
        public List<LearjetOperationDocumentsEquipment> OperationDocuments { get; set; } = new List<LearjetOperationDocumentsEquipment>();
        public List<LearjetAircraftFlipFile> AircraftFlipFiles { get; set; } = new List<LearjetAircraftFlipFile>();
        public List<LearjetEquipment> Equipment { get; set; } = new List<LearjetEquipment>();
        public List<LearjetAdditionalItem> AdditionalItems { get; set; } = new List<LearjetAdditionalItem>();
        public LearjetDocument()
        {

        }

    }
}
