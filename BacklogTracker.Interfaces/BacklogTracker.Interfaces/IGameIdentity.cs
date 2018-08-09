using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Interfaces
{
    public interface IGameIdentity
    {
        string ProviderId { get; set; }
        string Name { get; set; }
    }
}
