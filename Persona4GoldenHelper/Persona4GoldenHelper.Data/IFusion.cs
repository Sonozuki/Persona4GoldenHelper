using Persona4GoldenHelper.Data.Models.Calculator;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IFusion
    {
        /// <summary>Get all the arcana data.</summary>
        /// <returns>All arcana data.</returns>
        List<ArcanaRank> GetAllArcanas();

        /// <summary>Get all the 2 persona fusion arcana data.</summary>
        /// <returns>All 2 persona fusion arcana data.</returns>
        List<ArcanaFusionResult> GetAllArcana2FusionResults();

        /// <summary>Get all the 3 persona fusion arcana data.</summary>
        /// <returns>All 3 persona fusion arcana data.</returns>
        List<ArcanaFusionResult> GetAllArcana3FusionResults();

        /// <summary>Get all the special persona fusion data.</summary>
        /// <returns>All special persona fusion data.</returns>
        List<SpecialFusionResult> GetAllSpecialFusionResults();
    }
}
