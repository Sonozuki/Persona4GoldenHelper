namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a book.</summary>
    public class Book
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The date you can get the book.</summary>
        public string DateAvailable { get; set; }

        /// <summary>The book title.</summary>
        public string Title { get; set; }

        /// <summary>The requirement to get the book.</summary>
        public string Requirement { get; set; }

        /// <summary>The effect the book gives once you've read it.</summary>
        public string Effect { get; set; }
    }
}
