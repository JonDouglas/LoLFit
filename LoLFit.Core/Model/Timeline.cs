using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class Timeline
    {
        public long FrameInterval { get; set; }
        public List<Frame> Frames { get; set; } 
    }
}
