using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The view model for the persona view.</summary>
    public class PersonaViewModel
    {
        /// <summary>The persona to render.</summary>
        public Persona Persona { get; set; }

        /// <summary>The skills to render.</summary>
        public List<Skill> Skills { get; set; }
    }
}
