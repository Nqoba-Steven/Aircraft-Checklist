using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NAC_Aircraft_Checklist.Models.Entities
{
    [Table("DocumentEntries", Schema ="B1900")]
    public class DocumentEntryB1900
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public int AircraftID { get; set; }
        [NotNull]
        public int Revision { get; set; }

        public string CompletedBy { get; set; }

        public DateTime Date { get; set; }

        public string BaseOfOperations { get; set; }


        public override string ToString()
        {
            return $"Document Entry: \tID: {Id}\tAircraftID: {AircraftID}\tRevision: {Revision}\tCompletedBy: {CompletedBy}\tDate: {Date}\tBase of Operations:{BaseOfOperations}";
        }
    }
}
