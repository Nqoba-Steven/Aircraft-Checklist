using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;

namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    public class LearjetProofReadDocument
    {
        public LearjetProofReadEntry entry = new LearjetProofReadEntry();
        public LearjetEntry LearjetEntry = new LearjetEntry();

        public List<LearjetProofReadInterior> interiors = new List<LearjetProofReadInterior>();
        public List<LearjetProofReadExterior> exteriors = new List<LearjetProofReadExterior>();
        public List<LearjetProofReadCockpit> Cockpits = new List<LearjetProofReadCockpit>();
        public List<LearjetProofReadCabin> Cabins = new List<LearjetProofReadCabin>();
        public List<LearjetProofReadManuals> Manuals = new List<LearjetProofReadManuals>();
        public List<LearjetProofReadManualsEFB> ManualsEFB = new List<LearjetProofReadManualsEFB>();
        public List<LearjetProofReadFlightFolder> FlightFolder = new List<LearjetProofReadFlightFolder>();
        public List<LearjetProofReadAircraftFlipFile> AircraftFlipFile = new List<LearjetProofReadAircraftFlipFile>();
        public List<LearjetProofReadOperationDocumentsEquipment> OperationDocuments = new List<LearjetProofReadOperationDocumentsEquipment>();
        public List<LearjetProofReadEquipment> Equipment = new List<LearjetProofReadEquipment>();
        public List<LearjetProofReadAdditionalItem> AdditionalItems = new List<LearjetProofReadAdditionalItem>();
        public LearjetProofDocument proofDocument { get; set; }
        public bool isRevisionMatched;

        public LearjetProofReadDocument()
        {

        }

        public LearjetProofReadDocument(LearjetProofDocument proof, LearjetDocument document)
        {
            entry.ProofId = proof.ProofID;
            entry.EntryId = document.LearjetEntry.Id;

            foreach (LearjetProofInterior proofItem in proof.Interiors)
            {
                for (int i = 0; i < document.Interiors.Count; i++)
                {
                    if (document.Interiors[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadInterior newItem = LearjetProofReadInterior.Compare(proofItem, document.Interiors[i]);
                        interiors.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofExterior proofItem in proof.Exteriors)
            {
                for (int i = 0; i < document.Exteriors.Count; i++)
                {
                    if (document.Exteriors[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadExterior newItem = LearjetProofReadExterior.Compare(proofItem, document.Exteriors[i]);
                        exteriors.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofCockpit proofItem in proof.Cockpits)
            {
                for (int i = 0; i < document.Cockpits.Count; i++)
                {
                    if (document.Cockpits[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadCockpit newItem = LearjetProofReadCockpit.Compare(proofItem, document.Cockpits[i]);
                        Cockpits.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofCabin proofItem in proof.Cabins)
            {
                for (int i = 0; i < document.Cabins.Count; i++)
                {
                    if (document.Cabins[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadCabin newItem = LearjetProofReadCabin.Compare(proofItem, document.Cabins[i]);
                        Cabins.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofFlightFolder proofItem in proof.FlightFolders)
            {
                for (int i = 0; i < document.FlightFolders.Count; i++)
                {
                    if (document.FlightFolders[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadFlightFolder newItem = LearjetProofReadFlightFolder.Compare(proofItem, document.FlightFolders[i]);
                        FlightFolder.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofManuals proofItem in proof.Manuals)
            {
                for (int i = 0; i < document.Manuals.Count; i++)
                {
                    if (document.Manuals[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadManuals newItem = LearjetProofReadManuals.Compare(proofItem, document.Manuals[i]);
                        Manuals.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofManualsEFB proofItem in proof.ManualsEFB)
            {
                for (int i = 0; i < document.ManualsEFB.Count; i++)
                {
                    if (document.ManualsEFB[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadManualsEFB newItem = LearjetProofReadManualsEFB.Compare(proofItem, document.ManualsEFB[i]);
                        ManualsEFB.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofOperationDocumentsEquipment proofItem in proof.OperationDocuments)
            {
                for (int i = 0; i < document.OperationDocuments.Count; i++)
                {
                    if (document.OperationDocuments[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadOperationDocumentsEquipment newItem = LearjetProofReadOperationDocumentsEquipment.Compare(proofItem, document.OperationDocuments[i]);
                        OperationDocuments.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofAircraftFlipFile proofItem in proof.AircraftFlipFiles)
            {
                for (int i = 0; i < document.AircraftFlipFiles.Count; i++)
                {
                    if (document.AircraftFlipFiles[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadAircraftFlipFile newItem = LearjetProofReadAircraftFlipFile.Compare(proofItem, document.AircraftFlipFiles[i]);
                        AircraftFlipFile.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofEquipment proofItem in proof.Equipment)
            {
                for (int i = 0; i < document.Equipment.Count; i++)
                {
                    if (document.Equipment[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadEquipment newItem = LearjetProofReadEquipment.Compare(proofItem, document.Equipment[i]);
                        Equipment.Add(newItem);
                        break;
                    }
                }
                //
            }
            foreach (LearjetProofAdditionalItem proofItem in proof.AdditionalItems)
            {
                for (int i = 0; i < document.AdditionalItems.Count; i++)
                {
                    if (document.AdditionalItems[i].DescriptionId == proofItem.DescriptionId)
                    {
                        //Compare 
                        LearjetProofReadAdditionalItem newItem = LearjetProofReadAdditionalItem.Compare(proofItem, document.AdditionalItems[i]);
                        AdditionalItems.Add(newItem);
                        break;
                    }
                }
                //
            }
            //Run
            //Run a proof read by comparing the document and flagging if not equal
            //Set the endtry id 
            //Set the proofread id
        }

    }
}
