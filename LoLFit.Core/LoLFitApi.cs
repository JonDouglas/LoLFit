﻿using System;
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

        

        private static Region _region;

        public LoLFitApi(string apiToken, Region region)
        {
            //_apiToken = apiToken;

            _region = region;
        }

        public async Task<MatchDetails> GetMatchDetails(long matchId)
        {
            var baseAddress = String.Format(Endpoints.BaseUrl, _region);
            //var url = new Url(baseAddress);
            //url.SetQueryParam("api_key", "db6828b1-3bbd-4535-993b-f96017ff9af3");
            

            var client = new HttpClient(new LoLNativeMessageHandler(GetToken))
            {
                BaseAddress = new Uri(baseAddress)
            };

            var service = RestService.For<ILoLFitApi>(client);

            var results = await service.GetMatchDetails(matchId);
           
            return results;
        }

        private async Task<string> GetToken()
        {
            // The AquireTokenAsync call will prompt with a UI if necessary
            // Or otherwise silently use a refresh token to return
            // a valid access token 
            var token = "db6828b1-3bbd-4535-993b-f96017ff9af3";

            return token;
        }
    }
}
