using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a persona.</summary>
    public class Persona
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the persona.</summary>
        public string Name { get; }

        /// <summary>The arcana of the persona.</summary>
        public string Arcana { get; }

        /// <summary>The base level of the persona.</summary>
        public int Level { get; }

        /// <summary>The stats of the persona.</summary>
        public Stats Stats { get; }

        /// <summary>The element affinities of the persona.</summary>
        public ElementAffinities ElementAffinities { get; }

        /// <summary>The skills of the persona.</summary>
        public List<PersonaSkill> Skills { get; }

        /// <summary>Whether the persona is an ultimate persona.</summary>
        public bool IsUltimate { get; }

        /// <summary>Whether the persona is a new game plus persona.</summary>
        public bool IsNewGamePlus { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the persona.</param>
        /// <param name="arcana">The arcana of the persona.</param>
        /// <param name="level">The base level of the persona.</param>
        /// <param name="stats">The stats of the persona.</param>
        /// <param name="elementAffinities">The element affinities of the persona.</param>
        /// <param name="skills">The skills of the persona.</param>
        /// <param name="isUltimate">Whether the persona is an ultimate persona.</param>
        /// <param name="isNewGamePlus">Whether the persona is a new game plus persona.</param>
        public Persona(string name, string arcana, int level, Stats stats, ElementAffinities elementAffinities, List<PersonaSkill> skills, bool isUltimate = false, bool isNewGamePlus = false)
        {
            Name = name;
            Arcana = arcana;
            Level = level;
            Stats = stats;
            ElementAffinities = elementAffinities;
            Skills = skills ?? new();
            IsUltimate = isUltimate;
            IsNewGamePlus = isNewGamePlus;
        }
    }
}
