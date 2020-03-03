using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the armor listing view.</summary>
    public class ArmorListingViewModel
    {
        /// <summary>The collection of armor to render.</summary>
        public List<Armor> Armor { get; set; }
    }
}
