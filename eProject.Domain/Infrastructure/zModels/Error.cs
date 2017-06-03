using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.zModels.Abstracts;

namespace Infrastructure.zModels
{
    [Table("Errors")]
    public class Error : Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime CreateDate { get; set; }
    }
}