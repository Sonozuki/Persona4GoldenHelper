using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The weapon data.</summary>
    public class WeaponData
    {
        /// <summary>The weapon data.</summary>
        public static List<Weapon> Weapons { get; set; } = new List<Weapon>()
        {
            new Weapon() {
                User = User.Protagonist,
                Name = "Golf Club",
                Attack = 42,
                Accuracy = 93,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Musashi Shinai",
                Attack = 42,
                Accuracy = 98,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 2 Guardian for it. (December)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 8 Magatsu Xandrite & 8 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Imitation Sword",
                Attack = 53,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥4800",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Spiked Bat",
                Attack = 53,
                Accuracy = 98,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Long Sword",
                Attack = 60,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Black Lamp (The Castle, 3-7F, \"Black Raven\") and buy it.",
                        Price = "¥10000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "5-Iron",
                Attack = 71,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Supple Metal (The Castle, 6-7F, \"Magical Magus\") and buy it.",
                        Price = "¥12000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Iai Katana",
                Attack = 78,
                Accuracy = 98,
                Effect = "+3 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Golden Cloth (The Castle, 6-7F, \"Phantom Mage\") and buy it.",
                        Price = "¥13600",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Bastard Sword",
                Attack = 88,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Powered Iron (The Steamy Bathhouse, 1-2F, \"Autonomic Basalt\") and buy it.",
                        Price = "¥14000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Strange Sword",
                Attack = 92,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Zweihander",
                Attack = 108,
                Accuracy = 95,
                Effect = "+1 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Pure Iron Lump (The Steamy Bathhouse, 5-7F, \"Iron Dice\") and buy it.",
                        Price = "¥18000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Skull Rod",
                Attack = 125,
                Accuracy = 80,
                Effect = "Low chance to inflict Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Fluorite & 1 Yazu Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Titanium Club",
                Attack = 130,
                Accuracy = 96,
                Effect = "+2 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 2 Inaba Trout for it. (May)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Gothic Sword",
                Attack = 133,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Iron Eyeball (Marukyu Striptease, 1-4F, \"Death Seeker\") and buy it.",
                        Price = "¥20000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Myth-like Sword",
                Attack = 140,
                Accuracy = 80,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 6/26.",
                        Price = "¥9800",
                    },
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 8/7.",
                        Price = "¥12800"
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Type-98 Gunto",
                Attack = 145,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Silver Lump (Marukyu Striptease, 7-8F, \"Silver Dice\") and buy it.",
                        Price = "¥24000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Edge",
                Attack = 152,
                Accuracy = 92,
                Effect = "+3 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Nice Ornament (The Void Quest, 1-4F, \"Justice Sword\") and buy it.",
                        Price = "¥27000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Kage-Dachi",
                Attack = 172,
                Accuracy = 92,
                Effect = "Increase max HP by 20",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Compacted Metal (The Void Quest, 7-9F, \"Monomaniac Fuzz\") and buy it.",
                        Price = "¥30000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Bus Stop Sign",
                Attack = 179,
                Accuracy = 84,
                Effect = "High chance to inflict Rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Anglaise",
                Attack = 180,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Blade Metal (The Void Quest, 7-9F, \"Ardent Dancer\") and buy it.",
                        Price = "¥31000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Great Sword",
                Attack = 190,
                Accuracy = 84,
                Effect = "+2 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Tungsten (The Void Quest, 9F, \"Steel Machine\") and buy it.",
                        Price = "¥32000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Beach Parasol",
                Attack = 194,
                Accuracy = 98,
                Effect = "Low chance to counter Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Howlite & 1 Yazu Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Wooden Bat",
                Attack = 200,
                Accuracy = 30,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 8/14.",
                        Price = "¥14400",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Gaia Sword",
                Attack = 200,
                Accuracy = 88,
                Effect = "Low chance to inflict any ailment",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the optional boss in The Void Quest.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Bass",
                Attack = 202,
                Accuracy = 90,
                Effect = "Increase max SP by 40",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Meteorite & 2 Taisui Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Midare Hamon",
                Attack = 210,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Insolence Steel (The Secret Laboratory, 1-2F, \"Insolent Basalt\") and buy it.",
                        Price = "¥36000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Kakitsubata",
                Attack = 218,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Iron Gear (The Secret Laboratory, 5-6F, \"Wild Drive\") and buy it.",
                        Price = "¥37600",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Gardenia Sword",
                Attack = 220,
                Accuracy = 92,
                Effect = "Low chance to inflict Silence",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Damascus (The Secret Laboratory, 7-8F, \"Dominating Machine\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Krieg",
                Attack = 230,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Flame Steel (Heaven, 2F, \"Brave Wheel\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Number One",
                Attack = 240,
                Accuracy = 94,
                Effect = "+1 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Sacrilege Iron (Heaven, 3-4F, \"Apostate Tower\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Downpour Sword",
                Attack = 248,
                Accuracy = 50,
                Effect = "Greatly increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 3rd Boy's Talc (Marukyu Striptease, 5-6F, \"Rainy Brother 3\", Rainy weather) and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Kenka",
                Attack = 248,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Prime Steel (Heaven, 6F, \"Stasis Giant\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Metal Bat",
                Attack = 250,
                Accuracy = 30,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Gift from Margaret for completing 50% of active Social Links.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Kijintou",
                Attack = 252,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Platinum Reins (Heaven, 8-9F, \"Intrepid Knight\") and buy it.",
                        Price = "¥43600",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "El Caliente",
                Attack = 302,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Diamond Canine (Magatsu Inaba, 4-6F, \"SHADOWNAME\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Shichisei-Ken",
                Attack = 310,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Brilliant Armor (Magatsu Mandala, 2-3F, \"Battle Wheel\") and buy it.",
                        Price = "¥52000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Yahiro Sword",
                Attack = 320,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Spark Ornament (Magatsu Mandala, 4-6F, \"Judgement Sword\") and buy it.",
                        Price = "¥54000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Triumph",
                Attack = 334,
                Accuracy = 94,
                Effect = "+5 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Orichalcum (Magatsu Mandala, 6F, \"Solemn Machine\") and buy it.",
                        Price = "¥56000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Light Sword",
                Attack = 334,
                Accuracy = 94,
                Effect = "+5 Luck (Added sound effect when swung)",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Exchange Triumph with the Artisan Apprentice.",
                        Price = "¥56000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Tajikarao Sword",
                Attack = 345,
                Accuracy = 85,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Crown of Truth (Yomotsu Hirasaka, 3-4F, \"Grudge Tower\") and buy it.",
                        Price = "¥58000",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Futsuno Mitama",
                Attack = 360,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Ripper Horse (Yomotsu Hirasaka, 5-6F, \"Jotun of Grief\") and buy it.",
                        Price = "¥61600",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Soul Crusher",
                Attack = 372,
                Accuracy = 88,
                Effect = "Low chance to inflicit Exhaust",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Soul-Death Steel (Yomotsu Hirasaka, 7-8F, \"Void Giant\") and buy it.",
                        Price = "¥63600",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Tsubaki-Otoshi",
                Attack = 390,
                Accuracy = 98,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: Yomotsu Hirasaka.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Protagonist,
                Name = "Blade of Totsuka",
                Attack = 408,
                Accuracy = 96,
                Effect = "Greatly increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Happy Maracas",
                Attack = 25,
                Accuracy = 92,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Mondo Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Monkey Wrench",
                Attack = 40,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Hunting Nata",
                Attack = 48,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥4000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kunai",
                Attack = 55,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Light Iron (The Castle, 3-5F, \"Magic Hand\") and buy it.",
                        Price = "¥10000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Poison Kunai",
                Attack = 64,
                Accuracy = 92,
                Effect = "Low chance to inflict Poison",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Poison Flower (The Castle, 3-5F, \"Secret Bambino\") and buy it.",
                        Price = "¥11800",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Reign Skinner",
                Attack = 80,
                Accuracy = 98,
                Effect = "High chance to inflict any ailment",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 4th Girl's Talc (The Steamy Bathhouse, 7-8F, \"4th Girl's Talc\") and buy it.",
                        Price = "¥18000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Skill Spanner",
                Attack = 83,
                Accuracy = 86,
                Effect = "Increase max SP by 50",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to The Twisted Shopping District (First dungeon) on 5/1",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Strange Daggers",
                Attack = 84,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Bowling Pin",
                Attack = 85,
                Accuracy = 99,
                Effect = "+Auto-Sukukaja",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Lolite & 1 Kingyou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Santou",
                Attack = 95,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Gray Shackle (The Steamy Bathhouse, 9-10F, \"Killer Twins\") and buy it.",
                        Price = "¥19600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kozuka",
                Attack = 122,
                Accuracy = 93,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Hard Rock (Marukyu Striptease, 1-4F, \"Creation Relic\") and buy it.",
                        Price = "¥22000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Throwing Kunai",
                Attack = 138,
                Accuracy = 98,
                Effect = "+2 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Haori Iron (Marukyu Striptease, 5-8F, \"Venus Eagle\") and buy it.",
                        Price = "¥24000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kitchen Knife",
                Attack = 140,
                Accuracy = 90,
                Effect = "+10 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 7/24.",
                        Price = "¥11800",
                    },
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 8/7.",
                        Price = "¥12800"
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kris Naga",
                Attack = 146,
                Accuracy = 94,
                Effect = "Increase max SP by 30",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Sharp Thorn (Marukyu Striptease, 9-10F, \"Mighty Cyclops\") and buy it.",
                        Price = "¥25600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kaiken",
                Attack = 153,
                Accuracy = 93,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Steel Thorn (The Void Quest, 1-2F, \"Mad Cyclops\") and buy it.",
                        Price = "¥26400",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Yashioori Dagger",
                Attack = 153,
                Accuracy = 93,
                Effect = "Low chance to inflict Confuse",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Alluring Lily (The Void Quest, 7-8F, \"Avarice Bambino\") and buy it.",
                        Price = "¥26900",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Pinwheels",
                Attack = 158,
                Accuracy = 90,
                Effect = "High chance to inflict Poison",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Bashin",
                Attack = 168,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Alloy Signature (The Void Quest, 5-6F, \"Blue Sigil\") and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Thief Dagger",
                Attack = 170,
                Accuracy = 74,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: The Void Quest.",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 8/28.",
                        Price = "¥20800"
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Yashima",
                Attack = 174,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Trial Obsidian (The Void Quest, 7-9F, \"Leading Idol\") and buy it.",
                        Price = "¥30000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "En-Giri",
                Attack = 188,
                Accuracy = 96,
                Effect = "Low chance to inflict Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Iron Barrel (The Secret Laboratory, 3-4F, \"Dismayed Panzer\") and buy it.",
                        Price = "¥32000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Fearful Kunai",
                Attack = 203,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Shining Dish (The Secret Laboratory, 5-6F, \"World Balance\") and buy it.",
                        Price = "¥34000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Bloody Kunai",
                Attack = 216,
                Accuracy = 94,
                Effect = "Increase Wind damage by 25%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 1st Boy's Talc (The Secret Laboratory, 1-2F, \"Rainy Brother 1\", Rainy weather) and buy it.",
                        Price = "¥37600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Castilla Knife",
                Attack = 222,
                Accuracy = 98,
                Effect = "+3 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Black Sheet (The Secret Laboratory, 7-8F, \"Wicked Turret\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Titanium Wrench",
                Attack = 233,
                Accuracy = 80,
                Effect = "+1 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 4 Huge Fish for it. (October)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Buffalo Stone & 1 Takou Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Ohorinomikoto",
                Attack = 238,
                Accuracy = 96,
                Effect = "Reduce Fire damage by 30&",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Flame Scale (Heaven, 1-2F, \"Finicky Papillon\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Flying Kato",
                Attack = 240,
                Accuracy = 94,
                Effect = "Increase chance to give critical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Treasure Cloth (Heaven, 3-5F, \"Phantom Lord\") and buy it.",
                        Price = "¥41600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Basho",
                Attack = 252,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Perpetual Edge (Heaven, 8-9F, \"Conviction Sword\") and buy it.",
                        Price = "¥43600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Fuuma Kotaro",
                Attack = 280,
                Accuracy = 98,
                Effect = "+5 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Nightmare Sand (Magatsu Inaba, 1-2F, \"Infinite Sand\") and buy it.",
                        Price = "¥48000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Megaphone",
                Attack = 284,
                Accuracy = 92,
                Effect = "Increase max HP by 40",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Sunstone & 1 Ryugu Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Militia Dagger",
                Attack = 294,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Unthinkable Metal (Magatsu Mandala, 4-6F, \"Happy Gene\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Hattori",
                Attack = 311,
                Accuracy = 98,
                Effect = "+3 to all stats",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Knowledge Staff (Magatsu Mandala, 4-5F, \"Reformed Okina\") and buy it.",
                        Price = "¥52000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Blitz Knife",
                Attack = 320,
                Accuracy = 86,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Cruel Thorn (Magatsu Mandala, 6F, \"Brilliant Cyclops\") and buy it.",
                        Price = "¥54000",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Ogre Tooth",
                Attack = 336,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Mobius Sand (Yomotsu Hirasaka, 1-2F, \"Eternal Sand\") and buy it.",
                        Price = "¥57600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Rappa",
                Attack = 350,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Sephirot Staff (Yomotsu Hirasaka, 5-6F, \"Moon Okina\") and buy it.",
                        Price = "¥59600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Kashin Koji",
                Attack = 361,
                Accuracy = 96,
                Effect = "Medium chance to inflict any ailment",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Vengeance Steel (Yomotsu Hirasaka, 7-8F, \"Reckoning Dice\") and buy it.",
                        Price = "¥61600",
                    }
                }
            },
            new Weapon() {
                User = User.Yosuke,
                Name = "Malakh",
                Attack = 398,
                Accuracy = 98,
                Effect = "High chance to evade Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Yosuke in party.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Leather Shoes",
                Attack = 38,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Platform Sneaks",
                Attack = 45,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥7600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Spring Boots",
                Attack = 50,
                Accuracy = 70,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Magatsu Xandrite & 1 Kaiou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Shield Boots",
                Attack = 62,
                Accuracy = 92,
                Effect = "+2 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Hard Horn (The Castle, 6-7F, \"Burning Beetle\") and buy it.",
                        Price = "¥11200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Inline Skates",
                Attack = 71,
                Accuracy = 95,
                Effect = "Increase resistance to Panic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Blue Quartz.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Nanman Gusoku",
                Attack = 75,
                Accuracy = 92,
                Effect = "+1 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Golden Dish (The Castle, 6-7F, \"Heat Balance\") and buy it.",
                        Price = "¥13600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Loose Socks",
                Attack = 83,
                Accuracy = 85,
                Effect = "Increase max SP by 20",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Blue Quartz & 1 Gyosen Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "punk Shoes",
                Attack = 92,
                Accuracy = 92,
                Effect = "Low chance to inflict rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Tough Hide (The Steamy Bathhouse, 1-2F, \"Bribed Fuzz\") and buy it.",
                        Price = "¥20000",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Strange Greaves",
                Attack = 96,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Hard Boots",
                Attack = 108,
                Accuracy = 90,
                Effect = "+2 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Thick Hide (The Steamy Bathhouse, 5-8F, \"Dancing Hand\") and buy it.",
                        Price = "¥21200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Adios Shoes",
                Attack = 110,
                Accuracy = 82,
                Effect = "+3 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 5/22.",
                        Price = "¥5980",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Kintabi Gusoku",
                Attack = 125,
                Accuracy = 70,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: The Steamy Bathhouse.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Skill Greaves",
                Attack = 133,
                Accuracy = 90,
                Effect = "+1 to all stats",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Rubbery Object (Marukyu Striptease, 1-4F, \"Miss Gene\") and buy it.",
                        Price = "¥25600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Cowboy Boots",
                Attack = 150,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Sturdy Molar (Marukyu Striptease, 5-8F, \"Forgotten Hablerie\") and buy it.",
                        Price = "¥26800",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Heavy Heels",
                Attack = 167,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Wrought Lamp (Marukyu Striptease, 3-4F, \"Sonic Raven\") and buy it.",
                        Price = "¥28400",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Bishamonten",
                Attack = 182,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Jet Black Scale (The Void Quest, 1-4F, \"Lustful Snake\") and buy it.",
                        Price = "¥31600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Foot Maces",
                Attack = 187,
                Accuracy = 90,
                Effect = "Reduce Fire damage by 20%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Bloodstone & 2 Takou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Furinkazan",
                Attack = 193,
                Accuracy = 98,
                Effect = "High chance to inflict Enervate",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Platinum Crown (The Void Quest, 1-2F, \"Corrupt Tower\") and buy it.",
                        Price = "¥33200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Steel Slippers",
                Attack = 199,
                Accuracy = 87,
                Effect = "+2 to all stats",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 8 Amber Seema for it. (September)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Milky Quartz & 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Bucking Broncos",
                Attack = 205,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Stone Hide (The Secret Laboratory, 1-2F, \"Constancy Relic\") and buy it.",
                        Price = "¥35600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Sleipnir",
                Attack = 218,
                Accuracy = 92,
                Effect = "+5 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Stretchy Object (The Secret Laboratory, 5-6F, \"Fail Gene\") and buy it.",
                        Price = "¥37200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Amami Legs",
                Attack = 220,
                Accuracy = 80,
                Effect = "High chance to counter Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Curious Boulder (The Void Quest, 1-2F, \"Rainy Castle\", Rainy weather) and buy it.",
                        Price = "¥32800",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Four Beasts",
                Attack = 225,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Riveted Hide (The Secret Laboratory, 7-8F, \"Jotun of Power\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Vampire Shoes",
                Attack = 243,
                Accuracy = 94,
                Effect = "Medium chance to inflict Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Crimson Cover (Heaven, 2-4F, \"Maniacal Book\") and buy it.",
                        Price = "¥41200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Mjolnir Boots",
                Attack = 253,
                Accuracy = 92,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Cursed Stone (Heaven, 3-5F, \"Curse Dice\") and buy it.",
                        Price = "¥43600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Nice Shoes",
                Attack = 260,
                Accuracy = 78,
                Effect = "Medium chance to evade Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 10/9.",
                        Price = "¥28800",
                    },
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 11/13.",
                        Price = "¥19800"
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Vidar's Boots",
                Attack = 264,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Bloody Hide (Heaven, 8-9F, \"Jotun of Blood\") and buy it.",
                        Price = "¥45200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Demon Boots",
                Attack = 296,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Miracle Scale (Magatsu Inaba, 1-2F, \"Fickle Papillon\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Hero Legs",
                Attack = 300,
                Accuracy = 92,
                Effect = "+4 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Snow Stone (Magatsu Mandala, 1F, \"King Castle\") and buy it.",
                        Price = "¥51200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Kehaya",
                Attack = 310,
                Accuracy = 94,
                Effect = "+3 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Prime Hide (Magatsu Mandala, 4-6F, \"Phantom King\") and buy it.",
                        Price = "¥52000",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Gigant Fall",
                Attack = 325,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Platinum Hide (Magatsu Mandala, 6F, \"Minotaur I\") and buy it.",
                        Price = "¥55200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Peerless Heels",
                Attack = 338,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Love Scale (Yomotsu Hirasaka, 1-3F, \"Pure Papillon\") and buy it.",
                        Price = "¥57600",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Judgement Boots",
                Attack = 349,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Death Sentence (Yomotsu Hirasaka, 5-6F, \"Eternal Eagle\") and buy it.",
                        Price = "¥59000",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Stella Greaves",
                Attack = 362,
                Accuracy = 96,
                Effect = "+5 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Tyrannical Hide (Yomotsu Hirasaka, 8F, \"Neo Minotaur\") and buy it.",
                        Price = "¥61200",
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Red-Leaf Gusoku",
                Attack = 380,
                Accuracy = 70,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 10 Genji Ayu for it. (November)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Angelite & 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Chie,
                Name = "Moses Sandals",
                Attack = 412,
                Accuracy = 95,
                Effect = "High chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Chie in party.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Kyo Sensu",
                Attack = 36,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Santa Fan",
                Attack = 45,
                Accuracy = 85,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Magatsu Xandrite & 1 Mondo Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Strange Fan",
                Attack = 72,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Noh Fan",
                Attack = 74,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥11200",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Festival Fan",
                Attack = 80,
                Accuracy = 90,
                Effect = "+3 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Smoky Quartz.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Silk Fan",
                Attack = 85,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Cloth Wings (The Steamy Bathhouse, 1-2F 5-10F, \"Monopolizing Cupid\") and buy it.",
                        Price = "¥12400",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Arazuyu Fan",
                Attack = 89,
                Accuracy = 96,
                Effect = "Increase resistance to Silence",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 4th Boy's Talc (The Steamy Bathhouse, 1-2F, \"Rainy Brother 4\", Rainy weather) and buy it.",
                        Price = "¥13800",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Suzaku Feather",
                Attack = 92,
                Accuracy = 92,
                Effect = "Increase max SP by 50",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the optional boss in The Castle.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Tesseb",
                Attack = 108,
                Accuracy = 94,
                Effect = "+4 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Passion Clasp (Marukyu Striptease, 1-4F, \"Soul Dancer\") and buy it.",
                        Price = "¥19600",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Hanachirusato",
                Attack = 123,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Glossy Clasp (Marukyu Striptease, 5-10F, \"Killing Hand\") and buy it.",
                        Price = "¥21600",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Masquerade",
                Attack = 134,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Tortoise Shell (Marukyu Striptease, 7-8F, \"Large Basalt\") and buy it.",
                        Price = "¥23600",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Flying Disc",
                Attack = 137,
                Accuracy = 95,
                Effect = "Medium chance to evade Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Smoky Quartz & 1 Kingyou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Harlot's Mercy",
                Attack = 140,
                Accuracy = 60,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: The Marukyu Striptease.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Madam's Charm",
                Attack = 145,
                Accuracy = 92,
                Effect = "Medium chance to inflict Confuse",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Devilish Feather (The Void Quest, 3-4F, \"Amenti Raven\") and buy it.",
                        Price = "¥25600",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Duchess",
                Attack = 150,
                Accuracy = 80,
                Effect = "High chance to inflict Confuse",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 3 Inaba Trout for it. (June)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Lepidolite & 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Inversion Fan",
                Attack = 150,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Gazing Clasp (The Void Quest, 3-4F, \"Fate Seeker\") and buy it.",
                        Price = "¥26800",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Bat Saucer",
                Attack = 153,
                Accuracy = 91,
                Effect = "+Auto-Sukukaja",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Amagyou Fan",
                Attack = 162,
                Accuracy = 94,
                Effect = "High chance to inflict Silence",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 2nd Girl's Talc (The Void Quest, 3-4F, \"Rainy Sister 2\", Rainy weather) and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Mogari Bue",
                Attack = 170,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Azalea Cord (The Secret Laboratory, 1-2F, \"Inviting Nyogo\") and buy it.",
                        Price = "¥29600",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Fickle Madam",
                Attack = 173,
                Accuracy = 95,
                Effect = "Low chance to inflict Rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Dogma Clasp (The Secret Laboratory, 3-4F, \"Dogmatic Tower\") and buy it.",
                        Price = "¥32400",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Akisame Fan",
                Attack = 180,
                Accuracy = 50,
                Effect = "+10 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 3rd Girl's Talc (Marukyu Striptease, 1-4F, \"Rainy Sister 3\", Rainy weather) and buy it.",
                        Price = "¥25000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Tambourine",
                Attack = 182,
                Accuracy = 90,
                Effect = "+3 to all Stats",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Milky Quartz & 1 Taisui Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Ganar",
                Attack = 186,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Fur Clasp (The Secret Laboratory, 7-8F, \"Elegant Mother\") and buy it.",
                        Price = "¥32000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Courtesia",
                Attack = 208,
                Accuracy = 95,
                Effect = "Increase max SP by 10",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Smart Clasp (Heaven, 1-2F, \"Prime Magus\") and buy it.",
                        Price = "¥36400",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Adoracion",
                Attack = 218,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Scorching Scale (Heaven, 3-4F, \"Carnal Snake\") and buy it.",
                        Price = "¥37400",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Uhi Fan",
                Attack = 220,
                Accuracy = 92,
                Effect = "Increase resistance to Exhaustion",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 Rare Raincoat (Heaven, 2-4F, \"Raindrop Castle\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Suzumushi",
                Attack = 235,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Blessed Dish (Heaven, 5-7F, \"Light Balance\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Noblesse Oblige",
                Attack = 260,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 God Tailfeather (Magatsu Inaba, 1-2F, \"Jupiter Eagle\") and buy it.",
                        Price = "¥44400",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Hototogisu",
                Attack = 272,
                Accuracy = 92,
                Effect = "+10 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Love Clasp (Magatsu Mandala, 4-5F, \"Harem Dancer\") and buy it.",
                        Price = "¥46000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Secret Fan",
                Attack = 278,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Golden Film (Magatsu Mandala, 6F, \"Noble Seeker\") and buy it.",
                        Price = "¥47200",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Kacho Fugetsu",
                Attack = 293,
                Accuracy = 95,
                Effect = "Medium chance to inflict Enervate",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Red-Gold Cord (Yomotsu Hirasaka, 2-3F, \"Silent Nyogo\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Pieta",
                Attack = 300,
                Accuracy = 97,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Merciless Cord (Yomotsu Hirasaka, 7-8F, \"El Dorado Beast\") and buy it.",
                        Price = "¥51200",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Yume no Ukihashi",
                Attack = 328,
                Accuracy = 98,
                Effect = "Increase resistance to Confusion",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Forbidden Scale (Yomotsu Hirasaka, 6-7F, \"Stoic Snake\") and buy it.",
                        Price = "¥56000",
                    }
                }
            },
            new Weapon() {
                User = User.Yukiko,
                Name = "Boundless Sea",
                Attack = 395,
                Accuracy = 98,
                Effect = "High chance to inflict Exhaustion",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Yukiko in party.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Folding Chair",
                Attack = 45,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Christmas Wreath",
                Attack = 48,
                Accuracy = 84,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Magatus Xansrite & 1 Kaisou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Yasogami Desk",
                Attack = 92,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥16000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Half-Sized Tatami",
                Attack = 95,
                Accuracy = 89,
                Effect = "Low chance to inflict Enervate",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Fluorite.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Strange Shield",
                Attack = 103,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Iron Plate",
                Attack = 113,
                Accuracy = 92,
                Effect = "+2 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the optional boss in The Steamy Bathhouse.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Steel Plate",
                Attack = 142,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Heavy Iron Lump (Marukyu Striptease, 5-10F, \"Liberating Idol\") and buy it.",
                        Price = "¥24400",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Photon Plate",
                Attack = 158,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Steel Collar (Marukyu Striptease, 5-8F, \"Enslaved Beast\") and buy it.",
                        Price = "¥28000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Hard Board",
                Attack = 162,
                Accuracy = 92,
                Effect = "Reduce Fire damage by 20%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Dependent Iron (The Void Quest, 1-2F, \"Dependent Basalt\") and buy it.",
                        Price = "¥28800",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Thunder Plate",
                Attack = 172,
                Accuracy = 96,
                Effect = "Increase Electricity damage by 25%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Electric Rock (The Void Quest, 5-6F, \"Almighty Hand\") and buy it.",
                        Price = "¥30000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Bodyboard",
                Attack = 174,
                Accuracy = 94,
                Effect = "Increase resitance to Exhaustion",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Lepidolite & 2 Gyosen Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Power Plate",
                Attack = 180,
                Accuracy = 92,
                Effect = "+3 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Chirping Wings (The Void Quest, 3-4F, \"Blind Cupid\") and buy it.",
                        Price = "¥31200",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Alloyed Plate",
                Attack = 192,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Super-Alloy (The Void Quest, 9F, \"Scarlet Turret\") and buy it.",
                        Price = "¥33000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Bath Lid",
                Attack = 198,
                Accuracy = 55,
                Effect = "Medium chance to inflict Rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 1 Huge Fish for it. (July)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Howlite & 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Gorgon Plate",
                Attack = 205,
                Accuracy = 94,
                Effect = "Increase resistance to Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Source Lump (The Secret Laboratory, 1-2F, \"Source Basalt\") and buy it.",
                        Price = "¥35200",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Scutum",
                Attack = 220,
                Accuracy = 90,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Illusionary Sand (The Secret Laboratory, 3-4F, \"Flowing Sand\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Barbarian Shield",
                Attack = 235,
                Accuracy = 94,
                Effect = "Increase max HP by 30",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Platinum Lump (The Secret Laboratory, 5-6F, \"Chaos Fuzz\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Golden Plate",
                Attack = 246,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Fixed Lump (The Secret Laboratory, 7-8F, \"Order Giant\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Demon Shield",
                Attack = 252,
                Accuracy = 92,
                Effect = "+4 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Jet Black Steel (Heaven, 2F, \"Dark Eagle\") and buy it.",
                        Price = "¥43200",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Death Scudetto",
                Attack = 260,
                Accuracy = 50,
                Effect = "+2 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: The Secret Laboratory.",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 9/25.",
                        Price = "¥28800"
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Mega Buckler",
                Attack = 264,
                Accuracy = 94,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Divine Bark (Heaven, 5-7F, \"Angry Table\") and buy it.",
                        Price = "¥45200",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Oni-Gawara",
                Attack = 280,
                Accuracy = 88,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Heavy Chains (Heaven, 8-9F, \"Minotaur IV\") and buy it.",
                        Price = "¥45200",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Big Symbal",
                Attack = 290,
                Accuracy = 91,
                Effect = "Increase max SP by 30",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Aurora Quartz & 1 Maguro Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Colored Bench",
                Attack = 305,
                Accuracy = 99,
                Effect = "Low chance to inflict any ailment",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Sol Breaker",
                Attack = 318,
                Accuracy = 96,
                Effect = "Reduce fire damage by 10%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Dignified Lump (Magatsu Mandala, 1F, \"Great King\") and buy it.",
                        Price = "¥54000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Phalanx",
                Attack = 322,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Scaly Lump (Magatsu Mandala, 1-3F 6F, \"Amorous Snake\") and buy it.",
                        Price = "¥54800",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Asturias",
                Attack = 332,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Death Lump (Magatsu Mandala, 4-5F, \"Death Dice\") and buy it.",
                        Price = "¥56400",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Black Targe",
                Attack = 346,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Golden Chains (Magatsu Mandala, 6F, \"Minotaur II\") and buy it.",
                        Price = "¥58800",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Aegis Shield",
                Attack = 357,
                Accuracy = 94,
                Effect = "+10 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Platinum Shell (Yomotsu Hirasaka, 2-3F, \"Emperor Beetle\") and buy it.",
                        Price = "¥60000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Dullahan",
                Attack = 368,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Holy Gold Lump (Yomotsu Hirasaka, 4-5F, \"Doom Sword\") and buy it.",
                        Price = "¥62000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Christ Mirror",
                Attack = 382,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Platinum Gear (Yomotsu Hirasaka, 7F, \"Rampage Drive\") and buy it.",
                        Price = "¥64000",
                    }
                }
            },
            new Weapon() {
                User = User.Kanji,
                Name = "Perun Plate",
                Attack = 432,
                Accuracy = 92,
                Effect = "Increase Electricity damge by 25%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Kanji in party.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Animal Paw",
                Attack = 40,
                Accuracy = 80,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Mondo Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Spikey punch",
                Attack = 44,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Strange Claw",
                Attack = 78,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Mewling Claw",
                Attack = 154,
                Accuracy = 86,
                Effect = "+4 Agility",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Buy from Daidara Metalworks.",
                        Price = "¥26600",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Bear Claw",
                Attack = 161,
                Accuracy = 78,
                Effect = "Low chance to counter Physical attacks",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the optional boss in The Marukyu Striptease.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Crab Claw",
                Attack = 160,
                Accuracy = 85,
                Effect = "High chance to inflict silence",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Olive Quartz & 2 Takou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Drunken Fist",
                Attack = 172,
                Accuracy = 98,
                Effect = "Medium chance to inflict Exhaustion",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Shiny Scale (The Void Quest, 5-6F, \"Whimsical Papillon\") and buy it.",
                        Price = "¥30000",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Cute Assassin",
                Attack = 180,
                Accuracy = 95,
                Effect = "+5 Strength",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Samegawa Riverbank and trade 6 Red Goldfish for it. (August)",
                        Price = "",
                    },
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Lemon Quartz & 1 Ryugu Stone.",
                        Price = ""
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Fuuma Bundou",
                Attack = 190,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 9/11.",
                        Price = "¥27800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Typhoon Claw",
                Attack = 200,
                Accuracy = 70,
                Effect = "High chance to inflict Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 1 2nd Boy's Talc (The Void Quest, 7-8F, \"Rainy Brother 2\", Rainy weather) and buy it.",
                        Price = "¥32800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Air Break",
                Attack = 205,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Sharp Premolar (The Secret Laboratory, 1-2F, \"Flattering Hablerie\") and buy it.",
                        Price = "¥36800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Poison Claw",
                Attack = 218,
                Accuracy = 84,
                Effect = "High chance to inflict Poison",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Venomous Fang (The Secret Laboratory, 5-6F, \"Immoral Snake\") and buy it.",
                        Price = "¥37200",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Hyper Drill",
                Attack = 225,
                Accuracy = 89,
                Effect = "+Auto-Tarukaja",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Mail Duster",
                Attack = 232,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Guard Stationary (The Secret Laboratory, 7-8F, \"Truth Pesce\") and buy it.",
                        Price = "¥40000",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Assault Spike",
                Attack = 240,
                Accuracy = 93,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Claw of Myth (Heaven, 2F, \"Mythical Gigas\") and buy it.",
                        Price = "¥41200",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Gehenna Claw",
                Attack = 254,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Thirsty Claw (Heaven, 5F, \"Dry Dixie\") and buy it.",
                        Price = "¥43600",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Chain Glove",
                Attack = 271,
                Accuracy = 87,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 8 Blade Thorn (Heaven, 6-7F, \"Chaos Cyclops\") and buy it.",
                        Price = "¥46000",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Strega Claw",
                Attack = 300,
                Accuracy = 74,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: Heaven.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Pure Assassin",
                Attack = 300,
                Accuracy = 75,
                Effect = "Medium chance to inflict Poison",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Bought from the TV shopping show on 10/23.",
                        Price = "¥29800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Needle Spike",
                Attack = 322,
                Accuracy = 86,
                Effect = "High chance to inflict Rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Queen's Nail (Magatsu Mandala, 1F, \"Pistil Mother\") and buy it.",
                        Price = "¥54800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Seiryu Claw",
                Attack = 334,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Silver Claw (Magatsu Mandala, 4-5F, \"Change Relic\") and buy it.",
                        Price = "¥56800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Jakotsu Claw",
                Attack = 345,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Strength Claw (Magatsu Mandala, 6F, \"Minotaur III\") and buy it.",
                        Price = "¥58800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Platinum Claw",
                Attack = 358,
                Accuracy = 96,
                Effect = "+3 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Force Rock (Yomotsu Hirasaka, 2-3F, \"Primitive Idol\") and buy it.",
                        Price = "¥60000",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Reindeer Hoof",
                Attack = 362,
                Accuracy = 50,
                Effect = "Increase change to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Moonstone & 3 Taisui Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "The Ripper",
                Attack = 365,
                Accuracy = 92,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Bloody Thorn (Yomotsu Hirasaka, 6-7F, \"Rebellious Cyclops\") and buy it.",
                        Price = "¥62000",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Shitisei Jakotsu",
                Attack = 371,
                Accuracy = 96,
                Effect = "+4 Magic",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Mysterious Eye (Yomotsu Hirasaka, 7F, \"Acheron Seeker\") and buy it.",
                        Price = "¥62800",
                    }
                }
            },
            new Weapon() {
                User = User.Teddie,
                Name = "Seireiga",
                Attack = 406,
                Accuracy = 94,
                Effect = "Reduce magical damage by 30%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Teddie in party.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Rubber Band Gun",
                Attack = 35,
                Accuracy = 95,
                Effect = "+50% EXP",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Kaiou Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Nambu 2",
                Attack = 80,
                Accuracy = 95,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "[Default]",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Strange Firearm",
                Attack = 87,
                Accuracy = 99,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Hollow Forest equipment.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Frost Shot",
                Attack = 190,
                Accuracy = 85,
                Effect = "Increase Ice damge by 25%",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Rose Quatz & 2 Masuda Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Water Gun",
                Attack = 216,
                Accuracy = 80,
                Effect = "Medium chance to inflict Rage",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Sphalerite & 1 Masuda Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Raging Bull",
                Attack = 220,
                Accuracy = 88,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 2 Steel Barrel (Heaven, 2F, \"Rash Panzer\") and buy it.",
                        Price = "¥38000",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Algernon",
                Attack = 230,
                Accuracy = 85,
                Effect = "+5 to all stats",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the optional boss in The Secret Laboratory.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Crimson Dirge",
                Attack = 240,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Fixing Bolt (Heaven, 3-4F, \"Killer Drive\") and buy it.",
                        Price = "¥42000",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = ".44 Anaconda",
                Attack = 246,
                Accuracy = 94,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 6 Judgement Shot (Heaven, 8-9F, \"Hallowed Turret\") and buy it.",
                        Price = "¥43200",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Flintlock",
                Attack = 254,
                Accuracy = 90,
                Effect = "Increase max SP by 30",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Fish at Shichiri Beach.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Chrome Heart",
                Attack = 275,
                Accuracy = 95,
                Effect = "Medium chance to inflict Silence",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Orb of Love (Magatsu Mandala, 1-3F, \"Yearning Pot\") and buy it.",
                        Price = "¥46800",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Jovian Thunder",
                Attack = 290,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Gold Signature (Magatsu Mandala, 2-3F, \"Purple Sigil\") and buy it.",
                        Price = "¥49200",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Unlimited",
                Attack = 301,
                Accuracy = 95,
                Effect = "+3 Luck",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Thunder Bead (Magatsu Mandala, 4-5F, \"Jotun of Evil\") and buy it.",
                        Price = "¥50000",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Camel Red",
                Attack = 310,
                Accuracy = 98,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Golden Barrel (Magatsu Mandala, 6F, \"Conceited Panzer\") and buy it.",
                        Price = "¥52800",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Machine Pistol",
                Attack = 312,
                Accuracy = 93,
                Effect = "+10 Endurance",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Go to Shiroku pub and trade 5 Rainbow Quartz & 3 Yazu Stone.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "From Zero",
                Attack = 325,
                Accuracy = 96,
                Effect = "Increase chance to give a critical hit",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 4 Prophecy Orb (Yomotsu Hirasaka, 1F, \"Wrathful Book\") and buy it.",
                        Price = "¥56000",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Athena Kiss R",
                Attack = 342,
                Accuracy = 95,
                Effect = "Medium chance to inflict Confuse",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Pure White Bead (Yomotsu Hirasaka, 4-5F, \"Gracious Cupid\") and buy it.",
                        Price = "¥58800",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Judge of Hell",
                Attack = 360,
                Accuracy = 96,
                Effect = "",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Sell Daidara Metalworks 10 Bull's-Eye Shot (Yomotsu Hirasaka, 6F, \"Berserk Turret\") and buy it.",
                        Price = "¥62800",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Magatsu Kiba",
                Attack = 370,
                Accuracy = 74,
                Effect = "High chance to inflict Fear",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Found in golden chests in: Magatsu Inaba.",
                        Price = "",
                    }
                }
            },
            new Weapon() {
                User = User.Naoto,
                Name = "Black Hole",
                Attack = 406,
                Accuracy = 96,
                Effect = "High chance to inflict any Ailment",
                Obtained = new List<ItemObtain>() {
                    new ItemObtain() {
                        Obtain = "Defeat the Reaper with Naoto in party.",
                        Price = "",
                    }
                }
            }
        };
    }
}
