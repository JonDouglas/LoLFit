using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class BlockDto
    {
        public List<BlockItemDto> Items { get; set; }
        public bool RecMath { get; set; }
        public string Type { get; set; }
    }
}
