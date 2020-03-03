namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a persona that a skill can blong to.</summary>
    public class SkillPersona
    {
        /// <summary>The is.</summary>
        public int Id { get; set; }

        /// <summary>The persona name.</summary>
        public string Name { get; set; }

        /// <summary>The level required for this persona to unlock the skill.</summary>
        public int LevelRequired { get; set; }

        /// <summary>Whether the persona is an ultimate persona.</summary>
        public bool Ultimate { get; set; }

        /// <summary>Whether the persona is a new game plus persona.</summary>
        public bool NewGame { get; set; }
    }
}
