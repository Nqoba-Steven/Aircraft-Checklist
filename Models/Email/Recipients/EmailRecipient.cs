using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace NAC_Aircraft_Checklist.Models.Email
{
    public class EmailRecipient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public string? Name { get; set; }
        [NotNull]
        public string EmailAddress { get; set; }
        public bool isActive { get; set; }

        public override string ToString()
        {
            return $"Email Recipient \tName: {Name} \tEmail Address: {EmailAddress} \t isActive: {isActive}  "; 
        }
    }
}
