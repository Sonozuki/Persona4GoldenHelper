using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class SkillPersona
    {
        public string Name { get; private set; }
        public int LevelRequired { get; private set; }
        public bool Ultimate { get; private set; }
        public bool NewGame { get; private set; }

        public SkillPersona(string name, int levelRequired, bool ultimate = false, bool newGame = false)
        {
            Name = name;
            LevelRequired = levelRequired;
            Ultimate = ultimate;
            NewGame = newGame;
        }
    }
}
