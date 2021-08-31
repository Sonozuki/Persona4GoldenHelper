namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents an armour.</summary>
    public class Armour : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The gender than can wear the armour.</summary>
        public Gender Gender { get; }

        /// <summary>The name of the armour.</summary>
        public string Name { get; }

        /// <summary>The defence of the armour.</summary>
        public int Defence { get; }

        /// <summary>The evasion of the armour.</summary>
        public int Evasion { get; }

        /// <summary>The effect of the armour.</summary>
        public string Effect { get; }

        /// <summary>The ways to obtain the armour.</summary>
        public List<ItemObtain> Obtained { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="gender">The gender than can wear the armour.</param>
        /// <param name="name">The name of the armour.</param>
        /// <param name="defence">The defence of the armour.</param>
        /// <param name="evasion">The evasion of the armour.</param>
        /// <param name="effect">The effect of the armour.</param>
        /// <param name="obtained">The ways to obtain the armour.</param>
        public Armour(Gender gender, string name, int defence, int evasion, string effect, List<ItemObtain> obtained)
        {
            Gender = gender;
            Name = name;
            Defence = defence;
            Evasion = evasion;
            Effect = effect;
            Obtained = obtained ?? new();
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Gender.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Name.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Defence.ToString().Contains(filter)
            || Evasion.ToString().Contains(filter)
            || Effect.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Obtained.Any(obtained => obtained.DoesModelPassFilter(filter));
    }
}
