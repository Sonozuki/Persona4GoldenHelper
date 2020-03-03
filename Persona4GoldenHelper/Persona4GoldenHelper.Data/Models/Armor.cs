using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about an armor.</summary>
    public class Armor
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The gender than can wear the armor.</summary>
        public Gender Gender { get; set; }

        /// <summary>The armor name.</summary>
        public string Name { get; set; }

        /// <summary>The armor defense.</summary>
        public int Defense { get; set; }

        /// <summary>The armor evade.</summary>
        public int Evade { get; set; }

        /// <summary>The armor effect.</summary>
        public string Effect { get; set; }

        /// <summary>The collection of methods to obtain the armor.</summary>
        public List<ItemObtain> Obtained { get; set; }
    }
}
