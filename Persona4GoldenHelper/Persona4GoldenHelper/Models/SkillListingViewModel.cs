using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the skill listing view.</summary>
    public class SkillListingViewModel
    {
        /// <summary>The collection of skills to render.</summary>
        public List<Skill> Skills { get; set; }
    }
}
