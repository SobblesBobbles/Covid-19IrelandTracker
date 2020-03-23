using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
   public class GenderFactory
    {

        public GenderFactory()
        {
            GenderGroups = new Dictionary<int, string>();
            GenderGroups.Add(1, "Male");
            GenderGroups.Add(2, "Female");
            GenderGroups.Add(3, "Transgender");
            GenderGroups.Add(4, "Don't want to specify");
        }
        private Dictionary<int, string> GenderGroups { get; set; }


        public Dictionary<int, string> GetGenders() => GenderGroups;
    }
}
