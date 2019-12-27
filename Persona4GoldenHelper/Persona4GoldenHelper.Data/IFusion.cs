using Persona4GoldenHelper.Data.Models.Calculator;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IFusion
    {
        List<ArcanaFusionResult> GetAllArcana2FusionResults();
        List<ArcanaFusionResult> GetAllArcana3FusionResults();
        List<SpecialFusionResult> GetAllSpecialFusionResults();
    }
}
