using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IShadow
    {
        List<Shadow> GetAll();
        List<Shadow> GetByName(string shadowName);
    }
}
