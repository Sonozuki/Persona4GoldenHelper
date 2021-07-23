using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The accessory data.</summary>
    public static class AccessoryData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The accessory data.</summary>
        public static List<Accessory> Accessories { get; } = new()
        {
            new("Alarm Clock", "Prevents Dizzy", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Aluminum Badge", "", new()
            {
                new("[Chie's default]", "")
            }),
            new("Amaterasu Fob", "Increase max HP by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory, Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Amulet", "+1 Endurance", new()
            {
                new("Buy from Daidara Metalworks.", "¥3000")
            }),
            new("Awareness Note", "Reduce enemy's chance to get a preemptive attack", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory, Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Barbaric Bracers", "2x chance to dodge attacks", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Bat Charm", "+3 Magic", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Bead Ring (Protagonist Only)", "Increase chance of evading magical attacks", new()
            {
                new("Earn the top score in the October exams, then talk to Nanako in the evening.", "")
            }),
            new("Bear's Ears", "", new()
            {
                new("[Teddie's default]", "")
            }),
            new("Black Cat Charm", "+4 Magic", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Black Feather", "Increase resistance to Darkness", new()
            {
                new("Sell Daidara Metalworks 10 Black Signature (Heaven, 6-7F, \"Green Sigil\") and buy it.", "¥12000"),
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Blaze Pin", "Reduce Fire damage by 30%", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Blaze Vow", "Increase Fire damage by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory.", "")
            }),
            new("Blessed Hands", "Increase healing spells effect by 50%", new()
            {
                new("Sell Daidara Metalworks 10 Activated Felt (Magatsu Mandala, 6F, \"Earnest Carothy\") and buy it.", "¥40000"),
                new("Found in golden chests in: The Void Quest, The Secret Laboratory, Heaven, Magatsu Inaba, Yomotsu Hirasaka.", ""),
                new("Go to Samegawa Riverbank and trade 4 Amber Seema for it. (July)", "")
            }),
            new("Blizzard Pin", "Reduce Ice damage by 30%", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Blizzard Vow", "Increase Ice damage by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory.", "")
            }),
            new("Bold Ball", "Prevents Fear", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Book of Ruin", "Status ailments last 50% as long", new()
            {
                new("Found in golden chests in: Marukyu Striptease.", "")
            }),
            new("Book of Serenity", "Status ailments are recovered in 1 turn", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory, Heaven.", "")
            }),
            new("Book of the Void", "Prevents Rage, Fear, Silence, Enervation, and Confusion", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Bravery Vessel", "Reduce chance of Fear", new()
            {
                new("Sell Daidara Metalworks 10 Brave Lumber (The Steamy Bathhouse, 9-10F, \"Crying Table\") and buy it.", "¥18000"),
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Cat Whisker", "Increase chance of evading Magical attacks", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Chakra Ring", "Decrease SP cost for Magical attacks by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Confusion Hat", "Prevents Confusion", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Cool Beads", "Reduce chance of Rage", new()
            {
                new("Sell Daidara Metalworks 10 Quiet Bouquet (Marukyu Striptease, 7-8F, \"Blooming Bambino\") and buy it.", "¥18000"),
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Crow Charm", "+2 Magic", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Defense Essence", "+10 Endurance", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Demon Charm", "+10 Magic", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Disguise Mask", "Reduce chance of Silence", new()
            {
                new("Sell Daidara Metalworks 10 Decorative Stone (The Steamy Bathhouse, 7-8F, \"Tranquil Idol\") and buy it.", "¥18000"),
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Disinfectant", "Reduce chance of Poison", new()
            {
                new("Sell Daidara Metalworks 10 Beard Fiber (The Steamy Bathhouse, 7-8F, \"Egotistical King\") and buy it.", "¥18000"),
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Divine Pillar", "Decrease received damage by 50%, but unable to dodge", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Eagle Eye", "Greatly increase chance of evading Physical attacks", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", ""),
                new("Go to Samegawa Riverbank and trade 3 Huge Fish for it. (October)", "")
            }),
            new("Earth Badge", "Restores 4% HP at the start of each turn", new()
            {
                new("Sell Daidara Metalworks 10 Ill Will Claw (Yomotsu Hirasaka, 1-2F, \"Crazy Twins\") and buy it.", "¥30000"),
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Eye of Flame", "Greatly increase chance of evading Fire attacks", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Eye of Ice", "Greatly increase chance of evading Ice attacks", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Eye of Thunder", "Greatly increase chance of evading Electricity attacks", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Eye of Wind", "Greatly increase chance of evading Wind attacks", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Falcon Eye", "Increase chance of evading Physical attacks", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", ""),
                new("Go to Samegawa Riverbank and trade 3 Amber Seema for it. (May)", "")
            }),
            new("Fancy Mini-Car (Protagonist Only)", "Increase success rates of Darkness spells", new()
            {
                new("Christmas event (Yumi).", "")
            }),
            new("Feather Strap", "+1 Agility", new()
            {
                new("Sell Daidara Metalworks 10 Moustache Fiber (The Castle, 4-5F, \"Positive King\") and buy it.", "¥3000")
            }),
            new("Feng Shui Brace", "+1 to all stats", new()
            {
                new("Sell Daidara Metalworks 10 Bronze Reins (The Castle, 6-7F, \"Avenger Knight\") and buy it.", "¥9000")
            }),
            new("Festival Drum", "+5 Strength", new()
            {
                new("Sell Daidara Metalworks 10 Windcutter Cloth (The Secret Laboratory, 3-4F, \"Shallow Okina\") and buy it.", "¥15000")
            }),
            new("Fire Pin", "Reduce Fire damage by 10%", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Fire Suppressor", "Increase chance of evading Fire attacks", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", ""),
                new("Bought from the TV shopping show on 6/12.", "¥4980")
            }),
            new("Fire Vow", "Increase Fire damage by 10%", new()
            {
                new("Found in golden chests in: The Castle.", "")
            }),
            new("Flame Pin", "Reduce Fire damage by 20%", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Flame Vow", "Increase Fire damage by 20%", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease.", "")
            }),
            new("Flight Strap", "+3 Magic", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Fluffy Muffler (Protagonist Only)", "Increase resistance from Ice attacks", new()
            {
                new("Christmas event (Chie).", "")
            }),
            new("Frozen Rose", "Prevents Rage", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Gale Pin", "Reduce Wind damage by 40%", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", "")
            }),
            new("Gale Vow", "Increase Wind damage by 40%", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba.", "")
            }),
            new("Gas Mask", "Prevents Poison", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("God's Love", "+10 to all stats", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Guard Amulet", "+3 Endurance", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Guard Rosary", "+5 Endurance", new()
            {
                new("Sell Daidara Metalworks 10 Hard Thorn (The Secret Laboratory, 7-8F, \"Fierce Cyclops\") and buy it.", "¥15000")
            }),
            new("Gust Pin", "Reduce Wind damage by 20%", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Gust Vow", "Increase Wind damage by 20%", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease.", "")
            }),
            new("Hair Band", "", new()
            {
                new("[Yukiko's default]", "")
            }),
            new("Hand-Knit Mitten (Protagonist Only)", "Increase success rates of Light spells", new()
            {
                new("Christmas event (Ayane).", "")
            }),
            new("Handmade Watch (Protagonist Only)", "Increase chance of status effects", new()
            {
                new("Christmas event (Naoto).", "")
            }),
            new("Headband", "+1 Strength", new()
            {
                new("Buy from Daidara Metalworks.", "¥3000")
            }),
            new("Healthy Homa", "Prevents Exhaustion", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Healthy Recipe", "Reduce chance of Exhaustion", new()
            {
                new("Sell Daidara Metalworks 10 Paleograph (The Void Quest, 2-4F, \"Spurious Book\") and buy it.", "¥18000"),
                new("Found in golden chests in: Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Ice Pin", "Reduce Ice damage by 10%", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Ice Suppressor", "Increase chance of evading Ice attacks", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Ice Vow", "Increase Ice damage by 10%", new()
            {
                new("Found in golden chests in: The Castle.", "")
            }),
            new("Icicle Pin", "Reduce Ice damage by 40%", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", "")
            }),
            new("Icicle Vow", "Increase Ice damage by 40%", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba.", "")
            }),
            new("Inferno Pin", "Reduce Fire damage by 40%", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", "")
            }),
            new("Inferno Vow", "Increase Fire damage by 40%", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba.", "")
            }),
            new("Iron Charm", "+4 Endurance", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Kagutsuchi Pin", "Reduce Fire damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Kagutsuchi Vow", "Increase Fire damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Kid's Hachimaki", "Reduce chance of Enervation", new()
            {
                new("Sell Daidara Metalworks 10 Guard Cloth (The Void Quest, 9F, \"Protective Rexy\") and buy it.", "¥18000"),
                new("Found in golden chests in: Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Kimyaku Brace", "+2 to all stats", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Kuraokami Pin", "Reduce Ice damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Kuraokami Vow", "Increase Ice damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Land Badge", "Restores 2% HP at the start of each turn", new()
            {
                new("Sell Daidara Metalworks 10 Life Collar (The Steamy Bathhouse, 3-6F, \"Nizam Beast\") and buy it.", "¥25000"),
                new("Found in golden chests in: The Void Quest.", ""),
                new("Go to Samegawa Riverbank and trade 1 Huge Fish for it. (June)", "")
            }),
            new("Leather Keychain (Protagonist Only)", "Increase resistance from Fire attacks", new()
            {
                new("Christmas event (Yukiko).", "")
            }),
            new("Life Fob", "", new()
            {
                new("Increase max HP by 20%", "¥25000")
            }),
            new("Lightning Pin", "Reduce Electricity damage by 40%", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", "")
            }),
            new("Lightning Vow", "Increase Electricity damage by 40%", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba.", "")
            }),
            new("Lizard Charm", "+1 Magic", new()
            {
                new("Sell Daidara Metalworks 1 Big Incisor (The Castle, 1F, \"Lying Hablerie\") and buy it.", "¥3000")
            }),
            new("Lucky Coin", "+1 Luck", new()
            {
                new("Sell Daidara Metalworks 20 Black Lamp (The Castle, 3-7F, \"Black Raven\") and buy it.", "¥3000")
            }),
            new("Lucky Seven", "+10 Luck", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Macho Medal (Protagonist Only)", "Increase resistance from Physical attacks", new()
            {
                new("Christmas event ([Male party members]).", "")
            }),
            new("Mage's Mark", "Restores 3 SP at the start of each turn", new()
            {
                new("Sell Daidara Metalworks 10 Magic Cloth (The Steamy Bathhouse, 3-4F, \"Phantom Master\") and buy it.", "¥25000"),
                new("Found in golden chests in: The Void Quest.", "")
            }),
            new("Maneki Neko", "+4 Luck", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", ""),
                new("Bought from the TV shopping show on 7/31.", "¥7980")
            }),
            new("Mask of Truth", "Prevents Silence", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Moon Potpourri", "Increase max SP by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory, Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Omega Drive", "Increase chance to give a critical hit", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Omnipotent Orb", "Nullifies all attacks except Almighty", new()
            {
                new("Defeat the Reaper.", "")
            }),
            new("Ouryu Brace", "+5 to all stats", new()
            {
                new("Sell Daidara Metalworks 10 Torrent Gear (Magatsu Mandala, 6F, \"Slaughter Drive\") and buy it.", "¥30000")
            }),
            new("Paper Armband (Protagonist Only)", "+5 to all stats", new()
            {
                new("Earn the top score in the July exams, then talk to Nanako in the evening.", "")
            }),
            new("Partial Award (Protagonist Only)", "Restore 1HP when HP reaches 0 (1 use per battle)", new()
            {
                new("Earn the top score in the December exams, then check Nanako's seat in the evening.", "")
            }),
            new("Patient Collar", "Restore 1HP when HP reaches 0 (1 use per battle)", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest, The Secret Laboratory, Heaven.", "")
            }),
            new("Pegasus Strap", "+5 Agility", new()
            {
                new("Sell Daidara Metalworks 10 Mental Thread (The Secret Laboratory, 7-8F, \"Mind Dice\") and buy it.", "¥15000")
            }),
            new("Pitch Pipes", "Prevents Enervation", new()
            {
                new("Found in golden chests in: Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Plain Ring", "", new()
            {
                new("[Yosuke's default]", "")
            }),
            new("Plum Potpourri", "Increase max SP by 10%", new()
            {
                new("Sell Daidara Metalworks 10 Idea Paper (The Castle, 1F, \"Calm Pesce\") and buy it.", "¥12000")
            }),
            new("Portrait Medal (Protagonist Only)", "+5 Strength", new()
            {
                new("Earn the top score in the May exams, then talk to Nanako in the evening.", "")
            }),
            new("Power Belt", "+2 Strength", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", ""),
                new("Bought from the TV shopping show on 6/19.", "¥4980")
            }),
            new("Power Muscle", "+10 Strength", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Power Tasuki", "+3 Strength", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Rabbit Foot", "+2 Luck", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Reader King (Protagonist Only)", "+10 magic", new()
            {
                new("Read all 20 books.", "")
            }),
            new("Rebirth Prophecy", "Restore all HP when HP reaches 0 (1 use per battle)", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Reisen Brace", "+4 to all stats", new()
            {
                new("Found in golden chests in: Magatsu Inaba.", ""),
                new("Bought from the TV shopping show on 11/13.", "¥19800")
            }),
            new("Reprisal Chain", "15% chance to counter Physical attacks", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", ""),
                new("Bought from the TV shopping show on 9/18.", "¥21800")
            }),
            new("Retribution Mask", "20% chance to counter Physical attacks", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Revenge Ring", "10% chance to counter Physical attacks", new()
            {
                new("Sell Daidara Metalworks 10 Selfish Ornament (The Steamy Bathhouse, 7-8F, \"Selfish Basalt\") and buy it.", "¥30000"),
                new("Found in golden chests in: The Void Quest.", "")
            }),
            new("Rudra Ring", "Decrease HP cost for Physical attacks by 50%", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Rugged Ring (Protagonist Only)", "Increase healing spell effects", new()
            {
                new("Christmas event (Ai).", "")
            }),
            new("Ryumyaku Brace", "+3 to all stats", new()
            {
                new("Found in golden chests in: The Secret Laboratory.", "")
            }),
            new("Safety Belt", "Reduce chance of Dizzy", new()
            {
                new("Sell Daidara Metalworks 10 Ruinous Crown (Magatsu Mandala, 1-3F, \"Fanatic Tower\") and buy it.", "¥18000"),
                new("Found in golden chests in: Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Shinatobe Pin", "Reduce Wind damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Shinatobe Vow", "Increase Wind damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Sigma Drive", "", new()
            {
                new("Decrease chance to receive a critical hit", "¥30000"),
                new("Found in golden chests in: The Secret Laboratory, Heaven, Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Silver Bangle (Protagonist Only)", "Increase max SP by 50%", new()
            {
                new("Christmas event (Rise).", "")
            }),
            new("Silver Locket", "", new()
            {
                new("[Kanji's default]", "")
            }),
            new("Silver Spoon", "+3 Luck", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Snow Pin", "Reduce Ice damage by 20%", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Snow Vow", "Increase Ice damage by 20%", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease.", "")
            }),
            new("Sorcerer's Mark", "Restores 5 SP at the start of each turn", new()
            {
                new("Sell Daidara Metalworks 10 Silver Fox Fur (Yomotsu Hirasaka, 1F, \"Divine Mother\") and buy it.", "¥30000"),
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Soul Potpourri", "", new()
            {
                new("Increase max SP by 20%", "¥25000")
            }),
            new("Space Badge", "Restores 6% HP at the start of each turn", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Spark Pin", "Reduce Electricity damage by 20%", new()
            {
                new("Found in golden chests in: Marukyu Striptease, The Void Quest.", "")
            }),
            new("Spark Vow", "Increase Electricity damage by 20%", new()
            {
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease.", "")
            }),
            new("Speed Star", "+10 Agility", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Spiral Earrings", "", new()
            {
                new("[Naoto's default]", "")
            }),
            new("Spirit Hachimaki", "+4 Strength", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Steed Strap", "+4 Agility", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Storm Pin", "Reduce Wind damage by 30%", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Storm Vow", "Increase Wind damage by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory.", "")
            }),
            new("Takefutsu Pin", "Reduce Electricity damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Takefutsu Vow", "Increase Electricity damage by 50%", new()
            {
                new("Found in golden chests in: Yomotsu Hirasaka.", "")
            }),
            new("Talisman", "+2 Endurance", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Thunder Pin", "Reduce Electricity damage by 10%", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Thunder Vow", "Increase Electricity damage by 10%", new()
            {
                new("Found in golden chests in: The Castle.", "")
            }),
            new("Tranquil Buddha", "Reduce chance of Confusion", new()
            {
                new("Sell Daidara Metalworks 10 Safety Angle (Marukyu Striptease, 7-8F, \"Adamant Beetle\") and buy it.", "¥18000"),
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Vigor Fob", "Increase max HP by 10%", new()
            {
                new("Sell Daidara Metalworks 10 Big Incisor (The Castle, 1F, \"Lying Hablerie\") and buy it.", "¥12000")
            }),
            new("Volt Pin", "Reduce Electricity damage by 30%", new()
            {
                new("Found in golden chests in: The Secret Laboratory, Heaven.", "")
            }),
            new("Volt Suppressor", "Increase chance of evading Electricity attacks", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Volt Vow", "Increase Electricity damage by 30%", new()
            {
                new("Found in golden chests in: The Void Quest, The Secret Laboratory.", "")
            }),
            new("White Feather", "Increase resistance to Light", new()
            {
                new("Sell Daidara Metalworks 10 Crystal of Light (Heaven, 5-7F, \"Devoted Cupid\") and buy it.", "¥12000"),
                new("Found in golden chests in: The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Wind Pin", "Reduce Wind damage by 10%", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Wind Suppressor", "Increase chance of evading Wind attacks", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse, Marukyu Striptease, The Void Quest, The Secret Laboratory.", "")
            }),
            new("Wind Vow", "Increase Wind damage by 10%", new()
            {
                new("Found in golden chests in: The Castle.", "")
            }),
            new("Wing Strap", "+2 Agility", new()
            {
                new("Found in golden chests in: The Castle, The Steamy Bathhouse.", "")
            }),
            new("Witch Charm", "+5 Magic", new()
            {
                new("Sell Daidara Metalworks 10 Silver Signature (The Secret Laboratory, 3-4F, \"Red Sigil\") and buy it.", "¥15000")
            }),
            new("Wizard's Mark", "Restores 7 SP at the start of each turn", new()
            {
                new("Found in golden chests in: Magatsu Inaba, Yomotsu Hirasaka.", "")
            }),
            new("Wooden Ebisu", "+5 Luck", new()
            {
                new("Sell Daidara Metalworks 10 Yellow Cord (The Secret Laboratory, 1-2F, \"Royal Dancer\") and buy it.", "¥15000")
            }),
            new("Wristwatch", "", new()
            {
                new("[Protagonist's default]", "")
            })
        };
    }
}
