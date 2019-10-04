using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASUS_GamesDB.POCOs
{
    public enum Category
    {
        [JsonProperty("main_game")]
        MainGame = 0,

        [JsonProperty("dlc_addon")]
        DlcAddon = 1,

        [JsonProperty("expansion")]
        Expansion = 2,

        [JsonProperty("bundle")]
        Bundle = 3,

        [JsonProperty("standalone_expansion")]
        StandaloneExpansion = 4
    }
}
