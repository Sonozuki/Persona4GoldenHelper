namespace Persona4GoldenHelper.Data.Models
{
    public class PlantProduct
    {
        public string Name { get; private set; }
        public string Effect { get; private set; }

        public PlantProduct(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
