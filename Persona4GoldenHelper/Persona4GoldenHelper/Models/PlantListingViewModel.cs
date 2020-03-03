using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model the plant listing view.</summary>
    public class PlantListingViewModel
    {
        /// <summary>The collection of plants to render.</summary>
        public List<Plant> Plants { get; set; }
    }
}
