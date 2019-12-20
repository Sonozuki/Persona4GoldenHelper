using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Persona
    {
        public string Name { get; private set; }
        public string Arcana { get; private set; }
        public int Level { get; private set; }
        public PersonaStats Stats { get; private set; }
        public PersonaElements Elements { get; private set; }
        public List<PersonaSkill> Skills { get; private set; }
        public bool Ultimate { get; private set; }
        public bool NewGame { get; private set; }

        public Persona(string name, string arcana, int level, PersonaStats stats, PersonaElements elements, List<PersonaSkill> skills, bool ultimate = false, bool newGame = false)
        {
            Name = name;
            Arcana = arcana;
            Level = level;
            Stats = stats;
            Elements = elements;
            Skills = skills;
            Ultimate = ultimate;
            NewGame = newGame;
        }
    }
}
