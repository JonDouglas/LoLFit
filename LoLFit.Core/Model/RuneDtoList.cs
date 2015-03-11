using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class RuneDtoList
    {
        public BasicDataDto Basic { get; set; }
        public Dictionary<string, RuneDto> Data { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
    }
}
