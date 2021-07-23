using Persona4GoldenHelper.Shared;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The shadow data.</summary>
    public static class ShadowData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The shadow data.</summary>
        public static List<Shadow> Shadows { get; } = new()
        {
            new(ShadowType.Normal, "Acheron Seeker", 79, 346, 208, 2630, "¥430",
                stats: new(43, 22, 62, 54, 44),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Galgalim Eyes", "Stagnant Air", "Tentarafoo", "Mind Slice" }
            ),
            new(ShadowType.Normal, "Adamant Beetle", 33, 140, 116, 550, "¥250",
                stats: new(32, 17, 10, 22, 21),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bash", "Swift Strike", "Stagnant Air" }
            ),
            new(ShadowType.Normal, "Agitating Hablerie", 66, 238, 280, 2670, "¥360",
                stats: new(46, 52, 25, 43, 37),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Ziodyne", "Mazionga" }
            ),
            new(ShadowType.Normal, "Almighty Hand", 40, 284, 238, 900, "¥280",
                stats: new(28, 28, 32, 32, 20),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Diarama", "Rebellion", "White Wall", "God's Hand", "Null Mute", "Null Dizzy" }
            ),
            new(ShadowType.MiniBoss, "Almighty Hand", 40, 284, 238, 900, "¥280",
                stats: new(28, 28, 32, 32, 20),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Diarama", "Patra", "Posumudi", "Mutudi", "Nervundi", "Re Patra" }
            ),
            new(ShadowType.Boss, "Ameno-sagiri", 75, 8000, 2500, 28729, "¥3000",
                stats: new(58, 66, 64, 72, 46),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agneyastra", "Agidyne", "Maragidyne", "Bufudyne", "Mabufudyne", "Ziodyne", "Maziodyne", "Garudyne", "Magarudyne", "Megidola", "Mind Charge", "God's Judgement", "Foolish Whisper", "Tarukaja", "Rakukaja", "Sukukaja", "Debilitate", "Dekaja", "Dekunda", "Nebula Oculus", "Quake", "Bewildering Fog", "Galgalim Eyes" }
            ),
            new(ShadowType.Normal, "Amenti Raven", 39, 155, 117, 760, "¥270",
                stats: new(18, 28, 18, 30, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Power Charge", "Assault Dive", "Gale Slash" }
            ),
            new(ShadowType.Normal, "Amorous Snake", 69, 268, 183, 3760, "¥370",
                stats: new(48, 26, 48, 45, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Poison Arrow", "Blight", "Life Leech", "Poison Boost" }
            ),
            new(ShadowType.MiniBoss, "Amorous Snake", 33, 1012, 148, 6300, "¥260",
                stats: new(19, 38, 26, 21, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Stagnant Air", "Virus Wave", "Mind Slice" }
            ),
            new(ShadowType.Normal, "Angry Table", 62, 345, 270, 2310, "¥270",
                stats: new(38, 18, 42, 40, 41),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Auto-Mataru", "Balzac", "Valiant Dance", "Resist Dizzy" }
            ),
            new(ShadowType.Normal, "Anguish Basalt", 41, 122, 19, 600, "¥280",
                stats: new(35, 18, 31, 11, 23),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Agi", "Zio", "Cruel Attack" }
            ),
            new(ShadowType.Normal, "Apostate Tower", 59, 286, 327, 2150, "¥270",
                stats: new(25, 36, 40, 42, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Mazionga", "Ziodyne", "Fire Break", "Ice Break", "Elec Break", "Wind Break" }
            ),
            new(ShadowType.Normal, "Arcane Turret", 35, 546, 264, 2000, "¥260",
                stats: new(26, 28, 23, 24, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bufudyne", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Ardent Dancer", 44, 163, 231, 950, "¥290",
                stats: new(21, 32, 16, 31, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Garula", "Atom Smasher", "Tempest Slash" }
            ),
            new(ShadowType.Normal, "Autonomic Basalt", 16, 161, 13, 120, "¥190",
                stats: new(25, 10, 8, 2, 4),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Attack" }
            ),
            new(ShadowType.Normal, "Avarice Bambino", 42, 172, 167, 810, "¥290",
                stats: new(30, 23, 28, 28, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mind Slice", "Life Drain", "Bash" }
            ),
            new(ShadowType.Normal, "Avenger Knight", 15, 300, 87, 485, "¥250",
                stats: new(9, 8, 6, 8, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Red Wall", "Power Charge", "Skewer", "Poison Skewer", "Mudo" }
            ),
            new(ShadowType.MiniBoss, "Avenger Knight", 11, 900, 87, 900, "¥200",
                stats: new(7, 9, 10, 6, 13),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Tarukaja", "Red Wall", "Power Charge", "Skewer", "Poison Skewer", "Mudo" }
            ),
            new(ShadowType.Normal, "Battle Wheel", 72, 278, 194, 3740, "¥380",
                stats: new(43, 42, 28, 45, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Black Spot", "Vorpal Blade", "Auto-Masuku" }
            ),
            new(ShadowType.Normal, "Beastly Gigas", 45, 234, 94, 1100, "¥290",
                stats: new(30, 20, 30, 29, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Sonic Punch", "Assault Dive", "Swift Strike" }
            ),
            new(ShadowType.Normal, "Berserk Turret", 80, 621, 174, 1680, "¥430",
                stats: new(53, 62, 64, 57, 52),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agidyne", "Garudyne", "Bufudyne", "Ziodyne", "Mind Charge", "Megidolaon" }
            ),
            new(ShadowType.Normal, "Black Raven", 7, 138, 25, 48, "¥120",
                stats: new(8, 4, 4, 5, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tarukaja" }
            ),
            new(ShadowType.Normal, "Blind Cupid", 38, 210, 6, 550, "¥270",
                stats: new(18, 28, 26, 30, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Diarama", "Poison Arrow" }
            ),
            new(ShadowType.Normal, "Blooming Bambino", 33, 260, 194, 500, "¥250",
                stats: new(19, 25, 3, 22, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bufula", "Mabufula", "Life Drain" }
            ),
            new(ShadowType.Normal, "Blossom Nyogo", 63, 205, 188, 2210, "¥280",
                stats: new(41, 34, 46, 42, 33),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Blade of Fury", "Hysterical Slap", "Dodge Ice" }
            ),
            new(ShadowType.Normal, "Blue Sigil", 42, 339, 329, 940, "¥280",
                stats: new(17, 29, 29, 25, 25),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Megido", "Tetrakarn", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Brave Wheel", 57, 368, 173, 2250, "¥300",
                stats: new(32, 34, 39, 40, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Heat Wave", "Torrent Shot", "Power Charge" }
            ),
            new(ShadowType.Normal, "Bribed Fuzz", 17, 152, 88, 200, "¥190",
                stats: new(20, 6, 15, 8, 4),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Single Shot" }
            ),
            new(ShadowType.Normal, "Brilliant Cyclops", 73, 324, 285, 4820, "¥390",
                stats: new(60, 40, 45, 46, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Heat Wave", "Primal Force", "Assault Dive" }
            ),
            new(ShadowType.Normal, "Brilliant King", 81, 346, 256, 2230, "¥440",
                stats: new(54, 51, 61, 62, 48),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Summon", "Summon", "Summon", "Summon", "Summon", "Summon", "Auto-Masuku", "Evade Elec", "Hysterical Slap", "Diarahan" }
            ),
            new(ShadowType.Normal, "Bronze Dice", 10, 180, 34, 184, "¥200",
                stats: new(8, 5, 6, 6, 7),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Poisma", "Last Resort" }
            ),
            new(ShadowType.Normal, "Burning Beetle", 13, 132, 51, 298, "¥230",
                stats: new(9, 6, 13, 9, 12),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Bash", "Tarukaja" }
            ),
            new(ShadowType.Normal, "Calm Machine", 76, 1000, 310, 2500, "¥0",
                stats: new(55, 24, 35, 35, 45),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Null Dizzy", "Sharp Student", "Mighty Swing", "Herculean Strike", "Megidola", "Power Charge", "Rakukaja", "Makarakarn" }
            ),
            new(ShadowType.Normal, "Calm Pesce", 6, 82, 23, 40, "¥150",
                stats: new(6, 3, 4, 6, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Cleave" }
            ),
            new(ShadowType.Normal, "Carnal Snake", 59, 234, 137, 1920, "¥270",
                stats: new(37, 32, 30, 43, 34),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Crazy Chain", "Life Leech" }
            ),
            new(ShadowType.Normal, "Champion Knight", 34, 265, 116, 1500, "¥250",
                stats: new(28, 22, 22, 25, 16),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Power Charge" }
            ),
            new(ShadowType.Normal, "Change Relic", 74, 279, 485, 4900, "¥380",
                stats: new(55, 33, 40, 47, 33),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Old One", "Ziodyne", "Elec Boost" }
            ),
            new(ShadowType.Normal, "Chaos Cyclops", 63, 587, 318, 3170, "¥330",
                stats: new(40, 32, 35, 42, 34),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Mind Slice", "Aeon Rain", "Power Slash" }
            ),
            new(ShadowType.Normal, "Chaos Fuzz", 51, 341, 133, 1340, "¥310",
                stats: new(33, 30, 14, 30, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Foolish Whisper", "Rampage", "Cruel Attack" }
            ),
            new(ShadowType.MiniBoss, "Chaos Fuzz", 70, 600, 124, 1820, "¥44",
                stats: new(47, 34, 53, 45, 44),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Summon", "Summon", "Summon" }
            ),
            new(ShadowType.Normal, "Clear Sky Musha", 75, 1000, 555, 2400, "¥0",
                stats: new(17, 52, 10, 68, 58),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new() { "Hassou Tobi", "Tempest Slash", "Gale Slash", "Vicious Strike", "Primal Force", "Media", "Matarukaja", "Makarakarn" }
            ),
            new(ShadowType.Normal, "Cloudgirl Pot", 18, 175, 102, 260, "¥200",
                stats: new(13, 10, 14, 15, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Hysterical Slap" }
            ),
            new(ShadowType.Normal, "Conceited Panzer", 75, 320, 254, 5250, "¥400",
                stats: new(52, 49, 50, 49, 52),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Seal Bomb", "Mustard Bomb", "Virus Wave", "Mind Slice", "Navas Nebula", "Power Charge" }
            ),
            new(ShadowType.Normal, "Constancy Relic", 46, 240, 246, 1200, "¥290",
                stats: new(27, 29, 17, 31, 30),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Garudyne", "Anima Freeze", "Re Patra" }
            ),
            new(ShadowType.Normal, "Conviction Sword", 64, 320, 125, 2480, "¥350",
                stats: new(38, 36, 40, 45, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Rainy Death", "Matarukaja" }
            ),
            new(ShadowType.Normal, "Corrupt Tower", 36, 325, 209, 560, "¥260",
                stats: new(15, 21, 23, 26, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Balzac", "Diarama", "Mazionga", "Summon" }
            ),
            new(ShadowType.Normal, "Crazy Twins", 76, 385, 169, 2400, "¥440",
                stats: new(55, 38, 48, 52, 44),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None),
                skills: new() { "Dodge Fire", "Heat Wave", "Virus Wave", "Twin Shot", "Poison Boost" }
            ),
            new(ShadowType.Normal, "Creation Relic", 27, 159, 205, 450, "¥230",
                stats: new(15, 20, 12, 19, 18),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Old One", "Cell Breaker" }
            ),
            new(ShadowType.Normal, "Crying Table", 24, 139, 177, 440, "¥220",
                stats: new(12, 15, 15, 16, 12),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Makajam", "Diarama", "Magaru" }
            ),
            new(ShadowType.Normal, "Curse Dice", 60, 200, 271, 2410, "¥280",
                stats: new(25, 64, 41, 25, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Last Resort", "Marakukaja" }
            ),
            new(ShadowType.Normal, "Cursed Woman's Pot", 55, 55, 400, 1400, "¥0",
                stats: new(22, 62, 52, 50, 48),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Mazionga", "Spirit Drain", "Enervation", "Enervate Boost" }
            ),
            new(ShadowType.Normal, "Dancing Hand", 20, 135, 121, 240, "¥210",
                stats: new(12, 13, 8, 17, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Rebellion", "Stagnant Air", "Balzac" }
            ),
            new(ShadowType.Normal, "Daring Gigas", 19, 225, 46, 230, "¥200",
                stats: new(23, 6, 15, 15, 4),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Sonic Punch" }
            ),
            new(ShadowType.MiniBoss, "Daring Gigas", 24, 928, 100, 2800, "¥250",
                stats: new(21, 11, 17, 18, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Sonic Punch", "Rebellion", "Tarukaja", "Single Shot", "Counter" }
            ),
            new(ShadowType.Normal, "Dark Eagle", 57, 312, 197, 2250, "¥300",
                stats: new(36, 34, 26, 43, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Arm Chopper", "Evil Smile", "Ghastly Wail" }
            ),
            new(ShadowType.Normal, "Death Dice", 73, 44, 444, 4440, "¥380",
                stats: new(44, 44, 44, 44, 44),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Megidola", "Mind Charge", "Last Resort" }
            ),
            new(ShadowType.Normal, "Death Seeker", 28, 310, 339, 640, "¥230",
                stats: new(1, 25, 15, 16, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Zionga", "Mind Charge", "Mazio" }
            ),
            new(ShadowType.Normal, "Dependent Basalt", 36, 162, 23, 250, "¥200",
                stats: new(30, 20, 26, 10, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Bufu", "Mabufu" }
            ),
            new(ShadowType.Normal, "Devoted Cupid", 62, 258, 274, 1960, "¥250",
                stats: new(35, 37, 27, 47, 55),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agidyne", "Muzzle Shot", "Amrita" }
            ),
            new(ShadowType.Normal, "Dismayed Panzer", 48, 320, 164, 2000, "¥300",
                stats: new(38, 24, 25, 26, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Null),
                skills: new() { "Mustard Bomb", "Aeon Rain" }
            ),
            new(ShadowType.Normal, "Divine Mother", 76, 415, 400, 1980, "¥410",
                stats: new(22, 57, 52, 50, 48),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new() { "Agidyne", "Mabufudyne", "Maziodyne", "Media", "Summon" }
            ),
            new(ShadowType.Normal, "Dogmatic Tower", 48, 259, 339, 1210, "¥300",
                stats: new(29, 37, 20, 35, 30),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Ziodyne", "Cell Breaker", "Recarmdra" }
            ),
            new(ShadowType.Normal, "Dominating Machine", 57, 3500, 112, 5040, "¥330",
                stats: new(43, 31, 1, 40, 34),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Cruel Attack", "Power Charge" }
            ),
            new(ShadowType.MiniBoss, "Dominating Machine", 53, 3070, 300, 12400, "¥370",
                stats: new(39, 32, 44, 30, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Herculean Strike", "Power Charge", "Last Resort" }
            ),
            new(ShadowType.Normal, "Doom Sword", 79, 437, 149, 1690, "¥410",
                stats: new(70, 47, 39, 44, 48),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Atom Smasher", "Blade of Fury", "Vorpal Blade", "Fear Boost" }
            ),
            new(ShadowType.Normal, "Dry Dexy", 61, 265, 439, 1950, "¥260",
                stats: new(21, 35, 44, 45, 50),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bufula", "Mabufula", "Foolish Whisper", "Makajam" }
            ),
            new(ShadowType.Normal, "Earnest Calocy", 74, 420, 629, 4800, "¥390",
                stats: new(20, 54, 19, 52, 70),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Atom Smasher", "Arm Chopper", "Ghastly Wail", "Masukunda" }
            ),
            new(ShadowType.Normal, "Egotistical King", 23, 206, 105, 640, "¥220",
                stats: new(14, 16, 18, 15, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Mazio", "Twin Shot", "Summon" }
            ),
            new(ShadowType.Normal, "El Dorado Beast", 82, 412, 194, 2080, "¥440",
                stats: new(65, 50, 61, 49, 63),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new() { "Magarudyne", "Deathbound", "Makarakarn", "Wind Amp", "Regenerate 3", "Null Dizzy", "High Counter" }
            ),
            new(ShadowType.Normal, "Elegant Mother", 54, 250, 455, 2010, "¥320",
                stats: new(34, 47, 19, 36, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Heat Riser", "Bufula", "Mabufula", "Mediarama" }
            ),
            new(ShadowType.Normal, "Emaciated Garcy", 74, 500, 629, 3000, "¥0",
                stats: new(20, 54, 19, 52, 70),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new() { "Null Dizzy", "Maragi", "Mabufu", "Mazio", "Magaru", "Makarakarn", "Summon" }
            ),
            new(ShadowType.Normal, "Emperor Beetle", 77, 420, 231, 2190, "¥330",
                stats: new(58, 45, 55, 46, 40),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Regenerate 3", "Black Spot", "Gigantic Fist", "Primal Force", "Brave Blade" }
            ),
            new(ShadowType.Normal, "Enslaved Beast", 32, 250, 91, 430, "¥240",
                stats: new(26, 17, 14, 19, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Assault Dive", "Swift Strike" }
            ),
            new(ShadowType.Normal, "Escapist Soldier", 47, 3800, 1000, 10500, "¥1000",
                stats: new(48, 30, 20, 28, 18),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Arm Chopper", "Mind Slice", "Crazy Chain", "Blade of Fury", "Mudoon", "Foul Breath", "Stagnant Air" }
            ),
            new(ShadowType.Normal, "Eternal Eagle", 79, 200, 262, 1500, "¥420",
                stats: new(52, 51, 44, 70, 60),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Auto-Sukukaja", "Evil Touch", "Evil Smile", "Ghastly Wail", "Arm Chopper" }
            ),
            new(ShadowType.Normal, "Eternal Sand", 77, 337, 243, 2200, "¥370",
                stats: new(52, 42, 43, 55, 47),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null),
                skills: new() { "Brain Shake", "Navas Nebula", "Exhaust Boost" }
            ),
            new(ShadowType.Normal, "Execution Sword", 75, 777, 234, 2000, "¥0",
                stats: new(53, 30, 11, 52, 55),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Heaven's Blade", "Atom Smasher", "Debilitate", "Fear Boost", "Ghastly Wail" }
            ),
            new(ShadowType.MiniBoss, "Extreme Vessel", 57, 4800, 3000, 15000, "¥1000",
                stats: new(50, 45, 35, 56, 10),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Mind Charge", "Power Charge", "Rebellion", "Cruel Attack", "Agidyne", "Maragidyne", "Bufudyne", "Mabufudyne", "Ziodyne", "Maziodyne", "Garudyne", "Magarudyne", "Rampage", "God's Hand", "Virus Wave" }
            ),
            new(ShadowType.Normal, "Fail Gene", 52, 263, 315, 1150, "¥310",
                stats: new(30, 35, 15, 35, 39),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Red Wall", "White Wall", "Blue Wall", "Green Wall", "Tetrakarn", "Re Patra" }
            ),
            new(ShadowType.Normal, "Fanatic Tower", 69, 325, 422, 3850, "¥370",
                stats: new(45, 52, 24, 49, 41),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Matarukaja", "Marakunda", "Muzzle Shot", "Hamaon" }
            ),
            new(ShadowType.Normal, "Fate Seeker", 40, 200, 333, 820, "¥280",
                stats: new(21, 27, 22, 28, 21),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agilao", "Maragion" }
            ),
            new(ShadowType.Normal, "Fickle Papillon", 67, 224, 100, 2230, "¥360",
                stats: new(36, 45, 25, 48, 47),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Poison Skewer", "Cell Breaker", "Brain Shake", "Hysterical Slap" }
            ),
            new(ShadowType.Normal, "Fierce Cyclops", 53, 300, 397, 2520, "¥320",
                stats: new(36, 49, 25, 38, 18),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Megidola", "Counterstrike", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Finicky Papillon", 56, 227, 331, 1500, "¥240",
                stats: new(30, 55, 30, 44, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agi", "Garu", "Bufu", "Zio", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Flattering Hablerie", 47, 324, 199, 1220, "¥290",
                stats: new(33, 32, 16, 32, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant),
                skills: new() { "Agidyne", "Fire Break" }
            ),
            new(ShadowType.Normal, "Flowing Sand", 47, 274, 351, 1050, "¥290",
                stats: new(34, 30, 22, 33, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Sukunda", "Power Slash", "Deathbound" }
            ),
            new(ShadowType.Normal, "Forgotten Hablerie", 31, 220, 133, 430, "¥240",
                stats: new(20, 19, 8, 19, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agilao" }
            ),
            new(ShadowType.Normal, "Free Bambino", 66, 254, 170, 1820, "¥360",
                stats: new(30, 28, 27, 46, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Amrita", "Brave Blade", "Spirit Leech" }
            ),
            new(ShadowType.Normal, "Furious Gigas", 50, 318, 117, 1840, "¥310",
                stats: new(35, 26, 19, 35, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Rebellion", "Akasha Arts", "Gigantic Fist", "High Counter" }
            ),
            new(ShadowType.Normal, "Gauntlet Hand", 75, 600, 354, 1500, "¥0",
                stats: new(28, 20, 10, 44, 55),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "High Counter", "Agi", "Garu", "Bufu", "Zio", "Gigantic Fist", "Dodge Elec" }
            ),
            new(ShadowType.Normal, "Glorious Hand", 70, 9999, 777, 40000, "¥15000",
                stats: new(30, 30, 1, 85, 75),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Resistant, ElementAffinity.Resistant),
                skills: new() { "Agilao", "Garula", "Bufula", "Zionga", "Masukukaja", "Soul Break", "Pulinpa", "Poisma", "Enervation", "Makajam", "Counter", "Hama", "Mudo", "Hamaon", "Mudoon", "Heat Riser", "Rebellion" }
            ),
            new(ShadowType.Normal, "Golden Beetle", 40, 180, 164, 730, "¥280",
                stats: new(28, 20, 28, 27, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Mighty Swing", "Power Charge" }
            ),
            new(ShadowType.Normal, "Gracious Cupid", 79, 300, 252, 1860, "¥410",
                stats: new(46, 49, 42, 59, 56),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Matarukaja", "Marakukaja", "Amrita", "Re Patra", "Recarmdra", "Torrent Shot" }
            ),
            new(ShadowType.Normal, "Grand Magus", 79, 550, 644, 2390, "¥410",
                stats: new(40, 80, 40, 45, 55),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Maragi", "Magaru", "Mabufu", "Mazio", "Megidola", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Grave Beetle", 26, 180, 67, 330, "¥230",
                stats: new(20, 10, 24, 2, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new() { "Mamudo" }
            ),
            new(ShadowType.Normal, "Great King", 68, 359, 199, 4680, "¥370",
                stats: new(44, 37, 31, 46, 39),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new() { "Megidola", "Summon" }
            ),
            new(ShadowType.Normal, "Green Sigil", 63, 333, 424, 3110, "¥340",
                stats: new(25, 44, 40, 43, 37),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Magarula", "Mazionga", "Garula", "Zionga", "Foolish Whisper" }
            ),
            new(ShadowType.Normal, "Growth Relic", 56, 251, 282, 1520, "¥250",
                stats: new(33, 36, 33, 40, 33),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tarukaja", "Sukukaja", "Rakukaja", "Rebellion", "Poison Skewer" }
            ),
            new(ShadowType.Normal, "Grudge Tower", 78, 300, 475, 2480, "¥410",
                stats: new(42, 62, 52, 55, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Fire Break", "Ice Break", "Wind Break", "Elec Break", "Agidyne", "Garudyne", "Bufudyne", "Ziodyne" }
            ),
            new(ShadowType.Normal, "Hallowed Turret", 66, 776, 146, 4530, "¥360",
                stats: new(60, 20, 54, 29, 27),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Mind Charge", "Ziodyne", "Mahamaon" }
            ),
            new(ShadowType.Normal, "Happiness Hand", 10, 150, 100, 1500, "¥2000",
                stats: new(7, 7, 45, 25, 50),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant),
                skills: new() { "Agi", "Garu", "Bufu", "Zio", "Sukukaja", "Bash" }
            ),
            new(ShadowType.Normal, "Happy Gene", 73, 193, 354, 4370, "¥390",
                stats: new(45, 45, 31, 50, 46),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Tetrakarn", "Makarakarn", "Recarmdra", "Amrita", "Dodge Physical" }
            ),
            new(ShadowType.Normal, "Harem Dancer", 73, 368, 294, 3870, "¥380",
                stats: new(62, 50, 27, 47, 40),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Apt Pupil", "Mighty Swing", "Heat Riser" }
            ),
            new(ShadowType.Normal, "Harmonious Giant", 76, 250, 169, 1900, "¥0",
                stats: new(25, 12, 65, 72, 80),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mighty Swing", "Blight", "Virus Wave", "Poison Mist", "Poison Boost" }
            ),
            new(ShadowType.Normal, "Harmony Giant", 77, 305, 128, 5000, "¥430",
                stats: new(57, 50, 31, 58, 43),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Re Patra", "Tetrakarn", "Null Dizzy", "Red Wall", "White Wall", "Blue Wall", "Green Wall" }
            ),
            new(ShadowType.Normal, "Heartless Machine", 83, 100, 130, 8200, "¥450",
                stats: new(71, 56, 54, 54, 39),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agidyne", "Garudyne", "Bufudyne", "Ziodyne", "Megidolaon", "Rainy Death", "Vorpal Blade", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Heat Balance", 15, 140, 136, 210, "¥190",
                stats: new(5, 10, 7, 15, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None),
                skills: new() { "Agi", "Bufu", "Sukukaja", "Red Wall", "White Wall" }
            ),
            new(ShadowType.Normal, "Hell Knight", 55, 520, 153, 3780, "¥330",
                stats: new(44, 35, 28, 39, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mudoon", "Virus Wave" }
            ),
            new(ShadowType.Normal, "Idle Basalt", 29, 195, 27, 350, "¥230",
                stats: new(22, 15, 12, 14, 19),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { }
            ),
            new(ShadowType.Normal, "Immoral Snake", 52, 269, 148, 1530, "¥310",
                stats: new(38, 33, 18, 33, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Life Drain", "Spirit Drain", "Poison Mist", "Stagnant Air" }
            ),
            new(ShadowType.Normal, "Immortal Gigas", 52, 269, 148, 1530, "¥310",
                stats: new(38, 33, 18, 33, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Life Drain", "Spirit Drain", "Poison Mist", "Stagnant Air" }
            ),
            new(ShadowType.Normal, "Indignant Machine", 77, 888, 385, 4000, "¥0",
                stats: new(99, 77, 1, 43, 58),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Rampage", "Skull Cracker", "Fire Break", "Ice Break", "Elec Break", "Wind Break" }
            ),
            new(ShadowType.Normal, "Infinite Sand", 67, 256, 197, 2480, "¥360",
                stats: new(38, 32, 35, 47, 47),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Crazy Chain", "Rage Boost" }
            ),
            new(ShadowType.Normal, "Insolent Basalt", 45, 300, 25, 1150, "¥290",
                stats: new(31, 16, 20, 20, 20),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Last Resort", "Marakukaja" }
            ),
            new(ShadowType.MiniBoss, "Intolerant Officer", 27, 3000, 1000, 4650, "¥1000",
                stats: new(35, 28, 15, 12, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Single Shot", "Poison Arrow", "Bufula", "Garula" }
            ),
            new(ShadowType.Normal, "Intrepid Knight", 65, 562, 140, 5060, "¥360",
                stats: new(48, 34, 40, 46, 31),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Tempest Slash", "Blight", "Revolution", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Inviting Nyogo", 47, 358, 174, 1200, "¥290",
                stats: new(32, 28, 17, 32, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Hysterical Slap", "Twin Shot", "Torrent Shot" }
            ),
            new(ShadowType.Normal, "Iron Dice", 21, 178, 44, 280, "¥140",
                stats: new(11, 22, 10, 14, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Last Resort" }
            ),
            new(ShadowType.Normal, "Isolated Hand", 80, 550, 999, 10000, "¥10000",
                stats: new(55, 16, 62, 42, 99),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Megido", "Megidolaon", "Hamaon", "Mudoon" }
            ),
            new(ShadowType.Normal, "Jotun of Blood", 65, 346, 158, 3270, "¥360",
                stats: new(27, 29, 49, 44, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agidyne", "Bufudyne", "Power Charge", "God's Hand" }
            ),
            new(ShadowType.Normal, "Jotun of Evil", 73, 560, 344, -1, "¥-1",
                stats: new(51, 58, 32, 40, 34),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Spirit Drain", "Bufudyne", "Mabufudyne", "Aeon Rain", "Ice Boost", "Evade Physical" }
            ),
            new(ShadowType.Normal, "Jotun of Grief", 80, 505, 298, 1660, "¥420",
                stats: new(53, 59, 53, 54, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "God's Hand", "Revolution", "Megido" }
            ),
            new(ShadowType.Normal, "Jotun of Power", 54, 321, 203, 2000, "¥320",
                stats: new(42, 34, 25, 33, 27),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "God's Hand", "Gigantic Fist" }
            ),
            new(ShadowType.Normal, "Judgement Sword", 72, 388, 139, 4150, "¥380",
                stats: new(55, 42, 51, 47, 38),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Blade of Fury", "Marakukaja", "Revolution" }
            ),
            new(ShadowType.Normal, "Jupiter Eagle", 72, 388, 139, 4150, "¥380",
                stats: new(55, 42, 51, 47, 38),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Blade of Fury", "Marakukaja", "Revolution" }
            ),
            new(ShadowType.Normal, "Justice Sword", 37, 205, 76, 540, "¥260",
                stats: new(28, 18, 21, 25, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Power Slash", "Arm Chopper" }
            ),
            new(ShadowType.Normal, "Killer Drive", 37, 205, 76, 540, "¥260",
                stats: new(28, 18, 21, 25, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Power Slash", "Arm Chopper" }
            ),
            new(ShadowType.Normal, "Killer Twins", 24, 160, 48, 380, "¥220",
                stats: new(13, 16, 13, 17, 16),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Twin Shot", "Red Wall", "Virus Wave" }
            ),
            new(ShadowType.Normal, "Killing Hand", 32, 208, 179, 490, "¥250",
                stats: new(14, 20, 13, 27, 21),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Rebellion", "White Wall", "Tetrakarn", "Balzac", "Recarmdra" }
            ),
            new(ShadowType.MiniBoss, "Killing Hand", 32, 885, 100, 8960, "¥600",
                stats: new(32, 27, 32, 30, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Summon", "Deathbound" }
            ),
            new(ShadowType.Normal, "King Castle", 69, 431, 243, 3940, "¥370",
                stats: new(50, 30, 40, 47, 41),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Rainy Death", "Myriad Arrows", "Dodge Fire", "Rebellion" }
            ),
            new(ShadowType.Normal, "Large Basalt", 33, 200, 29, 425, "¥250",
                stats: new(25, 17, 10, 20, 20),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Stagnant Air", "Counterstrike", "Makajam" }
            ),
            new(ShadowType.Normal, "Laughing Table", 10, 164, 154, 153, "¥190",
                stats: new(7, 9, 8, 7, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Zio", "Mazio", "Evil Smile", "Rakukaja" }
            ),
            new(ShadowType.Normal, "Lawless Fuzz", 74, 400, 344, 1300, "¥0",
                stats: new(42, 58, 32, 40, 64),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Counterstrike", "Single Shot", "Black Spot", "Rakunda" }
            ),
            new(ShadowType.Normal, "Leading Idol", 43, 327, 322, 1520, "¥290",
                stats: new(24, 29, 25, 28, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Summon", "Garula", "Mudo", "Life Drain" }
            ),
            new(ShadowType.Normal, "Liberating Idol", 31, 265, 232, 590, "¥240",
                stats: new(18, 19, 14, 23, 20),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new() { "Balzac", "Valiant Dance", "Rampage" }
            ),
            new(ShadowType.Normal, "Light Balance", 62, 333, 363, 2480, "¥300",
                stats: new(33, 37, 38, 35, 40),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Hama", "Mudo", "Mahama", "Mamudo" }
            ),
            new(ShadowType.MiniBoss, "Lost Okina", 67, 4000, 500, 23000, "¥1000",
                stats: new(48, 78, 32, 50, 30),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Dekunda", "Spirit Leech", "Stagnant Air", "Seal Bomb", "Mustard Bomb", "Navas Nebula", "Megidola", "Agidyne", "Bufudyne", "Ziodyne", "Garudyne", "Masukunda", "Matarunda", "Makarakarn" }
            ),
            new(ShadowType.Normal, "Lustful Snake", 37, 255, 157, 600, "¥260",
                stats: new(22, 28, 20, 28, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Foolish Whisper", "Muzzle Shot" }
            ),
            new(ShadowType.Normal, "Luxury Hand", 60, 999, 200, 34000, "¥12500",
                stats: new(30, 30, 45, 75, 65),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Summon", "Summon", "Summon", "Summon", "Agilao", "Bufula", "Garula", "Zionga", "Masukukaja", "Bash", "Soul Break", "Anima Freeze", "Pulinpa", "Poisma", "Enervation", "Tentarafoo", "Makajam", "Heat Riser", "Rebellion", "Counter" }
            ),
            new(ShadowType.Normal, "Lying Hablerie (Yukiko's Castle)", 5, 73, 51, 32, "¥140",
                stats: new(5, 5, 3, 3, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Dia" }
            ),
            new(ShadowType.Normal, "Lying Hablerie (The Hollow Forest)", 73, 125, 328, 1000, "¥0",
                stats: new(56, 37, 50, 42, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Agilao", "Bufula" }
            ),
            new(ShadowType.Normal, "Mach Wheel", 52, 240, 151, 2340, "¥310",
                stats: new(35, 29, 18, 40, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Black Spot", "Herculean Strike", "Masukukaja" }
            ),
            new(ShadowType.Normal, "Mad Cyclops", 38, 134, 245, 850, "¥270",
                stats: new(28, 27, 24, 36, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Garula", "Mind Slice", "Kill Rush" }
            ),
            new(ShadowType.Normal, "Magic Hand", 8, 130, 10, 78, "¥200",
                stats: new(1, 6, 5, 2, 7),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agi" }
            ),
            new(ShadowType.Normal, "Magical Magus", 14, 180, 135, 352, "¥180",
                stats: new(6, 8, 8, 6, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Agi", "Maragi", "Agilao", "Media", "Hysterical Slap" }
            ),
            new(ShadowType.Normal, "Maniacal Book", 58, 305, 411, 2020, "¥290",
                stats: new(24, 48, 36, 41, 30),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tetrakarn", "Makarakarn", "Magarudyne", "Garudyne" }
            ),
            new(ShadowType.Normal, "Mighty Beast", 50, 364, 127, 2110, "¥360",
                stats: new(40, 28, 20, 33, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new() { "Crazy Chain", "Fatal End" }
            ),
            new(ShadowType.Normal, "Mighty Cyclops", 35, 220, 330, 675, "¥300",
                stats: new(26, 35, 19, 23, 5),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Maragion" }
            ),
            new(ShadowType.Normal, "Mind Dice", 53, 312, 155, 2550, "¥320",
                stats: new(25, 35, 25, 40, 40),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Last Resort", "Debilitate" }
            ),
            new(ShadowType.Normal, "Minotaur I", 77, 590, 310, 9230, "¥570",
                stats: new(65, 40, 42, 48, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Hamaon", "Mudoon", "Mahamaon", "Mamudoon", "Diarahan", "Counterstrike", "Evade Elec" }
            ),
            new(ShadowType.Normal, "Minotaur II", 76, 845, 583, 8410, "¥470",
                stats: new(52, 70, 18, 50, 26),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Null),
                skills: new() { "Mind Charge", "Agidyne", "Garudyne", "Bufudyne", "Ziodyne" }
            ),
            new(ShadowType.Normal, "Minotaur III", 75, 680, 234, 7250, "¥380",
                stats: new(72, 30, 55, 52, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None),
                skills: new() { "Marakunda", "Rampage", "Bash", "Sonic Punch", "Black Spot", "Mighty Swing", "Apt Pupil" }
            ),
            new(ShadowType.Normal, "Minotaur IV", 75, 680, 234, 7250, "¥380",
                stats: new(72, 30, 55, 52, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None),
                skills: new() { "Marakunda", "Rampage", "Bash", "Sonic Punch", "Black Spot", "Mighty Swing", "Apt Pupil" }
            ),
            new(ShadowType.Normal, "Miss Gene", 27, 186, 30, 390, "¥230",
                stats: new(12, 16, 14, 22, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Matarukaja", "Marakukaja" }
            ),
            new(ShadowType.Normal, "Mistress Pot", 78, 150, 218, 2060, "¥410",
                stats: new(60, 43, 50, 44, 43),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Life Drain", "Life Leech", "Agneyastra", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Momentary Child", 37, 4500, 1000, 8200, "¥1000",
                stats: new(46, 15, 30, 38, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Tarukaja", "Rebellion", "Herculean Strike", "Assault Dive", "Rampage", "Deathbound" }
            ),
            new(ShadowType.Normal, "Monomaniac Fuzz", 44, 196, 106, 770, "¥290",
                stats: new(27, 22, 28, 26, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Fatal End" }
            ),
            new(ShadowType.Normal, "Monopolizing Cupid", 18, 100, 88, 140, "¥200",
                stats: new(6, 12, 8, 18, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Pulinpa", "Recarmdra", "Skewer" }
            ),
            new(ShadowType.Normal, "Moon Okina", 80, 445, 383, 1700, "¥420",
                stats: new(43, 55, 53, 60, 46),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mahamaon", "Mamudoon", "Old One" }
            ),
            new(ShadowType.Normal, "Mythical Gigas", 57, 344, 94, 1940, "¥300",
                stats: new(48, 22, 48, 40, 23),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Gigantic Fist", "Deathbound", "Counterstrike" }
            ),
            new(ShadowType.Normal, "Natural Dancer", 64, 325, 230, 2760, "¥350",
                stats: new(40, 37, 40, 45, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Cleave", "Atom Smasher", "Debilitate", "Diarama" }
            ),
            new(ShadowType.Normal, "Nemean Beast", 70, 362, 155, -1, "¥-1",
                stats: new(-1, -1, -1, -1, -1),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Power Slash", "Deathbound", "Cruel Attack" }
            ),
            new(ShadowType.Normal, "Neo Minotaur", 82, 5100, 379, 3120, "¥450",
                stats: new(63, 59, 54, 42, 88),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mabufudyne", "Rampage", "Cruel Attack", "Auto-Mataru", "Evade Fire", "Ice Amp", "Power Charge", "Mind Charge" }
            ),
            new(ShadowType.MiniBoss, "Neo Minotaur", 78, 4240, 100, 23220, "¥520",
                stats: new(69, 44, 63, 50, 51),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Rampage" }
            ),
            new(ShadowType.Normal, "Next Gene", 80, 355, 339, 1720, "¥420",
                stats: new(45, 45, 48, 56, 44),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Red Wall", "White Wall", "Blue Wall", "Green Wall", "Debilitate", "Auto-Sukukaja" }
            ),
            new(ShadowType.Normal, "Nizam Beast", 18, 288, 57, 380, "¥200",
                stats: new(14, 12, 12, 14, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Double Fangs", "Rampage" }
            ),
            new(ShadowType.Normal, "Noble Seeker", 18, 288, 57, 380, "¥200",
                stats: new(14, 12, 12, 14, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Double Fangs", "Rampage" }
            ),
            new(ShadowType.Normal, "Opulent Hand", 50, 750, 500, 30000, "¥12000",
                stats: new(30, 30, 40, 65, 55),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agilao", "Garula", "Bufula", "Zionga", "Masukukaja", "Bash", "Foolish Whisper", "Makajam", "Pulinpa", "Poisma", "Enervation", "Tentarafoo", "Counter" }
            ),
            new(ShadowType.Normal, "Order Giant", 53, 470, 87, 2720, "¥320",
                stats: new(35, 30, 20, 34, 27),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Mighty Swing", "Blade of Fury", "Power Charge" }
            ),
            new(ShadowType.Normal, "Perpetual Sand", 55, 230, 263, 1530, "¥220",
                stats: new(42, 40, 30, 38, 33),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Enervation", "Cell Breaker", "Old One", "Twin Shot" }
            ),
            new(ShadowType.Normal, "Persistent Fuzz", 29, 150, 100, 450, "¥230",
                stats: new(21, 18, 10, 19, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { }
            ),
            new(ShadowType.Normal, "Phantom Hero", 78, 325, 438, 1960, "¥410",
                stats: new(35, 49, 52, 50, 58),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Hamaon", "Mudoon", "Foolish Whisper" }
            ),
            new(ShadowType.Normal, "Phantom King", 75, 432, 122, 4780, "¥390",
                stats: new(43, 70, 20, 48, 40),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Stagnant Air", "Agidyne", "Mahama", "Fire Boost" }
            ),
            new(ShadowType.Normal, "Phantom Lord", 61, 279, 469, 2890, "¥290",
                stats: new(16, 48, 24, 44, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Mind Charge", "Megido", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Phantom Mage", 13, 124, 152, 162, "¥210",
                stats: new(2, 7, 7, 8, 13),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new() { "Garu", "Mudo", "Makajam", "Tarunda" }
            ),
            new(ShadowType.Normal, "Phantom Master", 20, 162, 189, 350, "¥210",
                stats: new(7, 16, 12, 10, 14),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Ghastly Wail", "Garu", "Magaru", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Pistil Mother", 69, 370, 483, 4560, "¥370",
                stats: new(46, 55, 25, 47, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Foolish Whisper", "Garudyne", "Magarudyne", "Bufudyne", "Mabufudyne" }
            ),
            new(ShadowType.Normal, "Platinum Dice", 43, 256, 59, 520, "¥290",
                stats: new(25, 15, 25, 20, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Last Resort", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Positive King", 11, 350, 43, 212, "¥210",
                stats: new(6, 8, 7, 5, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Summon", "Summon", "Summon", "Zio", "Red Wall", "Dia" }
            ),
            new(ShadowType.Normal, "Power Castle", 54, 299, 385, 1680, "¥320",
                stats: new(29, 43, 26, 34, 24),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Zionga", "Agilao", "Bufula", "Mind Charge", "Garula" }
            ),
            new(ShadowType.Normal, "Praying Nyogo", 75, 175, 256, 1100, "¥0",
                stats: new(36, 35, 40, 40, 34),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Hysterical Slap", "Atom Smasher", "Dia", "Rage Boost" }
            ),
            new(ShadowType.Normal, "Praying Papillon", 73, 150, 511, 1650, "¥0",
                stats: new(15, 57, 59, 37, 59),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Media", "Soul Break", "Anima Freeze", "Navas Nebula", "Auto-Masuku", "Dodge Wind", "Dodge Elec", "Exhaust Boost" }
            ),
            new(ShadowType.Normal, "Prime Magus", 56, 364, 472, 1500, "¥300",
                stats: new(24, 44, 35, 38, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Agidyne", "Maragidyne", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Primitive Idol", 77, 1000, 523, 1950, "¥400",
                stats: new(58, 58, 45, 53, 55),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Heaven's Blade", "Power Charge" }
            ),
            new(ShadowType.Normal, "Protective Lexy", 46, 153, 451, 860, "¥290",
                stats: new(13, 42, 14, 38, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tetrakarn", "Makarakarn", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Ptarmigan Panzer", 81, 1111, 120, 2480, "¥430",
                stats: new(64, 46, 72, 54, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Maziodyne", "Ziodyne", "Garudyne", "Hama", "Elec Amp", "Wind Boost" }
            ),
            new(ShadowType.Normal, "Pure Papillon", 76, 325, 511, 2070, "¥360",
                stats: new(36, 57, 45, 58, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Matarunda", "Marakunda", "Stagnant Air", "Poison Arrow", "Muzzle Shot" }
            ),
            new(ShadowType.Normal, "Purple Sigil", 71, 328, 523, -1, "¥-1",
                stats: new(49, 57, 30, 47, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mudoon", "Megido", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Pursuing Pesce", 18, 125, 85, 240, "¥200",
                stats: new(14, 12, 10, 12, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Evil Touch", "Summon", "Summon" }
            ),
            new(ShadowType.Normal, "Rain End Musha", 42, 566, 73, 2800, "¥320",
                stats: new(32, 18, 31, 30, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Vicious Strike", "Power Charge", "Sharp Student", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Rain Leg Musha", 34, 265, 79, 1450, "¥250",
                stats: new(30, 18, 23, 22, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Rebellion", "Gale Slash" }
            ),
            new(ShadowType.Normal, "Rain Wheel", 30, 50, 56, 760, "¥240",
                stats: new(34, 9, 17, 19, 16),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Attack" }
            ),
            new(ShadowType.Normal, "Rain Wind Musha", 65, 694, 126, 4130, "¥360",
                stats: new(44, 37, 37, 46, 33),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Power Charge", "Dodge Physical", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Rainbow Twins", 48, 250, 149, 1380, "¥300",
                stats: new(37, 28, 23, 36, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Mind Slice", "Brain Shake" }
            ),
            new(ShadowType.Normal, "Raindrop Castle", 48, 250, 149, 1380, "¥300",
                stats: new(37, 28, 23, 36, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new() { "Stagnant Air", "Mind Slice", "Brain Shake" }
            ),
            new(ShadowType.Normal, "Raindrop Musha", 51, 1050, 119, 1900, "¥310",
                stats: new(39, 32, 16, 37, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Balzac", "Dodge Physical" }
            ),
            new(ShadowType.Normal, "Rainy Brother 1", 44, 110, 193, 960, "¥290",
                stats: new(27, 30, 24, 30, 26),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Garudyne", "Re Patra" }
            ),
            new(ShadowType.Normal, "Rainy Brother 2", 43, 89, 190, 680, "¥290",
                stats: new(21, 30, 18, 29, 29),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agilao", "Maragion" }
            ),
            new(ShadowType.Normal, "Rainy Brother 4", 16, 92, 131, 200, "¥190",
                stats: new(2, 16, 12, 10, 12),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agi", "Maragi", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Rainy Castle", 37, 220, 296, 880, "¥260",
                stats: new(19, 29, 17, 25, 22),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agilao", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Rainy Pot", 41, 62, 178, 800, "¥280",
                stats: new(22, 28, 25, 26, 21),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Rainy Sister 1", 44, 110, 193, 940, "¥290",
                stats: new(27, 30, 28, 27, 27),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Bufudyne" }
            ),
            new(ShadowType.Normal, "Rainy Sister 2", 40, 42, 40, 530, "¥280",
                stats: new(14, 28, 22, 26, 28),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bufula", "Mabufula" }
            ),
            new(ShadowType.Normal, "Rainy Sister 3", 28, 80, 203, 580, "¥230",
                stats: new(18, 28, 13, 16, 16),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Magaru", "Bash" }
            ),
            new(ShadowType.Normal, "Rainy Sister 4", 21, 80, 136, 240, "¥210",
                stats: new(12, 6, 10, 14, 14),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agilao", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Rampage Drive", 81, 385, 169, 2480, "¥430",
                stats: new(57, 45, 62, 50, 58),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Maragidyne", "Agidyne", "Bufudyne", "Mudo", "Fire Amp", "Ice Boost" }
            ),
            new(ShadowType.Normal, "Rash Panzer", 58, 284, 113, 2310, "¥310",
                stats: new(36, 20, 60, 28, 29),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mustard Bomb", "Seal Bomb", "Foul Breath" }
            ),
            new(ShadowType.Normal, "Rebellious Cyclops", 81, 525, 428, 1780, "¥430",
                stats: new(88, 42, 49, 54, 39),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Primal Force", "Cruel Attack", "Diarahan", "Dodge Ice" }
            ),
            new(ShadowType.Normal, "Reckless Okina", 61, 310, 354, 2080, "¥280",
                stats: new(27, 46, 36, 42, 34),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Garudyne", "Magarula", "Red Wall", "White Wall", "Blue Wall", "Green Wall" }
            ),
            new(ShadowType.Normal, "Reckoning Dice", 82, 777, 77, 2660, "¥440",
                stats: new(1, 77, 55, 55, 77),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Cleave", "Last Resort", "Apt Pupil" }
            ),
            new(ShadowType.Normal, "Red Sigil", 48, 247, 405, 2080, "¥300",
                stats: new(33, 38, 21, 32, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect),
                skills: new() { "Agilao", "Maragion", "Dodge Ice", "Balzac" }
            ),
            new(ShadowType.Normal, "Reformed Okina", 73, 315, 519, 4420, "¥390",
                stats: new(33, 72, 38, 48, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Vicious Strike", "Debilitate", "Media" }
            ),
            new(ShadowType.Normal, "Regal Mother", 60, 228, 386, 2100, "¥280",
                stats: new(32, 42, 31, 37, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Maragion", "Bufudyne", "Garudyne", "Hysterical Slap" }
            ),
            new(ShadowType.Normal, "Revelation Pesce", 63, 256, 149, 2120, "¥290",
                stats: new(33, 31, 31, 44, 44),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new() { "Mediarama", "Brain Shake", "Recarmdra" }
            ),
            new(ShadowType.Normal, "Reverent Table", 74, 950, 231, 950, "¥0",
                stats: new(58, 29, 35, 45, 40),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Garula", "Zionga", "Tetrakarn" }
            ),
            new(ShadowType.Normal, "Royal Dancer", 47, 282, 210, 1580, "¥290",
                stats: new(32, 30, 15, 32, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Matarukaja", "Gale Slash", "Tempest Slash", "Poison Skewer" }
            ),
            new(ShadowType.Normal, "Scarlet Turret", 46, 355, 246, 2450, "¥290",
                stats: new(20, 29, 38, 30, 24),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agidyne", "Maragion", "Dia", "Mind Charge", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Secret Bambino", 10, 80, 62, 82, "¥200",
                stats: new(8, 5, 10, 2, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agi", "Garu", "Bufu", "Zio", "Sukukaja", "Bash" }
            ),
            new(ShadowType.Normal, "Selfish Basalt", 22, 168, 80, 240, "¥210",
                stats: new(13, 12, 16, 8, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Zionga", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Shallow Okina", 49, 267, 322, 1350, "¥300",
                stats: new(27, 38, 20, 32, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Old One", "Garula", "Herculean Strike" }
            ),
            new(ShadowType.Normal, "Silent Book", 72, 307, 421, 3250, "¥380",
                stats: new(43, 53, 24, 50, 50),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Makajam", "Foolish Whisper", "Power Charge", "Seal Bomb" }
            ),
            new(ShadowType.Normal, "Silent Nyogo", 77, 1500, 179, 1430, "¥400",
                stats: new(46, 35, 44, 53, 55),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tempest Slash", "Myriad Arrows", "Gale Slash", "Rainy Death", "Power Charge", "Apt Pupil" }
            ),
            new(ShadowType.Normal, "Silver Dice", 31, 250, 83, 480, "¥240",
                stats: new(19, 19, 19, 20, 19),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Last Resort" }
            ),
            new(ShadowType.Normal, "Sky Balance", 30, 218, 440, 1680, "¥250",
                stats: new(15, 35, 18, 24, 17),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Garula", "Zionga" }
            ),
            new(ShadowType.Normal, "Slaughter Drive", 74, 380, 150, 5040, "¥390",
                stats: new(68, 38, 36, 47, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Double Fangs", "Torrent Shot", "Tetrakarn", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Sleeping Table", 71, 333, 60, 3950, "¥380",
                stats: new(45, 56, 30, 50, 42),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Brain Shake", "Navas Nebula", "Anima Freeze" }
            ),
            new(ShadowType.MiniBoss, "Sleeping Table", 82, 2000, 2000, 24570, "¥520",
                stats: new(42, 54, 67, 55, 75),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Maragidyne", "Mahamaon", "Megidolaon", "Evil Smile", "Ghastly Wail" }
            ),
            new(ShadowType.Normal, "Slipping Hablerie", 1, 40, 35, 30, "¥0",
                stats: new(2, 2, 5, 1, 1),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Attack" }
            ),
            new(ShadowType.Normal, "Snowfall Musha", 73, 330, 129, 1500, "¥0",
                stats: new(44, 33, 55, 37, 46),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tempest Slash", "Black Spot", "Megido", "Tarukaja", "Tarunda", "Rakunda", "Diarama", "Rebellion" }
            ),
            new(ShadowType.Normal, "Solemn Machine", 78, 5486, 133, 9990, "¥770",
                stats: new(60, 42, 1, 51, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Heaven's Blade", "Heat Riser", "Power Charge" }
            ),
            new(ShadowType.Normal, "Sonic Raven", 29, 210, 84, 390, "¥230",
                stats: new(12, 10, 12, 19, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Muzzle Shot" }
            ),
            new(ShadowType.Normal, "Soul Dancer", 28, 180, 129, 420, "¥230",
                stats: new(19, 16, 12, 18, 20),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agilao" }
            ),
            new(ShadowType.Normal, "Source Basalt", 45, 270, 44, 1100, "¥290",
                stats: new(40, 28, 20, 29, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Foul Breath", "Bufula", "Skull Cracker" }
            ),
            new(ShadowType.Normal, "Spastic Turret", 75, 400, 429, 5000, "¥400",
                stats: new(62, 95, 48, 60, 26),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Agi", "Ragnarok", "Null Dizzy", "Masukukaja" }
            ),
            new(ShadowType.Normal, "Spectral Raven", 74, 150, 445, 950, "¥0",
                stats: new(23, 58, 14, 48, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Dodge Physical", "Cleave", "Muzzle Shot", "Garula", "Silence Boost" }
            ),
            new(ShadowType.Normal, "Spurious Book", 39, 142, 242, 760, "¥270",
                stats: new(13, 24, 25, 30, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Makarakarn", "Maragi", "Mabufu", "Spirit Drain" }
            ),
            new(ShadowType.Normal, "Stasis Giant", 63, 456, 96, 2380, "¥350",
                stats: new(55, 35, 48, 35, 22),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new() { "Mighty Swing", "Vicious Strike", "Marakukaja", "Marakunda", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Steel Machine", 45, 65, 55, 3400, "¥290",
                stats: new(41, 14, 34, 30, 22),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Navas Nebula", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Stoic Snake", 81, 441, 259, 2110, "¥430",
                stats: new(44, 69, 51, 56, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new() { "Spirit Leech", "Poison Arrow", "Blight", "Poison Boost" }
            ),
            new(ShadowType.Normal, "Stone Panzer", 75, 300, 666, 1800, "¥0",
                stats: new(25, 25, 58, 49, 52),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Mind Charge", "Agidyne", "Bufudyne", "Ziodyne", "Hamaon", "Mudoon", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Stupendous Relic", 73, 50, 485, 1750, "¥0",
                stats: new(26, 67, 85, 82, 47),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Old One", "Cell Breaker", "Recarmdra", "Auto-Maraku", "Null Dizzy" }
            ),
            new(ShadowType.Normal, "Successful Junecy", 82, 307, 300, 2430, "¥440",
                stats: new(33, 34, 72, 60, 52),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Revolution", "Heat Riser", "Summon", "Muzzle Shot", "Silence Boost" }
            ),
            new(ShadowType.Normal, "Superstitious Okina", 74, 400, 519, 1600, "¥0",
                stats: new(34, 51, 5, 65, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Auto-Rakukaja", "Dodge Ice", "Evade Wind", "Maragidyne", "Zionga", "Spirit Drain", "Heat Riser" }
            ),
            new(ShadowType.Normal, "Supreme Hand", 40, 500, 500, 20000, "¥9000",
                stats: new(30, 30, 45, 55, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agi", "Bufu", "Zio", "Garu", "Sukukaja", "Bash", "Poisma", "Poison Mist", "Summon", "Summon", "Summon", "Summon" }
            ),
            new(ShadowType.MiniBoss, "The Reaper", 85, 5000, 12000, 5000, "¥13",
                stats: new(99, 80, 80, 75, 99),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Vile Assault", "Myriad Arrows", "Vorpal Blade", "Agidyne", "Maragidyne", "Bufudyne", "Mabufudyne", "Ziodyne", "Maziodyne", "Garudyne", "Magarudyne", "Megidola", "Megidolaon", "Mind Charge", "Hamaon", "Mahamaon", "Mudoon", "Mamudoon", "Fire Break", "Ice Break", "Elec Break", "Wind Break", "Life Drain", "Spirit Drain", "Life Leech" }
            ),
            new(ShadowType.Normal, "Trance Twins", 7, 222, 22, 88, "¥160",
                stats: new(4, 6, 5, 6, 7),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Bufu", "Mabufu", "Evil Touch", "Twin Shot" }
            ),
            new(ShadowType.Normal, "Tranquil Idol", 22, 185, 165, 380, "¥210",
                stats: new(10, 15, 11, 15, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Bufu", "Mabufu", "Marakukaja" }
            ),
            new(ShadowType.Normal, "Treasure Hand", 22, 185, 165, 380, "¥210",
                stats: new(10, 15, 11, 15, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Bufu", "Mabufu", "Marakukaja" }
            ),
            new(ShadowType.Normal, "Truth Pesce", 53, 212, 138, 1680, "¥320",
                stats: new(39, 27, 24, 41, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Fatal End", "Makarakarn", "Megido" }
            ),
            new(ShadowType.Normal, "Valuing Nyogo", 72, 288, 206, 4020, "¥380",
                stats: new(52, 39, 30, 48, 41),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new() { "Hysterical Slap", "Valiant Dance" }
            ),
            new(ShadowType.Normal, "Vehement Idol", 68, 301, 487, 2480, "¥360",
                stats: new(40, 48, 28, 43, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new() { "Bufula", "Mabufula", "Mind Charge", "Mediarama" }
            ),
            new(ShadowType.Normal, "Venus Eagle", 31, 216, 140, 580, "¥240",
                stats: new(18, 20, 16, 19, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Hama" }
            ),
            new(ShadowType.Normal, "Vicious Raven", 20, 150, 98, 220, "¥210",
                stats: new(9, 10, 12, 18, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Matarukaja", "Marakunda", "Bash" }
            ),
            new(ShadowType.Normal, "Void Giant", 82, 455, 133, 2670, "¥440",
                stats: new(67, 72, 54, 58, 49),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Fatal End", "Seal Bomb", "Silence Boost", "Auto-Maraku", "Power Charge" }
            ),
            new(ShadowType.Normal, "Wealth Hand", 20, 300, 250, 6000, "¥5000",
                stats: new(10, 15, 50, 35, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agi", "Garu", "Bufu", "Zio", "Sukukaja", "Bash", "Pulinpa", "Tentarafoo", "Summon" }
            ),
            new(ShadowType.Normal, "Wheeled Bambino", 75, 70, 245, 1250, "¥0",
                stats: new(32, 42, 75, 38, 66),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Bash", "Rampage", "Life Drain" }
            ),
            new(ShadowType.Normal, "Whimsical Papillon", 40, 254, 334, 740, "¥280",
                stats: new(18, 29, 17, 30, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Tarukaja", "Matarukaja", "Sukukaja", "Masukukaja", "Rakukaja", "Matarunda", "Masukunda", "Marakunda" }
            ),
            new(ShadowType.Normal, "Wicked Turret", 53, 455, 201, 3330, "¥320",
                stats: new(42, 25, 29, 35, 23),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new() { "Mind Charge", "Garudyne", "Magarudyne" }
            ),
            new(ShadowType.Normal, "Wild Drive", 51, 270, 120, 1530, "¥310",
                stats: new(38, 27, 21, 37, 27),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Matarukaja", "Kill Rush", "Mind Slice" }
            ),
            new(ShadowType.Normal, "Wondrous Magus", 25, 165, 269, 420, "¥230",
                stats: new(1, 19, 10, 16, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new() { "Maragi", "Agilao", "Mazio", "Zionga" }
            ),
            new(ShadowType.Normal, "World Balance", 52, 210, 576, 2300, "¥310",
                stats: new(11, 55, 21, 35, 34),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new() { "Hamaon", "Mudoon" }
            ),
            new(ShadowType.MiniBoss, "World Balance", 63, 1200, 1000, 22980, "¥410",
                stats: new(45, 45, 45, 45, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new() { "Agidyne", "Bufudyne", "Ziodyne", "Garudyne", "Mind Charge" }
            ),
            new(ShadowType.Normal, "Wrathful Book", 76, 341, 445, 2080, "¥380",
                stats: new(34, 58, 44, 60, 38),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new() { "Dodge Physical", "Tetrakarn", "Makarakarn", "Crazy Chain", "Balzac", "Rage Boost" }
            ),
            new(ShadowType.Normal, "Yearning Pot", 70, 298, 230, 4740, "¥370",
                stats: new(47, 43, 34, 43, 37),
                elementAffinities: new(ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new() { "Evil Touch", "Evil Smile", "Ghastly Wail", "Makarakarn" }
            )
        };
    }
}
