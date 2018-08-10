using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Objects.CompletionTime
{
    internal class CompletionTime
    {
        public TimeSpan Average { get; set; }
        public TimeSpan Median { get; set; }
        public TimeSpan Rushed { get; set; }
        public TimeSpan Leisure { get; set; }
    }
}
