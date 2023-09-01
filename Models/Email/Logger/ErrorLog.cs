
using NAC_Aircraft_Checklist.Util;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NAC_Aircraft_Checklist.Models.Email.Logger
{
    [Table(Names.Tables.SystemsLog.Error.TableName, Schema = Names.Tables.SystemsLog.Error.Schema)]
    public class ErrorLog 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        public DateTime Date;
        public string Message { get; set; }
    }
}
