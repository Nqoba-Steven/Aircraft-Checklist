using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Proof.B1900
{
    [Table(Names.Tables.B1900.Proofs.AdditionalItems, Schema = Names.Tables.B1900.Proofs.Schema)]

    public class B1900ProofAdditionalItems: EntryBase
    {
        public int ProofID { get; set; }
        [Column("ItemName", Order = 3)]
        public string? ItemName { get;set; }
        public DateTime? DateIfApplicable { get; set; }

        public string? RevStatusQTY { get; set; }
    }
}
