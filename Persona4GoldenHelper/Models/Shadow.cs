using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a shadow.</summary>
    public class Shadow
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The type of the shadow.</summary>
        public ShadowType Type { get; }

        /// <summary>The name of the shadow.</summary>
        public string Name { get; }

        /// <summary>The level of the shadow.</summary>
        public int Level { get; }

        /// <summary>The number of health points the shadow has.</summary>
        public int HP { get; }

        /// <summary>The number of skill points the shadow has.</summary>
        public int SP { get; }

        /// <summary>The experience you get upon killing the shadow.</summary>
        public int Experience { get; }

        /// <summary>The amount of money you get upon killing the shadow.</summary>
        public string Yen { get; }

        /// <summary>The stats of the shadow.</summary>
        public Stats Stats { get; }

        /// <summary>The element affinities of the shadow.</summary>
        public ElementAffinities ElementAffinities { get; }

        /// <summary>The skills the shadow has.</summary>
        public List<string> Skills { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="type">The type of the shadow.</param>
        /// <param name="name">The name of the shadow.</param>
        /// <param name="level">The level of the shadow.</param>
        /// <param name="hp">The number of health points the shadow has.</param>
        /// <param name="sp">The number of skill points the shadow has.</param>
        /// <param name="experience">The experience you get upon killing the shadow.</param>
        /// <param name="yen">The amount of money you get upon killing the shadow.</param>
        /// <param name="stats">The stats of the shadow.</param>
        /// <param name="elementAffinities">The element affinities of the shadow.</param>
        /// <param name="skills">The skills the shadow has.</param>
        public Shadow(ShadowType type, string name, int level, int hp, int sp, int experience, string yen, Stats stats, ElementAffinities elementAffinities, List<string> skills)
        {
            Type = type;
            Name = name;
            Level = level;
            HP = hp;
            SP = sp;
            Experience = experience;
            Yen = yen;
            Stats = stats;
            ElementAffinities = elementAffinities;
            Skills = skills ?? new();
        }
    }
}
