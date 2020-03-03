using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the lunch listing view.</summary>
    public class LunchListingViewModel
    {
        /// <summary>The collection of lunches to render.</summary>
        public List<Lunch> Lunches { get; set; }
    }
}
