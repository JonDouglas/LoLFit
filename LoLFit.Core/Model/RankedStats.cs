using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class RankedStats
    {
        public long ModifyDate { get; set; }
        public long SummonerId { get; set; }
        public List<ChampionStats> Champions { get; set; } 
    }
}
