using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
  public  class CurrentCovidCasesOverview
    {
        public List<CovidCaseVm> CurrentCovidCases { get; set; }
        public string GenderBreakdown { get; set; }
        public string AgeBreakdown { get; set; }
        public string CovidCasesJson { get; set; }
        public string CaseBreakdown { get; set; }
    }
}
