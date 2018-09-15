using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Dependencies.HLTB.POCO
{
    internal class HLTBCategory
    {
        public string Name { get; set; }
        public string[] Headers { get; set; }
        public List<HLTBSubCategory> SubCategories { get; set; }

        public HLTBCategory()
        {
            this.Name = String.Empty;
            this.SubCategories = new List<HLTBSubCategory>();
        }
    }
}
