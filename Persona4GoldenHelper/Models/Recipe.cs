namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a fusion recipe.</summary>
    public class Recipe
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The parent personas of the recipe.</summary>
        public List<Persona> ParentPersonas { get; }

        /// <summary>The cost of the recipe.</summary>
        public int Cost { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="parentPersonas">The parent personas of the recipe.</param>
        public Recipe(IEnumerable<Persona> parentPersonas)
        {
            ParentPersonas = parentPersonas.OrderByDescending(persona => persona.Cost).ToList();
            Cost = ParentPersonas.Sum(persona => persona.Cost);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) =>
            obj is Recipe recipe
             && ParentPersonas.SequenceEqual(recipe.ParentPersonas)
             && Cost == recipe.Cost;

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            foreach (var persona in ParentPersonas)
                hash.Add(persona.GetHashCode());
            return hash.ToHashCode();
        }
    }
}
