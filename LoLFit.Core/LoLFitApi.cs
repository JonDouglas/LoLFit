using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LoLFit.Core.Constants;
using LoLFit.Core.Model;
using LoLFit.Core.Model.Enum;
using ModernHttpClient;
using Refit;

namespace LoLFit.Core
{
    public class LoLFitApi
    {
        /// <summary>
        /// How many requests your app can make every 10 seconds
        /// </summary>
        private static int _requestsPerSecond;

        /// <summary>
        /// How many requests your app can make every 10 minutes
        /// </summary>
        private static int _requestsPerMinute;

        

        private static Region _region;

        public LoLFitApi(string apiToken, Region region)
        {
            //_apiToken = apiToken;

            _region = region;
        }

        public async Task<MatchDetails> GetMatchDetails(long matchId)
        {
            var client = new HttpClient(new NativeMessageHandler())
            {
                BaseAddress = new Uri(String.Format(Endpoints.BaseUrl, _region))
            };

            var service = RestService.For<ILeagueOfLegendsApi>(client);

            var results = await service.GetMatchDetails(matchId);
           
            return results;
        }
    }
}
