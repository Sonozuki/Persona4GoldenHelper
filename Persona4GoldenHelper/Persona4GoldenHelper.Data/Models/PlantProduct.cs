namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about what a plant can produce.</summary>
    public class PlantProduct
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The product name.</summary>
        public string Name { get; set; }

        /// <summary>The product effect.</summary>
        public string Effect { get; set; }
    }
}
