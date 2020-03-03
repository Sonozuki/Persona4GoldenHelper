using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;


namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the persona listing view.</summary>
    public class PersonaListingViewModel
    {
        /// <summary>The collection of personas to render.</summary>
        public List<Persona> Personas { get; set; }
    }
}
