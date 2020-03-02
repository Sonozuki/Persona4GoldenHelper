using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string DateAvailable { get; set; }
        public PlantSeed Seed { get; set; }
        public int GrowthTime { get; set; }
        public int Harvest { get; set; }
        public int HarvestWithTending { get; set; }
        public List<PlantProduct> Products { get; set; }
    }
}
