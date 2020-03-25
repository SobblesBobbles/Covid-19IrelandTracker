using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
   public class TownVm
    {
        public string TownName { get; set; }
        public string County { get; set; }

        public int Confirmed { get; set; }
    }
}
