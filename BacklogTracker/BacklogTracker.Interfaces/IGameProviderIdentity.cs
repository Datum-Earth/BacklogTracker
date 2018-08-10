using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Interfaces
{
    public interface IGameProviderIdentity
    {
        object ProviderId { get; set; }
        string Gamertag { get; set; }
        IEnumerable<object> CustomFields { get; set; }
    }
}
