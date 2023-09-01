
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    [Table(Names.Tables.EmailerLog.Escalations, Schema = Names.Tables.EmailerLog.Schema)]
    public class EscalationLog : MailLogBase
    {
    }
}
