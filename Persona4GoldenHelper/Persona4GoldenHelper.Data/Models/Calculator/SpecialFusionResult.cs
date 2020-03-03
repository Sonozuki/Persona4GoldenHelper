using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models.Calculator
{
    /// <summary>Metadata about a special persona fusion.</summary>
    public class SpecialFusionResult
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The collection of source personas.</summary>
        public List<FusionPersona> SourcePersonas { get; set; }

        /// <summary>The result persona.</summary>
        public string ResultPersona { get; set; }
    }
}
