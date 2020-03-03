using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the accessory listing view.</summary>
    public class AccessoryListingViewModel
    {
        /// <summary>The collection of accessories to render.</summary>
        public List<Accessory> Accessories { get; set; }
    }
}
