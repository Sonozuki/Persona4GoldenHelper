using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Context;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class QuestService : IQuest
    {
        private readonly QuestContext Context;
        private readonly ILogger<QuestService> Logger;

        public QuestService(QuestContext context, ILogger<QuestService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<Quest> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.Quests
                    .ToList();
            }
            catch(Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }
    }
}
