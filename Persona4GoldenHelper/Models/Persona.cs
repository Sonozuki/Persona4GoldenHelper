namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a persona.</summary>
    public class Persona : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the persona.</summary>
        public string Name { get; }

        /// <summary>The arcana of the persona.</summary>
        public string Arcana { get; }

        /// <summary>The base level of the persona.</summary>
        public int Level { get; }

        /// <summary>The stats of the persona.</summary>
        public Stats Stats { get; }

        /// <summary>The element affinities of the persona.</summary>
        public ElementAffinities ElementAffinities { get; }

        /// <summary>The skills of the persona.</summary>
        public List<PersonaSkill> Skills { get; }

        /// <summary>Whether the persona is an ultimate persona.</summary>
        public bool IsUltimate { get; }

        /// <summary>Whether the persona is a new game plus persona.</summary>
        public bool IsNewGamePlus { get; }

        /// <summary>Whether the persona has a special fusion recipe.</summary>
        public bool IsSpecial { get; }

        /// <summary>The cost to summon the persona.</summary>
        public int Cost { get; }
        

        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the persona.</param>
        /// <param name="arcana">The arcana of the persona.</param>
        /// <param name="level">The base level of the persona.</param>
        /// <param name="stats">The stats of the persona.</param>
        /// <param name="elementAffinities">The element affinities of the persona.</param>
        /// <param name="skills">The skills of the persona.</param>
        /// <param name="isUltimate">Whether the persona is an ultimate persona.</param>
        /// <param name="isNewGamePlus">Whether the persona is a new game plus persona.</param>
        /// <param name="isSpecial">Whether the persona has a special fusion recipe.</param>
        public Persona(string name, string arcana, int level, Stats stats, ElementAffinities elementAffinities, List<PersonaSkill> skills, bool isUltimate = false, bool isNewGamePlus = false, bool isSpecial = false)
        {
            Name = name;
            Arcana = arcana;
            Level = level;
            Stats = stats;
            ElementAffinities = elementAffinities;
            Skills = skills ?? new();
            IsUltimate = isUltimate;
            IsNewGamePlus = isNewGamePlus;
            IsSpecial = isSpecial;

            Cost = (int)MathF.Pow(Stats.Strength + Stats.Magic + Stats.Endurance + Stats.Agility + Stats.Luck, 2) + 2000;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Name.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Arcana.Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Level.ToString().Contains(filter)
            || Stats.DoesModelPassFilter(filter)
            || ElementAffinities.DoesModelPassFilter(filter);

        /// <inheritdoc/>
        public override bool Equals(object obj) =>
            obj is Persona persona
             && Name == persona.Name
             && Arcana == persona.Arcana
             && Level == persona.Level
             && Stats.Equals(persona.Stats)
             && ElementAffinities.Equals(persona.ElementAffinities)
             && Skills.SequenceEqual(persona.Skills)
             && IsUltimate == persona.IsUltimate
             && IsNewGamePlus == persona.IsNewGamePlus
             && Cost == persona.Cost;

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Name);
            hash.Add(Arcana);
            hash.Add(Level);
            hash.Add(Stats);
            hash.Add(ElementAffinities);
            hash.Add(Skills);
            hash.Add(IsUltimate);
            hash.Add(IsNewGamePlus);
            hash.Add(Cost);
            return hash.ToHashCode();
        }
    }
}
