using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.Learjet
{
    [Table(Names.Tables.Learjet.Proofs.Interior, Schema = Names.Tables.Learjet.Proofs.Schema)]
    public class LearjetProofInterior:EntryBase
    {
        public int ProofID { get; set; }
        public string? Status { get; set; }

    }
}
