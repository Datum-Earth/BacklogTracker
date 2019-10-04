using ASUS_GamesDB;
using ASUS_GamesDB.POCOs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ASUSGamesDB
{
    public class GamesDbClient
    {
        HttpClient Client;
        ILogger Logger;

        public GamesDbClient(ILogger logger)
        {
            this.Logger = logger;

            this.Client = new HttpClient();
            this.Client.BaseAddress = new Uri(Constants.BaseUri);
            this.Client.DefaultRequestHeaders.Add("user-key", Constants.ApiKey);
            this.Client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }

        public async Task<IEnumerable<Game>> FindGame(string Id)
        {
            string postData = $"fields *; where id = {Id};";
            string uri = "games";

            var response = await this.Client.PostAsync(uri, new StringContent(postData));
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Game>>(result);
            }
            else
            {
                throw new Exception($"ASUS Games DB search request failed. {response.StatusCode}");
            }
        }

        public async Task<IEnumerable<EntitySearchResult>> Search(string criteria)
        {
            string postData = $"search \"{ criteria }\"; fields *;";
            string uri = Constants.BaseUri + "games";
            var postContent = new FormUrlEncodedContent(
                new Dictionary<string, string>()
                {
                    { "", postData }
                }
            );

            var response = await this.Client.PostAsync(uri, postContent);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EntitySearchResult>>(result);
            } else
            {
                throw new Exception($"ASUS Games DB search request failed. {response.StatusCode}");
            }
        }
    }
}
