using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Plant
    {
        public string DateAvailable { get; private set; }
        public PlantSeed Seed { get; private set; }
        public int GrowthTime { get; private set; }
        public int Harvest { get; private set; }
        public List<PlantProduct> Products { get; private set; }

        public Plant(string dateAvailable, PlantSeed seed, int growthTime, int harvest, List<PlantProduct> products)
        {
            DateAvailable = dateAvailable;
            Seed = seed;
            GrowthTime = growthTime;
            Harvest = harvest;
            Products = products;
        }
    }
}
