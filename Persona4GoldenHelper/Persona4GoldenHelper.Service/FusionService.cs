using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Service
{
    public class FusionService : IFusion
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<FusionService> Logger;

        public FusionService(ApplicationDbContext context, ILogger<FusionService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<ArcanaFusionResult> GetAllArcana2FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAlLArcana2FusionResults was called");

                return Context.ArcanaFusionResults
                    .Where(fusionResult => fusionResult.FusionType == FusionType.Arcana2)
                    .Include(fusionResult => fusionResult.SourceArcanas)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana2FusionResults failed: {ex}");
                return null;
            }
        }

        public List<ArcanaFusionResult> GetAllArcana3FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllArcana3FusionResults was called");

                return Context.ArcanaFusionResults
                    .Where(fusionResult => fusionResult.FusionType == FusionType.Arcana3)
                    .Include(fusionResult => fusionResult.SourceArcanas)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana3FusionResults failed: {ex}");
                return null;
            }
        }

        public List<SpecialFusionResult> GetAllSpecialFusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllSpecialFusionResults was called");

                return Context.SpecialFusionResults
                    .Include(fusionResult => fusionResult.SourcePersonas)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSpecialFusionResults failed: {ex}");
                return null;
            }
        }
    }
}
