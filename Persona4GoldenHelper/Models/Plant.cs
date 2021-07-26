using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a plant.</summary>
    public class Plant
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The date the seeds become available.</summary>
        public string DateAvailable { get; }

        /// <summary>The number of days it takes the plant to grow.</summary>
        public int GrowthTime { get; }

        /// <summary>The number of items that are produced by the plant.</summary>
        public int Harvest { get; }

        /// <summary>The number of items that are produced by the plant once you've read the gardening book.</summary>
        public int HarvestWithTending { get; }

        /// <summary>The plant's seed.</summary>
        public PlantSeed Seed { get; }

        /// <summary>The products the plant can produce.</summary>
        public List<PlantProduct> Products { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="dateAvailable">The date the seeds become available.</param>
        /// <param name="growthTime">The number of days it takes the plant to grow.</param>
        /// <param name="harvest">The number of items that are produced by the plant.</param>
        /// <param name="harvestWithTending">The number of items that are produced by the plant once you've read the gardening book.</param>
        /// <param name="seed">The plant's seed.</param>
        /// <param name="products">The products the plant can produce.</param>
        public Plant(string dateAvailable, int growthTime, int harvest, int harvestWithTending, PlantSeed seed, List<PlantProduct> products)
        {
            DateAvailable = dateAvailable;
            GrowthTime = growthTime;
            Harvest = harvest;
            HarvestWithTending = harvestWithTending;
            Seed = seed;
            Products = products ?? new();
        }
    }
}
