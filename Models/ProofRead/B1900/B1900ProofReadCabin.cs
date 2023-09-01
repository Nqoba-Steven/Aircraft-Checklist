using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Models.Proof.B1900;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.ProofRead.B1900
{
    [Table(Names.Tables.B1900.ProofReads.Cabin, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadCabin : ProofReadEntryBase
    {
        public bool ExpiryDateFlagged { get; set; }
        public bool StatusFlagged { get; set; }
        public bool RevTextFlagged { get; set; }
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public static B1900ProofReadCabin Compare(B1900ProofCabin proof, B1900Cabin entry)
        {
            B1900ProofReadCabin item = new B1900ProofReadCabin();
            item.ProofId = proof.ProofID;
            item.EntryId = entry.EntryId;
            item.RevisionText = entry.RevisionText;
            item.Status = entry.Status;
            item.RevisionText = entry.RevisionText;
            item.ExpiryDate = entry.ExpiryDate;
            item.Comments = entry.Comments;

            item.DescriptionId = proof.DescriptionId;
            item.StatusFlagged = entry.Status == null || proof.Status == null ? false : entry.Status.Contains(proof.Status);
            item.ExpiryDateFlagged = entry.ExpiryDate == null || proof.ExpiryDate == null ? false : DateTime.Equals(proof.ExpiryDate.Value.Date, entry.ExpiryDate.Value.Date);
            item.RevTextFlagged = entry.RevisionText == null || proof.RevisionText == null ? false : entry.RevisionText.Contains(proof.RevisionText);
            return item;
        }
    }
}
