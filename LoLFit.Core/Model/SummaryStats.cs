using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class SummaryStats
    {
        public List<PlayerStatsSummary> PlayerStatSummaries { get; set; }
        public long SummonerId { get; set; }
    }
}
