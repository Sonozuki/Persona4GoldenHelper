using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Cost { get; set; }
        public List<SkillPersona> Personas { get; set; }
    }
}
