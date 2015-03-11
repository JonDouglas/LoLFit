using System.Collections.Generic;

namespace LoLFit.Core.Model
{
    public class MasteryDto
    {
        public List<string> Description { get; set; }
        public int Id { get; set; }
        public ImageDto Image { get; set; }
        public string Name { get; set; }
        public int Ranks { get; set; }
        public List<string> SanitizedDescription { get; set; } 
    }
}
