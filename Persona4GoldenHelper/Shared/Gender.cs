using Persona4GoldenHelper.Shared.Models;

namespace Persona4GoldenHelper.Shared
{
    /// <summary>The gender that a piece of <see cref="Armour"/> is equippable on.</summary>
    public enum Gender
    {
        /// <summary>Can be equipped by any character.</summary>
        Unisex,

        /// <summary>Can be equipped by male characters.</summary>
        Male,

        /// <summary>Can be equipped by female characters.</summary>
        Female
    }
}
