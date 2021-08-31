using Persona4GoldenHelper.Components;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The base of a model that can be filtered by a <see cref="SearchBox"/>.</summary>
    public abstract class FilterableModelBase
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Gets whether the model passes a filter.</summary>
        /// <param name="filter">The filter to check.</param>
        /// <returns><see langword="true"/>, if the model passes the filter; otherwise, <see langword="false"/>.</returns>
        public abstract bool DoesModelPassFilter(string filter);
    }
}
