using System.ComponentModel.DataAnnotations.Schema;
using NAC_Aircraft_Checklist.Util;
using NAC_Aircraft_Checklist.Models.Entry;
namespace NAC_Aircraft_Checklist.Models.Entry.B1900
{
    [Table(Names.Tables.B1900.Entries.OperationDocuments, Schema = Names.Tables.B1900.Entries.Schema)]
    public class B1900OperationDocuments : EntryBase
    {
        public DateTime? DateIfApplicable { get; set; }
        public string? RevStatus { get; set; }
        public override string ToString()
        {
            return $" DateIfApp :{DateIfApplicable}\t RevStatus: {RevStatus}\t {base.ToString()}";
        }
    }
}
