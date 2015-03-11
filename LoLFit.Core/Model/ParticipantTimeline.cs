namespace LoLFit.Core.Model
{
    public class ParticipantTimeline
    {
        public ParticipantTimelineData AncientGolemAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData AncientGolemKillsPerMinCounts { get; set; }
        public ParticipantTimelineData AssistedLaneDeathsPerMinDeltas { get; set; }
        public ParticipantTimelineData AssistedLaneKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData BaronAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData BaronKillsPerMinCounts { get; set; }
        public ParticipantTimelineData CreepsPerMinDeltas { get; set; }
        public ParticipantTimelineData CsDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData DamageTakenDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData DamageTakenPerMinDeltas { get; set; }
        public ParticipantTimelineData DragonAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData DragonKillsPerMinCounts { get; set; }
        public ParticipantTimelineData ElderLizardAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData ElderLizardKillsPerMinCounts { get; set; }
        public ParticipantTimelineData GoldPerMinDeltas { get; set; }
        public ParticipantTimelineData InhibitorAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData InhibitorKillsPerMinCounts { get; set; }
        public string Lane { get; set; }
        public string Role { get; set; }
        public ParticipantTimelineData TowerAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData TowerKillsPerMinCounts { get; set; }
        public ParticipantTimelineData TowerKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData VilemawAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData VilemawKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData WardsPerMinDeltas { get; set; }
        public ParticipantTimelineData XpDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData XpPerMinDeltas { get; set; }
    }
}
