namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a book.</summary>
    public class Book
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The date the book becomes available.</summary>
        public string DateAvailable { get; }

        /// <summary>The title of the book.</summary>
        public string Title { get; }

        /// <summary>The requirement to get the book.</summary>
        public string Requirement { get; }

        /// <summary>The effect the book gives once you've read it.</summary>
        public string Effect { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="dateAvailable">The date the book becomes available.</param>
        /// <param name="title">The title of the book.</param>
        /// <param name="requirement">The requirement to get the book.</param>
        /// <param name="effect">The effect the book gives once you've read it.</param>
        public Book(string dateAvailable, string title, string requirement, string effect)
        {
            DateAvailable = dateAvailable;
            Title = title;
            Requirement = requirement;
            Effect = effect;
        }
    }
}
