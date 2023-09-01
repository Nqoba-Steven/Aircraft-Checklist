using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    [Table(Names.Tables.EmailerLog.Revisions, Schema = Names.Tables.EmailerLog.Schema)]
    public class RevisionLog : MailLogBase
    {
        public string UploadedBy { get; set; }
        public int Revision { get; set; }
        public string AircraftType { get; set; }
    }
}
