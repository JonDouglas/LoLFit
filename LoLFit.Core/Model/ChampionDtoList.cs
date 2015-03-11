using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class ChampionDtoList
    {
        public Dictionary<string, ChampionDto> Data { get; set; }
        public string Format { get; set; }
        public Dictionary<string, string> Keys { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
    }
}
