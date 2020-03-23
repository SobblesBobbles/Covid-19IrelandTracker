using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Vm
{
   public class AgeGroup
    {
        public AgeGroup()
        {
            AgeGroupRanges = new Dictionary<int, string>();
            AgeGroupRanges.Add(1, "0-18");
            AgeGroupRanges.Add(2, "19-28");
            AgeGroupRanges.Add(3, "29-38");
            AgeGroupRanges.Add(4, "39-48");
            AgeGroupRanges.Add(5, "49-58");
            AgeGroupRanges.Add(6, "59-68");
            AgeGroupRanges.Add(7, "59-68");
            AgeGroupRanges.Add(8, "69-78");
            AgeGroupRanges.Add(9, "79+");
        }
        private Dictionary<int, string> AgeGroupRanges { get; set; }
        public Dictionary<int, string> GetAges () => AgeGroupRanges;
    }
}
