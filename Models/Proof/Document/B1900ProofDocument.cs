using Microsoft.AspNetCore.Mvc.Rendering;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using System.Diagnostics.CodeAnalysis;

namespace NAC_Aircraft_Checklist.Models.Proof.Document
{
    public class B1900ProofDocument
    {
        public int ProofID { get; set; } 
        public int AircraftID { get; set; }
        public int Revision { get; set; }

        public string CompletedBy { get; set; }

        public DateTime Date { get; set; }

        public string BaseOfOperations { get; set; }
        public List<B1900ProofAircraftFlipFile> AircraftFlipFiles { get; set; } = new List<B1900ProofAircraftFlipFile>();
        public List<B1900ProofCabin> Cabins { get; set; } = new List<B1900ProofCabin>();
        public List<B1900ProofCockpit> Cockpits { get; set; } = new List<B1900ProofCockpit>();
        public List<B1900ProofEquipment> Equipment { get; set; } = new List<B1900ProofEquipment>();
        //public List<B1900ProofExterior> Exteriors{ get; set; } = new List<B1900ProofExterior>();
        public List<B1900ProofFlightFolder> FlightFolders { get; set; } = new List<B1900ProofFlightFolder>();
        //public List<B1900ProofInterior> Interiors { get; set; } = new List<B1900ProofInterior>();
        public List<B1900ProofManuals> Manuals { get; set; } = new List<B1900ProofManuals>();
        public List<B1900ProofManualsIPad> ManualsIPad { get; set; } = new List<B1900ProofManualsIPad>();
        public List<B1900ProofOperationDocuments> OperationDocuments { get; set; } = new List<B1900ProofOperationDocuments>();
        public List<B1900ProofAdditionalItems> AdditionalItems { get; set; } = new List<B1900ProofAdditionalItems>();

        public List<SelectListItem> LopaConfigs
        {
            get
            {
                List<SelectListItem> Configs = new List<SelectListItem> {
                    new SelectListItem {Text="LOPA 19 Seats without Life Raft and Life Vest",Value="LOPA 19 Seats without Life Raft and Life Vest"},
                    new SelectListItem {Text="Cargo Config",Value="Cargo Config"},
                    new SelectListItem {Text="13 Seat Config",Value="13 Seat Config"},
                    new SelectListItem {Text="15 Seat Config",Value="15 Seat Config"},
                    new SelectListItem {Text="17 Seat Config",Value="17 Seat Config"},
                    new SelectListItem {Text="12 Seat 1 Stretcher Config",Value="12 Seat 1 Stretcher Config"}
                };  
                return Configs;
            }
        }


    }
}
