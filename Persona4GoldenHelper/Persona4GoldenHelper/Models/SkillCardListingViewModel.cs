using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model the skill card listing view.</summary>
    public class SkillCardListingViewModel
    {
        /// <summary>The collection of skill cards to render.</summary>
        public List<SkillCard> SkillCards { get; set; }

        /// <summary>The locations where skill cards can be found to render.</summary>
        public List<SkillCardLocation> SkillCardLocations { get; set; }
    }
}
