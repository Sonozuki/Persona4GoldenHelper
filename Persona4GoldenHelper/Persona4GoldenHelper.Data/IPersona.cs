using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IPersona
    {
        /// <summary>Get all the persona data.</summary>
        /// <returns>All persona data.</returns>
        List<Persona> GetAll();

        /// <summary>Get persona data by name.</summary>
        /// <param name="name">The persona's name.</param>
        /// <returns>The persona data.</returns>
        Persona GetByName(string personaName);
    }
}
