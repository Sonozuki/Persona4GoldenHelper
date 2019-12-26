using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public List<AccessoryObtain> Obtained { get; set; }
    }
}
