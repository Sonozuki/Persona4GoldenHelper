﻿using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Shadow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int SP { get; set; }
        public int Exp { get; set; }
        public string Yen { get; set; }
        public Stats Stats { get; set; }
        public Elements Elements { get; set; }
        public List<ShadowSkill> Skills { get; set; }

        /// <summary>Stores the full skills the shadow has, this get's populated when loading the shadow's page.</summary>
        public List<Skill> FullSkills { get; set; }
        public ShadowType Type { get; set; }
    }
}