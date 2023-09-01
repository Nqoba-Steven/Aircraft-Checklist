using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.Learjet
{
    [Table(Names.Tables.Learjet.Entries.ManualsEFB, Schema = Names.Tables.Learjet.Entries.Schema)]
    public class LearjetManualsEFB : EntryBase
    {
        public string? PublicationNumber { get; set; }

        public string? VolumeNumber { get; set; }
        public string? SetNumberFO { get; set; }
        public string? SetNumberPIC { get; set; }
        public string? RevStatus { get; set; }

    }
}
