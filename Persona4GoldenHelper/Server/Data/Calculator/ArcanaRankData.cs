using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data.Calculator
{
    /// <summary>The arcana rank data.</summary>
    public static class ArcanaRankData
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The arcana rank order data.</summary>
        public static List<string> ArcanaOrder { get; } = new() { "Fool", "Magician", "Priestess", "Empress", "Emperor", "Hierophant", "Lovers", "Chariot", "Justice", "Hermit", "Fortune", "Strength", "Hanged Man", "Death", "Temperance", "Devil", "Tower", "Star", "Moon", "Sun", "Judgement", "Jester", "Aeon", "World" };
    }
}
