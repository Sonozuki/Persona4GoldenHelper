﻿namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a method to obtaining an item.</summary>
    public class ItemObtain : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The method to obtain the item.</summary>
        public string Obtain { get; }

        /// <summary>The price of the item.</summary>
        public string Price { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="obtain">The method to obtain the item.</param>
        /// <param name="price">The price of the item.</param>
        public ItemObtain(string obtain, string price)
        {
            Obtain = obtain;
            Price = price;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Price.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Obtain.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }
}
