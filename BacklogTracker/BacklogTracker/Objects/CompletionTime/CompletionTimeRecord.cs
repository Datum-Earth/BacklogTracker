using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BacklogTracker.Objects.Base;

namespace BacklogTracker.Objects.CompletionTime
{
    internal class CompletionTimeRecord : BaseRecord
    {
        public string Category { get; set;}
        public string SubCategory { get; set; }
        public CompletionTime Times { get; set; }
        public CompletionTimeRecord()
        {
            this.CreateDate = DateTimeOffset.Now;
            this.ChangedDate = null;
            this.DeletedDate = null;
        }
    }
}
