using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a shadow.</summary>
    public class Shadow
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The shadow name.</summary>
        public string Name { get; set; }

        /// <summary>The shadow level.</summary>
        public int Level { get; set; }

        /// <summary>The number of health points the shadow has.</summary>
        public int HP { get; set; }

        /// <summary>The number of skill points the shadow has.</summary>
        public int SP { get; set; }

        /// <summary>The experience you get upon killing the shadow.</summary>
        public int Exp { get; set; }

        /// <summary>The amount of money you get upon killing the shadow.</summary>
        public string Yen { get; set; }

        /// <summary>The shadow skills.</summary>
        public Stats Stats { get; set; }

        /// <summary>The shadow element affinities.</summary>
        public Elements Elements { get; set; }

        /// <summary>The shadow skills.</summary>
        public List<ShadowSkill> Skills { get; set; }

        /// <summary>Stores the full skills the shadow has, this get's populated when loading the shadow's page.</summary>
        public List<Skill> FullSkills { get; set; }

        /// <summary>The type of shadow.</summary>
        public ShadowType Type { get; set; }
    }
}
