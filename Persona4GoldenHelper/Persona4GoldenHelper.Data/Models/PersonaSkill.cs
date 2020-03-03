namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a persona's skill.</summary>
    public class PersonaSkill
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The skill name.</summary>
        public string Name { get; set; }

        /// <summary>The required level for the persona to unlock the skill.</summary>
        public int LevelRequired { get; set; }
    }
}
