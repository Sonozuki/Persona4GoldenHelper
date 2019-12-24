using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class SkillCard
    {
        public int Id { get; set; }
        public SkillType Type { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }
}
