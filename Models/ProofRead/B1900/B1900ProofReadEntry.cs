using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.ProofRead
{

    [Table(Names.Tables.B1900.ProofReads.ProofRead, Schema = Names.Tables.B1900.ProofReads.Schema)]
    public class B1900ProofReadEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public int ProofId { get; set; }
        public int EntryId { get; set; }
    }
}
