namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a skill card.</summary>
    public class SkillCard : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The type of the skill card.</summary>
        public SkillCardType Type { get; }

        /// <summary>The name of the skill card.</summary>
        public string Name { get; }

        /// <summary>The rank of the skill card.</summary>
        public int Rank { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="type">The type of the skill card.</param>
        /// <param name="name">The name of the skill card.</param>
        /// <param name="rank">The rank of the skill card.</param>
        public SkillCard(SkillCardType type, string name, int rank)
        {
            Type = type;
            Name = name;
            Rank = rank;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Type.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Name.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Rank.ToString().Contains(filter);
    }
}
