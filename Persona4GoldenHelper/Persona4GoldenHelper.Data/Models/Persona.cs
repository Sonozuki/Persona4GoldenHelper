using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a persona.</summary>
    public class Persona
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The persona name.</summary>
        public string Name { get; set; }

        /// <summary>The persona arcana.</summary>
        public string Arcana { get; set; }

        /// <summary>The persona base level.</summary>
        public int Level { get; set; }

        /// <summary>The persona stats.</summary>
        public Stats Stats { get; set; }

        /// <summary>The persona element affinities.</summary>
        public Elements Elements { get; set; }

        /// <summary>The persona skills.</summary>
        public List<PersonaSkill> Skills { get; set; }

        /// <summary>Whether the persona is an ultimate persona.</summary>
        public bool Ultimate { get; set; }

        /// <summary>Whether the persona is a new game plus persona.</summary>
        public bool NewGame { get; set; }
    }
}
