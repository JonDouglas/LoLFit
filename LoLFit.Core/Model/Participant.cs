using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class Participant
    {
        public int ChampionId { get; set; }
        public List<Mastery> Masteries { get; set; }
        public int ParticipantId { get; set; }
        public List<Rune> Runes { get; set; }
        public int SpellId1 { get; set; }
        public int SpellId2 { get; set; }
        public ParticipantStats Stats { get; set; }
        public int TeamId { get; set; }
        public ParticipantTimeline Timeline { get; set; }
    }
}
