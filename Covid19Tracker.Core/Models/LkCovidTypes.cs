using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core.Models
{
    [Table("Lk_Covid_Types ")]
    public class LkCovidTypes
    {
        [Key]
        [Column("Covid_Type_Id")]
        public int CovidTypeId { get; set; }

        [Column("Covid_Type_Description")]
        public string CovidTypeDescription { get; set; }
    }
}
