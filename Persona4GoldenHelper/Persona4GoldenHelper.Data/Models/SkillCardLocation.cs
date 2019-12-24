using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class SkillCardLocation
    {
        public int Id { get; set; }
        public string DungeonName { get; set; }
        public int RankLowerBound { get; set; }
        public int RankUpperBound { get; set; }
    }
}
