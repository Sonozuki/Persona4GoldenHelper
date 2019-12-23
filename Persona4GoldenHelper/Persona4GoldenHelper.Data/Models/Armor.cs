using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Defense { get; set; }
        public int Evade { get; set; }
        public string Effect { get; set; }
        public IEnumerable<ArmorObtain> Obtained { get; set; }
    }
}
