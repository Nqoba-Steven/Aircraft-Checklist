using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAC_Aircraft_Checklist.Models.Email
{
    [Table(Names.Tables.Emailer.UploadWaitList, Schema = Names.Tables.Emailer.Schema)]
    public class UploadWaitList : EmailRecipient
    {
        public UploadWaitList() { } 
        public UploadWaitList(BaseManagerRecipient baseManager)
        {
            this.isActive = baseManager.isActive;
            this.EmailAddress = baseManager.EmailAddress;
            this.Name = baseManager.Name;
        }
    }
}
