namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a persona that a skill can belong to.</summary>
    public class SkillPersona
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the persona.</summary>
        public string Name { get; }

        /// <summary>The level required for the persona to unlock the skill.</summary>
        public int LevelRequired { get; }

        /// <summary>Whether the persona is an ultimate persona.</summary>
        public bool IsUltimate { get; }

        /// <summary>Whether the persona is a new game plus persona.</summary>
        public bool IsNewGamePlus { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the persona.</param>
        /// <param name="levelRequired">The level required for the persona to unlock the skill.</param>
        /// <param name="isUltimate">Whether the persona is an ultimate persona.</param>
        /// <param name="isNewGamePlus">Whether the persona is a new game plus persona.</param>
        public SkillPersona(string name, int levelRequired, bool isUltimate, bool isNewGamePlus)
        {
            Name = name;
            LevelRequired = levelRequired;
            IsUltimate = isUltimate;
            IsNewGamePlus = isNewGamePlus;
        }
    }
}
