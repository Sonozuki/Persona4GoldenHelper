using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The lunch data.</summary>
    public static class LunchData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The lunch data.</summary>
        public static List<Lunch> Lunches { get; } = new()
        {
            new("Broiled Fish", "Wrap it tightly"),
            new("California Rolls", "Mix and cool simultaneously"),
            new("Carrot & Burdock Root Kinpira", "Add soy sauce and mirin"),
            new("Chakin Sushi", "Thinned eggs"),
            new("Cream Stew", "Dump in all the cold milk"),
            new("Croquettes Curry", "High Simmer"),
            new("Daigaku-Imo", "Deep Fry Them"),
            new("Fried Chicken", "Potato starch"),
            new("Ginger Pork", "Score it with a knife"),
            new("Grilled Fish", "Strong heat but from far away"),
            new("Gyoza", "Olive oil"),
            new("Hamburgers", "Cut a hole and look for juice"),
            new("Kakuni", "Mirin, sugar & sake"),
            new("Marinated Spinach", "Strain it"),
            new("Meat Stew", "Simmer with a dropped lid"),
            new("Mentaiko Pasta", "Mayonnaise"),
            new("Oden", "Keep on a low flame and don't boil"),
            new("Potato Salad", "Smash while still hot"),
            new("Pudding", "Vanilla extract"),
            new("Sweet & Sour Pork", "Potato starch"),
            new("Tonkatsu", "Flour, egg, then panko"),
            new("Vichyssoise", "Add lots of milk"),
            new("Yakiniku Bento", "Use soy sauce")
        };
    }
}
