using System.Collections.Generic;

namespace Persona4GoldenHelper.Shared.Models
{
    /// <summary>Represents a skill for a shadow or persona.</summary>
    public class Skill
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the skill.</summary>
        public string Name { get; }

        /// <summary>The effect of the skill.</summary>
        public string Effect { get; }

        /// <summary>The cost to use the skill.</summary>
        public string Cost { get; }

        /// <summary>The personas that have this skill by default (excluding what can be passed via fusion).</summary>
        public List<SkillPersona> Personas { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the skill.</param>
        /// <param name="effect">The effect of the skill.</param>
        /// <param name="cost">The cost to use the skill.</param>
        /// <param name="personas">The personas that have this skill by default (excluding what can be passed via fusion).</param>
        public Skill(string name, string effect, string cost, List<SkillPersona> personas)
        {
            Name = name;
            Effect = effect;
            Cost = cost;
            Personas = personas ?? new();
        }
    }
}
