namespace Persona4GoldenHelper.Data.Models
{
    public class PersonaStats
    {
        public int Strength { get; private set; }
        public int Magic { get; private set; }
        public int Endurance { get; private set; }
        public int Agility { get; private set; }
        public int Luck { get; private set; }

        public PersonaStats(int strength, int magic, int endurance, int agility, int luck)
        {
            Strength = strength;
            Magic = magic;
            Endurance = endurance;
            Agility = agility;
            Luck = luck;
        }
    }
}
