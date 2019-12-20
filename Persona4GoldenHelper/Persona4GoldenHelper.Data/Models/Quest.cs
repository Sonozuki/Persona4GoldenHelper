namespace Persona4GoldenHelper.Data.Models
{
    public class Quest
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string QuestGiver { get; private set; }
        public string Location { get; private set; }
        public string DateAvailable { get; private set; }
        public string Prerequisites { get; private set; }
        public string Reward { get; private set; }
        public string Instructions { get; private set; }

        public Quest(int id, string title, string questGiver, string location, string dateAvailable, string prerequisites, string reward, string instructions)
        {
            Id = id;
            Title = title;
            QuestGiver = questGiver;
            Location = location;
            DateAvailable = dateAvailable;
            Prerequisites = prerequisites;
            Reward = reward;
            Instructions = instructions;
        }
    }
}
