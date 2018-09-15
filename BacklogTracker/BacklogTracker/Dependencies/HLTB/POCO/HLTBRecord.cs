using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Dependencies.HLTB.POCO
{
    internal class HLTBRecord
    {
        public string Name { get; set; }
        public List<HLTBCategory> Categories { get; set; }

        public HLTBRecord(string name, List<HLTBCategory> categories)
        {
            this.Name = name;
            this.Categories = categories;
        }
    }
}
