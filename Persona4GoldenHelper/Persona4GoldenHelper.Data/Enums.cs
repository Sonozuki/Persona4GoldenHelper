namespace Persona4GoldenHelper.Data
{
    public class Enums
    {
        public enum ElementAffinity
        {
            Weak,
            None,
            Resistant,
            Null,
            Reflect,
            Absorb
        }

        public enum Gender
        {
            Unisex,
            Male,
            Female
        }

        public enum Month
        { 
            January = 1,
            February,
            April = 4, // skip march as you never play that month
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public enum SkillType
        { 
            Physical,
            Magical,
            Support,
            Passive
        }

        public enum FusionType
        {
            Arcana2,
            Arcana3
        }
    }
}
