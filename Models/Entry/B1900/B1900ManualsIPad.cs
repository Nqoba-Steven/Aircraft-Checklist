using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Models.Entry;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.ManualsIPad, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900ManualsIPad : EntryBase
    {
        public string? PublicationNumber { get; set; }
        public string? VolumeNumber { get; set; }
        public string? SetNumberFO { get; set; }
        public string? SetNumberPIC { get; set; }
        public string? RevStatus { get; set; }
        //public string DocumentFormat { get; set; }
        public override string ToString()
        {
            return $" PubNum :{PublicationNumber}\t Vol: {VolumeNumber}\t Set Fo:{SetNumberFO}\t  Set PI:{SetNumberPIC}\tRevStatus: {RevStatus}\t {base.ToString()}";
        }

    }
}
