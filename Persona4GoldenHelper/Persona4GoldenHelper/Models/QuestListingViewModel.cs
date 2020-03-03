using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the quest listing view.</summary>
    public class QuestListingViewModel
    {
        /// <summary>The collection of quests to render.</summary>
        public List<Quest> Quests { get; set; }
    }
}
