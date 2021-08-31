namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a location where skill cards can be found.</summary>
    public class SkillCardLocation : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the dungeon skill cards can be found.</summary>
        public string DungeonName { get; }

        /// <summary>The lowest rank of skill card that can be found at this location.</summary>
        public int RankLowerBound { get; }

        /// <summary>The highest rank of skill card that can be found at this location.</summary>
        public int RankUpperBound { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="dungeonName">The name of the dungeon skill cards can be found.</param>
        /// <param name="rankLowerBound">The lowest rank of skill card that can be found at this location.</param>
        /// <param name="rankUpperBound">The highest rank of skill card that can be found at this location.</param>
        public SkillCardLocation(string dungeonName, int rankLowerBound, int rankUpperBound)
        {
            DungeonName = dungeonName;
            RankLowerBound = rankLowerBound;
            RankUpperBound = rankUpperBound;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            DungeonName.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || RankLowerBound.ToString().Contains(filter)
            || RankUpperBound.ToString().Contains(filter);
    }
}
