using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Email
{
    [Table(Names.Tables.Emailer.BaseManager, Schema =Names.Tables.Emailer.Schema)]
    public class BaseManagerRecipient : EmailRecipient
    {
       
    }
}
