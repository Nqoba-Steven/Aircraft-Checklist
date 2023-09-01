using Hangfire.Server;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace NAC_Aircraft_Checklist.Models.ProofRead
{
    public abstract class ProofReadEntryBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public int ProofId { get; set; }
        public int ProofReadId { get; set; }
        public int EntryId { get; set; }
        public int DescriptionId { get; set; }
        public string? RevisionText { get; set; }
        public string? Comments { get; set; }

    }
}
