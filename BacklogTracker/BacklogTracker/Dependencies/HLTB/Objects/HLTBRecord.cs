using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Dependencies.HLTB.Objects
{
    internal class HLTBRecord
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = this.Values.Keys.First(); }
        }

        public Dictionary<string, IEnumerable<string>> Values { get; set; }

        public HLTBRecord(Dictionary<string, IEnumerable<string>> values)
        {
            this.Values = values;
        }
    }
}
