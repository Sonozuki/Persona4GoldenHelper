using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about an accessory.</summary>
    public class Accessory
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The accessory name.</summary>
        public string Name { get; set; }

        /// <summary>The accessory effect.</summary>
        public string Effect { get; set; }

        /// <summary>The collection of methods to obtain the accessory.</summary>
        public List<ItemObtain> Obtained { get; set; }
    }
}
