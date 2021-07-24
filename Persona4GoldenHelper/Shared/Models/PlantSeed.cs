﻿namespace Persona4GoldenHelper.Shared.Models
{
    /// <summary>Represents a plant's seed.</summary>
    public class PlantSeed
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the seed.</summary>
        public string Name { get; }

        /// <summary>The price of the seed.</summary>
        public string Cost { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the seed.</param>
        /// <param name="cost">The cost of the seed.</param>
        public PlantSeed(string name, string cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}