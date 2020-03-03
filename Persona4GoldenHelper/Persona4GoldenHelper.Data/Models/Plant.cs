using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a plant.</summary>
    public class Plant
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The date the seeds become available.</summary>
        public string DateAvailable { get; set; }

        /// <summary>Data about the plant's seed.</summary>
        public PlantSeed Seed { get; set; }

        /// <summary>The number of days it takes the plant to grow.</summary>
        public int GrowthTime { get; set; }

        /// <summary>The amount of items are produced by the plant.</summary>
        public int Harvest { get; set; }

        /// <summary>The amount of items are produced by the plant once you'v eread the gardening book.</summary>
        public int HarvestWithTending { get; set; }

        /// <summary>The collection of possible products the plant can produce.</summary>
        public List<PlantProduct> Products { get; set; }
    }
}
