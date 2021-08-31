namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents an accessory.</summary>
    public class Accessory : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the accessory.</summary>
        public string Name { get; }

        /// <summary>The effect of the accessory.</summary>
        public string Effect { get; }

        /// <summary>The ways to obtain the accessory.</summary>
        public List<ItemObtain> Obtained { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the accessory.</param>
        /// <param name="effect">The effect of the accessory.</param>
        /// <param name="obtained">The ways to obtain the accessory.</param>
        public Accessory(string name, string effect, List<ItemObtain> obtained)
        {
            Name = name;
            Effect = effect;
            Obtained = obtained;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Name.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Effect.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Obtained.Any(obtained => obtained.DoesModelPassFilter(filter));
    }
}
