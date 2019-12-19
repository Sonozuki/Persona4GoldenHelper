namespace Persona4GoldenHelper.Data.Models
{
    public class Book
    {
        public string DateAvailable { get; private set; }
        public string Title { get; private set; }
        public string Requirement { get; private set; }
        public string Effect { get; private set; }

        public Book(string dateAvailable, string title, string requirement, string effect)
        {
            DateAvailable = dateAvailable;
            Title = title;
            Requirement = requirement;
            Effect = effect;
        }
    }
}
