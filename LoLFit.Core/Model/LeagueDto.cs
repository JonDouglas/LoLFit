using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class LeagueDto
    {
        public List<LeagueEntryDto> Entries { get; set; }
        public string Name { get; set; }
        public string ParticipantId { get; set; }
        public string Queue { get; set; }
        public string Tier { get; set; }
    }
}
