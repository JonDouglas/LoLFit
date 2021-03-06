﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLFit.Core.Model;
using LoLFit.Core.Model.Enum;
using Refit;

namespace LoLFit.Core
{
    public interface ILoLFitApi
    {
        [Get("/api/lol/{region}/v2.2/match/{matchId}?api_key={apiKey}")]
        Task<MatchDetails> GetMatchDetails(long matchId, string region, string apiKey); //Enums do not seem to work, strings do though
    }
}
