using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
    public class CreateCovidCaseOverview
    {
        public CreateCovidCaseOverview()
        {

        }
        [Required(ErrorMessage = "Date is required *")]
        public DateTime DateDiagnosed { get; set; }
        public string ResidentLocation { get; set; }

        [Required(ErrorMessage = "Age Range is required")]
        public string AgeGroupPicked { get; set; }

        public AgeGroup Ages { get; set; }
        public Dictionary<int,string> AgeGroupRanges { get; set; }

        [Required(ErrorMessage ="Gender is not specified")]
        public string GenderValue { get; set; }
        public Dictionary<int, string> GenderRange { get; set; }

        [Required(ErrorMessage ="Location requred")]
        public int LocationId { get; set; }

        [Required(ErrorMessage ="CaseType required")]
        public int CaseTypeId { get; set; }

        public Dictionary<int, string> CaseTypes { get; set; }

        public Dictionary<int,string> AllLocations { get; set; }
    }
}
