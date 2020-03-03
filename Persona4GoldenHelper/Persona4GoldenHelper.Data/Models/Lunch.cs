namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a lunch.</summary>
    public class Lunch
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The lunch name.</summary>
        public string Name { get; set; }

        /// <summary>The correct method to create the lunch.</summary>
        public string Method { get; set; }
    }
}
