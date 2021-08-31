using Persona4GoldenHelper.Components;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a string that can be used in a <see cref="FilterableTable{TContent}"/>.</summary>
    public class FilterableString : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The value of the filterable string.</summary>
        public string Value { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="value">The value of the filterable string.</param>
        public FilterableString(string value)
        {
            Value = value;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) => Value.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }
}
