namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a quest.</summary>
    public class Quest
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The game specified number for the quest.</summary>
        public int Number { get; set; }

        /// <summary>The quest title.</summary>
        public string Title { get; set; }

        /// <summary>The quest giver.</summary>
        public string QuestGiver { get; set; }

        /// <summary>The location to initiate and complete the quest.</summary>
        public string Location { get; set; }

        /// <summary>The date the quest becomes available.</summary>
        public string DateAvailable { get; set; }

        /// <summary>The requirements before the quest becomes available.</summary>
        public string Prerequisites { get; set; }

        /// <summary>The quest reward.</summary>
        public string Reward { get; set; }

        /// <summary>The instructions to complete the quest.</summary>
        public string Instructions { get; set; }
    }
}
