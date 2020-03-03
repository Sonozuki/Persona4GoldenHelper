using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Service
{
    public class FusionService : IFusion
    {
        /*********
        ** Fields 
        *********/
        /// <summary>The database context.</summary>
        private readonly ApplicationDbContext Context;

        /// <summary>Provides access to log to the console.</summary>
        private readonly ILogger<FusionService> Logger;


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">Provides access to log to the console.</param>
        public FusionService(ApplicationDbContext context, ILogger<FusionService> logger)
        {
            Context = context;
            Logger = logger;
        }

        /// <summary>Get all the arcana data.</summary>
        /// <returns>All arcana data.</returns>
        public List<ArcanaRank> GetAllArcanas()
        {
            try
            {
                Logger.LogInformation("GetAllArcanas was called");

                return Context.ArcanaRanks
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcanas failed: {ex}");
                return null;
            }
        }

        /// <summary>Get all the 2 persona fusion arcana data.</summary>
        /// <returns>All 2 persona fusion arcana data.</returns>
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

        /// <summary>Get all the 3 persona fusion arcana data.</summary>
        /// <returns>All 3 persona fusion arcana data.</returns>
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

        /// <summary>Get all the special persona fusion data.</summary>
        /// <returns>All special persona fusion data.</returns>
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
