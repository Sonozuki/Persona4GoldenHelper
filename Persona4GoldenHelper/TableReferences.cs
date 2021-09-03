using Persona4GoldenHelper.Components;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper
{
    /// <summary>Represents a collection of references to filterable tables.</summary>
    /// <typeparam name="TTableContent">The type of content of the tables whose references are to be stored.</typeparam>
    public class TableReferences<TTableContent>
        where TTableContent : FilterableModelBase
    {
        /*********
        ** Events
        *********/
        /// <summary>Invoked when the state of any of the tables gets changed.</summary>

        public event Action StateChanged;


        /*********
        ** Fields
        *********/
        /// <summary>The table references being stored.</summary>
        private readonly List<FilterableTable<TTableContent>> Tables = new();


        /*********
        ** Accessors
        *********/
        /// <summary>Gets the number of stored tables.</summary>
        public int Count => Tables.Count;

        /// <summary>Gets whether any of the stored tables have any results.</summary>
        public bool AnyHasResults => Tables.Any(table => table.HasResults);


        /*********
        ** Public Methods
        *********/
        /// <summary>Adds a table reference.</summary>
        /// <param name="table">The table to store.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="table"/> is <see langword="null"/>.</exception>
        public void Add(FilterableTable<TTableContent> table)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table));

            table.StateChanged += () => StateChanged?.Invoke();
            Tables.Add(table);
        }
    }
}
