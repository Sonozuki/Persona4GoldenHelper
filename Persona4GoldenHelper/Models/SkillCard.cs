namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a skill card.</summary>
    public class SkillCard
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
    }
}
