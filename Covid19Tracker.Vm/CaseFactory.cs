using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
   public class CaseFactory
    {

        public CaseFactory()
        {
            GenderGroups = new Dictionary<int, string>();
            CaseTypes = new Dictionary<int, string>();
            GenderGroups.Add(1, "Male");
            GenderGroups.Add(2, "Female");
            GenderGroups.Add(3, "Transgender");
            GenderGroups.Add(4, "Don't want to specify");
            CaseTypes.Add(1, "Confirmed Case");
            CaseTypes.Add(2, "Awaiting Results");
            CaseTypes.Add(3, "Awaiting Testing");

        }

        private Dictionary<int, string> CaseTypes { get; set; }
        public Dictionary<int, string> GetCaseTypes() => CaseTypes;
        private Dictionary<int, string> GenderGroups { get; set; }

        public Dictionary<int, string> GetGenders() => GenderGroups;
    }
}
