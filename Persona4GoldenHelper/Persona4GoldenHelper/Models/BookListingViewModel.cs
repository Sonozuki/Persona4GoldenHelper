using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    public class BookListingViewModel
    {
        public List<Book> Books { get; set; }
        public List<string> BookOrder { get; set; }
    }
}
