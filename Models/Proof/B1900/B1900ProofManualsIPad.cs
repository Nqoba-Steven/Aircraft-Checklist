using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Proof.B1900
{
    [Table(Names.Tables.B1900.Proofs.ManualsIPad, Schema = Names.Tables.B1900.Proofs.Schema)]

    public class B1900ProofManualsIPad : EntryBase
    {
        public int ProofID { get; set; }
        public string? PublicationNumber { get; set; }
        public string? VolumeNumber { get; set; }
        public string? SetNumberFO { get; set; }
        public string? SetNumberPIC { get; set; }
      
        public string? RevStatus { get; set; }
        //public string DocumentFormat { get; set; }
    }
}
