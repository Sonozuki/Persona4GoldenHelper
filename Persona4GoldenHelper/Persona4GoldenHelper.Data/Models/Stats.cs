namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about stats for shadows and personas.</summary>
    public class Stats
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The strength stat.</summary>
        public int Strength { get; set; }

        /// <summary>The magic stat.</summary>
        public int Magic { get; set; }

        /// <summary>The endurance stat.</summary>
        public int Endurance { get; set; }

        /// <summary>The agility stat.</summary>
        public int Agility { get; set; }

        /// <summary>The luck stat.</summary>
        public int Luck { get; set; }
    }
}
