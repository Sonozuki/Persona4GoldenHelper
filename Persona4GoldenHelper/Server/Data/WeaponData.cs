using Persona4GoldenHelper.Shared;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The weapon data.</summary>
    public static class WeaponData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The weapon data.</summary>
        public static List<Weapon> Weapons { get; } = new()
        {
            new(User.Protagonist, "Golf Club", 42, 93, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Protagonist, "Musashi Shinai", 42, 98, "+50% EXP", new()
            {
                new("Go to Samegawa Riverbank and trade 2 Guardian for it. (December)", ""),
                new("Go to Shiroku pub and trade 8 Magatsu Xandrite & 8 Ryugu Stone.", "")
            }),
            new(User.Protagonist, "Imitation Sword", 53, 92, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥4800")
            }),
            new(User.Protagonist, "Spiked Bat", 53, 98, "Increase chance to give a critical hit", new()
            {
                new("", "")
            }),
            new(User.Protagonist, "Long Sword", 60, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Black Lamp (The Castle, 3-7F, \"Black Raven\") and buy it.", "¥10000")
            }),
            new(User.Protagonist, "5-Iron", 71, 95, "", new()
            {
                new("Sell Daidara Metalworks 10 Supple Metal (The Castle, 6-7F, \"Magical Magus\") and buy it.", "¥12000")
            }),
            new(User.Protagonist, "Iai Katana", 78, 98, "+3 Agility", new()
            {
                new("Sell Daidara Metalworks 6 Golden Cloth (The Castle, 6-7F, \"Phantom Mage\") and buy it.", "¥13600")
            }),
            new(User.Protagonist, "Bastard Sword", 88, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Powered Iron (The Steamy Bathhouse, 1-2F, \"Autonomic Basalt\") and buy it.", "¥14000")
            }),
            new(User.Protagonist, "Strange Sword", 92, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Protagonist, "Zweihander", 108, 95, "+1 Endurance", new()
            {
                new("Sell Daidara Metalworks 8 Pure Iron Lump (The Steamy Bathhouse, 5-7F, \"Iron Dice\") and buy it.", "¥18000")
            }),
            new(User.Protagonist, "Skull Rod", 125, 80, "Low chance to inflict Fear", new()
            {
                new("Go to Shiroku pub and trade 5 Fluorite & 1 Yazu Stone.", "")
            }),
            new(User.Protagonist, "Titanium Club", 130, 96, "+2 Agility", new()
            {
                new("Go to Samegawa Riverbank and trade 2 Inaba Trout for it. (May)", ""),
                new("Go to Shiroku pub and trade 1 Ryugu Stone.", "")
            }),
            new(User.Protagonist, "Gothic Sword", 133, 94, "", new()
            {
                new("Sell Daidara Metalworks 6 Iron Eyeball (Marukyu Striptease, 1-4F, \"Death Seeker\") and buy it.", "¥20000")
            }),
            new(User.Protagonist, "Myth-like Sword", 140, 80, "", new()
            {
                new("Bought from the TV shopping show on 6/26.", "¥9800"),
                new("Bought from the TV shopping show on 8/7.", "¥12800")
            }),
            new(User.Protagonist, "Type-98 Gunto", 145, 98, "", new()
            {
                new("Sell Daidara Metalworks 4 Silver Lump (Marukyu Striptease, 7-8F, \"Silver Dice\") and buy it.", "¥24000")
            }),
            new(User.Protagonist, "Edge", 152, 92, "+3 Strength", new()
            {
                new("Sell Daidara Metalworks 6 Nice Ornament (The Void Quest, 1-4F, \"Justice Sword\") and buy it.", "¥27000")
            }),
            new(User.Protagonist, "Kage-Dachi", 172, 92, "Increase max HP by 20", new()
            {
                new("Sell Daidara Metalworks 10 Compacted Metal (The Void Quest, 7-9F, \"Monomaniac Fuzz\") and buy it.", "¥30000")
            }),
            new(User.Protagonist, "Bus Stop Sign", 179, 84, "High chance to inflict Rage", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Protagonist, "Anglaise", 180, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Blade Metal (The Void Quest, 7-9F, \"Ardent Dancer\") and buy it.", "¥31000")
            }),
            new(User.Protagonist, "Great Sword", 190, 84, "+2 Strength", new()
            {
                new("Sell Daidara Metalworks 4 Tungsten (The Void Quest, 9F, \"Steel Machine\") and buy it.", "¥32000")
            }),
            new(User.Protagonist, "Beach Parasol", 194, 98, "Low chance to counter Physical attacks", new()
            {
                new("Go to Shiroku pub and trade 5 Howlite & 1 Yazu Stone.", "")
            }),
            new(User.Protagonist, "Wooden Bat", 200, 30, "Increase chance to give a critical hit", new()
            {
                new("Bought from the TV shopping show on 8/14.", "¥14400")
            }),
            new(User.Protagonist, "Gaia Sword", 200, 88, "Low chance to inflict any ailment", new()
            {
                new("Defeat the optional boss in The Void Quest.", "")
            }),
            new(User.Protagonist, "Bass", 202, 90, "Increase max SP by 40", new()
            {
                new("Go to Shiroku pub and trade 5 Meteorite & 2 Taisui Stone.", "")
            }),
            new(User.Protagonist, "Midare Hamon", 210, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Insolence Steel (The Secret Laboratory, 1-2F, \"Insolent Basalt\") and buy it.", "¥36000")
            }),
            new(User.Protagonist, "Kakitsubata", 218, 94, "", new()
            {
                new("Sell Daidara Metalworks 6 Iron Gear (The Secret Laboratory, 5-6F, \"Wild Drive\") and buy it.", "¥37600")
            }),
            new(User.Protagonist, "Gardenia Sword", 220, 92, "Low chance to inflict Silence", new()
            {
                new("Sell Daidara Metalworks 6 Damascus (The Secret Laboratory, 7-8F, \"Dominating Machine\") and buy it.", "¥38000")
            }),
            new(User.Protagonist, "Krieg", 230, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Flame Steel (Heaven, 2F, \"Brave Wheel\") and buy it.", "¥40000")
            }),
            new(User.Protagonist, "Number One", 240, 94, "+1 Luck", new()
            {
                new("Sell Daidara Metalworks 8 Sacrilege Iron (Heaven, 3-4F, \"Apostate Tower\") and buy it.", "¥42000")
            }),
            new(User.Protagonist, "Downpour Sword", 248, 50, "Greatly increase chance to give a critical hit", new()
            {
                new("Sell Daidara Metalworks 1 3rd Boy's Talc (Marukyu Striptease, 5-6F, \"Rainy Brother 3\", Rainy weather) and buy it.", "¥28000")
            }),
            new(User.Protagonist, "Kenka", 248, 90, "", new()
            {
                new("Sell Daidara Metalworks 4 Prime Steel (Heaven, 6F, \"Stasis Giant\") and buy it.", "¥42000")
            }),
            new(User.Protagonist, "Metal Bat", 250, 30, "Increase chance to give a critical hit", new()
            {
                new("Gift from Margaret for completing 50% of active Social Links.", "")
            }),
            new(User.Protagonist, "Kijintou", 252, 98, "", new()
            {
                new("Sell Daidara Metalworks 6 Platinum Reins (Heaven, 8-9F, \"Intrepid Knight\") and buy it.", "¥43600")
            }),
            new(User.Protagonist, "El Caliente", 302, 98, "", new()
            {
                new("Sell Daidara Metalworks 4 Diamond Canine (Magatsu Inaba, 4-6F, \"SHADOWNAME\") and buy it.", "¥50000")
            }),
            new(User.Protagonist, "Shichisei-Ken", 310, 95, "", new()
            {
                new("Sell Daidara Metalworks 6 Brilliant Armor (Magatsu Mandala, 2-3F, \"Battle Wheel\") and buy it.", "¥52000")
            }),
            new(User.Protagonist, "Yahiro Sword", 320, 96, "", new()
            {
                new("Sell Daidara Metalworks 8 Spark Ornament (Magatsu Mandala, 4-6F, \"Judgement Sword\") and buy it.", "¥54000")
            }),
            new(User.Protagonist, "Triumph", 334, 94, "+5 Luck", new()
            {
                new("Sell Daidara Metalworks 4 Orichalcum (Magatsu Mandala, 6F, \"Solemn Machine\") and buy it.", "¥56000")
            }),
            new(User.Protagonist, "Light Sword", 334, 94, "+5 Luck (Added sound effect when swung)", new()
            {
                new("Exchange Triumph with the Artisan Apprentice.", "¥56000")
            }),
            new(User.Protagonist, "Tajikarao Sword", 345, 85, "", new()
            {
                new("Sell Daidara Metalworks 4 Crown of Truth (Yomotsu Hirasaka, 3-4F, \"Grudge Tower\") and buy it.", "¥58000")
            }),
            new(User.Protagonist, "Futsuno Mitama", 360, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Ripper Horse (Yomotsu Hirasaka, 5-6F, \"Jotun of Grief\") and buy it.", "¥61600")
            }),
            new(User.Protagonist, "Soul Crusher", 372, 88, "Low chance to inflicit Exhaust", new()
            {
                new("Sell Daidara Metalworks 10 Soul-Death Steel (Yomotsu Hirasaka, 7-8F, \"Void Giant\") and buy it.", "¥63600")
            }),
            new(User.Protagonist, "Tsubaki-Otoshi", 390, 98, "Increase chance to give a critical hit", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new(User.Protagonist, "Blade of Totsuka", 408, 96, "Greatly increase chance to give a critical hit", new()
            {
                new("Defeat the Reaper.", "")
            }),
            new(User.Yosuke, "Happy Maracas", 25, 92, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Mondo Stone.", "")
            }),
            new(User.Yosuke, "Monkey Wrench", 40, 90, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Yosuke, "Hunting Nata", 48, 96, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥4000")
            }),
            new(User.Yosuke, "Kunai", 55, 95, "", new()
            {
                new("Sell Daidara Metalworks 6 Light Iron (The Castle, 3-5F, \"Magic Hand\") and buy it.", "¥10000")
            }),
            new(User.Yosuke, "Poison Kunai", 64, 92, "Low chance to inflict Poison", new()
            {
                new("Sell Daidara Metalworks 4 Poison Flower (The Castle, 3-5F, \"Secret Bambino\") and buy it.", "¥11800")
            }),
            new(User.Yosuke, "Reign Skinner", 80, 98, "High chance to inflict any ailment", new()
            {
                new("Sell Daidara Metalworks 1 4th Girl's Talc (The Steamy Bathhouse, 7-8F, \"4th Girl's Talc\") and buy it.", "¥18000")
            }),
            new(User.Yosuke, "Skill Spanner", 83, 86, "Increase max SP by 50", new()
            {
                new("Go to The Twisted Shopping District (First dungeon) on 5/1", "")
            }),
            new(User.Yosuke, "Strange Daggers", 84, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Yosuke, "Bowling Pin", 85, 99, "+Auto-Sukukaja", new()
            {
                new("Go to Shiroku pub and trade 5 Lolite & 1 Kingyou Stone.", "")
            }),
            new(User.Yosuke, "Santou", 95, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Gray Shackle (The Steamy Bathhouse, 9-10F, \"Killer Twins\") and buy it.", "¥19600")
            }),
            new(User.Yosuke, "Kozuka", 122, 93, "", new()
            {
                new("Sell Daidara Metalworks 6 Hard Rock (Marukyu Striptease, 1-4F, \"Creation Relic\") and buy it.", "¥22000")
            }),
            new(User.Yosuke, "Throwing Kunai", 138, 98, "+2 Agility", new()
            {
                new("Sell Daidara Metalworks 10 Haori Iron (Marukyu Striptease, 5-8F, \"Venus Eagle\") and buy it.", "¥24000")
            }),
            new(User.Yosuke, "Kitchen Knife", 140, 90, "+10 Strength", new()
            {
                new("Bought from the TV shopping show on 7/24.", "¥11800"),
                new("Bought from the TV shopping show on 8/7.", "¥12800")
            }),
            new(User.Yosuke, "Kris Naga", 146, 94, "Increase max SP by 30", new()
            {
                new("Sell Daidara Metalworks 6 Sharp Thorn (Marukyu Striptease, 9-10F, \"Mighty Cyclops\") and buy it.", "¥25600")
            }),
            new(User.Yosuke, "Kaiken", 153, 93, "", new()
            {
                new("Sell Daidara Metalworks 6 Steel Thorn (The Void Quest, 1-2F, \"Mad Cyclops\") and buy it.", "¥26400")
            }),
            new(User.Yosuke, "Yashioori Dagger", 153, 93, "Low chance to inflict Confuse", new()
            {
                new("Sell Daidara Metalworks 6 Alluring Lily (The Void Quest, 7-8F, \"Avarice Bambino\") and buy it.", "¥26900")
            }),
            new(User.Yosuke, "Pinwheels", 158, 90, "High chance to inflict Poison", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Yosuke, "Bashin", 168, 96, "", new()
            {
                new("Sell Daidara Metalworks 6 Alloy Signature (The Void Quest, 5-6F, \"Blue Sigil\") and buy it.", "¥28000")
            }),
            new(User.Yosuke, "Thief Dagger", 170, 74, "", new()
            {
                new("Found in golden chests in: The Void Quest.", ""),
                new("Bought from the TV shopping show on 8/28.", "¥20800")
            }),
            new(User.Yosuke, "Yashima", 174, 98, "", new()
            {
                new("Sell Daidara Metalworks 6 Trial Obsidian (The Void Quest, 7-9F, \"Leading Idol\") and buy it.", "¥30000")
            }),
            new(User.Yosuke, "En-Giri", 188, 96, "Low chance to inflict Fear", new()
            {
                new("Sell Daidara Metalworks 4 Iron Barrel (The Secret Laboratory, 3-4F, \"Dismayed Panzer\") and buy it.", "¥32000")
            }),
            new(User.Yosuke, "Fearful Kunai", 203, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Shining Dish (The Secret Laboratory, 5-6F, \"World Balance\") and buy it.", "¥34000")
            }),
            new(User.Yosuke, "Bloody Kunai", 216, 94, "Increase Wind damage by 25%", new()
            {
                new("Sell Daidara Metalworks 1 1st Boy's Talc (The Secret Laboratory, 1-2F, \"Rainy Brother 1\", Rainy weather) and buy it.", "¥37600")
            }),
            new(User.Yosuke, "Castilla Knife", 222, 98, "+3 Endurance", new()
            {
                new("Sell Daidara Metalworks 6 Black Sheet (The Secret Laboratory, 7-8F, \"Wicked Turret\") and buy it.", "¥38000")
            }),
            new(User.Yosuke, "Titanium Wrench", 233, 80, "+1 Strength", new()
            {
                new("Go to Samegawa Riverbank and trade 4 Huge Fish for it. (October)", ""),
                new("Go to Shiroku pub and trade 5 Buffalo Stone & 1 Takou Stone.", "")
            }),
            new(User.Yosuke, "Ohorinomikoto", 238, 96, "Reduce Fire damage by 30&", new()
            {
                new("Sell Daidara Metalworks 4 Flame Scale (Heaven, 1-2F, \"Finicky Papillon\") and buy it.", "¥40000")
            }),
            new(User.Yosuke, "Flying Kato", 240, 94, "Increase chance to give critical attacks", new()
            {
                new("Sell Daidara Metalworks 8 Treasure Cloth (Heaven, 3-5F, \"Phantom Lord\") and buy it.", "¥41600")
            }),
            new(User.Yosuke, "Basho", 252, 95, "", new()
            {
                new("Sell Daidara Metalworks 6 Perpetual Edge (Heaven, 8-9F, \"Conviction Sword\") and buy it.", "¥43600")
            }),
            new(User.Yosuke, "Fuuma Kotaro", 280, 98, "+5 Magic", new()
            {
                new("Sell Daidara Metalworks 4 Nightmare Sand (Magatsu Inaba, 1-2F, \"Infinite Sand\") and buy it.", "¥48000")
            }),
            new(User.Yosuke, "Megaphone", 284, 92, "Increase max HP by 40", new()
            {
                new("Go to Shiroku pub and trade 5 Sunstone & 1 Ryugu Stone.", "")
            }),
            new(User.Yosuke, "Militia Dagger", 294, 96, "", new()
            {
                new("Sell Daidara Metalworks 4 Unthinkable Metal (Magatsu Mandala, 4-6F, \"Happy Gene\") and buy it.", "¥50000")
            }),
            new(User.Yosuke, "Hattori", 311, 98, "+3 to all stats", new()
            {
                new("Sell Daidara Metalworks 4 Knowledge Staff (Magatsu Mandala, 4-5F, \"Reformed Okina\") and buy it.", "¥52000")
            }),
            new(User.Yosuke, "Blitz Knife", 320, 86, "", new()
            {
                new("Sell Daidara Metalworks 6 Cruel Thorn (Magatsu Mandala, 6F, \"Brilliant Cyclops\") and buy it.", "¥54000")
            }),
            new(User.Yosuke, "Ogre Tooth", 336, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Mobius Sand (Yomotsu Hirasaka, 1-2F, \"Eternal Sand\") and buy it.", "¥57600")
            }),
            new(User.Yosuke, "Rappa", 350, 96, "", new()
            {
                new("Sell Daidara Metalworks 10 Sephirot Staff (Yomotsu Hirasaka, 5-6F, \"Moon Okina\") and buy it.", "¥59600")
            }),
            new(User.Yosuke, "Kashin Koji", 361, 96, "Medium chance to inflict any ailment", new()
            {
                new("Sell Daidara Metalworks 10 Vengeance Steel (Yomotsu Hirasaka, 7-8F, \"Reckoning Dice\") and buy it.", "¥61600")
            }),
            new(User.Yosuke, "Malakh", 398, 98, "High chance to evade Physical attacks", new()
            {
                new("Defeat the Reaper with Yosuke in party.", "")
            }),
            new(User.Chie, "Leather Shoes", 38, 94, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Chie, "Platform Sneaks", 45, 98, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥7600")
            }),
            new(User.Chie, "Spring Boots", 50, 70, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 5 Magatsu Xandrite & 1 Kaiou Stone.", "")
            }),
            new(User.Chie, "Shield Boots", 62, 92, "+2 Endurance", new()
            {
                new("Sell Daidara Metalworks 6 Hard Horn (The Castle, 6-7F, \"Burning Beetle\") and buy it.", "¥11200")
            }),
            new(User.Chie, "Inline Skates", 71, 95, "Increase resistance to Panic", new()
            {
                new("Go to Shiroku pub and trade 5 Blue Quartz.", "")
            }),
            new(User.Chie, "Nanman Gusoku", 75, 92, "+1 Agility", new()
            {
                new("Sell Daidara Metalworks 10 Golden Dish (The Castle, 6-7F, \"Heat Balance\") and buy it.", "¥13600")
            }),
            new(User.Chie, "Loose Socks", 83, 85, "Increase max SP by 20", new()
            {
                new("Go to Shiroku pub and trade 5 Blue Quartz & 1 Gyosen Stone.", "")
            }),
            new(User.Chie, "punk Shoes", 92, 92, "Low chance to inflict rage", new()
            {
                new("Sell Daidara Metalworks 6 Tough Hide (The Steamy Bathhouse, 1-2F, \"Bribed Fuzz\") and buy it.", "¥20000")
            }),
            new(User.Chie, "Strange Greaves", 96, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Chie, "Hard Boots", 108, 90, "+2 Strength", new()
            {
                new("Sell Daidara Metalworks 10 Thick Hide (The Steamy Bathhouse, 5-8F, \"Dancing Hand\") and buy it.", "¥21200")
            }),
            new(User.Chie, "Adios Shoes", 110, 82, "+3 Agility", new()
            {
                new("Bought from the TV shopping show on 5/22.", "¥5980")
            }),
            new(User.Chie, "Kintabi Gusoku", 125, 70, "", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse.", "")
            }),
            new(User.Chie, "Skill Greaves", 133, 90, "+1 to all stats", new()
            {
                new("Sell Daidara Metalworks 6 Rubbery Object (Marukyu Striptease, 1-4F, \"Miss Gene\") and buy it.", "¥25600")
            }),
            new(User.Chie, "Cowboy Boots", 150, 92, "", new()
            {
                new("Sell Daidara Metalworks 10 Sturdy Molar (Marukyu Striptease, 5-8F, \"Forgotten Hablerie\") and buy it.", "¥26800")
            }),
            new(User.Chie, "Heavy Heels", 167, 94, "", new()
            {
                new("Sell Daidara Metalworks 6 Wrought Lamp (Marukyu Striptease, 3-4F, \"Sonic Raven\") and buy it.", "¥28400")
            }),
            new(User.Chie, "Bishamonten", 182, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Jet Black Scale (The Void Quest, 1-4F, \"Lustful Snake\") and buy it.", "¥31600")
            }),
            new(User.Chie, "Foot Maces", 187, 90, "Reduce Fire damage by 20%", new()
            {
                new("Go to Shiroku pub and trade 5 Bloodstone & 2 Takou Stone.", "")
            }),
            new(User.Chie, "Furinkazan", 193, 98, "High chance to inflict Enervate", new()
            {
                new("Sell Daidara Metalworks 6 Platinum Crown (The Void Quest, 1-2F, \"Corrupt Tower\") and buy it.", "¥33200")
            }),
            new(User.Chie, "Steel Slippers", 199, 87, "+2 to all stats", new()
            {
                new("Go to Samegawa Riverbank and trade 8 Amber Seema for it. (September)", ""),
                new("Go to Shiroku pub and trade 5 Milky Quartz & 1 Ryugu Stone.", "")
            }),
            new(User.Chie, "Bucking Broncos", 205, 92, "", new()
            {
                new("Sell Daidara Metalworks 4 Stone Hide (The Secret Laboratory, 1-2F, \"Constancy Relic\") and buy it.", "¥35600")
            }),
            new(User.Chie, "Sleipnir", 218, 92, "+5 Agility", new()
            {
                new("Sell Daidara Metalworks 6 Stretchy Object (The Secret Laboratory, 5-6F, \"Fail Gene\") and buy it.", "¥37200")
            }),
            new(User.Chie, "Amami Legs", 220, 80, "High chance to counter Physical attacks", new()
            {
                new("Sell Daidara Metalworks 1 Curious Boulder (The Void Quest, 1-2F, \"Rainy Castle\", Rainy weather) and buy it.", "¥32800")
            }),
            new(User.Chie, "Four Beasts", 225, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Riveted Hide (The Secret Laboratory, 7-8F, \"Jotun of Power\") and buy it.", "¥38000")
            }),
            new(User.Chie, "Vampire Shoes", 243, 94, "Medium chance to inflict Fear", new()
            {
                new("Sell Daidara Metalworks 4 Crimson Cover (Heaven, 2-4F, \"Maniacal Book\") and buy it.", "¥41200")
            }),
            new(User.Chie, "Mjolnir Boots", 253, 92, "Increase chance to give a critical hit", new()
            {
                new("Sell Daidara Metalworks 6 Cursed Stone (Heaven, 3-5F, \"Curse Dice\") and buy it.", "¥43600")
            }),
            new(User.Chie, "Nice Shoes", 260, 78, "Medium chance to evade Physical attacks", new()
            {
                new("Bought from the TV shopping show on 10/9.", "¥28800"),
                new("Bought from the TV shopping show on 11/13.", "¥19800")
            }),
            new(User.Chie, "Vidar's Boots", 264, 94, "", new()
            {
                new("Sell Daidara Metalworks 8 Bloody Hide (Heaven, 8-9F, \"Jotun of Blood\") and buy it.", "¥45200")
            }),
            new(User.Chie, "Demon Boots", 296, 96, "", new()
            {
                new("Sell Daidara Metalworks 4 Miracle Scale (Magatsu Inaba, 1-2F, \"Fickle Papillon\") and buy it.", "¥50000")
            }),
            new(User.Chie, "Hero Legs", 300, 92, "+4 Luck", new()
            {
                new("Sell Daidara Metalworks 4 Snow Stone (Magatsu Mandala, 1F, \"King Castle\") and buy it.", "¥51200")
            }),
            new(User.Chie, "Kehaya", 310, 94, "+3 Magic", new()
            {
                new("Sell Daidara Metalworks 4 Prime Hide (Magatsu Mandala, 4-6F, \"Phantom King\") and buy it.", "¥52000")
            }),
            new(User.Chie, "Gigant Fall", 325, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Platinum Hide (Magatsu Mandala, 6F, \"Minotaur I\") and buy it.", "¥55200")
            }),
            new(User.Chie, "Peerless Heels", 338, 92, "", new()
            {
                new("Sell Daidara Metalworks 4 Love Scale (Yomotsu Hirasaka, 1-3F, \"Pure Papillon\") and buy it.", "¥57600")
            }),
            new(User.Chie, "Judgement Boots", 349, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Death Sentence (Yomotsu Hirasaka, 5-6F, \"Eternal Eagle\") and buy it.", "¥59000")
            }),
            new(User.Chie, "Stella Greaves", 362, 96, "+5 Strength", new()
            {
                new("Sell Daidara Metalworks 10 Tyrannical Hide (Yomotsu Hirasaka, 8F, \"Neo Minotaur\") and buy it.", "¥61200")
            }),
            new(User.Chie, "Red-Leaf Gusoku", 380, 70, "", new()
            {
                new("Go to Samegawa Riverbank and trade 10 Genji Ayu for it. (November)", ""),
                new("Go to Shiroku pub and trade 5 Angelite & 1 Ryugu Stone.", "")
            }),
            new(User.Chie, "Moses Sandals", 412, 95, "High chance to give a critical hit", new()
            {
                new("Defeat the Reaper with Chie in party.", "")
            }),
            new(User.Yukiko, "Kyo Sensu", 36, 94, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Yukiko, "Santa Fan", 45, 85, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 5 Magatsu Xandrite & 1 Mondo Stone.", "")
            }),
            new(User.Yukiko, "Strange Fan", 72, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Yukiko, "Noh Fan", 74, 95, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥11200")
            }),
            new(User.Yukiko, "Festival Fan", 80, 90, "+3 Magic", new()
            {
                new("Go to Shiroku pub and trade 5 Smoky Quartz.", "")
            }),
            new(User.Yukiko, "Silk Fan", 85, 92, "", new()
            {
                new("Sell Daidara Metalworks 10 Cloth Wings (The Steamy Bathhouse, 1-2F 5-10F, \"Monopolizing Cupid\") and buy it.", "¥12400")
            }),
            new(User.Yukiko, "Arazuyu Fan", 89, 96, "Increase resistance to Silence", new()
            {
                new("Sell Daidara Metalworks 1 4th Boy's Talc (The Steamy Bathhouse, 1-2F, \"Rainy Brother 4\", Rainy weather) and buy it.", "¥13800")
            }),
            new(User.Yukiko, "Suzaku Feather", 92, 92, "Increase max SP by 50", new()
            {
                new("Defeat the optional boss in The Castle.", "")
            }),
            new(User.Yukiko, "Tesseb", 108, 94, "+4 Strength", new()
            {
                new("Sell Daidara Metalworks 6 Passion Clasp (Marukyu Striptease, 1-4F, \"Soul Dancer\") and buy it.", "¥19600")
            }),
            new(User.Yukiko, "Hanachirusato", 123, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Glossy Clasp (Marukyu Striptease, 5-10F, \"Killing Hand\") and buy it.", "¥21600")
            }),
            new(User.Yukiko, "Masquerade", 134, 92, "", new()
            {
                new("Sell Daidara Metalworks 10 Tortoise Shell (Marukyu Striptease, 7-8F, \"Large Basalt\") and buy it.", "¥23600")
            }),
            new(User.Yukiko, "Flying Disc", 137, 95, "Medium chance to evade Physical attacks", new()
            {
                new("Go to Shiroku pub and trade 5 Smoky Quartz & 1 Kingyou Stone.", "")
            }),
            new(User.Yukiko, "Harlot's Mercy", 140, 60, "", new()
            {
                new("Found in golden chests in: The Marukyu Striptease.", "")
            }),
            new(User.Yukiko, "Madam's Charm", 145, 92, "Medium chance to inflict Confuse", new()
            {
                new("Sell Daidara Metalworks 6 Devilish Feather (The Void Quest, 3-4F, \"Amenti Raven\") and buy it.", "¥25600")
            }),
            new(User.Yukiko, "Duchess", 150, 80, "High chance to inflict Confuse", new()
            {
                new("Go to Samegawa Riverbank and trade 3 Inaba Trout for it. (June)", ""),
                new("Go to Shiroku pub and trade 5 Lepidolite & 1 Ryugu Stone.", "")
            }),
            new(User.Yukiko, "Inversion Fan", 150, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Gazing Clasp (The Void Quest, 3-4F, \"Fate Seeker\") and buy it.", "¥26800")
            }),
            new(User.Yukiko, "Bat Saucer", 153, 91, "+Auto-Sukukaja", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Yukiko, "Amagyou Fan", 162, 94, "High chance to inflict Silence", new()
            {
                new("Sell Daidara Metalworks 1 2nd Girl's Talc (The Void Quest, 3-4F, \"Rainy Sister 2\", Rainy weather) and buy it.", "¥28000")
            }),
            new(User.Yukiko, "Mogari Bue", 170, 98, "", new()
            {
                new("Sell Daidara Metalworks 4 Azalea Cord (The Secret Laboratory, 1-2F, \"Inviting Nyogo\") and buy it.", "¥29600")
            }),
            new(User.Yukiko, "Fickle Madam", 173, 95, "Low chance to inflict Rage", new()
            {
                new("Sell Daidara Metalworks 10 Dogma Clasp (The Secret Laboratory, 3-4F, \"Dogmatic Tower\") and buy it.", "¥32400")
            }),
            new(User.Yukiko, "Akisame Fan", 180, 50, "+10 Luck", new()
            {
                new("Sell Daidara Metalworks 1 3rd Girl's Talc (Marukyu Striptease, 1-4F, \"Rainy Sister 3\", Rainy weather) and buy it.", "¥25000")
            }),
            new(User.Yukiko, "Tambourine", 182, 90, "+3 to all Stats", new()
            {
                new("Go to Shiroku pub and trade 5 Milky Quartz & 1 Taisui Stone.", "")
            }),
            new(User.Yukiko, "Ganar", 186, 98, "", new()
            {
                new("Sell Daidara Metalworks 6 Fur Clasp (The Secret Laboratory, 7-8F, \"Elegant Mother\") and buy it.", "¥32000")
            }),
            new(User.Yukiko, "Courtesia", 208, 95, "Increase max SP by 10", new()
            {
                new("Sell Daidara Metalworks 4 Smart Clasp (Heaven, 1-2F, \"Prime Magus\") and buy it.", "¥36400")
            }),
            new(User.Yukiko, "Adoracion", 218, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Scorching Scale (Heaven, 3-4F, \"Carnal Snake\") and buy it.", "¥37400")
            }),
            new(User.Yukiko, "Uhi Fan", 220, 92, "Increase resistance to Exhaustion", new()
            {
                new("Sell Daidara Metalworks 1 Rare Raincoat (Heaven, 2-4F, \"Raindrop Castle\") and buy it.", "¥38000")
            }),
            new(User.Yukiko, "Suzumushi", 235, 95, "", new()
            {
                new("Sell Daidara Metalworks 6 Blessed Dish (Heaven, 5-7F, \"Light Balance\") and buy it.", "¥40000")
            }),
            new(User.Yukiko, "Noblesse Oblige", 260, 94, "", new()
            {
                new("Sell Daidara Metalworks 4 God Tailfeather (Magatsu Inaba, 1-2F, \"Jupiter Eagle\") and buy it.", "¥44400")
            }),
            new(User.Yukiko, "Hototogisu", 272, 92, "+10 Magic", new()
            {
                new("Sell Daidara Metalworks 4 Love Clasp (Magatsu Mandala, 4-5F, \"Harem Dancer\") and buy it.", "¥46000")
            }),
            new(User.Yukiko, "Secret Fan", 278, 96, "", new()
            {
                new("Sell Daidara Metalworks 4 Golden Film (Magatsu Mandala, 6F, \"Noble Seeker\") and buy it.", "¥47200")
            }),
            new(User.Yukiko, "Kacho Fugetsu", 293, 95, "Medium chance to inflict Enervate", new()
            {
                new("Sell Daidara Metalworks 4 Red-Gold Cord (Yomotsu Hirasaka, 2-3F, \"Silent Nyogo\") and buy it.", "¥50000")
            }),
            new(User.Yukiko, "Pieta", 300, 97, "", new()
            {
                new("Sell Daidara Metalworks 10 Merciless Cord (Yomotsu Hirasaka, 7-8F, \"El Dorado Beast\") and buy it.", "¥51200")
            }),
            new(User.Yukiko, "Yume no Ukihashi", 328, 98, "Increase resistance to Confusion", new()
            {
                new("Sell Daidara Metalworks 10 Forbidden Scale (Yomotsu Hirasaka, 6-7F, \"Stoic Snake\") and buy it.", "¥56000")
            }),
            new(User.Yukiko, "Boundless Sea", 395, 98, "High chance to inflict Exhaustion", new()
            {
                new("Defeat the Reaper with Yukiko in party.", "")
            }),
            new(User.Kanji, "Folding Chair", 45, 95, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Kanji, "Christmas Wreath", 48, 84, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 5 Magatus Xansrite & 1 Kaisou Stone.", "")
            }),
            new(User.Kanji, "Yasogami Desk", 92, 90, "", new()
            {
                new("Buy from Daidara Metalworks.", "¥16000")
            }),
            new(User.Kanji, "Half-Sized Tatami", 95, 89, "Low chance to inflict Enervate", new()
            {
                new("Go to Shiroku pub and trade 5 Fluorite.", "")
            }),
            new(User.Kanji, "Strange Shield", 103, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Kanji, "Iron Plate", 113, 92, "+2 Magic", new()
            {
                new("Defeat the optional boss in The Steamy Bathhouse.", "")
            }),
            new(User.Kanji, "Steel Plate", 142, 90, "", new()
            {
                new("Sell Daidara Metalworks 6 Heavy Iron Lump (Marukyu Striptease, 5-10F, \"Liberating Idol\") and buy it.", "¥24400")
            }),
            new(User.Kanji, "Photon Plate", 158, 90, "", new()
            {
                new("Sell Daidara Metalworks 10 Steel Collar (Marukyu Striptease, 5-8F, \"Enslaved Beast\") and buy it.", "¥28000")
            }),
            new(User.Kanji, "Hard Board", 162, 92, "Reduce Fire damage by 20%", new()
            {
                new("Sell Daidara Metalworks 6 Dependent Iron (The Void Quest, 1-2F, \"Dependent Basalt\") and buy it.", "¥28800")
            }),
            new(User.Kanji, "Thunder Plate", 172, 96, "Increase Electricity damage by 25%", new()
            {
                new("Sell Daidara Metalworks 6 Electric Rock (The Void Quest, 5-6F, \"Almighty Hand\") and buy it.", "¥30000")
            }),
            new(User.Kanji, "Bodyboard", 174, 94, "Increase resitance to Exhaustion", new()
            {
                new("Go to Shiroku pub and trade 5 Lepidolite & 2 Gyosen Stone.", "")
            }),
            new(User.Kanji, "Power Plate", 180, 92, "+3 Strength", new()
            {
                new("Sell Daidara Metalworks 10 Chirping Wings (The Void Quest, 3-4F, \"Blind Cupid\") and buy it.", "¥31200")
            }),
            new(User.Kanji, "Alloyed Plate", 192, 94, "", new()
            {
                new("Sell Daidara Metalworks 4 Super-Alloy (The Void Quest, 9F, \"Scarlet Turret\") and buy it.", "¥33000")
            }),
            new(User.Kanji, "Bath Lid", 198, 55, "Medium chance to inflict Rage", new()
            {
                new("Go to Samegawa Riverbank and trade 1 Huge Fish for it. (July)", ""),
                new("Go to Shiroku pub and trade 5 Howlite & 1 Ryugu Stone.", "")
            }),
            new(User.Kanji, "Gorgon Plate", 205, 94, "Increase resistance to Fear", new()
            {
                new("Sell Daidara Metalworks 4 Source Lump (The Secret Laboratory, 1-2F, \"Source Basalt\") and buy it.", "¥35200")
            }),
            new(User.Kanji, "Scutum", 220, 90, "", new()
            {
                new("Sell Daidara Metalworks 6 Illusionary Sand (The Secret Laboratory, 3-4F, \"Flowing Sand\") and buy it.", "¥38000")
            }),
            new(User.Kanji, "Barbarian Shield", 235, 94, "Increase max HP by 30", new()
            {
                new("Sell Daidara Metalworks 10 Platinum Lump (The Secret Laboratory, 5-6F, \"Chaos Fuzz\") and buy it.", "¥40000")
            }),
            new(User.Kanji, "Golden Plate", 246, 96, "", new()
            {
                new("Sell Daidara Metalworks 10 Fixed Lump (The Secret Laboratory, 7-8F, \"Order Giant\") and buy it.", "¥42000")
            }),
            new(User.Kanji, "Demon Shield", 252, 92, "+4 Endurance", new()
            {
                new("Sell Daidara Metalworks 4 Jet Black Steel (Heaven, 2F, \"Dark Eagle\") and buy it.", "¥43200")
            }),
            new(User.Kanji, "Death Scudetto", 260, 50, "+2 Luck", new()
            {
                new("Found in golden chests in: The Secret Laboratory.", ""),
                new("Bought from the TV shopping show on 9/25.", "¥28800")
            }),
            new(User.Kanji, "Mega Buckler", 264, 94, "Increase chance to give a critical hit", new()
            {
                new("Sell Daidara Metalworks 6 Divine Bark (Heaven, 5-7F, \"Angry Table\") and buy it.", "¥45200")
            }),
            new(User.Kanji, "Oni-Gawara", 280, 88, "", new()
            {
                new("Sell Daidara Metalworks 8 Heavy Chains (Heaven, 8-9F, \"Minotaur IV\") and buy it.", "¥45200")
            }),
            new(User.Kanji, "Big Symbal", 290, 91, "Increase max SP by 30", new()
            {
                new("Go to Shiroku pub and trade 5 Aurora Quartz & 1 Maguro Stone.", "")
            }),
            new(User.Kanji, "Colored Bench", 305, 99, "Low chance to inflict any ailment", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Kanji, "Sol Breaker", 318, 96, "Reduce fire damage by 10%", new()
            {
                new("Sell Daidara Metalworks 4 Dignified Lump (Magatsu Mandala, 1F, \"Great King\") and buy it.", "¥54000")
            }),
            new(User.Kanji, "Phalanx", 322, 94, "", new()
            {
                new("Sell Daidara Metalworks 4 Scaly Lump (Magatsu Mandala, 1-3F 6F, \"Amorous Snake\") and buy it.", "¥54800")
            }),
            new(User.Kanji, "Asturias", 332, 96, "", new()
            {
                new("Sell Daidara Metalworks 4 Death Lump (Magatsu Mandala, 4-5F, \"Death Dice\") and buy it.", "¥56400")
            }),
            new(User.Kanji, "Black Targe", 346, 92, "", new()
            {
                new("Sell Daidara Metalworks 4 Golden Chains (Magatsu Mandala, 6F, \"Minotaur II\") and buy it.", "¥58800")
            }),
            new(User.Kanji, "Aegis Shield", 357, 94, "+10 Endurance", new()
            {
                new("Sell Daidara Metalworks 4 Platinum Shell (Yomotsu Hirasaka, 2-3F, \"Emperor Beetle\") and buy it.", "¥60000")
            }),
            new(User.Kanji, "Dullahan", 368, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Holy Gold Lump (Yomotsu Hirasaka, 4-5F, \"Doom Sword\") and buy it.", "¥62000")
            }),
            new(User.Kanji, "Christ Mirror", 382, 94, "", new()
            {
                new("Sell Daidara Metalworks 10 Platinum Gear (Yomotsu Hirasaka, 7F, \"Rampage Drive\") and buy it.", "¥64000")
            }),
            new(User.Kanji, "Perun Plate", 432, 92, "Increase Electricity damge by 25%", new()
            {
                new("Defeat the Reaper with Kanji in party.", "")
            }),
            new(User.Teddie, "Animal Paw", 40, 80, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Mondo Stone.", "")
            }),
            new(User.Teddie, "Spikey punch", 44, 95, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Teddie, "Strange Claw", 78, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Teddie, "Mewling Claw", 154, 86, "+4 Agility", new()
            {
                new("Buy from Daidara Metalworks.", "¥26600")
            }),
            new(User.Teddie, "Bear Claw", 161, 78, "Low chance to counter Physical attacks", new()
            {
                new("Defeat the optional boss in The Marukyu Striptease.", "")
            }),
            new(User.Teddie, "Crab Claw", 160, 85, "High chance to inflict silence", new()
            {
                new("Go to Shiroku pub and trade 5 Olive Quartz & 2 Takou Stone.", "")
            }),
            new(User.Teddie, "Drunken Fist", 172, 98, "Medium chance to inflict Exhaustion", new()
            {
                new("Sell Daidara Metalworks 6 Shiny Scale (The Void Quest, 5-6F, \"Whimsical Papillon\") and buy it.", "¥30000")
            }),
            new(User.Teddie, "Cute Assassin", 180, 95, "+5 Strength", new()
            {
                new("Go to Samegawa Riverbank and trade 6 Red Goldfish for it. (August)", ""),
                new("Go to Shiroku pub and trade 5 Lemon Quartz & 1 Ryugu Stone.", "")
            }),
            new(User.Teddie, "Fuuma Bundou", 190, 94, "", new()
            {
                new("Bought from the TV shopping show on 9/11.", "¥27800")
            }),
            new(User.Teddie, "Typhoon Claw", 200, 70, "High chance to inflict Fear", new()
            {
                new("Sell Daidara Metalworks 1 2nd Boy's Talc (The Void Quest, 7-8F, \"Rainy Brother 2\", Rainy weather) and buy it.", "¥32800")
            }),
            new(User.Teddie, "Air Break", 205, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Sharp Premolar (The Secret Laboratory, 1-2F, \"Flattering Hablerie\") and buy it.", "¥36800")
            }),
            new(User.Teddie, "Poison Claw", 218, 84, "High chance to inflict Poison", new()
            {
                new("Sell Daidara Metalworks 6 Venomous Fang (The Secret Laboratory, 5-6F, \"Immoral Snake\") and buy it.", "¥37200")
            }),
            new(User.Teddie, "Hyper Drill", 225, 89, "+Auto-Tarukaja", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Teddie, "Mail Duster", 232, 92, "", new()
            {
                new("Sell Daidara Metalworks 10 Guard Stationary (The Secret Laboratory, 7-8F, \"Truth Pesce\") and buy it.", "¥40000")
            }),
            new(User.Teddie, "Assault Spike", 240, 93, "", new()
            {
                new("Sell Daidara Metalworks 4 Claw of Myth (Heaven, 2F, \"Mythical Gigas\") and buy it.", "¥41200")
            }),
            new(User.Teddie, "Gehenna Claw", 254, 92, "", new()
            {
                new("Sell Daidara Metalworks 6 Thirsty Claw (Heaven, 5F, \"Dry Dixie\") and buy it.", "¥43600")
            }),
            new(User.Teddie, "Chain Glove", 271, 87, "", new()
            {
                new("Sell Daidara Metalworks 8 Blade Thorn (Heaven, 6-7F, \"Chaos Cyclops\") and buy it.", "¥46000")
            }),
            new(User.Teddie, "Strega Claw", 300, 74, "", new()
            {
                new("Found in golden chests in: Heaven.", "")
            }),
            new(User.Teddie, "Pure Assassin", 300, 75, "Medium chance to inflict Poison", new()
            {
                new("Bought from the TV shopping show on 10/23.", "¥29800")
            }),
            new(User.Teddie, "Needle Spike", 322, 86, "High chance to inflict Rage", new()
            {
                new("Sell Daidara Metalworks 4 Queen's Nail (Magatsu Mandala, 1F, \"Pistil Mother\") and buy it.", "¥54800")
            }),
            new(User.Teddie, "Seiryu Claw", 334, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Silver Claw (Magatsu Mandala, 4-5F, \"Change Relic\") and buy it.", "¥56800")
            }),
            new(User.Teddie, "Jakotsu Claw", 345, 95, "", new()
            {
                new("Sell Daidara Metalworks 4 Strength Claw (Magatsu Mandala, 6F, \"Minotaur III\") and buy it.", "¥58800")
            }),
            new(User.Teddie, "Platinum Claw", 358, 96, "+3 Endurance", new()
            {
                new("Sell Daidara Metalworks 4 Force Rock (Yomotsu Hirasaka, 2-3F, \"Primitive Idol\") and buy it.", "¥60000")
            }),
            new(User.Teddie, "Reindeer Hoof", 362, 50, "Increase change to give a critical hit", new()
            {
                new("Go to Shiroku pub and trade 5 Moonstone & 3 Taisui Stone.", "")
            }),
            new(User.Teddie, "The Ripper", 365, 92, "", new()
            {
                new("Sell Daidara Metalworks 10 Bloody Thorn (Yomotsu Hirasaka, 6-7F, \"Rebellious Cyclops\") and buy it.", "¥62000")
            }),
            new(User.Teddie, "Shitisei Jakotsu", 371, 96, "+4 Magic", new()
            {
                new("Sell Daidara Metalworks 10 Mysterious Eye (Yomotsu Hirasaka, 7F, \"Acheron Seeker\") and buy it.", "¥62800")
            }),
            new(User.Teddie, "Seireiga", 406, 94, "Reduce magical damage by 30%", new()
            {
                new("Defeat the Reaper with Teddie in party.", "")
            }),
            new(User.Naoto, "Rubber Band Gun", 35, 95, "+50% EXP", new()
            {
                new("Go to Shiroku pub and trade 8 Magatsu Xandrite & 1 Kaiou Stone.", "")
            }),
            new(User.Naoto, "Nambu 2", 80, 95, "", new()
            {
                new("[Default]", "")
            }),
            new(User.Naoto, "Strange Firearm", 87, 99, "", new()
            {
                new("Hollow Forest equipment.", "")
            }),
            new(User.Naoto, "Frost Shot", 190, 85, "Increase Ice damge by 25%", new()
            {
                new("Go to Shiroku pub and trade 5 Rose Quatz & 2 Masuda Stone.", "")
            }),
            new(User.Naoto, "Water Gun", 216, 80, "Medium chance to inflict Rage", new()
            {
                new("Go to Shiroku pub and trade 5 Sphalerite & 1 Masuda Stone.", "")
            }),
            new(User.Naoto, "Raging Bull", 220, 88, "", new()
            {
                new("Sell Daidara Metalworks 2 Steel Barrel (Heaven, 2F, \"Rash Panzer\") and buy it.", "¥38000")
            }),
            new(User.Naoto, "Algernon", 230, 85, "+5 to all stats", new()
            {
                new("Defeat the optional boss in The Secret Laboratory.", "")
            }),
            new(User.Naoto, "Crimson Dirge", 240, 94, "", new()
            {
                new("Sell Daidara Metalworks 6 Fixing Bolt (Heaven, 3-4F, \"Killer Drive\") and buy it.", "¥42000")
            }),
            new(User.Naoto, ".44 Anaconda", 246, 94, "", new()
            {
                new("Sell Daidara Metalworks 6 Judgement Shot (Heaven, 8-9F, \"Hallowed Turret\") and buy it.", "¥43200")
            }),
            new(User.Naoto, "Flintlock", 254, 90, "Increase max SP by 30", new()
            {
                new("Fish at Shichiri Beach.", "")
            }),
            new(User.Naoto, "Chrome Heart", 275, 95, "Medium chance to inflict Silence", new()
            {
                new("Sell Daidara Metalworks 4 Orb of Love (Magatsu Mandala, 1-3F, \"Yearning Pot\") and buy it.", "¥46800")
            }),
            new(User.Naoto, "Jovian Thunder", 290, 98, "", new()
            {
                new("Sell Daidara Metalworks 4 Gold Signature (Magatsu Mandala, 2-3F, \"Purple Sigil\") and buy it.", "¥49200")
            }),
            new(User.Naoto, "Unlimited", 301, 95, "+3 Luck", new()
            {
                new("Sell Daidara Metalworks 4 Thunder Bead (Magatsu Mandala, 4-5F, \"Jotun of Evil\") and buy it.", "¥50000")
            }),
            new(User.Naoto, "Camel Red", 310, 98, "", new()
            {
                new("Sell Daidara Metalworks 4 Golden Barrel (Magatsu Mandala, 6F, \"Conceited Panzer\") and buy it.", "¥52800")
            }),
            new(User.Naoto, "Machine Pistol", 312, 93, "+10 Endurance", new()
            {
                new("Go to Shiroku pub and trade 5 Rainbow Quartz & 3 Yazu Stone.", "")
            }),
            new(User.Naoto, "From Zero", 325, 96, "Increase chance to give a critical hit", new()
            {
                new("Sell Daidara Metalworks 4 Prophecy Orb (Yomotsu Hirasaka, 1F, \"Wrathful Book\") and buy it.", "¥56000")
            }),
            new(User.Naoto, "Athena Kiss R", 342, 95, "Medium chance to inflict Confuse", new()
            {
                new("Sell Daidara Metalworks 10 Pure White Bead (Yomotsu Hirasaka, 4-5F, \"Gracious Cupid\") and buy it.", "¥58800")
            }),
            new(User.Naoto, "Judge of Hell", 360, 96, "", new()
            {
                new("Sell Daidara Metalworks 10 Bull's-Eye Shot (Yomotsu Hirasaka, 6F, \"Berserk Turret\") and buy it.", "¥62800")
            }),
            new(User.Naoto, "Magatsu Kiba", 370, 74, "High chance to inflict Fear", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", "")
            }),
            new(User.Naoto, "Black Hole", 406, 96, "High chance to inflict any Ailment", new()
            {
                new("Defeat the Reaper with Naoto in party.", "")
            })
        };
    }
}
