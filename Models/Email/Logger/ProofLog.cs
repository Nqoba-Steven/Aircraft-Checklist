using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    [Table(Names.Tables.EmailerLog.Proofs, Schema = Names.Tables.EmailerLog.Schema)]
    public class ProofLog: MailLogBase
    {
        public string UploadedBy { get; set; }
    }
}
