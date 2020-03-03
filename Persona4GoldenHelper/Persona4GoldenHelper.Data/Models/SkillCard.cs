using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about a skill card.</summary>
    public class SkillCard
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The skill card type.</summary>
        public SkillType Type { get; set; }

        /// <summary>The skill card name.</summary>
        public string Name { get; set; }

        /// <summary>The skill card rank.</summary>
        public int Rank { get; set; }
    }
}
