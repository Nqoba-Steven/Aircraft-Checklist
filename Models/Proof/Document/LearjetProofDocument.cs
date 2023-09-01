using NAC_Aircraft_Checklist.Models.Proof.Learjet;

namespace NAC_Aircraft_Checklist.Models.Proof.Document
{
    public class LearjetProofDocument
    {
        public int ProofID { get; set; }
        public int AircraftID { get; set; }
        public int Revision { get; set; }

        public string CompletedBy { get; set; }

        public DateTime Date { get; set; }
         
        public string BaseOfOperations { get; set; }
        public List<LearjetProofAircraftFlipFile> AircraftFlipFiles { get; set; } = new List<LearjetProofAircraftFlipFile>();
        public List<LearjetProofCabin> Cabins { get; set; } = new List<LearjetProofCabin>();
        public List<LearjetProofCockpit> Cockpits { get; set; } = new List<LearjetProofCockpit>();
        public List<LearjetProofEquipment> Equipment { get; set; } = new List<LearjetProofEquipment>();
        public List<LearjetProofExterior> Exteriors { get; set; } = new List<LearjetProofExterior>();
        public List<LearjetProofFlightFolder> FlightFolders { get; set; } = new List<LearjetProofFlightFolder>();
        public List<LearjetProofInterior> Interiors { get; set; } = new List<LearjetProofInterior>();
        public List<LearjetProofManuals> Manuals { get; set; } = new List<LearjetProofManuals>();
        public List<LearjetProofManualsEFB> ManualsEFB { get; set; } = new List<LearjetProofManualsEFB>();
        public List<LearjetProofOperationDocumentsEquipment> OperationDocuments { get; set; } = new List<LearjetProofOperationDocumentsEquipment>();
        public List<LearjetProofAdditionalItem> AdditionalItems { get; set; } = new List<LearjetProofAdditionalItem>();
    }
}
