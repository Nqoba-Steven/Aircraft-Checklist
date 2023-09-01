using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Models.ProofRead.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.Exterior, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadExterior : ProofReadEntryBase
    {
        public bool StatusFlagged { get; set; }

        public bool RevTextFlagged { get; set; }
        public static LearjetProofReadExterior Compare(LearjetProofExterior proof, LearjetExterior entry)
        {
            LearjetProofReadExterior item = new LearjetProofReadExterior();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = String.Equals(proof.Status, entry.Status, StringComparison.OrdinalIgnoreCase);
            return item;
        }
    }
}
