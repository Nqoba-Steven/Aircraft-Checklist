using NAC_Aircraft_Checklist.Models.Documents;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Document;
using NAC_Aircraft_Checklist.Models.Tables;
using static NAC_Aircraft_Checklist.Util.Names.Tables;

namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    public class B1900ProofReadDocument
    {
        public B1900ProofReadEntry entry = new B1900ProofReadEntry();

         public List<B1900ProofReadInterior> interiors = new List<B1900ProofReadInterior>();
         public List<B1900ProofReadExterior> exteriors = new List<B1900ProofReadExterior>();

        public B1900Entry b1900Entry = new B1900Entry();

        public B1900MasterListPayload masterList = new B1900MasterListPayload();

        public List<B1900ProofReadCockpit> Cockpits = new List<B1900ProofReadCockpit>();
        public List<B1900ProofReadCabin> Cabins = new List<B1900ProofReadCabin>();
        public List<B1900ProofReadManuals> Manuals = new List<B1900ProofReadManuals>();
        public List<B1900ProofReadManualsIPad> ManualsIpad = new List<B1900ProofReadManualsIPad>();
        public List<B1900ProofReadFlightFolder> FlightFolder = new List<B1900ProofReadFlightFolder>();
        public List<B1900ProofReadAircraftFlipFile> AircraftFlipFile = new List<B1900ProofReadAircraftFlipFile>();
        public List<B1900ProofReadOperationDocuments> OperationDocuments = new List<B1900ProofReadOperationDocuments>();
        public List<B1900ProofReadEquipment> Equipment = new List<B1900ProofReadEquipment>();
        public List<B1900ProofReadAdditionalItems> AdditionalItems = new List<B1900ProofReadAdditionalItems>();

        public B1900ProofDocument proofDocument { get; set; }
        public bool isRevisionMatched;
        public B1900ProofReadDocument()
        {

        }
        public B1900ProofReadDocument(B1900ProofDocument proof, B1900Document document)
        {
            proofDocument = proof;
            try
            {

                entry.ProofId = proof.ProofID;
                entry.EntryId = document.B1900Entry.Id;
                b1900Entry = document.B1900Entry;
                foreach (B1900ProofCockpit proofItem in proof.Cockpits)
                {
                    for (int i = 0; i < document.Cockpits.Count; i++)
                    {
                        System.Diagnostics.Debug.WriteLine("Create a proof ");
                        if (document.Cockpits[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadCockpit newItem = B1900ProofReadCockpit.Compare(proofItem, document.Cockpits[i]);
                            Cockpits.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofCabin proofItem in proof.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Cabins.Count; i++)
                    {
                        if (document.Cabins[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadCabin newItem = B1900ProofReadCabin.Compare(proofItem, document.Cabins[i]);
                            Cabins.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofFlightFolder proofItem in proof.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.FlightFolders.Count; i++)
                    {
                        if (document.FlightFolders[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadFlightFolder newItem = B1900ProofReadFlightFolder.Compare(proofItem, document.FlightFolders[i]);
                            FlightFolder.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofManuals proofItem in proof.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Manuals.Count; i++)
                    {
                        if (document.Manuals[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadManuals newItem = B1900ProofReadManuals.Compare(proofItem, document.Manuals[i]);
                            Manuals.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofManualsIPad proofItem in proof.ManualsIPad)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.ManualsIPad.Count; i++)
                    {
                        if (document.ManualsIPad[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadManualsIPad newItem = B1900ProofReadManualsIPad.Compare(proofItem, document.ManualsIPad[i]);
                            ManualsIpad.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofOperationDocuments proofItem in proof.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.OperationDocuments.Count; i++)
                    {
                        if (document.OperationDocuments[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadOperationDocuments newItem = B1900ProofReadOperationDocuments.Compare(proofItem, document.OperationDocuments[i]);
                            OperationDocuments.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofAircraftFlipFile proofItem in proof.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.AircraftFlipFiles.Count; i++)
                    {
                        if (document.AircraftFlipFiles[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadAircraftFlipFile newItem = B1900ProofReadAircraftFlipFile.Compare(proofItem, document.AircraftFlipFiles[i]);
                            AircraftFlipFile.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofEquipment proofItem in proof.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Equipment.Count; i++)
                    {
                        if (document.Equipment[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadEquipment newItem = B1900ProofReadEquipment.Compare(proofItem, document.Equipment[i]);
                            Equipment.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofAdditionalItems proofItem in proof.AdditionalItems)
                {
                    for (int i = 0; i < document.AdditionalItems.Count; i++)
                    {
                        if (document.AdditionalItems[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadAdditionalItems newItem = B1900ProofReadAdditionalItems.Compare(proofItem, document.AdditionalItems[i]);
                            System.Diagnostics.Debug.WriteLine("Create a proof ");
                            AdditionalItems.Add(newItem);
                            break;
                        }
                    }
                    //
                }

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            //Run
            //Run a proof read by comparing the document and flagging if not equal
            //Set the endtry id 
            //Set the proofread id
        }


        public B1900ProofReadDocument(B1900MasterListPayload proofMaster, B1900MasterListPayload entryMaster, B1900ProofDocument proof, B1900Document document)
        {
            proofDocument = proof;
            try
            {

                entry.ProofId = proof.ProofID;
                entry.EntryId = document.B1900Entry.Id;

                foreach (B1900ProofCockpit proofItem in proof.Cockpits)
                {
                    B1900CockpitMaster dex = proofMaster.Cockpits.Fields.FirstOrDefault(d => d.Id == proofItem.DescriptionId);
                    if (dex != null)
                        for (int i = 0; i < document.Cockpits.Count; i++)
                        {
                            System.Diagnostics.Debug.WriteLine("Create a proof ");
                            B1900CockpitMaster desc = entryMaster.Cockpits.Fields.FirstOrDefault(d => d.Descr == dex.Descr);
                            //For all the items in entry 
                            //Find where the item
                            if (desc != null)
                            {
                                string proofDesc = proofMaster.Cockpits.Fields.FirstOrDefault(d => d.Descr == desc.Descr).Descr;
                                System.Diagnostics.Debug.WriteLine($"Create a proof {desc.Descr}");

                                //if (document.Cockpits[i].DescriptionId == proofItem.DescriptionId)
                                if (proofDesc != null)
                                {
                                    System.Diagnostics.Debug.WriteLine($"Create a proof {proofDesc}");
                                    //Compare 
                                    B1900ProofReadCockpit newItem = B1900ProofReadCockpit.Compare(proofItem, document.Cockpits[i]);
                                    Cockpits.Add(newItem);
                                    break;
                                }
                            }

                        }
                    //
                }
                foreach (B1900ProofCabin proofItem in proof.Cabins)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Cabins.Count; i++)
                    {
                        if (document.Cabins[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadCabin newItem = B1900ProofReadCabin.Compare(proofItem, document.Cabins[i]);
                            Cabins.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofFlightFolder proofItem in proof.FlightFolders)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.FlightFolders.Count; i++)
                    {
                        if (document.FlightFolders[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadFlightFolder newItem = B1900ProofReadFlightFolder.Compare(proofItem, document.FlightFolders[i]);
                            FlightFolder.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofManuals proofItem in proof.Manuals)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Manuals.Count; i++)
                    {
                        if (document.Manuals[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadManuals newItem = B1900ProofReadManuals.Compare(proofItem, document.Manuals[i]);
                            Manuals.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofManualsIPad proofItem in proof.ManualsIPad)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.ManualsIPad.Count; i++)
                    {
                        if (document.ManualsIPad[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadManualsIPad newItem = B1900ProofReadManualsIPad.Compare(proofItem, document.ManualsIPad[i]);
                            ManualsIpad.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofOperationDocuments proofItem in proof.OperationDocuments)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.OperationDocuments.Count; i++)
                    {
                        if (document.OperationDocuments[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadOperationDocuments newItem = B1900ProofReadOperationDocuments.Compare(proofItem, document.OperationDocuments[i]);
                            OperationDocuments.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofAircraftFlipFile proofItem in proof.AircraftFlipFiles)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.AircraftFlipFiles.Count; i++)
                    {
                        if (document.AircraftFlipFiles[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadAircraftFlipFile newItem = B1900ProofReadAircraftFlipFile.Compare(proofItem, document.AircraftFlipFiles[i]);
                            AircraftFlipFile.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofEquipment proofItem in proof.Equipment)
                {
                    System.Diagnostics.Debug.WriteLine("Create a proof ");
                    for (int i = 0; i < document.Equipment.Count; i++)
                    {
                        if (document.Equipment[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadEquipment newItem = B1900ProofReadEquipment.Compare(proofItem, document.Equipment[i]);
                            Equipment.Add(newItem);
                            break;
                        }
                    }
                    //
                }
                foreach (B1900ProofAdditionalItems proofItem in proof.AdditionalItems)
                {
                    for (int i = 0; i < document.AdditionalItems.Count; i++)
                    {
                        if (document.AdditionalItems[i].DescriptionId == proofItem.DescriptionId)
                        {
                            //Compare 
                            B1900ProofReadAdditionalItems newItem = B1900ProofReadAdditionalItems.Compare(proofItem, document.AdditionalItems[i]);
                            System.Diagnostics.Debug.WriteLine("Create a proof ");
                            AdditionalItems.Add(newItem);
                            break;
                        }
                    }
                    //
                }

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            //Run
            //Run a proof read by comparing the document and flagging if not equal
            //Set the endtry id 
            //Set the proofread id
        }

    }
}
