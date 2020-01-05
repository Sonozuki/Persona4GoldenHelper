using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Accuracy { get; set; }
        public string Effect { get; set; }
        public List<ItemObtain> Obtained { get; set; }
    }
}
