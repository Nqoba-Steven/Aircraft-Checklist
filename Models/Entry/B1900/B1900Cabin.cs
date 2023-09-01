using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.Cabin, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900Cabin : EntryBase
    {
        public string? Status { get; set; }

        public DateTime? ExpiryDate { get; set; }
        //public DateTime ExpiryDate { get; set; }
        public override string ToString()
        {
            return $" Status: {Status}\tExpiry Date: {ExpiryDate}  {base.ToString()}";
        }
    }
}
