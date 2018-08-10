using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BacklogTracker.Interfaces;

namespace BacklogTracker.Objects.Base
{
    public class BaseRecord : IMetadata
    {
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ChangedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
    }
}
