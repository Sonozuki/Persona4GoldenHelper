using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a weapon.</summary>
    public class Weapon
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The person that can use the weapon.</summary>
        public User User { get; set; }

        /// <summary>The weapon name.</summary>
        public string Name { get; set; }

        /// <summary>The weapon attack.</summary>
        public int Attack { get; set; }

        /// <summary>The weapon accuracy.</summary>
        public int Accuracy { get; set; }

        /// <summary>The weapon effect.</summary>
        public string Effect { get; set; }

        /// <summary>The collection of methods to obtain the weapon.</summary>
        public List<ItemObtain> Obtained { get; set; }
    }
}
