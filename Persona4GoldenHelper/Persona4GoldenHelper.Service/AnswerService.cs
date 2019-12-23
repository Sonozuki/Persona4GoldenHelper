using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class AnswerService : IAnswer
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<AnswerService> Logger;

        public AnswerService(ApplicationDbContext context, ILogger<AnswerService> logger)
        {
            Context = context;
            Logger = logger;            
        }

        public List<Answer> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.ExamAnswers
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }
    }
}
