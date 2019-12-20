using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class SkillPersona
    {
        public string Name { get; set; }
        public int LevelRequired { get; set; }
        public bool Ultimate { get; set; }
        public bool NewGame { get; set; }

        public SkillPersona(string name, int levelRequired, bool ultimate = false, bool newGame = false)
        {
            Name = name;
            LevelRequired = levelRequired;
            Ultimate = ultimate;
            NewGame = newGame;
        }
    }
}
