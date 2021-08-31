namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a quest.</summary>
    public class Quest : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The game assigned number of the quest.</summary>
        public int Number { get; }

        /// <summary>The title of the quest.</summary>
        public string Title { get; }

        /// <summary>The quest giver.</summary>
        public string QuestGiver { get; }

        /// <summary>The location to initiate and complete the quest.</summary>
        public string Location { get; }

        /// <summary>The date the quest becomes available.</summary>
        public string DateAvailable { get; }

        /// <summary>The requirements before the quest becomes available.</summary>
        public string Prerequisites { get; }

        /// <summary>The reward of the quest.</summary>
        public string Reward { get; }

        /// <summary>The instructions to complete the quest.</summary>
        public string Instructions { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="number">The game assigned number of the quest.</param>
        /// <param name="title">The title of the quest.</param>
        /// <param name="questGiver">The quest giver.</param>
        /// <param name="location">The location to initiate and complete the quest.</param>
        /// <param name="dateAvailable">The date the quest becomes available.</param>
        /// <param name="prerequisites">The requirements before the quest becomes available.</param>
        /// <param name="reward">The reward of the quest.</param>
        /// <param name="instructions">The instructions to complete the quest.</param>
        public Quest(int number, string title, string questGiver, string location, string dateAvailable, string prerequisites, string reward, string instructions)
        {
            Number = number;
            Title = title;
            QuestGiver = questGiver;
            Location = location;
            DateAvailable = dateAvailable;
            Prerequisites = prerequisites;
            Reward = reward;
            Instructions = instructions;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Number.ToString().Contains(filter)
            || Title.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || QuestGiver.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Location.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || DateAvailable.Contains(filter)
            || Prerequisites.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Reward.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Instructions.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }
}
