using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IPersona
    {
        List<Persona> GetAll();

        Persona GetByName(string personaName);
    }
}
