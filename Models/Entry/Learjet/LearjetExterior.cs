using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.Exterior, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetExterior : EntryBase
    {
        public string? Status { get; set; }

    }
}
