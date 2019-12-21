using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Context
{
    public class PlantContext
    {
        public List<Plant> Plants { get; } = new List<Plant>()
        {
            new Plant(
                dateAvailable: "5/22",
                seed: new PlantSeed(
                    name: "Tomato Seedling",
                    cost: "¥500"
                ),
                growthTime: 5,
                harvest: 3,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Tiny Soul Tomato",
                        effect: "Recovers 20SP for one ally."
                    )
                }
            ),
            new Plant(
                dateAvailable: "5/22",
                seed: new PlantSeed(
                    name: "Daikon Seedling",
                    cost: "¥500"
                ),
                growthTime: 5,
                harvest: 3,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Return Daikon",
                        effect: "Lets you leave the dungeon."
                    )
                }
            ),
            new Plant(
                dateAvailable: "6/5",
                seed: new PlantSeed(
                    name: "Wheat Seedling",
                    cost: "¥1000"
                ),
                growthTime: 6,
                harvest: 2,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Cracked Wheat",
                        effect: "Opens a locked treasure box."
                    )
                }
            ),
            new Plant(
                dateAvailable: "6/5",
                seed: new PlantSeed(
                    name: "Cabbage Seedling",
                    cost: "¥1800"
                ),
                growthTime: 5,
                harvest: 2,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Hiranya Cabbage",
                        effect: "Cures all ailments besides Down and Unconscious (party)."
                    )
                }
            ),
            new Plant(
                dateAvailable: "6/25",
                seed: new PlantSeed(
                    name: "Paprika Seedling",
                    cost: "¥2300"
                ),
                growthTime: 7,
                harvest: 1,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Red Paprika",
                        effect: "Gives one ally Fire resistance for 3 turns."
                    ),
                    new PlantProduct(
                        name: "White Paprika",
                        effect: "Gives one ally Ice resistance for 3 turns."
                    ),
                    new PlantProduct(
                        name: "Blue Paprika",
                        effect: "Gives one ally Electric resistance for 3 turns."
                    ),
                    new PlantProduct(
                        name: "Green Paprika",
                        effect: "Gives one ally Wind resistance for 3 turns."
                    )
                }
            ),
            new Plant(
                dateAvailable: " 6/25",
                seed: new PlantSeed(
                    name: "Corn Seedling",
                    cost: "¥2300"
                ),
                growthTime: 8,
                harvest: 1,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Tertacorn",
                        effect: "Allows one ally to reflect one physical attack."
                    ),
                    new PlantProduct(
                        name: "Makaracorn",
                        effect: "Allows one ally to reflect one magical attack."
                    )
                }
            ),
            new Plant(
                dateAvailable: "6/24",
                seed: new PlantSeed(
                    name: "Eggplant Seedling",
                    cost: "¥3000"
                ),
                growthTime: 9,
                harvest: 1,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Scapegoat Eggplant",
                        effect: "Takes your place once when hit with instant death magic."
                    )
                }
            ),
            new Plant(
                dateAvailable: "8/14",
                seed: new PlantSeed(
                    name: "Melon Seedling",
                    cost: "¥5000"
                ),
                growthTime: 10,
                harvest: 1,
                products: new List<PlantProduct>(){
                    new PlantProduct(
                        name: "Bead Melon",
                        effect: "Fully restores on ally's HP and SP."
                    )
                }
            )
        };
    }
}
