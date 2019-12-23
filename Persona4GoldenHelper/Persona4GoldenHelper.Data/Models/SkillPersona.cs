using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class SkillPersona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LevelRequired { get; set; }
        public bool Ultimate { get; set; }
        public bool NewGame { get; set; }
    }
}
