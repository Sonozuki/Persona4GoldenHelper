using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a weapon.</summary>
    public class Weapon
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The person that can use the weapon.</summary>
        public User User { get; }

        /// <summary>The name of the weapon.</summary>
        public string Name { get; }

        /// <summary>The attack of the weapon.</summary>
        public int Attack { get; }

        /// <summary>The accuracy of the weapon.</summary>
        public int Accuracy { get; }

        /// <summary>The effect of the weapon.</summary>
        public string Effect { get; }

        /// <summary>The ways to obtain the weapon.</summary>
        public List<ItemObtain> Obtained { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="user">The person that can use the weapon.</param>
        /// <param name="name">The name of the weapon.</param>
        /// <param name="attack">The attack of the weapon.</param>
        /// <param name="accuracy">The accuracy of the weapon.</param>
        /// <param name="effect">The effect of the weapon.</param>
        /// <param name="obtained">The ways to obtain the weapon.</param>
        public Weapon(User user, string name, int attack, int accuracy, string effect, List<ItemObtain> obtained)
        {
            User = user;
            Name = name;
            Attack = attack;
            Accuracy = accuracy;
            Effect = effect;
            Obtained = obtained ?? new();
        }
    }
}
