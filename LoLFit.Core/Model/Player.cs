namespace LoLFit.Core.Model
{
    public class Player
    {
        public string SummonerName { get; set; }
        public long SummonerId { get; set; }
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public long SummonerLevel { get; set; }
        public string MatchHistoryUri { get; set; }
    }
}
