using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Proof.Learjet
{
    [Table(Names.Tables.Learjet.Proofs.Proof, Schema = Names.Tables.Learjet.Proofs.Schema)]
    public class LearjetProof
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int Revision { set; get; }
        public string User { set; get; }
        public int AircraftId { set; get; }
        public string BaseOfOperations { set; get; }
    }
}
