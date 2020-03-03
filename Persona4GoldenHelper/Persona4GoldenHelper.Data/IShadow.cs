using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IShadow
    {
        /// <summary>Get all the shadow data.</summary>
        /// <returns>All shadow data.</returns>
        List<Shadow> GetAll();

        /// <summary>Get shadow data by name.</summary>
        /// <param name="name">The persona's name.</param>
        /// <returns>The data for the shadows that have the name.</returns>
        List<Shadow> GetByName(string shadowName);
    }
}
