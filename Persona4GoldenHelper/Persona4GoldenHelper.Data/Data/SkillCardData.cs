using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The skill card data.</summary>
    public class SkillCardData
    {
        /// <summary>The skill card locations data.</summary>
        public static List<SkillCardLocation> SkillCardLocations { get; set; } = new List<SkillCardLocation>()
        {
            new SkillCardLocation() {
                DungeonName = "Yukiko's Castle",
                RankLowerBound = 1,
                RankUpperBound = 2,
            },
            new SkillCardLocation() {
                DungeonName = "Steamy Bathhouse",
                RankLowerBound = 1,
                RankUpperBound = 3,
            },
            new SkillCardLocation() {
                DungeonName = "Marukyu Striptease",
                RankLowerBound = 2,
                RankUpperBound = 4,
            },
            new SkillCardLocation() {
                DungeonName = "Void Quest",
                RankLowerBound = 3,
                RankUpperBound = 6,
            },
            new SkillCardLocation() {
                DungeonName = "Secret Lab",
                RankLowerBound = 3,
                RankUpperBound = 7,
            },
            new SkillCardLocation() {
                DungeonName = "Heaven",
                RankLowerBound = 4,
                RankUpperBound = 9,
            },
            new SkillCardLocation() {
                DungeonName = "Magatsu Inaba",
                RankLowerBound = 4,
                RankUpperBound = 10,
            },
            new SkillCardLocation() {
                DungeonName = "Hollow Forest",
                RankLowerBound = 4,
                RankUpperBound = 10,
            },
            new SkillCardLocation() {
                DungeonName = "Yomotsu Hirasaka",
                RankLowerBound = 5,
                RankUpperBound = 10,
            }
        };

        /// <summary>The skill card data.</summary>
        public static List<SkillCard> SkillCards { get; set; } = new List<SkillCard>()
        {
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Arm Chopper",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Double Fangs",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Hysterical Slap",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Muzzle Shot",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Poison Skewer",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Single Shot",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Skull Cracker",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Sonic Punch",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Assault Dive",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Brain Shake",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Cell Breaker",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Gale Slash",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Kill Rush",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Rampage",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Swift Strike",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Twin Shot",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Crazy Chain",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Cruel Attack",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Mind Slice",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Power Slash",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Seal Bomb",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Atom Smasher",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Black Spot",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Fatal End",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Heat Wave",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Herculean Strike",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Mighty Swing",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Aeon Rain",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Blade of Fury",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Mustard Bomb",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Navas Nebula",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Poison Arrow",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Torrent Shot",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Vicious Strike",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Arrow Rain",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Deathbound",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Gigantic Fist",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Tempest Slash",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Virus Wave",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Blight",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Myriad Arrows",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Rainy Death",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Vile Assault",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Agneyastra",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Akasha Arts",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Brave Blade",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "God's Hand",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Primal Force",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Physical,
                Name = "Vorpal Blade",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Agi",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Bufu",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Garu",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Zio",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Foul Breath",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Hama",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mabufu",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Magaru",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Maragi",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mazio",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Agilao",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Anima Freeze",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Bufula",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Evil Smile",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Foolish Whisper",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Garula",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mahama",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mamudo",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Old One",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Poison Mist",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Tentarafoo",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Valiant Dance",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Zionga",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Life Drain",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Megido",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Spirit Drain",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Stagnant Air",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mabufula",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Magarula",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Maragion",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mazionga",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Agidyne",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Bufudyne",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Garudyne",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Ghastly Wail",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Hamaon",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mudoon",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Ziodyne",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mabufudyne",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Magarudyne",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mahamaon",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Mamudoon",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Maragidyne",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Maziodyne",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Megidola",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Magical,
                Name = "Megidolaon",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Dia",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Mutudi",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Patra",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Rakunda",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Sukukaja",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Sukunda",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Tarukaja",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Tarunda",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Nervundi",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Posumundi",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Re Patra",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Rebellion",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Traesto",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Elec Break",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Fire Break",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Ice Break",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Me Patra",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Media",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Recarm",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Wind Break",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Blue Wall",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Dekaja",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Dekunda",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Diarama",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Green Wall",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Marakukaja",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Masukunda",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Matarunda",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Red Wall",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Revolution",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "White Wall",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Amrita",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Energy Shower",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Mediarama",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Samarecarm",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Tetraja",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Makara Break",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Mind Charge",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Power Charge",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Tetra Break",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Makarakarn",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Mediarahan",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Tetrakarn",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Support,
                Name = "Salvation",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Sharp Student",
                Rank = 1
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Alertness",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Dodge Elec",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Dodge Fire",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Dodge Ice",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Dodge Wind",
                Rank = 2
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Apt Pupil",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Counter",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Dodge Physical",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Elec Boost",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Fire Boost",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Growth 1",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Ice Boost",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Invigorate 1",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Regenerate 1",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Wind Boost",
                Rank = 3
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Evade Elec",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Evade Fire",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Evade Ice",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Evade Wind",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Null Dizzy",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Null Poison",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Speedy Recovery",
                Rank = 4
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Counterstrike",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Evade Physical",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Growth 2",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Resist Elec",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Resist Fire",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Resist Ice",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Resist Wind",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Survive Dark",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Survive Light",
                Rank = 5
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Cool Breeze",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Divine Grace",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Endure Dark",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Endure Light",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Hama Boost",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "High Counter",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Invigorate 2",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Mudo Boost",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Resist Physical",
                Rank = 6
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Ailment Boost",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Rakukaja",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Sukukaja",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Tarukaja",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Elec Amp",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Endure",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Fire Amp",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Firm Stance",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Ice Amp",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Wind Amp",
                Rank = 7
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Angelic Grace",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Enduring Soul",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Growth 3",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Invigorate 3",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Regenerate 3",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Repel Dark",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Repel Light",
                Rank = 8
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Arms Master",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Maraku",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Masuku",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Auto-Mataru",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Spell Master",
                Rank = 9
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Absorb Elec",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Absorb Fire",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Absorb Ice",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Absorb Physical",
                Rank = 10
            },
            new SkillCard() {
                Type = SkillType.Passive,
                Name = "Absorb Wind",
                Rank = 10
            }
        };
    }
}
