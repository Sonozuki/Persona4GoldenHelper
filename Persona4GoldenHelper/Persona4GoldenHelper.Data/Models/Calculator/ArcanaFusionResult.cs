using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models.Calculator
{
    public class ArcanaFusionResult
    {
        public int Id { get; set; }
        public FusionType FusionType { get; set; }
        public List<FusionArcana> SourceArcanas { get; set; }
        public string ResultArcana { get; set; }
    }
}
