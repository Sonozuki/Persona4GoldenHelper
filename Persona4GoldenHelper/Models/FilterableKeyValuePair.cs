using Persona4GoldenHelper.Components;
using System.Collections;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a key value pair that can be used in a <see cref="FilterableTable{TContent}"/>.</summary>
    public class FilterableKeyValuePair<TKey, TValue> : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The key of the filterable key value pair.</summary>
        public TKey Key { get; }

        /// <summary>The value of the filterable key value pair.</summary>
        public TValue Value { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="value">The value of the filterable string.</param>
        public FilterableKeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter)
        {
            if (Value is IEnumerable<FilterableModelBase> filterableCollection)
                return filterableCollection.Any(item => item.DoesModelPassFilter(filter));
            else if (Value is FilterableModelBase filterableValue)
                return filterableValue.DoesModelPassFilter(filter);
            else
                throw new InvalidOperationException($"{nameof(Value)} property in {nameof(FilterableKeyValuePair<TKey, TValue>)} isn't a {nameof(FilterableModelBase)} or {nameof(IEnumerable)}<{nameof(FilterableModelBase)}>.");
        }
    }
}
