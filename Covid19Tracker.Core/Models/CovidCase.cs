using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core.Models
{
    [Table("Covid_Ireland_Cases")]
    public class CovidCase
    {
        [Key]
        [Column("Covid_Case_Id")]
        public int CaseId { get; set; }

        [Column("Date_Diagnosed")]
        public DateTime DateDiagnosed { get; set; }

        [Column("AgeGroup")]
        public string AgeGroup { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }

        [ForeignKey("Town")]
        [Column("Location_Id")]
        public int LocationId { get; set; }

        public virtual Town Town { get; set; }

    }
}
