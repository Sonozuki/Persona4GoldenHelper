namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents the stats of a shadow or persona.</summary>
    public class Stats : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The strength stat.</summary>
        public int Strength { get; }

        /// <summary>The magic stat.</summary>
        public int Magic { get; }

        /// <summary>The endurance stat.</summary>
        public int Endurance { get; }

        /// <summary>The agility stat.</summary>
        public int Agility { get; }

        /// <summary>The luck stat.</summary>
        public int Luck { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance/</summary>
        /// <param name="strength">The strength stat.</param>
        /// <param name="magic">The magic stat.</param>
        /// <param name="endurance">The endurance stat.</param>
        /// <param name="agility">The agility stat.</param>
        /// <param name="luck">The luck stat.</param>
        public Stats(int strength, int magic, int endurance, int agility, int luck)
        {
            Strength = strength;
            Magic = magic;
            Endurance = endurance;
            Agility = agility;
            Luck = luck;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Strength.ToString().Contains(filter)
            || Magic.ToString().Contains(filter)
            || Endurance.ToString().Contains(filter)
            || Agility.ToString().Contains(filter)
            || Luck.ToString().Contains(filter);
    }
}
