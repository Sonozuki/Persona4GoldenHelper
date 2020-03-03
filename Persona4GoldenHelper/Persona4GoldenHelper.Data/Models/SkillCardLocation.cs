namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a skill card location.</summary>
    public class SkillCardLocation
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The dungeon name of this location.</summary>
        public string DungeonName { get; set; }

        /// <summary>The lowest rank of skill card that can be found at this location.</summary>
        public int RankLowerBound { get; set; }

        /// <summary>The highest rank of skill card that can be found at this location.</summary>
        public int RankUpperBound { get; set; }
    }
}
