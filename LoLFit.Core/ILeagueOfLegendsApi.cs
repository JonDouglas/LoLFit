using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLFit.Core.Model;
using LoLFit.Core.Model.Enum;
using Refit;

namespace LoLFit.Core
{
    public interface ILeagueOfLegendsApi
    {
        [Get("/api/lol/{region}/v2.2/match/{matchId}?api_key=db6828b1-3bbd-4535-993b-f96017ff9af3")]
        Task<MatchDetails> GetMatchDetails(long matchId, string region = "na"); //Enums do not seem to work, strings do though
    }
}
