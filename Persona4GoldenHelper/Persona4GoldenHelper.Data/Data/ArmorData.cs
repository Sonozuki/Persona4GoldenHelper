using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Data
{
    public static class ArmorData
    {
        public static List<Armor> Armor { get; } = new List<Armor>()
        {
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Chain Mail",
                Defense = 34,
                Evade = 8,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥3000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Kevlar Vest",
                Defense = 58,
                Evade = 10,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Moustache Fiber (The Castle, 4-5F, \"Positive King\") and buy it.",
                        Price = "¥6800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Survival Guard",
                Defense = 62,
                Evade = 12,
                Effect = "+1 Endurance",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Wonder Cloth (The Castle, 3-5F, \"Trance Twins\") and buy it.",
                        Price = "¥7200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Metal Jacket",
                Defense = 78,
                Evade = 3,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Bronze Reins (The Castle, 6-7F, \"Avenger Knight\") and buy it.",
                        Price = "¥12800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Hard Armor",
                Defense = 156,
                Evade = 16,
                Effect = "Reduce Physical damage by 10%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Fashionable Dishs (Marukyu Striptease, 9-10F, \"Sky Balance\") and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Haikara Shirt",
                Defense = 194,
                Evade = 20,
                Effect = "+50% EXP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Go to the Samegawa Riverbank and trade a Guardian for it.",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Talisman Cape",
                Defense = 210,
                Evade = 3,
                Effect = "Low chance to evade Magic attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Bushy Fur (Secret Laboratory, 5-6F, \"Mach Wheel\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Unisex,
                Name = "Godly Robe",
                Defense = 375,
                Evade = 15,
                Effect = "+10 to all stats",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Defeat the Reaper.",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Pretty Suit",
                Defense = 22,
                Evade = 15,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Teddie's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "T-Shirt",
                Defense = 26,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Protagonist's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Long T-Shirt",
                Defense = 28,
                Evade = 10,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Yosuke's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Skull T-Shirt",
                Defense = 28,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Kanji's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Gentleman's Tux",
                Defense = 60,
                Evade = 24,
                Effect = "+50 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Castle (Yukiko's dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Jingi Fundoshi",
                Defense = 72,
                Evade = 23,
                Effect = "+10 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Steamy Bathhouse (Kanji's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, June 5th.",
                        Price = "¥11800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Lion Happi",
                Defense = 78,
                Evade = 16,
                Effect = "+1 Strength",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Power String (The Castle, 5-7F, \"Bronze Dice\") and buy it.",
                        Price = "¥14400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Knifeproof Coat",
                Defense = 86,
                Evade = 8,
                Effect = "+2 Endurance",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Proof of Spirit (The Steamy Bathhouse, 3-8F, \"Daring Gigas\") and buy it.",
                        Price = "¥16800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Doumaru",
                Defense = 94,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Firm Cloth (The Steamy Bathhouse, 3-4F, \"Pursuing Pesce\") and buy it.",
                        Price = "¥17800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Ama-Gakure",
                Defense = 98,
                Evade = 40,
                Effect = "+10 Agility",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Rain Steel (The Void Quest, 5-6F, \"Pursuing Pesce\", Rainy weather) and buy it.",
                        Price = "¥32000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Desperate Plate",
                Defense = 114,
                Evade = 4,
                Effect = "Resist Rage",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Sharp Horns (The Steamy Bathhouse, 9-10F, \"Grave Beetle\") and buy it.",
                        Price = "¥21600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Purple Suit",
                Defense = 116,
                Evade = 23,
                Effect = "Low chance to counter Physical attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Marukyu Striptease (Rise's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, July 17th.",
                        Price = "¥20800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Ame-Otoko",
                Defense = 120,
                Evade = 5,
                Effect = "+100 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Rain Leg Musha (Marukyu Striptease, 7-9F, \"Rain Leg Musha\", Rainy weather) and buy it.",
                        Price = "¥26000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Black Stone Mail",
                Defense = 132,
                Evade = 11,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Idle Stone Iron (Marukyu Striptease, 3-4F, \"Idle Basalt\") and buy it.",
                        Price = "¥24000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Knight Scale",
                Defense = 142,
                Evade = 8,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Sheet Metal (Marukyu Striptease, 9-10F, \"Arcane Turret\") and buy it.",
                        Price = "¥25600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Plate Mail",
                Defense = 161,
                Evade = 3,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Golden Horns (The Void Quest, 5-6F, \"Strength Beetle\") and buy it.",
                        Price = "¥29800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Paladin Armor",
                Defense = 166,
                Evade = 4,
                Effect = "Low chance to evade Physical attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Void Quest (Mitsuo's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, October 16th.",
                        Price = "¥20800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Passion Sweats",
                Defense = 190,
                Evade = 18,
                Effect = "Auto-Tarukaja",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Proof of Flight (The Void Quest, 7-9F, \"Beastly Gigas\") and buy it.",
                        Price = "¥34000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Kuroito-odoshi",
                Defense = 206,
                Evade = 4,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Demon Collars (The Secret Laboratory, 5-6F, \"Mighty Beast\") and buy it.",
                        Price = "¥36800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Niagra Climber",
                Defense = 210,
                Evade = 3,
                Effect = "Auto-Rakukaja",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 1st Girl's Talc (The Secret Laboratory, 1-2F, \"Rainy Sister 1\", Rainy weather) and buy it.",
                        Price = "¥38400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Red Battlesuit",
                Defense = 216,
                Evade = 26,
                Effect = "Reduce Physical damage by 20%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Secret Laboratory (Naoto's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, October 16th.",
                        Price = "¥20800",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, November 13th.",
                        Price = "¥19800",
                    },
                    new ArmorObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 2 Huge Fish for it. (August)",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Hurricane Coat",
                Defense = 228,
                Evade = 14,
                Effect = "Reduce Wind damage by 20%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Black Reins (The Secret Laboratory, 7-8F, \"Hell Knight\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Amamusha Armor",
                Defense = 236,
                Evade = 3,
                Effect = "Resist Dizzy",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Rain Metal (The Secret Laboratory, 5-6F, \"Raindrop Musha\", Rainy weather) and buy it.",
                        Price = "¥41200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Dragon Scale",
                Defense = 245,
                Evade = 11,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Porcelain Statue (Heaven, 2F, \"Growth Relic\") and buy it.",
                        Price = "¥42800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Tsukuyomi Noshi",
                Defense = 254,
                Evade = 26,
                Effect = "+5 to all stats",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Heaven (Nanako's dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Stylish Kimono",
                Defense = 258,
                Evade = 15,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Practical Cloth (Heaven, 5F, \"Reckless Okina\") and buy it.",
                        Price = "¥45800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Oracle Gown",
                Defense = 270,
                Evade = 17,
                Effect = "+40 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Oracle Textile (Heaven, 6-7F, \"Revelation Pesce\") and buy it.",
                        Price = "¥47200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Ame-agari Kesshi",
                Defense = 280,
                Evade = 8,
                Effect = "Reduce Physical damage by 30%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Cascade Metal (Heaven, 6-7F, \"Rain Wind Musha\", Rainy weather) and buy it.",
                        Price = "¥48000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Nubatama Suit",
                Defense = 280,
                Evade = 32,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Magatsu Inaba ([True Killer]'s dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "1000-Stud Coat",
                Defense = 287,
                Evade = 4,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Calm Marble (Magatsu Inaba, 1-2F, \"Vehement Idol\") and buy it.",
                        Price = "¥49200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Komaryo Uchinugi",
                Defense = 302,
                Evade = 11,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Thought Crosses (Magatsu Inaba, 2-3F, \"Sleeping Table\") and buy it.",
                        Price = "¥52000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Mikagura Vest",
                Defense = 308,
                Evade = 14,
                Effect = "Resist Enervation",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Formidable Proof (Magatsu Inaba, 4-5F, \"Immortal Gigas\") and buy it.",
                        Price = "¥53200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Surcoat",
                Defense = 315,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Diamond Sheets (Magatsu Inaba, 6F, \"Harmony Giant\") and buy it.",
                        Price = "¥54000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Sonidori Wear",
                Defense = 315,
                Evade = 32,
                Effect = "+100 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Yomotsu Hirasaka (True ending dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Opera Coat",
                Defense = 325,
                Evade = 19,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Demon Cloth (Yomotsu Hirasaka, 3-4F, \"Phantom Hero\") and buy it.",
                        Price = "¥56000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Lorica Hamata",
                Defense = 340,
                Evade = 11,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Unknown Barrel (Yomotsu Hirasaka, 6-7F, \"Phantom Hero\") and buy it.",
                        Price = "¥58000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Male,
                Name = "Full Jin-Baori",
                Defense = 350,
                Evade = 10,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Pyroxene Fiber (Yomotsu Hirasaka, 7-8F, \"Heartless Machine\") and buy it.",
                        Price = "¥60000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Tank Top",
                Defense = 25,
                Evade = 14,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Chie's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Lace Blouse",
                Defense = 25,
                Evade = 14,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Yukiko's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Gothic Shirt",
                Defense = 30,
                Evade = 10,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "[Naoto's default]",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Combat Dress",
                Defense = 60,
                Evade = 4,
                Effect = "Medium chance to evade Fire attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Castle (Yukiko's dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Miori Shirt",
                Defense = 60,
                Evade = 40,
                Effect = "Auto-Sukukaja",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Curious Line (The Steamy Bathhouse, 3-4F, \"Cloudgirl Pot\", Rainy weather) and buy it.",
                        Price = "¥22400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Steel Panier",
                Defense = 75,
                Evade = 22,
                Effect = "+20 SP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Steamy Bathhouse (Kanji's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, May 29th.",
                        Price = "¥11800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Charm Robe",
                Defense = 78,
                Evade = 18,
                Effect = "+1 Magic",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Magic Cross (The Castle, 6-7F, \"Laughing Table\") and buy it.",
                        Price = "¥15200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Battle Camisole",
                Defense = 85,
                Evade = 15,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Karma Lamp (The Steamy Bathhouse, 5-6F, \"Vicious Raven\") and buy it.",
                        Price = "¥15600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Zero Kosode",
                Defense = 108,
                Evade = 3,
                Effect = "High chance to evade Magic attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Zero Cloth (The Marukyu Striptease, 3-4F, \"Rain Wheel\", Rainy weather) and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Hard Bolero",
                Defense = 115,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Smooth Fabric (The Steamy Bathhouse, 7-10F, \"Wondrous Magus\") and buy it.",
                        Price = "¥21200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Armada Bustier",
                Defense = 118,
                Evade = 25,
                Effect = "+5 Magic",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Marukyu Striptease (Rise's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, July 3rd.",
                        Price = "¥20800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Amakaze Happi",
                Defense = 120,
                Evade = 3,
                Effect = "High chance to evade Physical attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Rare Poncho (The Void Quest, 5-6F, \"Rainy Pot\", Rainy weather) and buy it.",
                        Price = "¥31200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Wolf Tunic",
                Defense = 130,
                Evade = 14,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Tanned Hide (The Marukyu Striptease, 3-4F, \"Persistent Fuzz\") and buy it.",
                        Price = "¥24800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Action Vest",
                Defense = 144,
                Evade = 5,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Steel Reins (The Marukyu Striptease, 9-10F, \"Champion Knight\") and buy it.",
                        Price = "¥26400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Capital Robe",
                Defense = 160,
                Evade = 11,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Anguish Stone (The Void Quest, 5-6F, \"Anguish Basalt\") and buy it.",
                        Price = "¥28400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Charm Drape",
                Defense = 167,
                Evade = 24,
                Effect = "+5 Endurance",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Void Quest (Mitsuo's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, September 4th.",
                        Price = "¥21800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Breeze Tutu",
                Defense = 180,
                Evade = 14,
                Effect = "Reduce Wind damage by 20%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Light String (The Void Quest, 7-9F, \"Platinum Dice\") and buy it.",
                        Price = "¥32600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Divine Blouse",
                Defense = 204,
                Evade = 8,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Proof of Passion (The Secret Laboratory, 3-4F, \"Furious Gigas\") and buy it.",
                        Price = "¥35600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Peach Battlesuit",
                Defense = 211,
                Evade = 4,
                Effect = "Low chance to evade Physical attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in The Secret Laboratory (Naoto's dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, October 2nd.",
                        Price = "¥29800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Uin Haori",
                Defense = 222,
                Evade = 8,
                Effect = "Resist Confusion",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Cascade String (The Secret Laboratory, 3-4F, \"Rainbow Twins\", Rainy weather) and buy it.",
                        Price = "¥39200",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Invincible Mini",
                Defense = 232,
                Evade = 8,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Power Rock (The Secret Laboratory, 7-8F, \"Power Castle\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Mythos Robe",
                Defense = 240,
                Evade = 16,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Golden Sand (Heaven, 1F, \"Perpetual Sand\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Amaterasu Hitoe",
                Defense = 251,
                Evade = 29,
                Effect = "Medium chance to counter Physical attacks",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Heaven (Nanako's dungeon).",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Lan Ling Wang",
                Defense = 255,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Mink Fur (Heaven, 3-5F, \"Regal Mother\") and buy it.",
                        Price = "¥44000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Rune Dress",
                Defense = 270,
                Evade = 14,
                Effect = "+4 to all stats",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Ayanishiki (Heaven, 6-7F, \"Blossom Nyogo\") and buy it.",
                        Price = "¥46000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Elint Duffle",
                Defense = 274,
                Evade = 8,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Hemp Cloth (Heaven, 8-9F, \"Natural Dancer\") and buy it.",
                        Price = "¥48800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Angel Skirt",
                Defense = 284,
                Evade = 30,
                Effect = "Reduce Physical damage by 20%",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Magatsu Inaba ([True Killer]'s dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Buy on the shopping channel, November 20th.",
                        Price = "¥59800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Kikusui Awase",
                Defense = 285,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Royal Blossom (Magatsu Mandala, 1F, \"Free Bambino\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Shinra Robe",
                Defense = 304,
                Evade = 13,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Oguruma Brocade (Magatsu Mandala, 2-5F, \"Valuing Nyogo\") and buy it.",
                        Price = "¥52800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Kotodama Cape",
                Defense = 310,
                Evade = 19,
                Effect = "Resist Poison",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Word String (Magatsu Mandala, 2-5F, \"Silent Book\") and buy it.",
                        Price = "¥54400",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Uzume Robe",
                Defense = 310,
                Evade = 33,
                Effect = "+100 HP",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Found in golden chests in Yomotsu Hirasaka (True ending dungeon).",
                        Price = "",
                    },
                    new ArmorObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 3 Huge Fish for it. (December)",
                        Price = "",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Mizuha Armor",
                Defense = 314,
                Evade = 12,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Flame Sheet (Magatsu Mandala, 6F, \"Spastic Turret\") and buy it.",
                        Price = "¥54800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Yomi Sleeves",
                Defense = 324,
                Evade = 18,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Klein Bottle (Yomotsu Hirasaka, 3-4F, \"Mistress Pot\") and buy it.",
                        Price = "¥56800",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Emery Meisen",
                Defense = 338,
                Evade = 14,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Unknowable Fiber (Yomotsu Hirasaka, 5-6F, \"Next Gene\") and buy it.",
                        Price = "¥59600",
                    }
                }
            },
            new Armor() {
                Gender = Gender.Female,
                Name = "Haten Robe",
                Defense = 352,
                Evade = 10,
                Effect = "",
                Obtained = new List<ArmorObtain>() {
                    new ArmorObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Silver String (Yomotsu Hirasaka, 7-8F, \"Brilliant King\") and buy it.",
                        Price = "¥61200",
                    }
                }
            }
        };
    }
}
