using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models.Calculator
{
    public class SpecialFusionResult
    {
        public int Id { get; set; }
        public List<FusionPersona> SourcePersonas { get; set; }
        public string ResultPersona { get; set; }
    }
}
