using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class Frame
    {
        public long Timestamp { get; set; }
        public List<Event> Events { get; set; }
        public Dictionary<string, ParticipantFrame> ParticipantFrames { get; set; }
    }
}
