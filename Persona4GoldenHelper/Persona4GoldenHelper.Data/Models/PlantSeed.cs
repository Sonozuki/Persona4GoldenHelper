namespace Persona4GoldenHelper.Data.Models
{
    public class PlantSeed
    {
        public string Name { get; private set; }
        public string Cost { get; private set; }

        public PlantSeed(string name, string cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
