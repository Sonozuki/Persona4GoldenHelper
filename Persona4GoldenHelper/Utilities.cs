using System.Collections.Generic;

namespace Persona4GoldenHelper
{
    /// <summary>Contains miscellaneous helper methods.</summary>
    public static class Utilities
    {
        /*********
        ** Fields
        *********/
        /// <summary>The short name for each element affinity.</summary>
        private static readonly Dictionary<string, string> AffinitityNameConversion = new()
        {
            ["Weak"] = "wk",
            ["None"] = "-",
            ["Resistant"] = "rs",
            ["Null"] = "nu",
            ["Reflect"] = "rf",
            ["Absorb"] = "ab"
        };


        /*********
        ** Public Methods
        *********/
        /// <summary>This will convert the element affinities into shorter versions (e.g. "", "wk", "rs") for easier reading and displaying.</summary>
        /// <param name="element">The element affinity to convert</param>
        /// <returns>The short hand version of the affinity</returns>
        public static string ConvertElementAffinityToShortHand(ElementAffinity element) => AffinitityNameConversion[element.ToString()];
    }
}
