namespace Persona4GoldenHelper.Shared.Models
{
    /// <summary>Represents the product of a plant.</summary>
    public class PlantProduct
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the product.</summary>
        public string Name { get; }

        /// <summary>The effect of the product.</summary>
        public string Effect { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the product.</param>
        /// <param name="effect">The effect of the product.</param>
        public PlantProduct(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
