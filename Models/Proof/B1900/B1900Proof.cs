using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Proof.B1900
{
    [Table(Names.Tables.B1900.Proofs.Proof, Schema = Names.Tables.B1900.Proofs.Schema)]
    public class B1900Proof
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int Revision { set; get; }
        public string User { set; get; }
        public int AircraftId { set; get; }
        public string BaseOfOperations { set; get; }
    }
}
