namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about obtaining an item.</summary>
    public class ItemObtain
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The method to obtain the item.</summary>
        public string Obtain { get; set; }

        /// <summary>The price of the item.</summary>
        public string Price { get; set; }
    }
}
