using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Arcana { get; set; }
        public int Level { get; set; }
        public Stats Stats { get; set; }
        public Elements Elements { get; set; }
        public List<PersonaSkill> Skills { get; set; }
        public bool Ultimate { get; set; }
        public bool NewGame { get; set; }
    }
}
