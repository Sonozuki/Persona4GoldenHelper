namespace Persona4GoldenHelper.Shared.Models
{
    /// <summary>Represents a persona's skill.</summary>
    public class PersonaSkill
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the skill.</summary>
        public string Name { get; }

        /// <summary>The required level for the persona to unlock the skill.</summary>
        public int LevelRequired { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the skill.</param>
        /// <param name="levelRequired">The required level for the persona to unlock the skill.</param>
        public PersonaSkill(string name, int levelRequired)
        {
            Name = name;
            LevelRequired = levelRequired;
        }
    }
}
