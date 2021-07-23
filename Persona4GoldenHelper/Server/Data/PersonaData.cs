using Persona4GoldenHelper.Shared;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The persona data.</summary>
    public static class PersonaData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The persona data.</summary>
        public static List<Persona> Personas { get; } = new()
        {
            new("Izanagi", "Fool", 1,
                stats: new(3, 2, 2, 3, 2),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Zio", 0),
                    new("Cleave", 0),
                    new("Rakukaja", 0),
                    new("Rakunda", 3),
                    new("Tarukaja", 5)
                }
            ),
            new("Pixie", "Magician", 2,
                stats: new(2, 3, 2, 4, 2),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Dia", 0),
                    new("Patra", 0),
                    new("Zio", 3),
                    new("Me Patra", 4),
                    new("Trafuri", 8)
                }
            ),
            new("Slime", "Chariot", 2,
                stats: new(3, 2, 3, 2, 3),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Bash", 0),
                    new("Evil Touch", 0),
                    new("Tarunda", 3),
                    new("Red Wall", 4),
                    new("Fear Boost", 5),
                    new("Resist Physical", 7)
                }
            ),
            new("Ukobach", "Devil", 3,
                stats: new(3, 4, 3, 4, 2),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agi", 0),
                    new("Sukunda", 0),
                    new("Pulinpa", 4),
                    new("Confuse Boost", 5),
                    new("Resist Fire", 6),
                    new("Fire Break", 7)
                }
            ),
            new("Angel", "Justice", 4,
                stats: new(4, 5, 2, 5, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Weak),
                skills: new()
                {
                    new("Garu", 0),
                    new("Patra", 0),
                    new("Hama", 5),
                    new("Sukukaja", 6),
                    new("Regenerate 1", 8),
                    new("Hama Boost", 9)
                }
            ),
            new("Apsaras", "Temperance", 4,
                stats: new(3, 5, 3, 5, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Patra", 0),
                    new("Dia", 0),
                    new("Rakunda", 5),
                    new("Me Patra", 6),
                    new("Bufu", 7)
                }
            ),
            new("Sandman", "Strength", 5,
                stats: new(4, 5, 6, 4, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garu", 0),
                    new("Pulinpa", 0),
                    new("Skull Cracker", 6),
                    new("Confuse Boost", 7),
                    new("Dekaja", 8),
                    new("Traesto", 11)
                }
            ),
            new("Nata Taishi", "Chariot", 6,
                stats: new(6, 2, 6, 7, 4),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Bash", 0),
                    new("Rakunda", 0),
                    new("Dekunda", 0),
                    new("Sonic Punch", 7),
                    new("Dodge Ice", 8),
                    new("Resist Dizzy", 9),
                    new("Soul Break", 10)
                }
            ),
            new("Forneus", "Hermit", 6,
                stats: new(4, 5, 7, 6, 3),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Bufu", 0),
                    new("Skewer", 0),
                    new("Tarukaja", 0),
                    new("Rakunda", 7),
                    new("Poisma", 8),
                    new("Dodge Elec", 10)
                }
            ),
            new("Yomotsu-Shikome", "Fool", 7,
                stats: new(2, 7, 7, 8, 4),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Poisma", 0),
                    new("Skewer", 0),
                    new("Evil Touch", 0),
                    new("Sukunda", 9),
                    new("Mudo", 10),
                    new("Ghastly Wail", 11)
                }
            ),
            new("Omoikane", "Hierophant", 7,
                stats: new(5, 8, 5, 4, 6),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zio", 0),
                    new("Sukunda", 0),
                    new("Tarunda", 0),
                    new("Poison Mist", 8),
                    new("Resist Wind", 9),
                    new("Resist Poison", 11),
                    new("Resist Elec", 12)
                }
            ),
            new("Orobas", "Magician", 8,
                stats: new(4, 10, 6, 7, 4),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agi", 0),
                    new("Hysterical Slap", 0),
                    new("Dekaja", 0),
                    new("Dodge Ice", 10),
                    new("Resist Dizzy", 11),
                    new("Sharp Student", 12)
                }
            ),
            new("Valkyrie", "Strength", 8,
                stats: new(7, 6, 6, 7, 5),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Bufu", 0),
                    new("Cleave", 0),
                    new("Rakunda", 0),
                    new("Media", 10),
                    new("Arm Chopper", 11),
                    new("Mabufu", 12)
                }
            ),
            new("Senri", "Empress", 9,
                stats: new(7, 7, 4, 11, 5),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Dia", 0),
                    new("Makajam", 0),
                    new("Agi", 0),
                    new("Dekunda", 10),
                    new("Media", 11),
                    new("Trafuri", 14)
                }
            ),
            new("Ghoul", "Death", 9,
                stats: new(8, 7, 9, 5, 5),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new()
                {
                    new("Bash", 0),
                    new("Poisma", 0),
                    new("Sukukaja", 10),
                    new("Enervation", 11),
                    new("Poison Skewer", 12),
                    new("Rakunda", 13),
                    new("Poison Boost", 14)
                }
            ),
            new("Lilim", "Devil", 10,
                stats: new(4, 11, 5, 9, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Zio", 0),
                    new("Mudo", 0),
                    new("Enervation", 0),
                    new("Enervate Boost", 12),
                    new("Sukukaja", 13),
                    new("Mamudo", 15)
                }
            ),
            new("Cu Sith", "Sun", 10,
                stats: new(10, 5, 6, 9, 7),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garu", 0),
                    new("Pulinpa", 0),
                    new("Rakukaja", 0),
                    new("Growth 1", 11),
                    new("Magaru", 13),
                    new("White Wall", 14),
                    new("Traesto", 15)
                }
            ),
            new("Saki Mitama", "Priestess", 11,
                stats: new(5, 12, 5, 8, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Dia", 0),
                    new("Bufu", 0),
                    new("Sukunda", 0),
                    new("Alertness", 13),
                    new("Media", 14),
                    new("Null Rage", 16)
                }
            ),
            new("Archangel", "Justice", 11,
                stats: new(8, 9, 7, 7, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hama", 0),
                    new("Double Fangs", 0),
                    new("Patra", 0),
                    new("Media", 12),
                    new("Muzzle Shot", 13),
                    new("Sharp Student", 14),
                    new("Survive Dark", 15)
                }
            ),
            new("Sylph", "Temperance", 11,
                stats: new(8, 10, 5, 10, 7),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garu", 0),
                    new("Sukukaja", 0),
                    new("Me Patra", 0),
                    new("Regenerate 1", 12),
                    new("Media", 13),
                    new("Magaru", 14)
                }
            ),
            new("Oberon", "Emperor", 12,
                stats: new(10, 12, 8, 8, 5),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zio", 0),
                    new("Arm Chopper", 0),
                    new("Makajam", 13),
                    new("Media", 14),
                    new("Elec Boost", 15),
                    new("Mazio", 16),
                    new("Dodge Wind", 17)
                }
            ),
            new("Eligor", "Chariot", 12,
                stats: new(11, 6, 13, 8, 5),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Poison Skewer", 0),
                    new("Agi", 0),
                    new("Maragi", 13),
                    new("Arm Chopper", 14),
                    new("Fire Boost", 15),
                    new("Soul Break", 16),
                    new("Resist Exhaust", 17)
                }
            ),
            new("Obariyon", "Fool", 13,
                stats: new(11, 6, 11, 9, 9),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Sonic Punch", 0),
                    new("Tarukaja", 0),
                    new("Dekaja", 0),
                    new("Muzzle Shot", 14),
                    new("Silence Boost", 15),
                    new("Resist Physical", 17),
                    new("Single Shot", 18)
                }
            ),
            new("Titan", "Strength", 14,
                stats: new(11, 12, 10, 10, 6),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mazio", 0),
                    new("Skull Cracker", 0),
                    new("Dekunda", 0),
                    new("Dodge Ice", 16),
                    new("Kill Rush", 18),
                    new("Resist Fear", 19)
                }
            ),
            new("Mokoi", "Death", 14,
                stats: new(13, 7, 9, 11, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Sonic Punch", 0),
                    new("Hysterical Slap", 0),
                    new("Dekaja", 0),
                    new("Valiant Dance", 15),
                    new("Rage Boost", 16),
                    new("Soul Break", 18),
                    new("Exhaust Boost", 19)
                }
            ),
            new("Anzu", "Hierophant", 15,
                stats: new(9, 11, 10, 13, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garu", 0),
                    new("Balzac", 0),
                    new("Alertness", 0),
                    new("Magaru", 17),
                    new("Red Wall", 18),
                    new("Mahama", 19),
                    new("Auto-Sukukaja", 20)
                }
            ),
            new("Berith", "Hanged Man", 15,
                stats: new(12, 10, 9, 12, 9),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Single Shot", 0),
                    new("Mudo", 0),
                    new("Maragi", 16),
                    new("Mudo Boost", 17),
                    new("Green Wall", 18),
                    new("Brain Shake", 19),
                    new("Resist Confuse", 20)
                }
            ),
            new("Jack Frost", "Magician", 16,
                stats: new(10, 14, 12, 11, 8),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufu", 0),
                    new("Ice Break", 0),
                    new("Bufula", 19),
                    new("Dodge Fire", 20),
                    new("Mind Charge", 25)
                }
            ),
            new("Xiezhai", "Temperance", 16,
                stats: new(14, 12, 9, 13, 7),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zio", 0),
                    new("Mazio", 0),
                    new("Rakunda", 0),
                    new("Makajam", 17),
                    new("Silence Boost", 18),
                    new("Rampage", 19),
                    new("Elec Boost", 21)
                }
            ),
            new("Sarasvati", "Pristess", 17,
                stats: new(9, 16, 10, 13, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Media", 0),
                    new("Mabufu", 0),
                    new("Patra", 0),
                    new("Invigorate 2", 19),
                    new("Resist Rage", 20),
                    new("Dekaja", 21),
                    new("Null Wind", 23)
                }
            ),
            new("Ippon-Datara", "Hermit", 17,
                stats: new(15, 6, 14, 13, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Mudo", 0),
                    new("Maragi", 0),
                    new("Mamudo", 19),
                    new("Agilao", 20),
                    new("Rampage", 21),
                    new("Mudo Boost", 22)
                }
            ),
            new("Yaksini", "Empress", 18,
                stats: new(13, 16, 10, 12, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufu", 0),
                    new("Arm Chopper", 0),
                    new("Rakunda", 0),
                    new("Swift Strike", 20),
                    new("Ice Boost", 21),
                    new("Bufula", 22),
                    new("Auto-Tarukaja", 23)
                }
            ),
            new("Ame No Uzume", "Aeon", 18,
                stats: new(9, 15, 12, 10, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Media", 0),
                    new("Magaru", 0),
                    new("Hama", 0),
                    new("Invigorate 1", 20),
                    new("Re Patra", 21),
                    new("Auto-Rakukaja", 23),
                    new("Trafuri", 24)
                }
            ),
            new("Ara Mitama", "Chariot", 18,
                stats: new(11, 11, 11, 11, 11),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Assault Dive", 0),
                    new("Rakunda", 0),
                    new("Tarukaja", 20),
                    new("Sharp Student", 21),
                    new("Blue Wall", 22),
                    new("Dodge Elec", 23)
                }
            ),
            new("Principality", "Justice", 19,
                stats: new(11, 15, 10, 18, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hama", 0),
                    new("Twin Shot", 0),
                    new("Mahama", 21),
                    new("Media", 22),
                    new("Resist Confuse", 23),
                    new("Survive Dark", 24),
                    new("Tetraja", 25)
                }
            ),
            new("Vetala", "Devil", 19,
                stats: new(17, 10, 14, 12, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Foolish Whisper", 0),
                    new("Evil Touch", 0),
                    new("Life Drain", 20),
                    new("Foul Breath", 21),
                    new("Brain Shake", 22),
                    new("Ghastly Wail", 23),
                    new("Fear Boost", 24)
                }
            ),
            new("Andra", "Moon", 20,
                stats: new(14, 16, 13, 12, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Media", 0),
                    new("Mazio", 0),
                    new("Sukukaja", 0),
                    new("Blue Wall", 22),
                    new("Regenerate 2", 23),
                    new("Zionga", 24),
                    new("Dodge Wind", 25)
                }
            ),
            new("Gurr", "Jester", 20,
                stats: new(16, 11, 14, 15, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Muzzle Shot", 0),
                    new("Auto-Tarukaja", 0),
                    new("Growth 1", 21),
                    new("Swift Strike", 22),
                    new("Poison Boost", 25),
                    new("Resist Physical", 27)
                }
            ),
            new("Phoenix", "Sun", 20,
                stats: new(9, 15, 9, 20, 14),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garula", 0),
                    new("Maragi", 0),
                    new("Twin Shot", 22),
                    new("Growth 1", 23),
                    new("Dodge Ice", 25),
                    new("Fire Boost", 26),
                    new("Maragion", 27)
                }
            ),
            new("Legion", "Fool", 21,
                stats: new(14, 14, 18, 13, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Tentarafoo", 0),
                    new("Mudo", 0),
                    new("Evil Smile", 0),
                    new("Rampage", 23),
                    new("Confuse Boost", 24),
                    new("Foul Breath", 25),
                    new("Survive Light", 26)
                }
            ),
            new("Shiisaa", "Hierophant", 21,
                stats: new(18, 18, 9, 14, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mazio", 0),
                    new("Balzac", 0),
                    new("Rakukaja", 22),
                    new("Zionga", 23),
                    new("Silence Boost", 24),
                    new("Resist Fire", 25),
                    new("Null Rage", 26)
                }
            ),
            new("High Pixie", "Priestess", 22,
                stats: new(10, 21, 10, 19, 13),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mazio", 0),
                    new("Sukukaja", 0),
                    new("Me Patra", 0),
                    new("Zionga", 24),
                    new("Invigorate 1", 25),
                    new("Dodge Fire", 26),
                    new("Trafuri", 27)
                }
            ),
            new("King Frost", "Emperor", 22,
                stats: new(11, 20, 17, 13, 12),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Bufula", 0),
                    new("Mabufu", 0),
                    new("Ice Break", 0),
                    new("Rakukaja", 23),
                    new("Dodge Fire", 24),
                    new("Ice Boost", 26),
                    new("Null Fire", 27),
                    new("Anima Freeze", 28)
                }
            ),
            new("Yomotsu-Ikusa", "Hanged Man", 22,
                stats: new(17, 16, 18, 12, 10),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Cell Breaker", 0),
                    new("Mabufu", 0),
                    new("Enervate Boost", 24),
                    new("Foul Breath", 25),
                    new("Poison Mist", 26),
                    new("Poison Boost", 27)
                }
            ),
            new("Rakshasa", "Strength", 23,
                stats: new(19, 12, 18, 14, 13),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Kill Rush", 0),
                    new("Brain Shake", 0),
                    new("Counter", 0),
                    new("Gale Slash", 25),
                    new("Auto-Tarukaja", 26),
                    new("Dodge Physical", 27),
                    new("Power Charge", 28)
                }
            ),
            new("Nigi Mitama", "Temperance", 23,
                stats: new(15, 16, 14, 15, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Diarama", 0),
                    new("Me Patra", 0),
                    new("Re Patra", 0),
                    new("Recarm", 25),
                    new("Invigorate 2", 26),
                    new("Garula", 28),
                    new("Resist Enervate", 29)
                }
            ),
            new("Matador", "Death", 24,
                stats: new(17, 10, 16, 25, 11),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mamudo", 0),
                    new("Swift Strike", 0),
                    new("Dekunda", 0),
                    new("Mudo Boost", 26),
                    new("Rampage", 27),
                    new("Auto-Sukukaja", 29),
                    new("Survive Light", 30)
                }
            ),
            new("Narcissus", "Aeon", 24,
                stats: new(13, 18, 11, 16, 21),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Foolish Whisper", 0),
                    new("Tentarafoo", 0),
                    new("Magaru", 0),
                    new("Old One", 25),
                    new("Resist Fire", 26),
                    new("Anima Freeze", 27),
                    new("Ailment Boost", 30)
                }
            ),
            new("Kaiwan", "Star", 24,
                stats: new(16, 23, 14, 15, 11),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Tetrakarn", 0),
                    new("Cell Breaker", 0),
                    new("Mamudo", 0),
                    new("Stagnant Air", 26),
                    new("Resist Light", 27),
                    new("Life Drain", 28),
                    new("Spirit Drain", 29)
                }
            ),
            new("Hua Po", "Magician", 25,
                stats: new(14, 21, 15, 17, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Rakukaja", 0),
                    new("Re Patra", 0),
                    new("Fire Break", 26),
                    new("Makajam", 27),
                    new("Dodge Ice", 29),
                    new("Fire Boost", 30)
                }
            ),
            new("Queen Mab", "Lovers", 25,
                stats: new(17, 19, 15, 17, 14),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Tentarafoo", 0),
                    new("Dekunda", 0),
                    new("Recarm", 26),
                    new("Dodge Wind", 27),
                    new("Mazionga", 29),
                    new("Resist Confuse", 30)
                }
            ),
            new("Ares", "Chariot", 25,
                stats: new(18, 15, 20, 15, 14),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Gale Slash", 0),
                    new("Counter", 0),
                    new("Dodge Wind", 27),
                    new("Rampage", 28),
                    new("Dekaja", 29),
                    new("Power Charge", 30)
                }
            ),
            new("Titania", "Empress", 26,
                stats: new(12, 23, 15, 19, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Diarama", 0),
                    new("Magaru", 0),
                    new("Red Wall", 27),
                    new("Garula", 29),
                    new("Regenerate 2", 31),
                    new("Mind Charge", 32)
                }
            ),
            new("Lamia", "Hermit", 26,
                stats: new(16, 23, 12, 20, 14),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Poison Mist", 0),
                    new("Agilao", 0),
                    new("Nervundi", 0),
                    new("Poison Boost", 28),
                    new("Null Poison", 29),
                    new("Soul Break", 30),
                    new("Maragion", 32)
                }
            ),
            new("Power", "Justice", 27,
                stats: new(21, 20, 11, 17, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hama", 0),
                    new("Tentarafoo", 0),
                    new("Mahama", 0),
                    new("Zionga", 29),
                    new("Power Slash", 30),
                    new("Hama Boost", 31),
                    new("Survive Dark", 32),
                    new("Null Confuse", 33)
                }
            ),
            new("Take-Minakata", "Jester", 27,
                stats: new(20, 20, 22, 14, 12),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mazio", 0),
                    new("Zionga", 0),
                    new("Survive Light", 29),
                    new("Auto-Rakukaja", 30),
                    new("Dekaja", 31),
                    new("Dodge Physical", 33)
                }
            ),
            new("Makami", "Hanged Man", 27,
                stats: new(16, 21, 13, 22, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Sukunda", 0),
                    new("Auto-Sukukaja", 29),
                    new("Diarama", 30),
                    new("Resist Mute", 31),
                    new("Dodge Physical", 32),
                    new("Resist Ice", 33)
                }
            ),
            new("Nozuchi", "Moon", 27,
                stats: new(26, 13, 19, 15, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Poison Mist", 0),
                    new("Enervation", 0),
                    new("Ailment Boost", 0),
                    new("Zionga", 29),
                    new("Rakukaja", 30),
                    new("Null Poison", 31),
                    new("Null Enervate", 32)
                }
            ),
            new("Kusi Mitama", "Strength", 28,
                stats: new(18, 21, 12, 19, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garula", 0),
                    new("Zionga", 0),
                    new("Soul Break", 0),
                    new("Survive Light", 31),
                    new("Survive Dark", 32),
                    new("Traesto", 33),
                    new("Exhaust Boost", 34)
                }
            ),
            new("Incubus", "Devil", 28,
                stats: new(17, 22, 16, 19, 17),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Evil Smile", 0),
                    new("Mind Slice", 0),
                    new("Stagnant Air", 30),
                    new("Spirit Drain", 32),
                    new("Ghastly Wail", 33)
                }
            ),
            new("Ganga", "Priestess", 29,
                stats: new(16, 22, 16, 19, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Bufula", 0),
                    new("Diarama", 0),
                    new("Dekaja", 0),
                    new("Mind Slice", 31),
                    new("Confuse Boost", 32),
                    new("Mediarama", 33),
                    new("Evade Fire", 35)
                }
            ),
            new("Unicorn", "Hierophant", 29,
                stats: new(17, 22, 19, 22, 14),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Mahama", 0),
                    new("Nervundi", 0),
                    new("Dekunda", 31),
                    new("Trafuri", 32),
                    new("Recarm", 33),
                    new("Mazionga", 34)
                }
            ),
            new("Oni", "Strength", 30,
                stats: new(25, 12, 26, 18, 16),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Fatal End", 0),
                    new("Counter", 0),
                    new("Cruel Attack", 0),
                    new("Atom Smasher", 32),
                    new("Resist Physical", 33),
                    new("Endure", 34),
                    new("Power Charge", 35)
                }
            ),
            new("Ose", "Fool", 31,
                stats: new(28, 12, 20, 25, 15),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None),
                skills: new()
                {
                    new("Power Slash", 0),
                    new("Atom Smasher", 0),
                    new("Power Charge", 0),
                    new("Poison Mist", 33),
                    new("Poison Boost", 34),
                    new("Auto-Sukukaja", 35),
                    new("Survive Light", 36)
                }
            ),
            new("Mithra", "Temperance", 31,
                stats: new(22, 26, 21, 16, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Mahama", 0),
                    new("Seal Bomb", 0),
                    new("Tetra Break", 33),
                    new("Hamaon", 34),
                    new("Dodge Elec", 35),
                    new("Hama Boost", 36),
                    new("Null Mute", 37)
                }
            ),
            new("Sati", "Aeon", 31,
                stats: new(19, 27, 20, 17, 17),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maragi", 0),
                    new("Agilao", 0),
                    new("Energy Shower", 0),
                    new("Diarama", 33),
                    new("Trafuri", 34),
                    new("Maragion", 36)
                }
            ),
            new("Gdon", "Sun", 31,
                stats: new(27, 10, 23, 22, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Maragi", 0),
                    new("Fire Break", 0),
                    new("Growth 2", 33),
                    new("Maragion", 34),
                    new("Fire Boost", 35),
                    new("Evade Ice", 36)
                }
            ),
            new("Pyro Jack", "Magician", 32,
                stats: new(16, 26, 19, 22, 20),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Tarunda", 0),
                    new("Marakukaja", 34),
                    new("Maragion", 36),
                    new("Auto-Rakukaja", 37),
                    new("Resist Ice", 38)
                }
            ),
            new("Neko Shogun", "Star", 32,
                stats: new(26, 20, 19, 23, 15),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Elec Boost", 0),
                    new("Black Spot", 0),
                    new("Mediarama", 34),
                    new("Matarukaja", 35),
                    new("Evade Wind", 36),
                    new("Divine Grace", 37)
                }
            ),
            new("Undine", "Lovers", 33,
                stats: new(21, 27, 13, 26, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Diarama", 0),
                    new("Bufula", 0),
                    new("Posumudi", 0),
                    new("Mabufula", 34),
                    new("Mediarama", 36),
                    new("Ice Boost", 37)
                }
            ),
            new("Virtue", "Justice", 33,
                stats: new(22, 29, 21, 19, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mahama", 0),
                    new("Garula", 0),
                    new("Posumudi", 0),
                    new("Fatal End", 35),
                    new("Blue Wall", 37),
                    new("Hama Boost", 38),
                    new("Resist Dark", 39)
                }
            ),
            new("Mothman", "Hermit", 33,
                stats: new(20, 23, 17, 28, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Valiant Dance", 0),
                    new("Foul Breath", 35),
                    new("Elec Break", 36),
                    new("Mazionga", 37),
                    new("Rage Boost", 38)
                }
            ),
            new("Gorgon", "Empress", 34,
                stats: new(20, 21, 25, 24, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new()
                {
                    new("Bufula", 0),
                    new("Me Patra", 0),
                    new("Crazy Chain", 35),
                    new("Null Confuse", 36),
                    new("Mabufula", 38),
                    new("Ice Boost", 39)
                }
            ),
            new("Setanta", "Emperor", 34,
                stats: new(23, 21, 25, 24, 16),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Fatal End", 0),
                    new("Zionga", 0),
                    new("Sharp Student", 0),
                    new("Counterstrike", 36),
                    new("Power Charge", 38),
                    new("Auto-Maraku", 39),
                    new("Null Fire", 40)
                }
            ),
            new("Pale Rider", "Jester", 34,
                stats: new(25, 24, 21, 24, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Mamudo", 0),
                    new("Mind Slice", 0),
                    new("Garula", 0),
                    new("Counterstrike", 35),
                    new("Mudoon", 37),
                    new("Survive Light", 39)
                }
            ),
            new("Yamata-No-Orochi", "Moon", 34,
                stats: new(29, 21, 26, 18, 15),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufula", 0),
                    new("Garula", 0),
                    new("Red Wall", 0),
                    new("Green Wall", 36),
                    new("Resist Enervate", 38),
                    new("Ice Boost", 39)
                }
            ),
            new("Fortuna", "Fortune", 35,
                stats: new(19, 23, 22, 26, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garula", 0),
                    new("Rakukaja", 0),
                    new("Dodge Elec", 37),
                    new("Magarula", 38),
                    new("Auto-Sukukaja", 39),
                    new("Wind Boost", 40)
                }
            ),
            new("Taotie", "Tower", 35,
                stats: new(20, 27, 30, 22, 13),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Megido", 0),
                    new("Mind Slice", 0),
                    new("Dekunda", 0),
                    new("Confuse Boost", 37),
                    new("Mind Charge", 38),
                    new("Null Enervate", 40),
                    new("Torrent Shot", 41)
                }
            ),
            new("Flauros", "Hierophant", 36,
                stats: new(30, 20, 24, 20, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Fatal End", 0),
                    new("Tarukaja", 0),
                    new("Agilao", 0),
                    new("Herculean Strike", 38),
                    new("Apt Pupil", 39),
                    new("Dodge Ice", 40),
                    new("Crazy Chain", 41)
                }
            ),
            new("Samael", "Death", 36,
                stats: new(24, 29, 25, 19, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Matarunda", 0),
                    new("Poison Mist", 0),
                    new("Dekunda", 38),
                    new("Megido", 39),
                    new("Mudo Boost", 40),
                    new("Survive Light", 41)
                }
            ),
            new("Parvati", "Priestess", 37,
                stats: new(20, 29, 17, 25, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Diarama", 0),
                    new("Nervundi", 0),
                    new("Mediarama", 39),
                    new("Marakukaja", 40),
                    new("Dodge Elec", 41),
                    new("Divine Grace", 43)
                }
            ),
            new("Raja Naga", "Aeon", 37,
                stats: new(25, 26, 24, 22, 21),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Fatal End", 0),
                    new("Tentarafoo", 0),
                    new("Matarukaja", 38),
                    new("Torrent Shot", 39),
                    new("Null Confuse", 40),
                    new("Mazionga", 42),
                    new("Confuse Boost", 43)
                }
            ),
            new("Pazuzu", "Devil", 37,
                stats: new(27, 15, 28, 29, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Rakukaja", 0),
                    new("Bufula", 0),
                    new("Stagnant Air", 39),
                    new("Ailment Boost", 40),
                    new("Navas Nebula", 41),
                    new("Cool Breeze", 42)
                }
            ),
            new("Black Frost", "Fool", 38,
                stats: new(23, 31, 22, 23, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Maragion", 0),
                    new("Bufula", 0),
                    new("Ice Boost", 0),
                    new("Mind Charge", 40),
                    new("Masukunda", 41),
                    new("Fire Amp", 42),
                    new("Agidyne", 43),
                    new("Mudoon", 44)
                }
            ),
            new("Dominion", "Justice", 38,
                stats: new(22, 32, 25, 24, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Zionga", 0),
                    new("Hama Boost", 40),
                    new("Resist Exhaust", 41),
                    new("Mazionga", 42),
                    new("Survive Dark", 43),
                    new("Null Dark", 44)
                }
            ),
            new("Dis", "Magician", 39,
                stats: new(25, 31, 24, 26, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maragion", 0),
                    new("Diarama", 0),
                    new("Dekunda", 0),
                    new("Dodge Ice", 41),
                    new("Masukunda", 42),
                    new("Agidyne", 43),
                    new("Mind Charge", 44)
                }
            ),
            new("Orthrus", "Hanged Man", 39,
                stats: new(34, 21, 28, 23, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Black Spot", 0),
                    new("Marakukaja", 41),
                    new("Fire Boost", 42),
                    new("Maragion", 44),
                    new("Null Ice", 45)
                }
            ),
            new("Genbu", "Temperance", 40,
                stats: new(28, 27, 39, 12, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufula", 0),
                    new("Marakukaja", 0),
                    new("Regenerate 2", 42),
                    new("Makara Break", 43),
                    new("Blue Wall", 44),
                    new("Resist Physical", 45),
                    new("Evade Elec", 46)
                }
            ),
            new("Loa", "Jester", 40,
                stats: new(25, 30, 28, 23, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Life Drain", 0),
                    new("Matarunda", 0),
                    new("Survive Light", 42),
                    new("Ziodyne", 43),
                    new("Mudo Boost", 45),
                    new("Tetraja", 47)
                }
            ),
            new("Yatagarasu", "Sun", 40,
                stats: new(28, 27, 22, 31, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Masukukaja", 0),
                    new("Nervundi", 0),
                    new("Agilao", 0),
                    new("Null Fear", 43),
                    new("Growth 2", 44),
                    new("Diarahan", 45),
                    new("Cool Breeze", 46)
                }
            ),
            new("Okuninushi", "Emperor", 41,
                stats: new(29, 34, 25, 20, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Blade of Fury", 0),
                    new("Counterstrike", 43),
                    new("Mazionga", 44),
                    new("Apt Pupil", 45),
                    new("Elec Boost", 46),
                    new("Null Wind", 47)
                }
            ),
            new("Hitokoto-Nushi", "Hermit", 41,
                stats: new(28, 33, 30, 20, 19),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Foolish Whisper", 0),
                    new("Auto-Sukukaja", 0),
                    new("Poison Arrow", 0),
                    new("Zionga", 43),
                    new("Resist Fire", 45),
                    new("Elec Boost", 46),
                    new("Auto-Masuku", 47)
                }
            ),
            new("Alraune", "Moon", 41,
                stats: new(17, 35, 21, 29, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Mediarama", 0),
                    new("Energy Shower", 0),
                    new("Old One", 0),
                    new("Makarakarn", 43),
                    new("Green Wall", 44),
                    new("Null Enervate", 45),
                    new("Enervate Boost", 46)
                }
            ),
            new("Leanan Sidhe", "Lovers", 42,
                stats: new(19, 33, 26, 29, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mediarama", 0),
                    new("Me Patra", 0),
                    new("Tentarafoo", 43),
                    new("Confuse Boost", 44),
                    new("Energy Shower", 45),
                    new("Samarecarm", 46),
                    new("Divine Grace", 47)
                }
            ),
            new("Hanuman", "Strength", 42,
                stats: new(31, 25, 31, 21, 25),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mighty Swing", 0),
                    new("Rakunda", 0),
                    new("Recarm", 0),
                    new("Blade of Fury", 44),
                    new("Endure", 47),
                    new("Power Charge", 48)
                }
            ),
            new("Triglav", "Chariot", 43,
                stats: new(33, 23, 27, 32, 21),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Heat Wave", 0),
                    new("Counterstrike", 0),
                    new("Marakukaja", 45),
                    new("Mustard Bomb", 46),
                    new("Null Dizzy", 47),
                    new("Blue Wall", 48),
                    new("Power Charge", 49)
                }
            ),
            new("Fuu-Ki", "Star", 43,
                stats: new(25, 32, 34, 27, 18),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garula", 0),
                    new("Torrent Shot", 0),
                    new("Counterstrike", 0),
                    new("Evade Fire", 45),
                    new("Apt Pupil", 46),
                    new("Wind Boost", 47),
                    new("Null Exhaust", 49)
                }
            ),
            new("Gabriel", "Empress", 44,
                stats: new(28, 34, 22, 30, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mabufula", 0),
                    new("Mediarama", 0),
                    new("Energy Shower", 45),
                    new("Survive Dark", 47),
                    new("Heat Wave", 48),
                    new("Divine Grace", 50)
                }
            ),
            new("Clotho", "Fortune", 44,
                stats: new(22, 31, 28, 26, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Magarula", 0),
                    new("Mutudi", 0),
                    new("Navas Nebula", 45),
                    new("Makarakarn", 47),
                    new("Wind Boost", 48),
                    new("Garudyne", 49),
                    new("Null Enervate", 50)
                }
            ),
            new("Kushinada", "Aeon", 44,
                stats: new(25, 32, 27, 24, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Matarukaja", 0),
                    new("Mediarama", 0),
                    new("Red Wall", 0),
                    new("Maragion", 46),
                    new("Null Fire", 48),
                    new("Makarakarn", 50)
                }
            ),
            new("Succubus", "Devil", 44,
                stats: new(22, 33, 28, 32, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Agilao", 0),
                    new("Mudoon", 0),
                    new("Maragion", 46),
                    new("Mudo Boost", 47),
                    new("Spirit Drain", 48),
                    new("Resist Light", 49),
                    new("Invigorate 3", 50)
                }
            ),
            new("Thoth", "Emperor", 45,
                stats: new(28, 43, 23, 21, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mazionga", 0),
                    new("Mahama", 0),
                    new("Megido", 0),
                    new("Mediarama", 47),
                    new("Growth 2", 48),
                    new("Null Mute", 49),
                    new("Ziodyne", 51)
                }
            ),
            new("Hokuto Seikun", "Hierophant", 45,
                stats: new(29, 34, 31, 26, 22),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Zionga", 0),
                    new("Elec Boost", 0),
                    new("Navas Nebula", 0),
                    new("Blade of Fury", 47),
                    new("Resist Exhaust", 48),
                    new("Counterstrike", 50),
                    new("Ziodyne", 51)
                }
            ),
            new("Decarabia", "Fool", 46,
                stats: new(27, 36, 25, 26, 31),
                elementAffinities: new(ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Matarunda", 0),
                    new("Tetrakarn", 0),
                    new("Evade Physical", 48),
                    new("Megidola", 50),
                    new("Fire Amp", 51),
                    new("Resist Physical", 52)
                }
            ),
            new("Mot", "Death", 46,
                stats: new(32, 38, 30, 24, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Evil Smile", 0),
                    new("Tentarafoo", 0),
                    new("Survive Light", 48),
                    new("Ghastly Wail", 49),
                    new("Mudo Boost", 50)
                }
            ),
            new("Cu Chulainn", "Tower", 46,
                stats: new(40, 32, 28, 25, 20),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Magarula", 0),
                    new("Deathbound", 0),
                    new("Matarukaja", 47),
                    new("Mind Charge", 48),
                    new("White Wall", 49),
                    new("Endure Dark", 50),
                    new("Garudyne", 51),
                    new("Wind Amp", 53)
                }
            ),
            new("Rangda", "Magician", 47,
                stats: new(24, 37, 30, 25, 32),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maragion", 0),
                    new("Tentarafoo", 0),
                    new("Agidyne", 49),
                    new("Dodge Ice", 50),
                    new("Mustard Bomb", 51),
                    new("Repel Physical", 55)
                }
            ),
            new("Baphomet", "Jester", 47,
                stats: new(25, 35, 35, 26, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Evil Smile", 0),
                    new("Maragion", 0),
                    new("Ghastly Wail", 0),
                    new("Ailment Boost", 49),
                    new("Dodge Physical", 50),
                    new("Mamudoon", 52),
                    new("Mudo Boost", 53)
                }
            ),
            new("Seiryu", "Temperance", 47,
                stats: new(30, 31, 33, 28, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mazionga", 0),
                    new("Matarunda", 0),
                    new("Ziodyne", 49),
                    new("Poison Mist", 50),
                    new("Elec Break", 51),
                    new("Elec Boost", 52),
                    new("Resist Exhaust", 53)
                }
            ),
            new("Narasimha", "Sun", 47,
                stats: new(29, 27, 30, 35, 27),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Tempest Slash", 0),
                    new("Counterstrike", 48),
                    new("Evade Wind", 49),
                    new("Mahamaon", 51),
                    new("Auto-Mataru", 53)
                }
            ),
            new("Kikuri-Hime", "Priestess", 48,
                stats: new(26, 36, 28, 31, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mediarama", 0),
                    new("Posumudi", 0),
                    new("Agilao", 0),
                    new("Samarecarm", 50),
                    new("Diarahan", 52),
                    new("Resist Dark", 53),
                    new("Divine Grace", 54)
                }
            ),
            new("Kurama Tengu", "Hermit", 48,
                stats: new(30, 34, 28, 38, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garula", 0),
                    new("Marakunda", 0),
                    new("Vicious Strike", 0),
                    new("Growth 2", 50),
                    new("Wind Boost", 51),
                    new("Red Wall", 52),
                    new("Resist Elec", 53)
                }
            ),
            new("Girimehkala", "Moon", 48,
                stats: new(36, 35, 23, 30, 27),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Weak),
                skills: new()
                {
                    new("Power Charge", 0),
                    new("Mighty Swing", 0),
                    new("Poison Mist", 0),
                    new("Mamudoon", 50),
                    new("Blight", 51),
                    new("Tetraja", 52),
                    new("Endure Light", 53),
                    new("Repel Physical", 56)
                }
            ),
            new("Throne", "Justice", 49,
                stats: new(37, 30, 24, 37, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Agidyne", 0),
                    new("Hama Boost", 0),
                    new("Mind Charge", 51),
                    new("Regenerate 2", 53),
                    new("Resist Dark", 54),
                    new("Endure Dark", 55)
                }
            ),
            new("Yatsufusa", "Hanged Man", 49,
                stats: new(32, 33, 27, 36, 26),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Masukukaja", 0),
                    new("Fire Boost", 0),
                    new("Heat Wave", 51),
                    new("Power Charge", 52),
                    new("Dodge Physical", 53),
                    new("Maragidyne", 54),
                    new("Mind Charge", 55)
                }
            ),
            new("Kali", "Strength", 50,
                stats: new(37, 25, 36, 35, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Mudoon", 0),
                    new("Deathbound", 52),
                    new("Revolution", 53),
                    new("High Counter", 54),
                    new("Power Charge", 55)
                }
            ),
            new("Ganesha", "Star", 50,
                stats: new(38, 29, 31, 27, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Mustard Bomb", 0),
                    new("Makarakarn", 0),
                    new("Power Charge", 52),
                    new("High Counter", 54),
                    new("Endure", 55),
                    new("Magarudyne", 56)
                }
            ),
            new("Pabilsag", "Emperor", 51,
                stats: new(38, 29, 30, 33, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Blight", 0),
                    new("Foolish Whisper", 0),
                    new("Stagnant Air", 53),
                    new("Silence Boost", 54),
                    new("Mudoon", 55),
                    new("Arrow Rain", 56)
                }
            ),
            new("Quetzalcoatl", "Aeon", 51,
                stats: new(30, 31, 31, 35, 33),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Magarula", 0),
                    new("Masukukaja", 0),
                    new("Growth 2", 0),
                    new("Garudyne", 52),
                    new("Heat Wave", 53),
                    new("Mahamaon", 55),
                    new("Wind Amp", 57)
                }
            ),
            new("Lachesis", "Fortune", 51,
                stats: new(31, 39, 25, 34, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Masukukaja", 0),
                    new("Recarm", 53),
                    new("Makara Break", 54),
                    new("Absorb Wind", 55),
                    new("Red Wall", 56),
                    new("Resist Exhaust", 57)
                }
            ),
            new("Skadi", "Empress", 52,
                stats: new(27, 37, 32, 36, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufula", 0),
                    new("Aeon Rain", 0),
                    new("Bufudyne", 54),
                    new("Ice Amp", 56),
                    new("Repel Ice", 57),
                    new("Repel Fire", 59),
                    new("Spell Master", 60)
                }
            ),
            new("Cerberus", "Hierophant", 52,
                stats: new(37, 30, 32, 35, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Gigantic Fist", 0),
                    new("Vicious Strike", 53),
                    new("Maragidyne", 53),
                    new("Regenerate 2", 55),
                    new("Fire Amp", 57),
                    new("Auto-Sukukaja", 58)
                }
            ),
            new("Raphael", "Lovers", 53,
                stats: new(32, 38, 24, 33, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Diarahan", 0),
                    new("Megidola", 0),
                    new("Masukukaja", 55),
                    new("Amrita", 56),
                    new("Null Dizzy", 57),
                    new("Mediarahan", 59)
                }
            ),
            new("Lilith", "Devil", 53,
                stats: new(30, 43, 30, 36, 27),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Makarakarn", 0),
                    new("Old One", 54),
                    new("Maziodyne", 55),
                    new("Elec Break", 56),
                    new("Ailment Boost", 57)
                }
            ),
            new("Tam Lin", "Sun", 53,
                stats: new(45, 31, 34, 39, 25),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Deathbound", 0),
                    new("High Counter", 0),
                    new("Auto-Maraku", 54),
                    new("Power Charge", 55),
                    new("Elec Amp", 56),
                    new("Evade Physical", 58),
                    new("Enduring Soul", 59)
                }
            ),
            new("Kin-Ki", "Chariot", 54,
                stats: new(41, 25, 53, 23, 27),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Vile Assault", 0),
                    new("High Counter", 0),
                    new("Gigantic Fist", 56),
                    new("Seal Bomb", 57),
                    new("Revolution", 59),
                    new("Power Charge", 60)
                }
            ),
            new("Suzaku", "Temperance", 54,
                stats: new(30, 36, 31, 42, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maragion", 0),
                    new("Energy Shower", 0),
                    new("Masukukaja", 55),
                    new("Agidyne", 56),
                    new("Resist Ice", 58),
                    new("Fire Amp", 59),
                    new("Auto-Masuku", 60)
                }
            ),
            new("Nidhoggr", "Hermit", 55,
                stats: new(23, 41, 35, 31, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Mamudoon", 0),
                    new("Evil Smile", 0),
                    new("Ghastly Wail", 57),
                    new("Bufudyne", 58),
                    new("Stagnant Air", 59),
                    new("Resist Physical", 60),
                    new("Ice Boost", 61)
                }
            ),
            new("Kumbhanda", "Jester", 55,
                stats: new(37, 36, 35, 44, 20),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Auto-Masuku", 0),
                    new("Alertness", 56),
                    new("Fire Amp", 58),
                    new("Resist Elec", 59),
                    new("Deathbound", 60),
                    new("Tetraja", 61)
                }
            ),
            new("Abaddon", "Tower", 55,
                stats: new(43, 27, 50, 23, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Old One", 0),
                    new("Mudoon", 0),
                    new("Arrow Rain", 0),
                    new("Agidyne", 56),
                    new("Endure Light", 57),
                    new("Tetra Break", 60),
                    new("Null Physical", 62)
                }
            ),
            new("Shiki-Ouji", "Fool", 56,
                stats: new(50, 29, 31, 41, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Navas Nebula", 0),
                    new("Matarunda", 0),
                    new("Revolution", 0),
                    new("Apt Pupil", 58),
                    new("Growth 2", 59),
                    new("Null Physical", 62)
                }
            ),
            new("Taowu", "Hanged Man", 56,
                stats: new(40, 37, 31, 38, 29),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Aeon Rain", 0),
                    new("Dekaja", 0),
                    new("Matarukaja", 0),
                    new("Null Enervate", 58),
                    new("Power Charge", 60),
                    new("Evade Physical", 61),
                    new("Absorb Fire", 62)
                }
            ),
            new("Garuda", "Star", 57,
                stats: new(39, 33, 28, 47, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new()
                {
                    new("Diarama", 0),
                    new("Garudyne", 0),
                    new("Arrow Rain", 0),
                    new("Amrita", 60),
                    new("High Counter", 61),
                    new("Repel Wind", 62),
                    new("Auto-Sukukaja", 63)
                }
            ),
            new("Sui-Ki", "Moon", 57,
                stats: new(42, 49, 43, 33, 17),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Power Charge", 0),
                    new("Vicious Strike", 0),
                    new("Regenerate 2", 59),
                    new("Tetra Break", 60),
                    new("Enduring Soul", 62)
                }
            ),
            new("Uriel", "Justice", 58,
                stats: new(35, 42, 37, 36, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Maragion", 0),
                    new("Hamaon", 0),
                    new("High Counter", 60),
                    new("Agidyne", 61),
                    new("Endure Dark", 62),
                    new("Fire Amp", 63),
                    new("Null Dark", 64)
                }
            ),
            new("Ananta", "Fortune", 58,
                stats: new(43, 42, 45, 28, 23),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufula", 0),
                    new("White Wall", 0),
                    new("Marakukaja", 59),
                    new("Bufudyne", 61),
                    new("Green Wall", 62),
                    new("Invigorate 3", 63),
                    new("Null Exhaust", 64)
                }
            ),
            new("Kingu", "Aeon", 58,
                stats: new(38, 44, 38, 30, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant),
                skills: new()
                {
                    new("Mediarama", 0),
                    new("Evade Fire", 0),
                    new("Auto-Masuku", 0),
                    new("Null Confuse", 59),
                    new("Null Poison", 60),
                    new("Vicious Strike", 62),
                    new("Endure", 63)
                }
            ),
            new("White Rider", "Death", 58,
                stats: new(49, 31, 37, 40, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Hamaon", 0),
                    new("Agidyne", 60),
                    new("Evade Ice", 62),
                    new("Mahamaon", 63),
                    new("Mamudoon", 65),
                    new("Hama Boost", 66),
                    new("Mudo Boost", 67)
                }
            ),
            new("Hariti", "Priestess", 59,
                stats: new(31, 47, 33, 34, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Diarahan", 0),
                    new("Bufudyne", 0),
                    new("Marakukaja", 0),
                    new("Mediarahan", 61),
                    new("Arrow Rain", 62),
                    new("Samarecarm", 64)
                }
            ),
            new("Anubis", "Judgement", 59,
                stats: new(38, 41, 37, 37, 31),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Makarakarn", 0),
                    new("Mudoon", 0),
                    new("Poison Arrow", 60),
                    new("Mustard Bomb", 61),
                    new("Megidola", 62),
                    new("Mahamaon", 64),
                    new("Hama Boost", 65)
                }
            ),
            new("Mother Harlot", "Empress", 60,
                stats: new(38, 47, 37, 29, 36),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Maziodyne", 0),
                    new("Mamudoon", 0),
                    new("Mudo Boost", 62),
                    new("Foolish Whisper", 63),
                    new("Resist Fire", 64),
                    new("Ailment Boost", 65)
                }
            ),
            new("Daisoujou", "Hierophant", 60,
                stats: new(34, 45, 40, 30, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Diarahan", 0),
                    new("Makarakarn", 0),
                    new("Agidyne", 62),
                    new("Endure Dark", 63),
                    new("Mahamaon", 64),
                    new("Hama Boost", 65),
                    new("Samsara", 67)
                }
            ),
            new("Belphegor", "Devil", 61,
                stats: new(40, 48, 42, 39, 21),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Maziodyne", 0),
                    new("Evil Smile", 0),
                    new("Marakunda", 63),
                    new("Fear Boost", 64),
                    new("Old One", 65),
                    new("Enervate Boost", 66),
                    new("Elec Amp", 67)
                }
            ),
            new("Jatayu", "Sun", 61,
                stats: new(38, 44, 35, 48, 25),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Null Confuse", 0),
                    new("Amrita", 62),
                    new("Growth 3", 64),
                    new("Repel Elec", 65),
                    new("Magarudyne", 66)
                }
            ),
            new("Jinn", "Magician", 62,
                stats: new(37, 51, 38, 39, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Foolish Whisper", 0),
                    new("Resist Physical", 65),
                    new("Fire Boost", 66),
                    new("Null Physical", 67),
                    new("Valiant Dance", 68)
                }
            ),
            new("Chernobog", "Jester", 62,
                stats: new(46, 47, 32, 35, 33),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Mamudoon", 0),
                    new("Rainy Death", 0),
                    new("Tetra Break", 0),
                    new("Myriad Arrows", 64),
                    new("Resist Wind", 66),
                    new("Megidola", 68),
                    new("Invigorate 3", 69)
                }
            ),
            new("Byakko", "Temperance", 62,
                stats: new(47, 32, 35, 49, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Deathbound", 0),
                    new("High Counter", 0),
                    new("Auto-Sukukaja", 64),
                    new("Amrita", 66),
                    new("Ice Amp", 67),
                    new("Mabufudyne", 68)
                }
            ),
            new("Mara", "Tower", 62,
                stats: new(44, 35, 48, 36, 30),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Blight", 0),
                    new("Power Charge", 63),
                    new("Makarakarn", 64),
                    new("Absorb Physical", 66),
                    new("Fire Amp", 67)
                }
            ),
            new("Nebiros", "Hermit", 63,
                stats: new(38, 47, 39, 40, 32),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Mamudoon", 0),
                    new("Agidyne", 0),
                    new("Dekaja", 0),
                    new("Mind Charge", 65),
                    new("Mudo Boost", 67),
                    new("Null Light", 69),
                    new("Spell Master", 70)
                }
            ),
            new("Siegfried", "Strength", 63,
                stats: new(48, 36, 41, 38, 33),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Akasha Arts", 0),
                    new("Power Charge", 0),
                    new("Masukukaja", 0),
                    new("High Counter", 65),
                    new("Regenerate 3", 66),
                    new("Rainy Death", 68),
                    new("God's Hand", 70)
                }
            ),
            new("Loki", "Fool", 64,
                stats: new(48, 50, 31, 47, 23),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Rakukaja", 0),
                    new("Sharp Student", 0),
                    new("Ice Amp", 66),
                    new("High Counter", 67),
                    new("Mabufudyne", 68),
                    new("Null Fire", 69),
                    new("Niflheim", 70)

                },
                isUltimate: true
            ),
            new("Cybele", "Lovers", 64,
                stats: new(41, 47, 37, 39, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mediarama", 0),
                    new("Vicious Strike", 0),
                    new("Recarm", 0),
                    new("Myriad Arrows", 67),
                    new("Samarecarm", 68),
                    new("Mediarahan", 70)
                }
            ),
            new("Barong", "Emperor", 65,
                stats: new(48, 44, 40, 36, 34),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Poison Mist", 0),
                    new("Me Patra", 0),
                    new("Marakukaja", 67),
                    new("Invigorate 2", 69),
                    new("High Counter", 71),
                    new("Maziodyne", 72)
                }
            ),
            new("Lakshmi", "Aeon", 65,
                stats: new(36, 50, 37, 38, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Mabufudyne", 0),
                    new("Ice Break", 66),
                    new("Null Dark", 68),
                    new("Resist Fire", 70),
                    new("Amrita", 71)
                }
            ),
            new("Thor", "Chariot", 65,
                stats: new(43, 39, 53, 32, 35),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Deathbound", 0),
                    new("High Counter", 0),
                    new("Arms Master", 67),
                    new("Maziodyne", 68),
                    new("Null Physical", 69),
                    new("Thunder Reign", 70)
                }
            ),
            new("Atropos", "Fortune", 65,
                stats: new(36, 48, 36, 37, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Wind Boost", 0),
                    new("Mind Charge", 67),
                    new("Magarudyne", 68),
                    new("Evade Fire", 69),
                    new("Wind Amp", 70)
                }
            ),
            new("Melchizedek", "Justice", 66,
                stats: new(51, 46, 46, 34, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mediarahan", 0),
                    new("Hamaon", 0),
                    new("Akasha Arts", 0),
                    new("Matarukaja", 68),
                    new("Mahamaon", 69),
                    new("God's Hand", 72)
                }
            ),
            new("Hell Biker", "Hanged Man", 66,
                stats: new(49, 40, 40, 48, 28),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Aeon Rain", 0),
                    new("Endure", 68),
                    new("Mudoon", 69),
                    new("Maragidyne", 70),
                    new("Absorb Fire", 71),
                    new("Fire Amp", 73)
                }
            ),
            new("Kartikeya", "Star", 67,
                stats: new(47, 39, 40, 44, 38),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maziodyne", 0),
                    new("Auto-Mataru", 0),
                    new("High Counter", 68),
                    new("Myriad Arrows", 69),
                    new("Growth 2", 70),
                    new("Primal Force", 75)
                }
            ),
            new("Trumpeter", "Judgement", 67,
                stats: new(40, 47, 39, 45, 37),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Null),
                skills: new()
                {
                    new("Megidola", 0),
                    new("Ziodyne", 0),
                    new("Elec Amp", 0),
                    new("Marakukaja", 68),
                    new("Cool Breeze", 69),
                    new("Megidolaon", 70),
                    new("Debilitate", 73),
                    new("Heat Riser", 74)
                }
            ),
            new("Belial", "Devil", 68,
                stats: new(51, 31, 48, 40, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mudoon", 0),
                    new("Myriad Arrows", 0),
                    new("Agidyne", 69),
                    new("Endure Light", 71),
                    new("Fire Amp", 72),
                    new("Maragidyne", 73)
                }
            ),
            new("Seth", "Moon", 68,
                stats: new(46, 51, 40, 39, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Magarudyne", 0),
                    new("Garudyne", 0),
                    new("Wind Break", 71),
                    new("Null Light", 72),
                    new("Wind Amp", 73),
                    new("Evade Elec", 74)
                }
            ),
            new("Seiten Taisei", "Jester", 68,
                stats: new(47, 34, 40, 48, 42),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Brave Blade", 0),
                    new("Rebellion", 0),
                    new("Evade Elec", 0),
                    new("High Counter", 69),
                    new("Arms Master", 71),
                    new("Regenerate 3", 74),
                    new("Vorpal Blade", 76)
                }
            ),
            new("Horus", "Sun", 68,
                stats: new(45, 48, 35, 45, 38),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new()
                {
                    new("Diarahan", 0),
                    new("Mahamaon", 0),
                    new("Magarudyne", 0),
                    new("Wind Amp", 70),
                    new("Matarukaja", 71),
                    new("Absorb Wind", 73)
                }
            ),
            new("Surt", "Magician", 69,
                stats: new(41, 54, 39, 40, 40),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Deathbound", 0),
                    new("High Counter", 0),
                    new("Maragidyne", 71),
                    new("Ragnarok", 74),
                    new("Fire Amp", 75),
                    new("Null Ice", 76)
                }
            ),
            new("Yurlungur", "Temperance", 69,
                stats: new(41, 50, 45, 43, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Virus Wave", 0),
                    new("Bufudyne", 0),
                    new("Growth 3", 71),
                    new("Mediarahan", 72),
                    new("Samarecarm", 74),
                    new("Repel Light", 75)
                }
            ),
            new("Masakado", "Tower", 69,
                stats: new(51, 32, 45, 46, 40),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mahamaon", 0),
                    new("Tempest Slash", 0),
                    new("Myriad Arrows", 71),
                    new("Hama Boost", 73),
                    new("Arms Master", 74),
                    new("Enduring Soul", 76)
                }
            ),
            new("Tzitzimitl", "Priestess", 70,
                stats: new(46, 56, 41, 39, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Virus Wave", 0),
                    new("Mustard Bomb", 0),
                    new("Silence Boost", 71),
                    new("Dekaja", 72),
                    new("Regenerate 3", 73),
                    new("Maziodyne", 76),
                    new("Repel Elec", 77)
                }
            ),
            new("Alilat", "Empress", 70,
                stats: new(39, 48, 49, 39, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Makarakarn", 0),
                    new("Mabufudyne", 0),
                    new("Regenerate 3", 72),
                    new("Evade Physical", 73),
                    new("Growth 2", 74),
                    new("Auto-Maraku", 75)
                }
            ),
            new("Hachiman", "Hierophant", 70,
                stats: new(33, 60, 39, 38, 47),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Maziodyne", 0),
                    new("Makarakarn", 0),
                    new("Matarukaja", 0),
                    new("Elec Break", 72),
                    new("Dekunda", 74),
                    new("Revolution", 75)
                }
            ),
            new("Ishtar", "Lovers", 71,
                stats: new(46, 44, 33, 48, 49),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mediarahan", 0),
                    new("Samarecarm", 0),
                    new("Mutudi", 0),
                    new("Maziodyne", 73),
                    new("Amrita", 75),
                    new("Spell Master", 76),
                    new("Absorb Wind", 77),
                    new("Salvation", 78)

                },
                isUltimate: true
            ),
            new("Vasuki", "Hanged Man", 71,
                stats: new(48, 47, 50, 340, 35),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Virus Wave", 0),
                    new("Null Poison", 73),
                    new("High Counter", 74),
                    new("Evade Wind", 75),
                    new("Mahamaon", 76),
                    new("Ziodyne", 77)
                }
            ),
            new("Atavaka", "Chariot", 72,
                stats: new(50, 41, 43, 41, 48),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Mahamaon", 0),
                    new("Diarahan", 0),
                    new("Amrita", 0),
                    new("Brave Blade", 74),
                    new("Megidolaon", 75),
                    new("Mind Charge", 76),
                    new("Arms Master", 79)
                }
            ),
            new("Norn", "Fortune", 72,
                stats: new(42, 53, 31, 48, 46),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Magarudyne", 0),
                    new("Diarahan", 0),
                    new("Auto-Masuku", 74),
                    new("Invigorate 3", 75),
                    new("Wind Amp", 76),
                    new("Insta-Heal", 77),
                    new("Debilitate", 79)

                },
                isUltimate: true
            ),
            new("Alice", "Death", 72,
                stats: new(39, 56, 33, 45, 44),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mamudoon", 0),
                    new("Mudo Boost", 0),
                    new("Dekunda", 0),
                    new("Endure Light", 75),
                    new("Megidola", 76),
                    new("Mind Charge", 77),
                    new("Die for Me!", 79)
                }
            ),
            new("Michael", "Judgement", 72,
                stats: new(45, 42, 43, 48, 45),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Vorpal Blade", 0),
                    new("Megidola", 0),
                    new("Hamaon", 0),
                    new("Megidolaon", 74),
                    new("Mahamaon", 75),
                    new("Repel Dark", 76),
                    new("Heaven's Blade", 79)
                }
            ),
            new("Arahabaki", "Hermit", 73,
                stats: new(50, 55, 62, 37, 25),
                elementAffinities: new(ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null),
                skills: new()
                {
                    new("Vicious Strike", 0),
                    new("Auto-Maraku", 0),
                    new("Null Fear", 0),
                    new("Alertness", 74),
                    new("Tetrakarn", 76),
                    new("Repel Physical", 80)
                }
            ),
            new("Vishnu", "Temperance", 73,
                stats: new(46, 52, 34, 54, 43),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Megidolaon", 0),
                    new("Akasha Arts", 0),
                    new("Mabufudyne", 0),
                    new("Regenerate 3", 75),
                    new("God's Hand", 76),
                    new("Power Charge", 78),
                    new("Angelic Grace", 79)

                },
                isUltimate: true
            ),
            new("Odin", "Emperor", 74,
                stats: new(48, 60, 42, 39, 43),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Magarudyne", 0),
                    new("Wind Amp", 76),
                    new("Regenerate 3", 77),
                    new("Maziodyne", 78),
                    new("Mind Charge", 80),
                    new("Panta Rhei", 81)

                },
                isUltimate: true
            ),
            new("Kaguya", "Aeon", 74,
                stats: new(37, 65, 36, 44, 47),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.Null),
                skills: new()
                {
                    new("Hamaon", 0),
                    new("Mediarahan", 0),
                    new("Fast Heal", 0),
                    new("Tetraja", 75),
                    new("Mahamaon", 77),
                    new("Hama Boost", 78),
                    new("Spell Master", 80)
                }
            ),
            new("Sraosha", "Justice", 74,
                stats: new(57, 36, 44, 62, 33),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mahamaon", 0),
                    new("Brave Blade", 0),
                    new("Power Charge", 0),
                    new("Ziodyne", 76),
                    new("Hama Boost", 78),
                    new("Megidolaon", 80),
                    new("Angelic Grace", 81)

                },
                isUltimate: true
            ),
            new("Yoshitsune", "Tower", 75,
                stats: new(52, 39, 49, 61, 34),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None),
                skills: new()
                {
                    new("Brave Blade", 0),
                    new("Power Charge", 0),
                    new("Ziodyne", 0),
                    new("Heat Riser", 77),
                    new("Repel Elec", 78),
                    new("Elec Amp", 79),
                    new("Hassou Tobi", 83)
                }
            ),
            new("Saturnus", "Star", 75,
                stats: new(50, 57, 36, 43, 49),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Maragidyne", 0),
                    new("Fire Amp", 0),
                    new("Evade Ice", 77),
                    new("Growth 3", 79),
                    new("Spell Master", 81)
                }
            ),
            new("Kohryu", "Hierophant", 76,
                stats: new(50, 53, 54, 40, 38),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Mediarahan", 0),
                    new("Samarecarm", 0),
                    new("Maziodyne", 78),
                    new("Mind Charge", 79),
                    new("Elec Amp", 80),
                    new("Spell Master", 82),
                    new("Salvation", 83)

                },
                isUltimate: true
            ),
            new("Satan", "Judgement", 76,
                stats: new(45, 60, 47, 40, 43),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Megidolaon", 0),
                    new("Maragidyne", 0),
                    new("Regenerate 3", 77),
                    new("Invigorate 3", 78),
                    new("Endure Light", 80),
                    new("Black Viper", 81),
                    new("Null Wind", 82)
                }
            ),
            new("Baal Zebul", "Moon", 77,
                stats: new(48, 60, 49, 40, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Mabufudyne", 0),
                    new("Mamudoon", 0),
                    new("Old One", 0),
                    new("Tentarafoo", 78),
                    new("Maziodyne", 79),
                    new("Mudo Boost", 80),
                    new("Stagnant Air", 82)
                }
            ),
            new("Suparna", "Sun", 77,
                stats: new(48, 52, 45, 55, 38),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Garudyne", 0),
                    new("Makajam", 0),
                    new("Evade Ice", 79),
                    new("Wind Amp", 80),
                    new("Magarudyne", 81),
                    new("Evade Fire", 82),
                    new("Elec Amp", 83)
                }
            ),
            new("Mada", "Magician", 78,
                stats: new(45, 63, 52, 38, 43),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Fire Boost", 0),
                    new("Foolish Whisper", 0),
                    new("Maragidyne", 81),
                    new("Evade Ice", 82),
                    new("Ailment Boost", 83),
                    new("Fire Amp", 84)

                },
                isUltimate: true
            ),
            new("Mahakala", "Death", 78,
                stats: new(58, 38, 57, 49, 39),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Myriad Arrows", 0),
                    new("Power Charge", 0),
                    new("Mind Charge", 80),
                    new("Maragidyne", 82),
                    new("Mamudoon", 83),
                    new("Fire Amp", 84),
                    new("Mudo Boost", 85)

                },
                isUltimate: true
            ),
            new("Scathach", "Priestess", 79,
                stats: new(54, 59, 37, 49, 45),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Absorb, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mabufudyne", 0),
                    new("Garudyne", 0),
                    new("Amrita", 81),
                    new("Magarudyne", 82),
                    new("Ice Amp", 83),
                    new("Wind Amp", 84),
                    new("Mind Charge", 85)

                },
                isUltimate: true
            ),
            new("Isis", "Empress", 79,
                stats: new(52, 48, 42, 48, 54),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Mediarahan", 0),
                    new("Bufudyne", 0),
                    new("Tetrakarn", 0),
                    new("Cool Breeze", 80),
                    new("Absorb Ice", 82),
                    new("Mabufudyne", 83),
                    new("Salvation", 85),
                    new("Null Elec", 86)

                },
                isUltimate: true
            ),
            new("Futsunushi", "Chariot", 80,
                stats: new(59, 38, 61, 44, 45),
                elementAffinities: new(ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Primal Force", 0),
                    new("Power Charge", 0),
                    new("Matarukaja", 0),
                    new("Apt Pupil", 82),
                    new("Null Dizzy", 83),
                    new("Ali Dance", 84),
                    new("Arms Master", 85),
                    new("Firm Stance", 86)

                },
                isUltimate: true
            ),
            new("Shiva", "Tower", 80,
                stats: new(59, 48, 44, 54, 42),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Ziodyne", 0),
                    new("Magarudyne", 0),
                    new("Enduring Soul", 0),
                    new("Maziodyne", 82),
                    new("Spell Master", 83),
                    new("Megidolaon", 84),
                    new("Pralaya", 87)

                },
                isUltimate: true
            ),
            new("Beelzebub", "Devil", 81,
                stats: new(48, 60, 49, 40, 41),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Absorb, ElementAffinity.Null, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Reflect),
                skills: new()
                {
                    new("Mabufudyne", 0),
                    new("Mamudoon", 0),
                    new("Old One", 0),
                    new("Tentarafoo", 78),
                    new("Maziodyne", 79),
                    new("Mudo Boost", 80),
                    new("Stagnant Air", 82)

                },
                isUltimate: true
            ),
            new("Ongyo-Ki", "Hermit", 82,
                stats: new(59, 64, 59, 47, 24),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Absorb, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Foolish Whisper", 0),
                    new("Ziodyne", 0),
                    new("Masukukaja", 0),
                    new("Ailment Boost", 84),
                    new("Elec Amp", 85),
                    new("Revolution", 86),
                    new("Firm Stance", 87)

                },
                isUltimate: true
            ),
            new("Attis", "Hanged Man", 82,
                stats: new(51, 56, 56, 50, 40),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak),
                skills: new()
                {
                    new("Agidyne", 0),
                    new("Amrita", 0),
                    new("Marakukaja", 0),
                    new("Enduring Soul", 84),
                    new("Samarecarm", 86),
                    new("Maragidyne", 87),
                    new("Mamudoon", 88)

                },
                isUltimate: true
            ),
            new("Metatron", "Judgement", 83,
                stats: new(54, 55, 53, 46, 48),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mahamaon", 0),
                    new("Heaven's Blade", 0),
                    new("Megidolaon", 86),
                    new("Repel Ice", 87),
                    new("Repel Elec", 88),
                    new("Repel Fire", 89)
                }
            ),
            new("Sandalphon", "Moon", 84,
                stats: new(56, 61, 46, 47, 49),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Reflect, ElementAffinity.Weak),
                skills: new()
                {
                    new("Mahamaon", 0),
                    new("Samarecarm", 0),
                    new("Amrita", 0),
                    new("Angelic Grace", 87),
                    new("Agneyastra", 88),
                    new("Endure Dark", 89),
                    new("Repel Dark", 90)

                },
                isUltimate: true
            ),
            new("Asura", "Sun", 86,
                stats: new(59, 57, 51, 50, 48),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.None),
                skills: new()
                {
                    new("Maragidyne", 0),
                    new("Primal Force", 0),
                    new("Marakukaja", 0),
                    new("Mahamaon", 88),
                    new("High Counter", 89),
                    new("Spell Master", 90),
                    new("Unshaken Will", 92)

                },
                isUltimate: true
            ),
            new("Helel", "Star", 87,
                stats: new(56, 57, 56, 49, 50),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null, ElementAffinity.Null),
                skills: new()
                {
                    new("Megidolaon", 0),
                    new("Maragidyne", 0),
                    new("God's Hand", 0),
                    new("Salvation", 88),
                    new("Insta-Heal", 90),
                    new("Repel Wind", 91),
                    new("Arms Master", 92),
                    new("Morning Star", 94)

                },
                isUltimate: true
            ),
            new("Zaou Gongen", "Strength", 90,
                stats: new(61, 48, 71, 47, 50),
                elementAffinities: new(ElementAffinity.None, ElementAffinity.Reflect, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Maragidyne", 0),
                    new("Power Charge", 0),
                    new("God's Hand", 0),
                    new("Anima Freeze", 92),
                    new("Evade Physical", 93),
                    new("Enduring Soul", 94),
                    new("Fire Amp", 95),
                    new("Vorpal Blade", 96)

                },
                isUltimate: true
            ),
            new("Ardha", "Judgement", 90,
                stats: new(62, 52, 64, 41, 58),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.Null, ElementAffinity.Null, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Primal Force", 0),
                    new("God's Hand", 0),
                    new("Megidolaon", 91),
                    new("Null Dizzy", 92),
                    new("Auto-Rakukaja", 93),
                    new("Mediarahan", 94),
                    new("Angelic Grace", 95),
                    new("Null Physical", 96)
                }
            ),
            new("Izanagi-No-Okami", "World", 91,
                stats: new(80, 80, 80, 80, 80),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None),
                skills: new()
                {
                    new("Megidolaon", 0),
                    new("Victory Cry", 0),
                    new("Angelic Grace", 0),
                    new("Mind Charge", 0),
                    new("Agidyne", 92),
                    new("Bufudyne", 93),
                    new("Ziodyne", 94),
                    new("Garudyne", 95),
                    new("Fire Amp", 96),
                    new("Ice Amp", 97),
                    new("Elec Amp", 98),
                    new("Wind Amp", 99)

                },
                isNewGamePlus: true
            ),
            new("Lucifer", "Judgement", 93,
                stats: new(62, 69, 61, 52, 51),
                elementAffinities: new(ElementAffinity.Resistant, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.None, ElementAffinity.Weak, ElementAffinity.Null),
                skills: new()
                {
                    new("Bufudyne", 0),
                    new("Brave Blade", 0),
                    new("Mind Charge", 0),
                    new("Ice Amp", 94),
                    new("Spell Master", 95),
                    new("Repel Light", 96),
                    new("Absorb Elec", 98),
                    new("Victory Cry", 99)
                },
                isUltimate: true
            )
        };
    }
}
