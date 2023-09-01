using Hangfire.Server;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    public abstract class MailLogBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public DateTime Date;

        public string EmailRecipients { get; set; }

    }
}
