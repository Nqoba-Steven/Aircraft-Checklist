using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.Cockpit, Schema = Names.Tables.B1900.ProofReads.Schema)]

    public class B1900ProofReadCockpit : ProofReadEntryBase
    {
        public bool ExpiryDateFlagged { get; set; }
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public static B1900ProofReadCockpit Compare(B1900ProofCockpit proof, B1900Cockpit entry)
        {
            B1900ProofReadCockpit item = new B1900ProofReadCockpit();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.Status = entry.Status;
            item.ExpiryDate = entry.ExpiryDate;
            item.RevisionText = entry.RevisionText;
            item.Comments = entry.Comments;

            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = proof.Status == null || entry.Status == null ?  false: entry.Status.Contains(proof.Status);
            item.ExpiryDateFlagged = entry.ExpiryDate == null || proof.ExpiryDate == null ? false : DateTime.Equals(proof.ExpiryDate.Value.Date, entry.ExpiryDate.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
