using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core.Models
{
    [Table("Covid_Counties")]
    public class County
    {
        [Key]
        [Column("County_Id")]
        public int CountyId { get; set; }

        [Column("County_Name")]
        public string CountyName { get; set; }


        public virtual List<Town> Towns { get; set; }
        }
}
