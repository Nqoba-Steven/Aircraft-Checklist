using NAC_Aircraft_Checklist.Util;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace NAC_Aircraft_Checklist.Models.Entities
{
    [Table(Names.Tables.Aircrafts.Schema)]
    public class Aircraft
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public  string Reg { get; set; }
        public string Type { get; set; } =null;
        public string EmailAddress { get; set; }
        public string BaseOfOperations { get; set; } = null;
        public override string ToString()
        {
            return $"Aircraft ID: {Id}\tAircraft Reg: {Reg}\t Email :{EmailAddress} \t Aircraft Type:{Type} \tBaseOfOperations: {BaseOfOperations}";
        }
    }
}
