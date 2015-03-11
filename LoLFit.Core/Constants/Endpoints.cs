using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLFit.Core.Constants
{
    public class Endpoints
    {
        /// <summary>
        /// {0] - Represents the Region of the API
        /// </summary>
        public const string BaseUrl = "https://{0}.api.pvp.net";
        public const string PlayerByName = "/api/lol/{region}/v1.4/summoner/by-name/{summonerNames}";
        public const string RankedMatchHistory = "/api/lol/{region}/v2.2/matchhistory/{summonerId}";
        public const string MatchDetails = "/api/lol/{region}/v2.2/match/{matchId}";
        public const string RecentMatchHistory = "/api/lol/{region}/v1.3/game/by-summoner/{summonerId}/recent";
        public const string RankedStats = "/api/lol/{region}/v1.3/stats/by-summoner/{summonerId}/ranked";
        public const string SummaryStats = "/api/lol/{region}/v1.3/stats/by-summoner/{summonerId}/summary";
        public const string ChampionDataById = "/api/lol/static-data/{region}/v1.2/champion/{id}";
        public const string MasteryDataById = "/api/lol/static-data/{region}/v1.2/mastery/{id}";
        public const string RuneDataById = "/api/lol/static-data/{region}/v1.2/rune/{id}";
        public const string SummonerSpellDataById = "/api/lol/static-data/{region}/v1.2/summoner-spell/{id}";
        public const string ChampionData = "/api/lol/static-data/{region}/v1.2/champion";
        public const string MasteryData = "/api/lol/static-data/{region}/v1.2/mastery";
        public const string RuneData = "/api/lol/static-data/{region}/v1.2/rune";
        public const string SummonerSpellData = "/api/lol/static-data/{region}/v1.2/summoner-spell";
        public const string ItemData = "/api/lol/static-data/{region}/v1.2/item";
        public const string ItemDataById = "/api/lol/static-data/{region}/v1.2/item/{id}";
        public const string LeagueData = "/api/lol/{region}/v2.5/league/by-summoner/{summonerIds}";
        public const string CurrentGameInfo = "/observer-mode/rest/consumer/getSpectatorGameInfo/{platformId}/{summonerId}";
    }
}
