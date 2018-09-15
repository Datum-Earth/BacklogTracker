using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Dependencies.HLTB.POCO
{
    internal class HLTBSubCategory
    {
        public string Name { get; set; }

        public string[] Values { get; set; }

        public HLTBSubCategory(string[] values)
        {
            this.Values = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                {
                    this.Name = values[0];
                    continue;
                }

                this.Values[i] = values[i];
            }
        }
    }
}
