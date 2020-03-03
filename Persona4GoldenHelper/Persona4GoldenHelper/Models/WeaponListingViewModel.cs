using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the weapon listing view.</summary>
    public class WeaponListingViewModel
    {
        /// <summary>The collection of weapons to render.</summary>
        public List<Weapon> Weapons { get; set; }
    }
}
