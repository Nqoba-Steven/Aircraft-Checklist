using NAC_Aircraft_Checklist.Models.Entry.Learjet;
using NAC_Aircraft_Checklist.Models.Proof.Learjet;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.Learjet
{
    [Table(Names.Tables.Learjet.ProofReads.Interior, Schema = Names.Tables.Learjet.ProofReads.Schema)]
    public class LearjetProofReadInterior : ProofReadEntryBase
    {
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public static LearjetProofReadInterior Compare(LearjetProofInterior proof, LearjetInterior entry)
        {
            LearjetProofReadInterior item = new LearjetProofReadInterior();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = String.Equals(proof.Status, entry.Status, StringComparison.OrdinalIgnoreCase);
            return item;
        }
    }
}
