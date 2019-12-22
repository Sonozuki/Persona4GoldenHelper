using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Context
{
    public class ArmorContext
    {
        public List<Armor> Armor { get; } = new List<Armor>()
        {
            new Armor(
                gender: Gender.Unisex,
                name: "Chain Mail",
                defense: 34,
                evade: 8,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Buy from Daidara Metalworks.",
                        price: "¥3000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Kevlar Vest",
                defense: 58,
                evade: 10,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Moustache Fiber (The Castle, 4-5F, \"Positive King\") and buy it.",
                        price: "¥6800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Survival Guard",
                defense: 62,
                evade: 12,
                effect: "+1 Endurance",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 8 Wonder Cloth (The Castle, 3-5F, \"Trance Twins\") and buy it.",
                        price: "¥7200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Metal Jacket",
                defense: 78,
                evade: 3,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Bronze Reins (The Castle, 6-7F, \"Avenger Knight\") and buy it.",
                        price: "¥12800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Hard Armor",
                defense: 156,
                evade: 16,
                effect: "Reduce Physical damage by 10%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Fashionable Dishs (Marukyu Striptease, 9-10F, \"Sky Balance\") and buy it.",
                        price: "¥28000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Haikara Shirt",
                defense: 194,
                evade: 20,
                effect: "+50% EXP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Go to the Samegawa Riverbank and trade a Guardian for it.",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Talisman Cape",
                defense: 210,
                evade: 3,
                effect: "Low chance to evade Magic attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Bushy Fur (Secret Laboratory, 5-6F, \"Mach Wheel\") and buy it.",
                        price: "¥42000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Unisex,
                name: "Godly Robe",
                defense: 375,
                evade: 15,
                effect: "+10 to all stats",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Defeat the Reaper.",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "T-Shirt",
                defense: 26,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Protagonist's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Long T-Shirt",
                defense: 28,
                evade: 10,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Yosuke's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Skull T-Shirt",
                defense: 28,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Kanji's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Pretty Suit",
                defense: 22,
                evade: 15,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Teddie's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Gentleman's Tux",
                defense: 60,
                evade: 24,
                effect: "+50 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Castle (Yukiko's dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Jingi Fundoshi",
                defense: 72,
                evade: 23,
                effect: "+10 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Steamy Bathhouse (Kanji's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, June 5th.",
                        price: "¥11800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Lion Happi",
                defense: 78,
                evade: 16,
                effect: "+1 Strength",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Power String (The Castle, 5-7F, \"Bronze Dice\") and buy it.",
                        price: "¥14400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Knifeproof Coat",
                defense: 86,
                evade: 8,
                effect: "+2 Endurance",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Proof of Spirit (The Steamy Bathhouse, 3-8F, \"Daring Gigas\") and buy it.",
                        price: "¥16800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Doumaru",
                defense: 94,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Firm Cloth (The Steamy Bathhouse, 3-4F, \"Pursuing Pesce\") and buy it.",
                        price: "¥17800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Ama-Gakure",
                defense: 98,
                evade: 40,
                effect: "+10 Agility",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Rain Steel (The Void Quest, 5-6F, \"Pursuing Pesce\", Rainy weather) and buy it.",
                        price: "¥32000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Desperate Plate",
                defense: 114,
                evade: 4,
                effect: "Resist Rage",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Sharp Horns (The Steamy Bathhouse, 9-10F, \"Grave Beetle\") and buy it.",
                        price: "¥21600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Purple Suit",
                defense: 116,
                evade: 23,
                effect: "Low chance to counter Physical attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Marukyu Striptease (Rise's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, July 17th.",
                        price: "¥20800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Ame-Otoko",
                defense: 120,
                evade: 5,
                effect: "+100 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Rain Leg Musha (Marukyu Striptease, 7-9F, \"Rain Leg Musha\", Rainy weather) and buy it.",
                        price: "¥26000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Black Stone Mail",
                defense: 132,
                evade: 11,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Idle Stone Iron (Marukyu Striptease, 3-4F, \"Idle Basalt\") and buy it.",
                        price: "¥24000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Knight Scale",
                defense: 142,
                evade: 8,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Sheet Metal (Marukyu Striptease, 9-10F, \"Arcane Turret\") and buy it.",
                        price: "¥25600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Plate Mail",
                defense: 161,
                evade: 3,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Golden Horns (The Void Quest, 5-6F, \"Strength Beetle\") and buy it.",
                        price: "¥29800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Paladin Armor",
                defense: 166,
                evade: 4,
                effect: "Low chance to evade Physical attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Void Quest (Mitsuo's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, October 16th.",
                        price: "¥20800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Passion Sweats",
                defense: 190,
                evade: 18,
                effect: "Auto-Tarukaja",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Proof of Flight (The Void Quest, 7-9F, \"Beastly Gigas\") and buy it.",
                        price: "¥34000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Kuroito-odoshi",
                defense: 206,
                evade: 4,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Demon Collars (The Secret Laboratory, 5-6F, \"Mighty Beast\") and buy it.",
                        price: "¥36800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Niagra Climber",
                defense: 210,
                evade: 3,
                effect: "Auto-Rakukaja",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 1st Girl's Talc (The Secret Laboratory, 1-2F, \"Rainy Sister 1\", Rainy weather) and buy it.",
                        price: "¥38400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Red Battlesuit",
                defense: 216,
                evade: 26,
                effect: "Reduce Physical damage by 20%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Secret Laboratory (Naoto's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, October 16th.",
                        price: "¥20800"
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, November 13th.",
                        price: "¥19800"
                    ),
                    new ArmorObtain(
                        obtain: "Go to Samegawa Riverbank and trade 2 Huge Fish for it. (August)",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Hurricane Coat",
                defense: 228,
                evade: 14,
                effect: "Reduce Wind damage by 20%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Black Reins (The Secret Laboratory, 7-8F, \"Hell Knight\") and buy it.",
                        price: "¥40000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Amamusha Armor",
                defense: 236,
                evade: 3,
                effect: "Resist Dizzy",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Rain Metal (The Secret Laboratory, 5-6F, \"Raindrop Musha\", Rainy weather) and buy it.",
                        price: "¥41200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Dragon Scale",
                defense: 245,
                evade: 11,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Porcelain Statue (Heaven, 2F, \"Growth Relic\") and buy it.",
                        price: "¥42800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Tsukuyomi Noshi",
                defense: 254,
                evade: 26,
                effect: "+5 to all stats",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Heaven (Nanako's dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Stylish Kimono",
                defense: 258,
                evade: 15,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Practical Cloth (Heaven, 5F, \"Reckless Okina\") and buy it.",
                        price: "¥45800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Oracle Gown",
                defense: 270,
                evade: 17,
                effect: "+40 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Oracle Textile (Heaven, 6-7F, \"Revelation Pesce\") and buy it.",
                        price: "¥47200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Ame-agari Kesshi",
                defense: 280,
                evade: 8,
                effect: "Reduce Physical damage by 30%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Cascade Metal (Heaven, 6-7F, \"Rain Wind Musha\", Rainy weather) and buy it.",
                        price: "¥48000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Nubatama Suit",
                defense: 280,
                evade: 32,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Magatsu Inaba ([True Killer]'s dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "1000-Stud Coat",
                defense: 287,
                evade: 4,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Calm Marble (Magatsu Inaba, 1-2F, \"Vehement Idol\") and buy it.",
                        price: "¥49200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Komaryo Uchinugi",
                defense: 302,
                evade: 11,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Thought Crosses (Magatsu Inaba, 2-3F, \"Sleeping Table\") and buy it.",
                        price: "¥52000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Mikagura Vest",
                defense: 308,
                evade: 14,
                effect: "Resist Enervation",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Formidable Proof (Magatsu Inaba, 4-5F, \"Immortal Gigas\") and buy it.",
                        price: "¥53200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Surcoat",
                defense: 315,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Diamond Sheets (Magatsu Inaba, 6F, \"Harmony Giant\") and buy it.",
                        price: "¥54000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Sonidori Wear",
                defense: 315,
                evade: 32,
                effect: "+100 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Yomotsu Hirasaka (True ending dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Opera Coat",
                defense: 325,
                evade: 19,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Demon Cloth (Yomotsu Hirasaka, 3-4F, \"Phantom Hero\") and buy it.",
                        price: "¥56000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Lorica Hamata",
                defense: 340,
                evade: 11,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Unknown Barrel (Yomotsu Hirasaka, 6-7F, \"Phantom Hero\") and buy it.",
                        price: "¥58000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Male,
                name: "Full Jin-Baori",
                defense: 350,
                evade: 10,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Pyroxene Fiber (Yomotsu Hirasaka, 7-8F, \"Heartless Machine\") and buy it.",
                        price: "¥60000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Tank Top",
                defense: 25,
                evade: 14,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Chie's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Lace Blouse",
                defense: 25,
                evade: 14,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Yukiko's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Gothic Shirt",
                defense: 30,
                evade: 10,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "[Naoto's default]",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Combat Dress",
                defense: 60,
                evade: 4,
                effect: "Medium chance to evade Fire attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Castle (Yukiko's dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Miori Shirt",
                defense: 60,
                evade: 40,
                effect: "Auto-Sukukaja",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Curious Line (The Steamy Bathhouse, 3-4F, \"Cloudgirl Pot\", Rainy weather) and buy it.",
                        price: "¥22400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Steel Panier",
                defense: 75,
                evade: 22,
                effect: "+20 SP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Steamy Bathhouse (Kanji's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, May 29th.",
                        price: "¥11800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Charm Robe",
                defense: 78,
                evade: 18,
                effect: "+1 Magic",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Magic Cross (The Castle, 6-7F, \"Laughing Table\") and buy it.",
                        price: "¥15200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Battle Camisole",
                defense: 85,
                evade: 15,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Karma Lamp (The Steamy Bathhouse, 5-6F, \"Vicious Raven\") and buy it.",
                        price: "¥15600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Zero Kosode",
                defense: 108,
                evade: 3,
                effect: "High chance to evade Magic attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Zero Cloth (The Marukyu Striptease, 3-4F, \"Rain Wheel\", Rainy weather) and buy it.",
                        price: "¥28000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Hard Bolero",
                defense: 115,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Smooth Fabric (The Steamy Bathhouse, 7-10F, \"Wondrous Magus\") and buy it.",
                        price: "¥21200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Armada Bustier",
                defense: 118,
                evade: 25,
                effect: "+5 Magic",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Marukyu Striptease (Rise's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, July 3rd.",
                        price: "¥20800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Amakaze Happi",
                defense: 120,
                evade: 3,
                effect: "High chance to evade Physical attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Rare Poncho (The Void Quest, 5-6F, \"Rainy Pot\", Rainy weather) and buy it.",
                        price: "¥31200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Wolf Tunic",
                defense: 130,
                evade: 14,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Tanned Hide (The Marukyu Striptease, 3-4F, \"Persistent Fuzz\") and buy it.",
                        price: "¥24800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Action Vest",
                defense: 144,
                evade: 5,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Steel Reins (The Marukyu Striptease, 9-10F, \"Champion Knight\") and buy it.",
                        price: "¥26400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Capital Robe",
                defense: 160,
                evade: 11,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Anguish Stone (The Void Quest, 5-6F, \"Anguish Basalt\") and buy it.",
                        price: "¥28400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Charm Drape",
                defense: 167,
                evade: 24,
                effect: "+5 Endurance",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Void Quest (Mitsuo's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, September 4th.",
                        price: "¥21800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Breeze Tutu",
                defense: 180,
                evade: 14,
                effect: "Reduce Wind damage by 20%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Light String (The Void Quest, 7-9F, \"Platinum Dice\") and buy it.",
                        price: "¥32600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Divine Blouse",
                defense: 204,
                evade: 8,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Proof of Passion (The Secret Laboratory, 3-4F, \"Furious Gigas\") and buy it.",
                        price: "¥35600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Peach Battlesuit",
                defense: 211,
                evade: 4,
                effect: "Low chance to evade Physical attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in The Secret Laboratory (Naoto's dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, October 2nd.",
                        price: "¥29800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Uin Haori",
                defense: 222,
                evade: 8,
                effect: "Resist Confusion",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 1 Cascade String (The Secret Laboratory, 3-4F, \"Rainbow Twins\", Rainy weather) and buy it.",
                        price: "¥39200"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Invincible Mini",
                defense: 232,
                evade: 8,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 8 Power Rock (The Secret Laboratory, 7-8F, \"Power Castle\") and buy it.",
                        price: "¥40000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Mythos Robe",
                defense: 240,
                evade: 16,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Golden Sand (Heaven, 1F, \"Perpetual Sand\") and buy it.",
                        price: "¥42000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Amaterasu Hitoe",
                defense: 251,
                evade: 29,
                effect: "Medium chance to counter Physical attacks",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Heaven (Nanako's dungeon).",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Lan Ling Wang",
                defense: 255,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Mink Fur (Heaven, 3-5F, \"Regal Mother\") and buy it.",
                        price: "¥44000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Rune Dress",
                defense: 270,
                evade: 14,
                effect: "+4 to all stats",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Ayanishiki (Heaven, 6-7F, \"Blossom Nyogo\") and buy it.",
                        price: "¥46000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Elint Duffle",
                defense: 274,
                evade: 8,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Hemp Cloth (Heaven, 8-9F, \"Natural Dancer\") and buy it.",
                        price: "¥48800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Angel Skirt",
                defense: 284,
                evade: 30,
                effect: "Reduce Physical damage by 20%",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Magatsu Inaba ([True Killer]'s dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Buy on the shopping channel, November 20th.",
                        price: "¥59800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Kikusui Awase",
                defense: 285,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Royal Blossom (Magatsu Mandala, 1F, \"Free Bambino\") and buy it.",
                        price: "¥50000"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Shinra Robe",
                defense: 304,
                evade: 13,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 6 Oguruma Brocade (Magatsu Mandala, 2-5F, \"Valuing Nyogo\") and buy it.",
                        price: "¥52800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Kotodama Cape",
                defense: 310,
                evade: 19,
                effect: "Resist Poison",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Word String (Magatsu Mandala, 2-5F, \"Silent Book\") and buy it.",
                        price: "¥54400"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Uzume Robe",
                defense: 310,
                evade: 33,
                effect: "+100 HP",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Found in golden chests in Yomotsu Hirasaka (True ending dungeon).",
                        price: ""
                    ),
                    new ArmorObtain(
                        obtain: "Go to Samegawa Riverbank and trade 3 Huge Fish for it. (December)",
                        price: ""
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Mizuha Armor",
                defense: 314,
                evade: 12,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Flame Sheet (Magatsu Mandala, 6F, \"Spastic Turret\") and buy it.",
                        price: "¥54800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Yomi Sleeves",
                defense: 324,
                evade: 18,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 4 Klein Bottle (Yomotsu Hirasaka, 3-4F, \"Mistress Pot\") and buy it.",
                        price: "¥56800"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Emery Meisen",
                defense: 338,
                evade: 14,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Unknowable Fiber (Yomotsu Hirasaka, 5-6F, \"Next Gene\") and buy it.",
                        price: "¥59600"
                    )
                }
            ),
            new Armor(
                gender: Gender.Female,
                name: "Haten Robe",
                defense: 352,
                evade: 10,
                effect: "",
                obtained: new List<ArmorObtain>() {
                    new ArmorObtain(
                        obtain: "Sell Daidara Metalworks 10 Silver String (Yomotsu Hirasaka, 7-8F, \"Brilliant King\") and buy it.",
                        price: "¥61200"
                    )
                }
            )
        };
    }
}
