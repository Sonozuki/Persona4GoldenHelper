using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a skill.</summary>
    public class Skill
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The skill name.</summary>
        public string Name { get; set; }

        /// <summary>The skill effect.</summary>
        public string Effect { get; set; }

        /// <summary>The cost to use the skill.</summary>
        public string Cost { get; set; }

        /// <summary>The collection of personas that have the skill by default.</summary>
        public List<SkillPersona> Personas { get; set; }
    }
}
