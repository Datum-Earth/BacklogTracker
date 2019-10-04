using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASUS_GamesDB.POCOs
{
    public class EntitySearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
