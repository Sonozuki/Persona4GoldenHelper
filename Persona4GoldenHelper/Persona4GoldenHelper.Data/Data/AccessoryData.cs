using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    public class AccessoryData
    {
        public static List<Accessory> Accessories { get; set; } = new List<Accessory>()
        {
            new Accessory() {
                Name = "Alarm Clock",
                Effect = "Prevents Dizzy",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Aluminum Badge",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Chie's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Amaterasu Fob",
                Effect = "Increase max HP by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Amulet",
                Effect = "+1 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥3000"
                    }
                }
            },
            new Accessory() {
                Name = "Awareness Note",
                Effect = "Reduce enemy's chance to get a preemptive attack",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Barbaric Bracers",
                Effect = "2x chance to dodge attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Bat Charm",
                Effect = "+3 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Bead Ring (Protagonist Only)",
                Effect = "Increase chance of evading magical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Earn the top score in the October exams, then talk to Nanako in the evening.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Bear's Ears",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Teddie's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Black Cat Charm",
                Effect = "+4 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Black Feather",
                Effect = "Increase resistance to Darkness",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Black Signature (Heaven, 6-7F, \"Green Sigil\") and buy it.",
                        Price = "¥12000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Blaze Pin",
                Effect = "Reduce Fire damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Blaze Vow",
                Effect = "Increase Fire damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Blessed Hands",
                Effect = "Increase healing spells effect by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Activated Felt (Magatsu Mandala, 6F, \"Earnest Carothy\") and buy it.",
                        Price = "¥40000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 4 Amber Seema for it. (July)",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Blizzard Pin",
                Effect = "Reduce Ice damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Blizzard Vow",
                Effect = "Increase Ice damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Bold Ball",
                Effect = "Prevents Fear",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Book of Ruin",
                Effect = "Status ailments last 50% as long",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Book of Serenity",
                Effect = "Status ailments are recovered in 1 turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Book of the Void",
                Effect = "Prevents Rage, Fear, Silence, Enervation, and Confusion",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Bravery Vessel",
                Effect = "Reduce chance of Fear",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Brave Lumber (The Steamy Bathhouse, 9-10F, \"Crying Table\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Cat Whisker",
                Effect = "Increase chance of evading Magical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Chakra Ring",
                Effect = "Decrease SP cost for Magical attacks by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Confusion Hat",
                Effect = "Prevents Confusion",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Cool Beads",
                Effect = "Reduce chance of Rage",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Quiet Bouquet (Marukyu Striptease, 7-8F, \"Blooming Bambino\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Crow Charm",
                Effect = "+2 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Defense Essence",
                Effect = "+10 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Demon Charm",
                Effect = "+10 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Disguise Mask",
                Effect = "Reduce chance of Silence",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Decorative Stone (The Steamy Bathhouse, 7-8F, \"Tranquil Idol\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Disinfectant",
                Effect = "Reduce chance of Poison",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Beard Fiber (The Steamy Bathhouse, 7-8F, \"Egotistical King\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Divine Pillar",
                Effect = "Decrease received damage by 50%, but unable to dodge",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Eagle Eye",
                Effect = "Greatly increase chance of evading Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 3 Huge Fish for it. (October)",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Earth Badge",
                Effect = "Restores 4% HP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Ill Will Claw (Yomotsu Hirasaka, 1-2F, \"Crazy Twins\") and buy it.",
                        Price = "¥30000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Eye of Flame",
                Effect = "Greatly increase chance of evading Fire attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Eye of Ice",
                Effect = "Greatly increase chance of evading Ice attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Eye of Thunder",
                Effect = "Greatly increase chance of evading Electricity attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Eye of Wind",
                Effect = "Greatly increase chance of evading Wind attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Falcon Eye",
                Effect = "Increase chance of evading Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 3 Amber Seema for it. (May)",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Fancy Mini-Car (Protagonist Only)",
                Effect = "Increase success rates of Darkness spells",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Yumi).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Feather Strap",
                Effect = "+1 Agility",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Moustache Fiber (The Castle, 4-5F, \"Positive King\") and buy it.",
                        Price = "¥3000"
                    }
                }
            },
            new Accessory() {
                Name = "Feng Shui Brace",
                Effect = "+1 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Bronze Reins (The Castle, 6-7F, \"Avenger Knight\") and buy it.",
                        Price = "¥9000"
                    }
                }
            },
            new Accessory() {
                Name = "Festival Drum",
                Effect = "+5 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Windcutter Cloth (The Secret Laboratory, 3-4F, \"Shallow Okina\") and buy it.",
                        Price = "¥15000"
                    }
                }
            },
            new Accessory() {
                Name = "Fire Pin",
                Effect = "Reduce Fire damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Fire Suppressor",
                Effect = "Increase chance of evading Fire attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Bought from the TV shopping show on 6/12.",
                        Price = "¥4980"
                    }
                }
            },
            new Accessory() {
                Name = "Fire Vow",
                Effect = "Increase Fire damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Flame Pin",
                Effect = "Reduce Fire damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Flame Vow",
                Effect = "Increase Fire damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Flight Strap",
                Effect = "+3 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Fluffy Muffler (Protagonist Only)",
                Effect = "Increase resistance from Ice attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Chie).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Frozen Rose",
                Effect = "Prevents Rage",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Gale Pin",
                Effect = "Reduce Wind damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Gale Vow",
                Effect = "Increase Wind damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Gas Mask",
                Effect = "Prevents Poison",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "God's Love",
                Effect = "+10 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Guard Amulet",
                Effect = "+3 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Guard Rosary",
                Effect = "+5 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Hard Thorn (The Secret Laboratory, 7-8F, \"Fierce Cyclops\") and buy it.",
                        Price = "¥15000"
                    }
                }
            },
            new Accessory() {
                Name = "Gust Pin",
                Effect = "Reduce Wind damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Gust Vow",
                Effect = "Increase Wind damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Hair Band",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Yukiko's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Hand-Knit Mitten (Protagonist Only)",
                Effect = "Increase success rates of Light spells",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Ayane).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Handmade Watch (Protagonist Only)",
                Effect = "Increase chance of status effects",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Naoto).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Headband",
                Effect = "+1 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥3000"
                    }
                }
            },
            new Accessory() {
                Name = "Healthy Homa",
                Effect = "Prevents Exhaustion",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Healthy Recipe",
                Effect = "Reduce chance of Exhaustion",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Paleograph (The Void Quest, 2-4F, \"Spurious Book\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Ice Pin",
                Effect = "Reduce Ice damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Ice Suppressor",
                Effect = "Increase chance of evading Ice attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Ice Vow",
                Effect = "Increase Ice damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Icicle Pin",
                Effect = "Reduce Ice damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Icicle Vow",
                Effect = "Increase Ice damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Inferno Pin",
                Effect = "Reduce Fire damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Inferno Vow",
                Effect = "Increase Fire damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Iron Charm",
                Effect = "+4 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kagutsuchi Pin",
                Effect = "Reduce Fire damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kagutsuchi Vow",
                Effect = "Increase Fire damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kid's Hachimaki",
                Effect = "Reduce chance of Enervation",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Guard Cloth (The Void Quest, 9F, \"Protective Rexy\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kimyaku Brace",
                Effect = "+2 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kuraokami Pin",
                Effect = "Reduce Ice damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Kuraokami Vow",
                Effect = "Increase Ice damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Land Badge",
                Effect = "Restores 2% HP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Life Collar (The Steamy Bathhouse, 3-6F, \"Nizam Beast\") and buy it.",
                        Price = "¥25000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 1 Huge Fish for it. (June)",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Leather Keychain (Protagonist Only)",
                Effect = "Increase resistance from Fire attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Yukiko).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Life Fob",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Increase max HP by 20%",
                        Price = "¥25000"
                    }
                }
            },
            new Accessory() {
                Name = "Lightning Pin",
                Effect = "Reduce Electricity damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Lightning Vow",
                Effect = "Increase Electricity damage by 40%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Lizard Charm",
                Effect = "+1 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Big Incisor (The Castle, 1F, \"Lying Hablerie\") and buy it.",
                        Price = "¥3000"
                    }
                }
            },
            new Accessory() {
                Name = "Lucky Coin",
                Effect = "+1 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 20 Black Lamp (The Castle, 3-7F, \"Black Raven\") and buy it.",
                        Price = "¥3000"
                    }
                }
            },
            new Accessory() {
                Name = "Lucky Seven",
                Effect = "+10 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Macho Medal (Protagonist Only)",
                Effect = "Increase resistance from Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event ([Male party members]).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Mage's Mark",
                Effect = "Restores 3 SP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Magic Cloth (The Steamy Bathhouse, 3-4F, \"Phantom Master\") and buy it.",
                        Price = "¥25000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Maneki Neko",
                Effect = "+4 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Bought from the TV shopping show on 7/31.",
                        Price = "¥7980"
                    }
                }
            },
            new Accessory() {
                Name = "Mask of Truth",
                Effect = "Prevents Silence",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Moon Potpourri",
                Effect = "Increase max SP by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Omega Drive",
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Omnipotent Orb",
                Effect = "Nullifies all attacks except Almighty",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Defeat the Reaper.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Ouryu Brace",
                Effect = "+5 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Torrent Gear (Magatsu Mandala, 6F, \"Slaughter Drive\") and buy it.",
                        Price = "¥30000"
                    }
                }
            },
            new Accessory() {
                Name = "Paper Armband (Protagonist Only)",
                Effect = "+5 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Earn the top score in the July exams, then talk to Nanako in the evening.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Partial Award (Protagonist Only)",
                Effect = "Restore 1HP when HP reaches 0 (1 use per battle)",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Earn the top score in the December exams, then check Nanako's seat in the evening.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Patient Collar",
                Effect = "Restore 1HP when HP reaches 0 (1 use per battle)",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Pegasus Strap",
                Effect = "+5 Agility",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Mental Thread (The Secret Laboratory, 7-8F, \"Mind Dice\") and buy it.",
                        Price = "¥15000"
                    }
                }
            },
            new Accessory() {
                Name = "Pitch Pipes",
                Effect = "Prevents Enervation",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Plain Ring",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Yosuke's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Plum Potpourri",
                Effect = "Increase max SP by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Idea Paper (The Castle, 1F, \"Calm Pesce\") and buy it.",
                        Price = "¥12000"
                    }
                }
            },
            new Accessory() {
                Name = "Portrait Medal (Protagonist Only)",
                Effect = "+5 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Earn the top score in the May exams, then talk to Nanako in the evening.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Power Belt",
                Effect = "+2 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Bought from the TV shopping show on 6/19.",
                        Price = "¥4980"
                    }
                }
            },
            new Accessory() {
                Name = "Power Muscle",
                Effect = "+10 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Power Tasuki",
                Effect = "+3 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Rabbit Foot",
                Effect = "+2 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Reader King (Protagonist Only)",
                Effect = "+10 magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Read all 20 books.",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Rebirth Prophecy",
                Effect = "Restore all HP when HP reaches 0 (1 use per battle)",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Reisen Brace",
                Effect = "+4 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Bought from the TV shopping show on 11/13.",
                        Price = "¥19800"
                    }
                }
            },
            new Accessory() {
                Name = "Reprisal Chain",
                Effect = "15% chance to counter Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    },
                    new AccessoryObtain() {
                        Obtain = "Bought from the TV shopping show on 9/18.",
                        Price = "¥21800"
                    }
                }
            },
            new Accessory() {
                Name = "Retribution Mask",
                Effect = "20% chance to counter Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Revenge Ring",
                Effect = "10% chance to counter Physical attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Selfish Ornament (The Steamy Bathhouse, 7-8F, \"Selfish Basalt\") and buy it.",
                        Price = "¥30000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Rudra Ring",
                Effect = "Decrease HP cost for Physical attacks by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Rugged Ring (Protagonist Only)",
                Effect = "Increase healing spell effects",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Ai).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Ryumyaku Brace",
                Effect = "+3 to all stats",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Safety Belt",
                Effect = "Reduce chance of Dizzy",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Ruinous Crown (Magatsu Mandala, 1-3F, \"Fanatic Tower\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Shinatobe Pin",
                Effect = "Reduce Wind damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Shinatobe Vow",
                Effect = "Increase Wind damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Sigma Drive",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Decrease chance to receive a critical hit",
                        Price = "¥30000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon), Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Silver Bangle (Protagonist Only)",
                Effect = "Increase max SP by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Christmas event (Rise).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Silver Locket",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Kanji's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Silver Spoon",
                Effect = "+3 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Snow Pin",
                Effect = "Reduce Ice damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Snow Vow",
                Effect = "Increase Ice damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Sorcerer's Mark",
                Effect = "Restores 5 SP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Silver Fox Fur (Yomotsu Hirasaka, 1F, \"Divine Mother\") and buy it.",
                        Price = "¥30000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Soul Potpourri",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Increase max SP by 20%",
                        Price = "¥25000"
                    }
                }
            },
            new Accessory() {
                Name = "Space Badge",
                Effect = "Restores 6% HP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Spark Pin",
                Effect = "Reduce Electricity damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Spark Vow",
                Effect = "Increase Electricity damage by 20%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Speed Star",
                Effect = "+10 Agility",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Spiral Earrings",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Naoto's default]",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Spirit Hachimaki",
                Effect = "+4 Strength",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Steed Strap",
                Effect = "+4 Agility",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Storm Pin",
                Effect = "Reduce Wind damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Storm Vow",
                Effect = "Increase Wind damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Takefutsu Pin",
                Effect = "Reduce Electricity damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Takefutsu Vow",
                Effect = "Increase Electricity damage by 50%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Talisman",
                Effect = "+2 Endurance",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Thunder Pin",
                Effect = "Reduce Electricity damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Thunder Vow",
                Effect = "Increase Electricity damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Tranquil Buddha",
                Effect = "Reduce chance of Confusion",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Safety Angle (Marukyu Striptease, 7-8F, \"Adamant Beetle\") and buy it.",
                        Price = "¥18000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Vigor Fob",
                Effect = "Increase max HP by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Big Incisor (The Castle, 1F, \"Lying Hablerie\") and buy it.",
                        Price = "¥12000"
                    }
                }
            },
            new Accessory() {
                Name = "Volt Pin",
                Effect = "Reduce Electricity damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory (Naoto's dungeon), Heaven (Nanako's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Volt Suppressor",
                Effect = "Increase chance of evading Electricity attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Volt Vow",
                Effect = "Increase Electricity damage by 30%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "White Feather",
                Effect = "Increase resistance to Light",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Crystal of Light (Heaven, 5-7F, \"Devoted Cupid\") and buy it.",
                        Price = "¥12000"
                    },
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Wind Pin",
                Effect = "Reduce Wind damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Wind Suppressor",
                Effect = "Increase chance of evading Wind attacks",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon), Marukyu Striptease (Rise's dungeon), The Void Quest (Mitsuo's dungeon), The Secret Laboratory (Naoto's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Wind Vow",
                Effect = "Increase Wind damage by 10%",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Wing Strap",
                Effect = "+2 Agility",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: The Castle (Yukiko's dungeon), The Steamy Bathhouse (Kanji's dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Witch Charm",
                Effect = "+5 Magic",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Silver Signature (The Secret Laboratory, 3-4F, \"Red Sigil\") and buy it.",
                        Price = "¥15000"
                    }
                }
            },
            new Accessory() {
                Name = "Wizard's Mark",
                Effect = "Restores 7 SP at the start of each turn",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba ([True killer]'s dungeon), Yomotsu Hirasaka ([True ending]'s dungeon).",
                        Price = ""
                    }
                }
            },
            new Accessory() {
                Name = "Wooden Ebisu",
                Effect = "+5 Luck",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Yellow Cord (The Secret Laboratory, 1-2F, \"Royal Dancer\") and buy it.",
                        Price = "¥15000"
                    }
                }
            },
            new Accessory() {
                Name = "Wristwatch",
                Effect = "",
                Obtained = new List<AccessoryObtain>() {
                    new AccessoryObtain() {
                        Obtain = "[Protagonist's default]",
                        Price = ""
                    }
                }
            }
        };
    }
}
