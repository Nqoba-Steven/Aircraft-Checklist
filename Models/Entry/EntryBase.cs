using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Entry
{

    public class EntryBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        //Foreign key Get from Entries Table Primary Key
        [Column("EntryId", Order = 1)]
        public int EntryId { get; set; }
        [Column("DescriptionId", Order = 2)]
        public int DescriptionId { get; set; } = -1;
        public string? RevisionText { get; set; }
        public string? Comments { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\tDocumentID: {EntryId}\tDescriptionID: {DescriptionId}\tRevisionText: {RevisionText}\tComments: {Comments}";
        }
    }
}
