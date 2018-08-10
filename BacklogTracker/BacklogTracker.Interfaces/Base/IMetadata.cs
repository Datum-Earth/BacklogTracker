using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Interfaces
{
    public interface IMetadata
    {
        DateTimeOffset? CreateDate { get; set; }
        DateTimeOffset? ChangedDate { get; set; }
        DateTimeOffset? DeletedDate { get; set; }
    }
}
