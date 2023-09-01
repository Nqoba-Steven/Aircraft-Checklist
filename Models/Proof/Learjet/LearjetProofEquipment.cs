using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.Learjet
{
    [Table(Names.Tables.Learjet.Proofs.Equipment, Schema = Names.Tables.Learjet.Proofs.Schema)]
    public class LearjetProofEquipment : EntryBase
    {
        public int ProofID { get; set; }
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatusQTY { get; set; }
    }
}
