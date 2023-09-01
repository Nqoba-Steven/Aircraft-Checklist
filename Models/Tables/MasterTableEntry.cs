using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NAC_Aircraft_Checklist.Models.Tables
{
    public class MasterTableEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public int Revision { get; set; }
        public string Descr { get; set; }
        public string ShortName { get; set; } = null;
    }
}
