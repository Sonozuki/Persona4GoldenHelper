using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Context;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class AnswerService : IAnswer
    {
        private readonly ExamAnswerContext Context;
        private readonly ILogger<AnswerService> Logger;

        public AnswerService(ExamAnswerContext context, ILogger<AnswerService> logger)
        {
            Context = context;
            Logger = logger;            
        }

        public List<Answer> GetByMonth(string monthName)
        {
            try
            {
                Logger.LogInformation("GetByMonth was called");

                // use reflection to get the answers using the monthName variable
                return Context.Answers
                    .Where(answer => answer.Month.ToString() == monthName)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetByMonth failed: {ex}");
                return null;
            }
        }
    }
}
