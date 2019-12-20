namespace Persona4GoldenHelper.Data.Models
{
    public class PersonaSkill
    {
        public string Name { get; private set; }
        public int LevelRequired { get; private set; }

        public PersonaSkill(string name, int levelRequired)
        {
            Name = name;
            LevelRequired = levelRequired;
        }
    }
}
