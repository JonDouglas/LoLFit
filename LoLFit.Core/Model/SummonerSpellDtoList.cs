using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class SummonerSpellDtoList
    {
        public Dictionary<string, SummonerSpellDto> Data { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
    }
}
