using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IBook
    {
        List<Book> GetAll();
        List<string> GetOrder();
    }
}
