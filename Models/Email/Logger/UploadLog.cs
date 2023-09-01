using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    [Table(Names.Tables.EmailerLog.Uploads, Schema = Names.Tables.EmailerLog.Schema)]
    public class UploadLog : MailLogBase
    {
        public string UploadedBy { get; set; }
    }
}
