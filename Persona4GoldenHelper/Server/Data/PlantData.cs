using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The plant data.</summary>
    public static class PlantData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The plant data.</summary>
        public static List<Plant> Plants { get; } = new()
        {
            new("5/22", 5, 3, 5, new("Tomato Seedling", "¥500"), new()
            {
                new("Tiny Soul Tomato", "Recovers 20SP for one ally.")
            }),
            new("5/22", 5, 3, 5, new("Daikon Seedling", "¥500"), new()
            {
                new("Return Daikon", "Lets you leave the dungeon.")
            }),
            new("6/5", 6, 2, 2, new("Wheat Seedling", "¥1000"), new()
            {
                new("Cracked Wheat", "Opens a locked treasure box.")
            }),
            new("6/5", 5, 2, 2, new("Cabbage Seedling", "¥1800"), new()
            {
                new("Hiranya Cabbage", "Cures all ailments besides Down and Unconscious (party).")
            }),
            new("6/25", 7, 1, 1, new("Paprika Seedling", "¥2300"), new()
            {
                new("Red Paprika", "Gives one ally Fire resistance for 3 turns."),
                new("White Paprika", "Gives one ally Ice resistance for 3 turns."),
                new("Blue Paprika", "Gives one ally Electric resistance for 3 turns."),
                new("Green Paprika", "Gives one ally Wind resistance for 3 turns.")
            }),
            new("6/25", 8, 1, 1, new("Corn Seedling", "¥2300"), new()
            {
                new("Tertacorn", "Allows one ally to reflect one physical attack."),
                new("Makaracorn", "Allows one ally to reflect one magical attack.")
            }),
            new("6/24", 9, 1, 1, new("Eggplant Seedling", "¥3000"), new()
            {
                new("Scapegoat Eggplant", "Takes your place once when hit with instant death magic.")
            }),
            new("8/14", 10, 1, 2, new("Melon Seedling", "¥5000"), new()
            {
                new("Bead Melon", "Fully restores on ally's HP and SP.")
            })
        };
    }
}
