using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
   public class CovidCaseVm
    {
        public string Gender { get; set; }
        public string AgeRange { get; set; }
        public DateTime DateDiagnosed { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
