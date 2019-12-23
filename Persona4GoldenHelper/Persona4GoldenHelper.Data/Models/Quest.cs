namespace Persona4GoldenHelper.Data.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string QuestGiver { get; set; }
        public string Location { get; set; }
        public string DateAvailable { get; set; }
        public string Prerequisites { get; set; }
        public string Reward { get; set; }
        public string Instructions { get; set; }
    }
}
