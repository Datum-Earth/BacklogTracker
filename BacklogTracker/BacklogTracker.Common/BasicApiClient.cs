using BacklogTracker.Interfaces.Clients;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BacklogTracker.Common
{
    public abstract class BasicApiClient : IWebApiClient
    {
        HttpClient Client { get; set; }

        public abstract void ApplyAuthentication();


    }
}
