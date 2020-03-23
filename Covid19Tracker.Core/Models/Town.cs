using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core.Models
{
    [Table("Covid_Towns")]
  public  class Town
    {
        [Key]
        [Column("Town_Id")]
        public int TownId { get; set; }

        [ForeignKey("County")]
        [Column("County_Id")]
        public int CountyId { get; set; }

        [Column("Town_Name")]
        public string TownName { get; set; }

        public virtual County County { get; set; }

        public virtual List<CovidCase> Cases { get; set; }

    }
}
