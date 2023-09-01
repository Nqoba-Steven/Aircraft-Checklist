using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Models.Entry.B1900;

namespace NAC_Aircraft_Checklist.Models.Documents
{
    public class B1900Document
    {
        public Aircraft Aircraft { get; set; }
        //public DocumentEntryB1900 DocumentHeader { get; set; }
        public B1900Entry B1900Entry { get; set; }
        public List<B1900Interior> Interiors { get; set; } = new List<B1900Interior>();
        public List<B1900Exterior> Exteriors { get; set; } = new List<B1900Exterior>();
        public List<B1900Cockpit> Cockpits { get; set; } = new List<B1900Cockpit>();
        public List<B1900Cabin> Cabins { get; set; } = new List<B1900Cabin>();
        public List<B1900FlightFolder> FlightFolders { get; set; } = new List<B1900FlightFolder>();
        public List<B1900Manuals> Manuals { get; set; } = new List<B1900Manuals>();
        public List<B1900ManualsIPad> ManualsIPad { get; set; } = new List<B1900ManualsIPad>();
        public List<B1900OperationDocuments> OperationDocuments { get; set; } = new List<B1900OperationDocuments>();
        public List<B1900AircraftFlipFile> AircraftFlipFiles { get; set; } = new List<B1900AircraftFlipFile>();
        public List<B1900Equipment> Equipment { get; set; } = new List<B1900Equipment>();
        public List<B1900AdditionalItems> AdditionalItems { get; set; } = new List<B1900AdditionalItems>();
        public B1900Document()
        {
        }

    }
}
