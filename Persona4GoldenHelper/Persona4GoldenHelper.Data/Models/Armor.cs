using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Armor
    {
        public Gender Gender { get; private set; }
        public string Name { get; private set; }
        public int Defense { get; private set; }
        public int Evade { get; private set; }
        public string Effect { get; private set; }
        public List<ArmorObtain> Obtained { get; private set; }

        public Armor(Gender gender, string name, int defense, int evade, string effect, List<ArmorObtain> obtained)
        {
            Gender = gender;
            Name = name;
            Defense = defense;
            Evade = evade;
            Effect = effect;
            Obtained = obtained;
        }
    }
}
