using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The view model for the shadow view.</summary>
    public class ShadowViewModel
    {
        /// <summary>The shadows to render (there may be multiple shadows as each shadow can have multiple types).</summary>
        public List<Shadow> Shadows { get; set; }
    }
}
