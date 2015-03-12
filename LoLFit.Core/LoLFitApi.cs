using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LoLFit.Core.Constants;
using LoLFit.Core.Handlers;
using LoLFit.Core.Model;
using LoLFit.Core.Model.Enum;
using ModernHttpClient;
using Refit;
using Flurl;

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

        private static string _apiToken;

        private static Region _region;

        private static string _regionName;

        public LoLFitApi(string apiToken, Region region)
        {
            _apiToken = apiToken;

            _region = region;

            _regionName = _region.ToString().ToLower(); //Ensure lower case or else API will 404
        }

        public async Task<MatchDetails> GetMatchDetails(long matchId)
        {
            var baseAddress = String.Format(Endpoints.BaseUrl, _region);

            var client = new HttpClient(new LoLNativeMessageHandler())
            {
                BaseAddress = new Uri(baseAddress)
            };

            var service = RestService.For<ILoLFitApi>(client);

            var results = await service.GetMatchDetails(matchId, _regionName, _apiToken);
           
            return results;
        }
    }
}
