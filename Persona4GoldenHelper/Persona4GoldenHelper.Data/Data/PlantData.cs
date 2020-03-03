using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The plant data.</summary>
    public static class PlantData
    {
        /// <summary>The plant data.</summary>
        public static List<Plant> Plants { get; } = new List<Plant>()
        {
            new Plant() {
                DateAvailable = "5/22",
                Seed = new PlantSeed() {
                    Name = "Tomato Seedling",
                    Cost = "¥500"
                },
                GrowthTime = 5,
                Harvest = 3,
                HarvestWithTending = 5,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Tiny Soul Tomato",
                        Effect = "Recovers 20SP for one ally."
                    }
                }
            },
            new Plant() {
                DateAvailable = "5/22",
                Seed = new PlantSeed() {
                    Name = "Daikon Seedling",
                    Cost = "¥500"
                },
                GrowthTime = 5,
                Harvest = 3,
                HarvestWithTending = 5,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Return Daikon",
                        Effect = "Lets you leave the dungeon."
                    }
                }
            },
            new Plant() {
                DateAvailable = "6/5",
                Seed = new PlantSeed() {
                    Name = "Wheat Seedling",
                    Cost = "¥1000"
                },
                GrowthTime = 6,
                Harvest = 2,
                HarvestWithTending = 2,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Cracked Wheat",
                        Effect = "Opens a locked treasure box."
                    }
                }
            },
            new Plant() {
                DateAvailable = "6/5",
                Seed = new PlantSeed() {
                    Name = "Cabbage Seedling",
                    Cost = "¥1800"
                },
                GrowthTime = 5,
                Harvest = 2,
                HarvestWithTending = 2,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Hiranya Cabbage",
                        Effect = "Cures all ailments besides Down and Unconscious (party)."
                    }
                }
            },
            new Plant() {
                DateAvailable = "6/25",
                Seed = new PlantSeed() {
                    Name = "Paprika Seedling",
                    Cost = "¥2300"
                },
                GrowthTime = 7,
                Harvest = 1,
                HarvestWithTending = 1,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Red Paprika",
                        Effect = "Gives one ally Fire resistance for 3 turns."
                    },
                    new PlantProduct() {
                        Name = "White Paprika",
                        Effect = "Gives one ally Ice resistance for 3 turns."
                    },
                    new PlantProduct() {
                        Name = "Blue Paprika",
                        Effect = "Gives one ally Electric resistance for 3 turns."
                    },
                    new PlantProduct() {
                        Name = "Green Paprika",
                        Effect = "Gives one ally Wind resistance for 3 turns."
                    }
                }
            },
            new Plant() {
                DateAvailable = "6/25",
                Seed = new PlantSeed() {
                    Name = "Corn Seedling",
                    Cost = "¥2300"
                },
                GrowthTime = 8,
                Harvest = 1,
                HarvestWithTending = 1,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Tertacorn",
                        Effect = "Allows one ally to reflect one physical attack."
                    },
                    new PlantProduct() {
                        Name = "Makaracorn",
                        Effect = "Allows one ally to reflect one magical attack."
                    }
                }
            },
            new Plant() {
                DateAvailable = "6/24",
                Seed = new PlantSeed() {
                    Name = "Eggplant Seedling",
                    Cost = "¥3000"
                },
                GrowthTime = 9,
                Harvest = 1,
                HarvestWithTending = 1,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Scapegoat Eggplant",
                        Effect = "Takes your place once when hit with instant death magic."
                    }
                }
            },
            new Plant() {
                DateAvailable = "8/14",
                Seed = new PlantSeed() {
                    Name = "Melon Seedling",
                    Cost = "¥5000"
                },
                GrowthTime = 10,
                Harvest = 1,
                HarvestWithTending = 2,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "Bead Melon",
                        Effect = "Fully restores on ally's HP and SP."
                    }
                }
            }
        };
    }
}
