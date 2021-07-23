using Persona4GoldenHelper.Shared;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The armour data.</summary>
    public static class ArmourData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The armour data.</summary>
        public static List<Armour> Armour { get; } = new()
        {
            new(Gender.Unisex, "Chain Mail", 34, 8, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥3000")
            }),
            new(Gender.Unisex, "Kevlar Vest", 58, 10, "", new()
            {
                new("Sell Daidara Metalworks 6 Moustache Fiber (The Castle, 4-5F, \"Positive King\") and buy it.", "¥6800")
            }),
            new(Gender.Unisex, "Survival Guard", 62, 12, "+1 Endurance", new()
            {
                new("Sell Daidara Metalworks 8 Wonder Cloth (The Castle, 3-5F, \"Trance Twins\") and buy it.", "¥7200")
            }),
            new(Gender.Unisex, "Metal Jacket", 78, 3, "", new()
            {
                new("Sell Daidara Metalworks 6 Bronze Reins (The Castle, 6-7F, \"Avenger Knight\") and buy it.", "¥12800")
            }),
            new(Gender.Unisex, "Hard Armor", 156, 16, "Reduce Physical damage by 10%", new()
            {
                new("Sell Daidara Metalworks 6 Fashionable Dishs (Marukyu Striptease, 9-10F, \"Sky Balance\") and buy it.", "¥28000")
            }),
            new(Gender.Unisex, "Haikara Shirt", 194, 20, "+50% EXP", new()
            {
                new("Go to the Samegawa Riverbank and trade a Guardian for it.", "")
            }),
            new(Gender.Unisex, "Talisman Cape", 210, 3, "Low chance to evade Magic attacks", new()
            {
                new("Sell Daidara Metalworks 4 Bushy Fur (Secret Laboratory, 5-6F, \"Mach Wheel\") and buy it.", "¥42000")
            }),
            new(Gender.Unisex, "Godly Robe", 375, 15, "+10 to all stats", new()
            {
                new("Defeat the Reaper.", "")
            }),
            new(Gender.Male, "Pretty Suit", 22, 15, "", new()
            {
                new("[Teddie's default]", "")
            }),
            new(Gender.Male, "T-Shirt", 26, 12, "", new()
            {
                new("[Protagonist's default]", "")
            }),
            new(Gender.Male, "Long T-Shirt", 28, 10, "", new()
            {
                new("[Yosuke's default]", "")
            }),
            new(Gender.Male, "Skull T-Shirt", 28, 12, "", new()
            {
                new("[Kanji's default]", "")
            }),
            new(Gender.Male, "Gentleman's Tux", 60, 24, "+50 HP", new()
            {
                new("Found in golden chests in The Castle.", "")
            }),
            new(Gender.Male, "Jingi Fundoshi", 72, 23, "+10 HP", new()
            {
                new("Found in golden chests in The Steamy Bathhouse.", ""),
                new("Buy on the shopping channel, June 5th.", "¥11800")
            }),
            new(Gender.Male, "Lion Happi", 78, 16, "+1 Strength", new()
            {
                new("Sell Daidara Metalworks 6 Power String (The Castle, 5-7F, \"Bronze Dice\") and buy it.", "¥14400")
            }),
            new(Gender.Male, "Knifeproof Coat", 86, 8, "+2 Endurance", new()
            {
                new("Sell Daidara Metalworks 6 Proof of Spirit (The Steamy Bathhouse, 3-8F, \"Daring Gigas\") and buy it.", "¥16800")
            }),
            new(Gender.Male, "Doumaru", 94, 12, "", new()
            {
                new("Sell Daidara Metalworks 6 Firm Cloth (The Steamy Bathhouse, 3-4F, \"Pursuing Pesce\") and buy it.", "¥17800")
            }),
            new(Gender.Male, "Ama-Gakure", 98, 40, "+10 Agility", new()
            {
                new("Sell Daidara Metalworks 1 Rain Steel (The Void Quest, 5-6F, \"Pursuing Pesce\", Rainy weather) and buy it.", "¥32000")
            }),
            new(Gender.Male, "Desperate Plate", 114, 4, "Resist Rage", new()
            {
                new("Sell Daidara Metalworks 4 Sharp Horns (The Steamy Bathhouse, 9-10F, \"Grave Beetle\") and buy it.", "¥21600")
            }),
            new(Gender.Male, "Purple Suit", 116, 23, "Low chance to counter Physical attacks", new()
            {
                new("Found in golden chests in The Marukyu Striptease.", ""),
                new("Buy on the shopping channel, July 17th.", "¥20800")
            }),
            new(Gender.Male, "Ame-Otoko", 120, 5, "+100 HP", new()
            {
                new("Sell Daidara Metalworks 1 Rain Leg Musha (Marukyu Striptease, 7-9F, \"Rain Leg Musha\", Rainy weather) and buy it.", "¥26000")
            }),
            new(Gender.Male, "Black Stone Mail", 132, 11, "", new()
            {
                new("Sell Daidara Metalworks 6 Idle Stone Iron (Marukyu Striptease, 3-4F, \"Idle Basalt\") and buy it.", "¥24000")
            }),
            new(Gender.Male, "Knight Scale", 142, 8, "", new()
            {
                new("Sell Daidara Metalworks 6 Sheet Metal (Marukyu Striptease, 9-10F, \"Arcane Turret\") and buy it.", "¥25600")
            }),
            new(Gender.Male, "Plate Mail", 161, 3, "", new()
            {
                new("Sell Daidara Metalworks 6 Golden Horns (The Void Quest, 5-6F, \"Strength Beetle\") and buy it.", "¥29800")
            }),
            new(Gender.Male, "Paladin Armor", 166, 4, "Low chance to evade Physical attacks", new()
            {
                new("Found in golden chests in The Void Quest.", ""),
                new("Buy on the shopping channel, October 16th.", "¥20800")
            }),
            new(Gender.Male, "Passion Sweats", 190, 18, "Auto-Tarukaja", new()
            {
                new("Sell Daidara Metalworks 10 Proof of Flight (The Void Quest, 7-9F, \"Beastly Gigas\") and buy it.", "¥34000")
            }),
            new(Gender.Male, "Kuroito-odoshi", 206, 4, "", new()
            {
                new("Sell Daidara Metalworks 6 Demon Collars (The Secret Laboratory, 5-6F, \"Mighty Beast\") and buy it.", "¥36800")
            }),
            new(Gender.Male, "Niagra Climber", 210, 3, "Auto-Rakukaja", new()
            {
                new("Sell Daidara Metalworks 1 1st Girl's Talc (The Secret Laboratory, 1-2F, \"Rainy Sister 1\", Rainy weather) and buy it.", "¥38400")
            }),
            new(Gender.Male, "Red Battlesuit", 216, 26, "Reduce Physical damage by 20%", new()
            {
                new("Found in golden chests in The Secret Laboratory.", ""),
                new("Buy on the shopping channel, October 16th.", "¥20800"),
                new("Buy on the shopping channel, November 13th.", "¥19800"),
                new("Go to Samegawa Riverbank and trade 2 Huge Fish for it. (August)", "")
            }),
            new(Gender.Male, "Hurricane Coat", 228, 14, "Reduce Wind damage by 20%", new()
            {
                new("Sell Daidara Metalworks 4 Black Reins (The Secret Laboratory, 7-8F, \"Hell Knight\") and buy it.", "¥40000")
            }),
            new(Gender.Male, "Amamusha Armor", 236, 3, "Resist Dizzy", new()
            {
                new("Sell Daidara Metalworks 1 Rain Metal (The Secret Laboratory, 5-6F, \"Raindrop Musha\", Rainy weather) and buy it.", "¥41200")
            }),
            new(Gender.Male, "Dragon Scale", 245, 11, "", new()
            {
                new("Sell Daidara Metalworks 4 Porcelain Statue (Heaven, 2F, \"Growth Relic\") and buy it.", "¥42800")
            }),
            new(Gender.Male, "Tsukuyomi Noshi", 254, 26, "+5 to all stats", new()
            {
                new("Found in golden chests in Heaven (Nanako's dungeon).", "")
            }),
            new(Gender.Male, "Stylish Kimono", 258, 15, "", new()
            {
                new("Sell Daidara Metalworks 10 Practical Cloth (Heaven, 5F, \"Reckless Okina\") and buy it.", "¥45800")
            }),
            new(Gender.Male, "Oracle Gown", 270, 17, "+40 HP", new()
            {
                new("Sell Daidara Metalworks 6 Oracle Textile (Heaven, 6-7F, \"Revelation Pesce\") and buy it.", "¥47200")
            }),
            new(Gender.Male, "Ame-agari Kesshi", 280, 8, "Reduce Physical damage by 30%", new()
            {
                new("Sell Daidara Metalworks 1 Cascade Metal (Heaven, 6-7F, \"Rain Wind Musha\", Rainy weather) and buy it.", "¥48000")
            }),
            new(Gender.Male, "Nubatama Suit", 280, 32, "", new()
            {
                new("Found in golden chests in Magatsu Inaba.", "")
            }),
            new(Gender.Male, "1000-Stud Coat", 287, 4, "", new()
            {
                new("Sell Daidara Metalworks 6 Calm Marble (Magatsu Inaba, 1-2F, \"Vehement Idol\") and buy it.", "¥49200")
            }),
            new(Gender.Male, "Komaryo Uchinugi", 302, 11, "", new()
            {
                new("Sell Daidara Metalworks 4 Thought Crosses (Magatsu Inaba, 2-3F, \"Sleeping Table\") and buy it.", "¥52000")
            }),
            new(Gender.Male, "Mikagura Vest", 308, 14, "Resist Enervation", new()
            {
                new("Sell Daidara Metalworks 4 Formidable Proof (Magatsu Inaba, 4-5F, \"Immortal Gigas\") and buy it.", "¥53200")
            }),
            new(Gender.Male, "Surcoat", 315, 12, "", new()
            {
                new("Sell Daidara Metalworks 6 Diamond Sheets (Magatsu Inaba, 6F, \"Harmony Giant\") and buy it.", "¥54000")
            }),
            new(Gender.Male, "Sonidori Wear", 315, 32, "+100 HP", new()
            {
                new("Found in golden chests in Yomotsu Hirasaka (True ending dungeon).", "")
            }),
            new(Gender.Male, "Opera Coat", 325, 19, "", new()
            {
                new("Sell Daidara Metalworks 4 Demon Cloth (Yomotsu Hirasaka, 3-4F, \"Phantom Hero\") and buy it.", "¥56000")
            }),
            new(Gender.Male, "Lorica Hamata", 340, 11, "", new()
            {
                new("Sell Daidara Metalworks 10 Unknown Barrel (Yomotsu Hirasaka, 6-7F, \"Phantom Hero\") and buy it.", "¥58000")
            }),
            new(Gender.Male, "Full Jin-Baori", 350, 10, "", new()
            {
                new("Sell Daidara Metalworks 10 Pyroxene Fiber (Yomotsu Hirasaka, 7-8F, \"Heartless Machine\") and buy it.", "¥60000")
            }),
            new(Gender.Female, "Tank Top", 25, 14, "", new()
            {
                new("[Chie's default]", "")
            }),
            new(Gender.Female, "Lace Blouse", 25, 14, "", new()
            {
                new("[Yukiko's default]", "")
            }),
            new(Gender.Female, "Gothic Shirt", 30, 10, "", new()
            {
                new("[Naoto's default]", "")
            }),
            new(Gender.Female, "Combat Dress", 60, 4, "Medium chance to evade Fire attacks", new()
            {
                new("Found in golden chests in The Castle.", "")
            }),
            new(Gender.Female, "Miori Shirt", 60, 40, "Auto-Sukukaja", new()
            {
                new("Sell Daidara Metalworks 1 Curious Line (The Steamy Bathhouse, 3-4F, \"Cloudgirl Pot\", Rainy weather) and buy it.", "¥22400")
            }),
            new(Gender.Female, "Steel Panier", 75, 22, "+20 SP", new()
            {
                new("Found in golden chests in The Steamy Bathhouse.", ""),
                new("Buy on the shopping channel, May 29th.", "¥11800")
            }),
            new(Gender.Female, "Charm Robe", 78, 18, "+1 Magic", new()
            {
                new("Sell Daidara Metalworks 4 Magic Cross (The Castle, 6-7F, \"Laughing Table\") and buy it.", "¥15200")
            }),
            new(Gender.Female, "Battle Camisole", 85, 15, "", new()
            {
                new("Sell Daidara Metalworks 6 Karma Lamp (The Steamy Bathhouse, 5-6F, \"Vicious Raven\") and buy it.", "¥15600")
            }),
            new(Gender.Female, "Zero Kosode", 108, 3, "High chance to evade Magic attacks", new()
            {
                new("Sell Daidara Metalworks 1 Zero Cloth (The Marukyu Striptease, 3-4F, \"Rain Wheel\", Rainy weather) and buy it.", "¥28000")
            }),
            new(Gender.Female, "Hard Bolero", 115, 12, "", new()
            {
                new("Sell Daidara Metalworks 10 Smooth Fabric (The Steamy Bathhouse, 7-10F, \"Wondrous Magus\") and buy it.", "¥21200")
            }),
            new(Gender.Female, "Armada Bustier", 118, 25, "+5 Magic", new()
            {
                new("Found in golden chests in The Marukyu Striptease.", ""),
                new("Buy on the shopping channel, July 3rd.", "¥20800")
            }),
            new(Gender.Female, "Amakaze Happi", 120, 3, "High chance to evade Physical attacks", new()
            {
                new("Sell Daidara Metalworks 1 Rare Poncho (The Void Quest, 5-6F, \"Rainy Pot\", Rainy weather) and buy it.", "¥31200")
            }),
            new(Gender.Female, "Wolf Tunic", 130, 14, "", new()
            {
                new("Sell Daidara Metalworks 4 Tanned Hide (The Marukyu Striptease, 3-4F, \"Persistent Fuzz\") and buy it.", "¥24800")
            }),
            new(Gender.Female, "Action Vest", 144, 5, "", new()
            {
                new("Sell Daidara Metalworks 10 Steel Reins (The Marukyu Striptease, 9-10F, \"Champion Knight\") and buy it.", "¥26400")
            }),
            new(Gender.Female, "Capital Robe", 160, 11, "", new()
            {
                new("Sell Daidara Metalworks 6 Anguish Stone (The Void Quest, 5-6F, \"Anguish Basalt\") and buy it.", "¥28400")
            }),
            new(Gender.Female, "Charm Drape", 167, 24, "+5 Endurance", new()
            {
                new("Found in golden chests in The Void Quest.", ""),
                new("Buy on the shopping channel, September 4th.", "¥21800")
            }),
            new(Gender.Female, "Breeze Tutu", 180, 14, "Reduce Wind damage by 20%", new()
            {
                new("Sell Daidara Metalworks 4 Light String (The Void Quest, 7-9F, \"Platinum Dice\") and buy it.", "¥32600")
            }),
            new(Gender.Female, "Divine Blouse", 204, 8, "", new()
            {
                new("Sell Daidara Metalworks 6 Proof of Passion (The Secret Laboratory, 3-4F, \"Furious Gigas\") and buy it.", "¥35600")
            }),
            new(Gender.Female, "Peach Battlesuit", 211, 4, "Low chance to evade Physical attacks", new()
            {
                new("Found in golden chests in The Secret Laboratory.", ""),
                new("Buy on the shopping channel, October 2nd.", "¥29800")
            }),
            new(Gender.Female, "Uin Haori", 222, 8, "Resist Confusion", new()
            {
                new("Sell Daidara Metalworks 1 Cascade String (The Secret Laboratory, 3-4F, \"Rainbow Twins\", Rainy weather) and buy it.", "¥39200")
            }),
            new(Gender.Female, "Invincible Mini", 232, 8, "", new()
            {
                new("Sell Daidara Metalworks 8 Power Rock (The Secret Laboratory, 7-8F, \"Power Castle\") and buy it.", "¥40000")
            }),
            new(Gender.Female, "Mythos Robe", 240, 16, "", new()
            {
                new("Sell Daidara Metalworks 6 Golden Sand (Heaven, 1F, \"Perpetual Sand\") and buy it.", "¥42000")
            }),
            new(Gender.Female, "Amaterasu Hitoe", 251, 29, "Medium chance to counter Physical attacks", new()
            {
                new("Found in golden chests in Heaven (Nanako's dungeon).", "")
            }),
            new(Gender.Female, "Lan Ling Wang", 255, 12, "", new()
            {
                new("Sell Daidara Metalworks 10 Mink Fur (Heaven, 3-5F, \"Regal Mother\") and buy it.", "¥44000")
            }),
            new(Gender.Female, "Rune Dress", 270, 14, "+4 to all stats", new()
            {
                new("Sell Daidara Metalworks 10 Ayanishiki (Heaven, 6-7F, \"Blossom Nyogo\") and buy it.", "¥46000")
            }),
            new(Gender.Female, "Elint Duffle", 274, 8, "", new()
            {
                new("Sell Daidara Metalworks 6 Hemp Cloth (Heaven, 8-9F, \"Natural Dancer\") and buy it.", "¥48800")
            }),
            new(Gender.Female, "Angel Skirt", 284, 30, "Reduce Physical damage by 20%", new()
            {
                new("Found in golden chests in Magatsu Inaba.", ""),
                new("Buy on the shopping channel, November 20th.", "¥59800")
            }),
            new(Gender.Female, "Kikusui Awase", 285, 12, "", new()
            {
                new("Sell Daidara Metalworks 6 Royal Blossom (Magatsu Mandala, 1F, \"Free Bambino\") and buy it.", "¥50000")
            }),
            new(Gender.Female, "Shinra Robe", 304, 13, "", new()
            {
                new("Sell Daidara Metalworks 6 Oguruma Brocade (Magatsu Mandala, 2-5F, \"Valuing Nyogo\") and buy it.", "¥52800")
            }),
            new(Gender.Female, "Kotodama Cape", 310, 19, "Resist Poison", new()
            {
                new("Sell Daidara Metalworks 4 Word String (Magatsu Mandala, 2-5F, \"Silent Book\") and buy it.", "¥54400")
            }),
            new(Gender.Female, "Uzume Robe", 310, 33, "+100 HP", new()
            {
                new("Found in golden chests in Yomotsu Hirasaka (True ending dungeon).", ""),
                new("Go to Samegawa Riverbank and trade 3 Huge Fish for it. (December)", "")
            }),
            new(Gender.Female, "Mizuha Armor", 314, 12, "", new()
            {
                new("Sell Daidara Metalworks 4 Flame Sheet (Magatsu Mandala, 6F, \"Spastic Turret\") and buy it.", "¥54800")
            }),
            new(Gender.Female, "Yomi Sleeves", 324, 18, "", new()
            {
                new("Sell Daidara Metalworks 4 Klein Bottle (Yomotsu Hirasaka, 3-4F, \"Mistress Pot\") and buy it.", "¥56800")
            }),
            new(Gender.Female, "Emery Meisen", 338, 14, "", new()
            {
                new("Sell Daidara Metalworks 10 Unknowable Fiber (Yomotsu Hirasaka, 5-6F, \"Next Gene\") and buy it.", "¥59600")
            }),
            new(Gender.Female, "Haten Robe", 352, 10, "", new()
            {
                new("Sell Daidara Metalworks 10 Silver String (Yomotsu Hirasaka, 7-8F, \"Brilliant King\") and buy it.", "¥61200")
            }),
        };
    }
}
