using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface ISkill
    {
        List<Skill> GetAll();
        List<Skill> GetByPersona(Persona persona);
    }
}
