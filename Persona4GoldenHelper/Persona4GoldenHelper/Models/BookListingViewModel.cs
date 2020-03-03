using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// The listing view model for the book listing view.</summary>
    public class BookListingViewModel
    {
        /// <summary>The collection of books to render.</summary>
        public List<Book> Books { get; set; }

        /// <summary>The order the books are rendered in the player inventory to render on the web UI.</summary>
        public List<BookOrder> BookOrder { get; set; }
    }
}
