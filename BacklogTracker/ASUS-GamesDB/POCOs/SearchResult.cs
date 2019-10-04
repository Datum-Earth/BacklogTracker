using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASUS_GamesDB.POCOs
{
    public class SearchResult
    {
        [JsonProperty("alternative_name")]
        public string AlternativeName { get; set; }

        /// <summary>
        /// Reference ID for Character
        /// </summary>
        [JsonProperty("character")]
        public string CharacterId { get; set; }

        /// <summary>
        /// Reference ID for Collection
        /// </summary>
        [JsonProperty("collection")]
        public string CollectionId { get; set; }

        /// <summary>
        /// Reference ID for Company
        /// </summary>
        [JsonProperty("company")]
        public string CompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///	Reference ID for Game
        /// </summary>
        [JsonProperty("game")]
        public string GameId { get; set; }

        [JsonProperty("name")]
        public string NameId { get; set; }

        /// <summary>
        /// Reference ID for Person
        /// </summary>
        [JsonProperty("person")]
        public string PersonId { get; set; }

        /// <summary>
        /// Reference ID for Platform
        /// </summary>
        [JsonProperty("platform")]
        public string PlatformId { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }


        [JsonProperty("theme")]
        public string ThemeId { get; set; }
    }
}
