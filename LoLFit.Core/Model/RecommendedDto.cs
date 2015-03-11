using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class RecommendedDto
    {
        public List<BlockDto> Blocks { get; set; }
        public string Champion { get; set; }
        public string Map { get; set; }
        public string Mode { get; set; }
        public bool Priority { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
