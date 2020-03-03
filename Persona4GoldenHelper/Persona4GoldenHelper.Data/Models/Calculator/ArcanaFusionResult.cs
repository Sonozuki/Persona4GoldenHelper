using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models.Calculator
{
    /// <summary>Metadata about an arcana fusion.</summary>
    public class ArcanaFusionResult
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The fusion type.</summary>
        public FusionType FusionType { get; set; }

        /// <summary>The source arcanas of the fusion.</summary>
        public List<FusionArcana> SourceArcanas { get; set; }

        /// <summary>The result aracana of the fusion.</summary>
        public string ResultArcana { get; set; }
    }
}
