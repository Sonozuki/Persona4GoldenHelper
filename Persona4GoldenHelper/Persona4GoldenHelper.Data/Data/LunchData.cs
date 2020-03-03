using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The lunch data.</summary>
    public class LunchData
    {
        /// <summary>The lunch data.</summary>
        public static List<Lunch> Lunches { get; set; } = new List<Lunch>()
        {
            new Lunch() {
                Name = "Broiled Fish",
                Method = "Wrap it tightly"
            },
            new Lunch() {
                Name = "California Rolls",
                Method = "Mix and cool simultaneously"
            },
            new Lunch() {
                Name = "Carrot & Burdock Root Kinpira",
                Method = "Add soy sauce and mirin"
            },
            new Lunch() {
                Name = "Chakin Sushi",
                Method = "Thinned eggs"
            },
            new Lunch() {
                Name = "Cream Stew",
                Method = "Dump in all the cold milk"
            },
            new Lunch() {
                Name = "Croquettes Curry",
                Method = "High Simmer"
            },
            new Lunch() {
                Name = "Daigaku-Imo",
                Method = "Deep Fry Them"
            },
            new Lunch() {
                Name = "Fried Chicken",
                Method = "Potato starch"
            },
            new Lunch() {
                Name = "Ginger Pork",
                Method = "Score it with a knife"
            },
            new Lunch() {
                Name = "Grilled Fish",
                Method = "Strong heat but from far away"
            },
            new Lunch() {
                Name = "Gyoza",
                Method = "Olive oil"
            },
            new Lunch() {
                Name = "Hamburgers",
                Method = "Cut a hole and look for juice"
            },
            new Lunch() {
                Name = "Kakuni",
                Method = "Mirin, sugar & sake"
            },
            new Lunch() {
                Name = "Marinated Spinach",
                Method = "Strain it"
            },
            new Lunch() {
                Name = "Meat Stew",
                Method = "Simmer with a dropped lid"
            },
            new Lunch() {
                Name = "Mentaiko Pasta",
                Method = "Mayonnaise"
            },
            new Lunch() {
                Name = "Oden",
                Method = "Keep on a low flame and don't boil"
            },
            new Lunch() {
                Name = "Potato Salad",
                Method = "Smash while still hot"
            },
            new Lunch() {
                Name = "Pudding",
                Method = "Vanilla extract"
            },
            new Lunch() {
                Name = "Sweet & Sour Pork",
                Method = "Potato starch"
            },
            new Lunch() {
                Name = "Tonkatsu",
                Method = "Flour, egg, then panko"
            },
            new Lunch() {
                Name = "Vichyssoise",
                Method = "Add lots of milk"
            },
            new Lunch() {
                Name = "Yakiniku Bento",
                Method = "Use soy sauce"
            }
        };
    }
}
