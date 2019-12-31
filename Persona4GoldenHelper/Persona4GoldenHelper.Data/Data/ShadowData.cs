using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Data
{
    public class ShadowData
    {
        public static List<Shadow> Shadows { get; set; } = new List<Shadow>()
        {
            new Shadow() {
                Name = "Acheron Seeker",
                Level = 79,
                HP = 346,
                SP = 208,
                Exp = 2630,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 22,
                    Endurance = 62,
                    Agility = 54,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Galgalim Eyes"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Tentarafoo"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Adamant Beetle",
                Level = 33,
                HP = 140,
                SP = 116,
                Exp = 550,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 17,
                    Endurance = 10,
                    Agility = 22,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Swift Strike"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Agitating Hablerie",
                Level = 66,
                HP = 238,
                SP = 280,
                Exp = 2670,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 52,
                    Endurance = 25,
                    Agility = 43,
                    Luck = 37
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Mazionga"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Almighty Hand",
                Level = 40,
                HP = 284,
                SP = 238,
                Exp = 900,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 28,
                    Endurance = 32,
                    Agility = 32,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "God's Hand"
                    },
                    new ShadowSkill() {
                        Name = "Null Mute"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Almighty Hand",
                Level = 40,
                HP = 284,
                SP = 238,
                Exp = 900,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 28,
                    Endurance = 32,
                    Agility = 32,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Patra"
                    },
                    new ShadowSkill() {
                        Name = "Posumudi"
                    },
                    new ShadowSkill() {
                        Name = "Mutudi"
                    },
                    new ShadowSkill() {
                        Name = "Nervundi"
                    },
                    new ShadowSkill() {
                        Name = "Re Patra"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Ameno-sagiri",
                Level = 75,
                HP = 8000,
                SP = 2500,
                Exp = 28729,
                Yen = "¥3000",
                Stats = new Stats() {
                    Strength = 58,
                    Magic = 66,
                    Endurance = 64,
                    Agility = 72,
                    Luck = 46
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agneyastra"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Maziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "God's Judgement"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Rakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    },
                    new ShadowSkill() {
                        Name = "Dekaja"
                    },
                    new ShadowSkill() {
                        Name = "Dekunda"
                    },
                    new ShadowSkill() {
                        Name = "Nebula Oculus"
                    },
                    new ShadowSkill() {
                        Name = "Quake"
                    },
                    new ShadowSkill() {
                        Name = "Bewildering Fog"
                    },
                    new ShadowSkill() {
                        Name = "Galgalim Eyes"
                    }
                },
                Type = ShadowType.Boss
            },
            new Shadow() {
                Name = "Amenti Raven",
                Level = 39,
                HP = 155,
                SP = 117,
                Exp = 760,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 28,
                    Endurance = 18,
                    Agility = 30,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Assault Dive"
                    },
                    new ShadowSkill() {
                        Name = "Gale Slash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Amorous Snake",
                Level = 69,
                HP = 268,
                SP = 183,
                Exp = 3760,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 26,
                    Endurance = 48,
                    Agility = 45,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Poison Arrow"
                    },
                    new ShadowSkill() {
                        Name = "Blight"
                    },
                    new ShadowSkill() {
                        Name = "Life Leech"
                    },
                    new ShadowSkill() {
                        Name = "Poison Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Amorous Snake",
                Level = 33,
                HP = 1012,
                SP = 148,
                Exp = 6300,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 38,
                    Endurance = 26,
                    Agility = 21,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Angry Table",
                Level = 62,
                HP = 345,
                SP = 270,
                Exp = 2310,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 18,
                    Endurance = 42,
                    Agility = 40,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Auto-Mataru"
                    },
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Valiant Dance"
                    },
                    new ShadowSkill() {
                        Name = "Resist Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Anguish Basalt",
                Level = 41,
                HP = 122,
                SP = 19,
                Exp = 600,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 18,
                    Endurance = 31,
                    Agility = 11,
                    Luck = 23
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Apostate Tower",
                Level = 59,
                HP = 286,
                SP = 327,
                Exp = 2150,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 36,
                    Endurance = 40,
                    Agility = 42,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mazionga"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Fire Break"
                    },
                    new ShadowSkill() {
                        Name = "Ice Break"
                    },
                    new ShadowSkill() {
                        Name = "Elec Break"
                    },
                    new ShadowSkill() {
                        Name = "Wind Break"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Arcane Turret",
                Level = 35,
                HP = 546,
                SP = 264,
                Exp = 2000,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 28,
                    Endurance = 23,
                    Agility = 24,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Ardent Dancer",
                Level = 44,
                HP = 163,
                SP = 231,
                Exp = 950,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 32,
                    Endurance = 16,
                    Agility = 31,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Autonomic Basalt",
                Level = 16,
                HP = 161,
                SP = 13,
                Exp = 120,
                Yen = "¥190",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 10,
                    Endurance = 8,
                    Agility = 2,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Avarice Bambino",
                Level = 42,
                HP = 172,
                SP = 167,
                Exp = 810,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 23,
                    Endurance = 28,
                    Agility = 28,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Life Drain"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Avenger Knight",
                Level = 15,
                HP = 300,
                SP = 87,
                Exp = 485,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 8,
                    Endurance = 6,
                    Agility = 8,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Skewer"
                    },
                    new ShadowSkill() {
                        Name = "Poison Skewer"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Avenger Knight",
                Level = 11,
                HP = 900,
                SP = 87,
                Exp = 900,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 9,
                    Endurance = 10,
                    Agility = 6,
                    Luck = 13
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Skewer"
                    },
                    new ShadowSkill() {
                        Name = "Poison Skewer"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Battle Wheel",
                Level = 72,
                HP = 278,
                SP = 194,
                Exp = 3740,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 42,
                    Endurance = 28,
                    Agility = 45,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Vorpal Blade"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Masuku"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Beastly Gigas",
                Level = 45,
                HP = 234,
                SP = 94,
                Exp = 1100,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 20,
                    Endurance = 30,
                    Agility = 29,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Sonic Punch"
                    },
                    new ShadowSkill() {
                        Name = "Assault Dive"
                    },
                    new ShadowSkill() {
                        Name = "Swift Strike"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Berserk Turret",
                Level = 80,
                HP = 621,
                SP = 174,
                Exp = 1680,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 53,
                    Magic = 62,
                    Endurance = 64,
                    Agility = 57,
                    Luck = 52
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Megidolaon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Black Raven",
                Level = 7,
                HP = 138,
                SP = 25,
                Exp = 48,
                Yen = "¥120",
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 4,
                    Endurance = 4,
                    Agility = 5,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Blind Cupid",
                Level = 38,
                HP = 210,
                SP = 6,
                Exp = 550,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 28,
                    Endurance = 26,
                    Agility = 30,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Poison Arrow"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Blooming Bambino",
                Level = 33,
                HP = 260,
                SP = 194,
                Exp = 500,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 25,
                    Endurance = 3,
                    Agility = 22,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mabufula"
                    },
                    new ShadowSkill() {
                        Name = "Life Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Blossom Nyogo",
                Level = 63,
                HP = 205,
                SP = 188,
                Exp = 2210,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 34,
                    Endurance = 46,
                    Agility = 42,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Ice"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Blue Sigil",
                Level = 42,
                HP = 339,
                SP = 329,
                Exp = 940,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 29,
                    Endurance = 29,
                    Agility = 25,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Megido"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Brave Wheel",
                Level = 57,
                HP = 368,
                SP = 173,
                Exp = 2250,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 34,
                    Endurance = 39,
                    Agility = 40,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heat Wave"
                    },
                    new ShadowSkill() {
                        Name = "Torrent Shot"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Bribed Fuzz",
                Level = 17,
                HP = 152,
                SP = 88,
                Exp = 200,
                Yen = "¥190",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 6,
                    Endurance = 15,
                    Agility = 8,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Single Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Brilliant Cyclops",
                Level = 73,
                HP = 324,
                SP = 285,
                Exp = 4820,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 60,
                    Magic = 40,
                    Endurance = 45,
                    Agility = 46,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heat Wave"
                    },
                    new ShadowSkill() {
                        Name = "Primal Force"
                    },
                    new ShadowSkill() {
                        Name = "Assault Dive"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Brilliant King",
                Level = 81,
                HP = 346,
                SP = 256,
                Exp = 2230,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 54,
                    Magic = 51,
                    Endurance = 61,
                    Agility = 62,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Masuku"
                    },
                    new ShadowSkill() {
                        Name = "Evade Elec"
                    },
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    },
                    new ShadowSkill() {
                        Name = "Diarahan"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Bronze Dice",
                Level = 10,
                HP = 180,
                SP = 34,
                Exp = 184,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 5,
                    Endurance = 6,
                    Agility = 6,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Poisma"
                    },
                    new ShadowSkill() {
                        Name = "Last Resort"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Burning Beetle",
                Level = 13,
                HP = 132,
                SP = 51,
                Exp = 298,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 6,
                    Endurance = 13,
                    Agility = 9,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Calm Machine",
                Level = 76,
                HP = 1000,
                SP = 310,
                Exp = 2500,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 24,
                    Endurance = 35,
                    Agility = 35,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    },
                    new ShadowSkill() {
                        Name = "Sharp Student"
                    },
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Herculean Strike"
                    },
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Rakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Calm Pesce",
                Level = 6,
                HP = 82,
                SP = 23,
                Exp = 40,
                Yen = "¥150",
                Stats = new Stats() {
                    Strength = 6,
                    Magic = 3,
                    Endurance = 4,
                    Agility = 6,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Cleave"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Carnal Snake",
                Level = 59,
                HP = 234,
                SP = 137,
                Exp = 1920,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 32,
                    Endurance = 30,
                    Agility = 43,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Crazy Chain"
                    },
                    new ShadowSkill() {
                        Name = "Life Leech"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Champion Knight",
                Level = 34,
                HP = 265,
                SP = 116,
                Exp = 1500,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 22,
                    Endurance = 22,
                    Agility = 25,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Change Relic",
                Level = 74,
                HP = 279,
                SP = 485,
                Exp = 4900,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 33,
                    Endurance = 40,
                    Agility = 47,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Old One"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Elec Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Chaos Cyclops",
                Level = 63,
                HP = 587,
                SP = 318,
                Exp = 3170,
                Yen = "¥330",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 32,
                    Endurance = 35,
                    Agility = 42,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Aeon Rain"
                    },
                    new ShadowSkill() {
                        Name = "Power Slash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Chaos Fuzz",
                Level = 51,
                HP = 341,
                SP = 133,
                Exp = 1340,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 30,
                    Endurance = 14,
                    Agility = 30,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Chaos Fuzz",
                Level = 70,
                HP = 600,
                SP = 124,
                Exp = 1820,
                Yen = "¥44",
                Stats = new Stats() {
                    Strength = 47,
                    Magic = 34,
                    Endurance = 53,
                    Agility = 45,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Clear Sky Musha",
                Level = 75,
                HP = 1000,
                SP = 555,
                Exp = 2400,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 52,
                    Endurance = 10,
                    Agility = 68,
                    Luck = 58
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hassou Tobi"
                    },
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    },
                    new ShadowSkill() {
                        Name = "Gale Slash"
                    },
                    new ShadowSkill() {
                        Name = "Vicious Strike"
                    },
                    new ShadowSkill() {
                        Name = "Primal Force"
                    },
                    new ShadowSkill() {
                        Name = "Media"
                    },
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Cloudgirl Pot",
                Level = 18,
                HP = 175,
                SP = 102,
                Exp = 260,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 10,
                    Endurance = 14,
                    Agility = 15,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Conceited Panzer",
                Level = 75,
                HP = 320,
                SP = 254,
                Exp = 5250,
                Yen = "¥400",
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 49,
                    Endurance = 50,
                    Agility = 49,
                    Luck = 52
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Seal Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Mustard Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Constancy Relic",
                Level = 46,
                HP = 240,
                SP = 246,
                Exp = 1200,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 29,
                    Endurance = 17,
                    Agility = 31,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Anima Freeze"
                    },
                    new ShadowSkill() {
                        Name = "Re Patra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Conviction Sword",
                Level = 64,
                HP = 320,
                SP = 125,
                Exp = 2480,
                Yen = "¥350",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 36,
                    Endurance = 40,
                    Agility = 45,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rainy Death"
                    },
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Corrupt Tower",
                Level = 36,
                HP = 325,
                SP = 209,
                Exp = 560,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 21,
                    Endurance = 23,
                    Agility = 26,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Mazionga"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Crazy Twins",
                Level = 76,
                HP = 385,
                SP = 169,
                Exp = 2400,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 38,
                    Endurance = 48,
                    Agility = 52,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Dodge Fire"
                    },
                    new ShadowSkill() {
                        Name = "Heat Wave"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    },
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    },
                    new ShadowSkill() {
                        Name = "Poison Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Creation Relic",
                Level = 27,
                HP = 159,
                SP = 205,
                Exp = 450,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 20,
                    Endurance = 12,
                    Agility = 19,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Old One"
                    },
                    new ShadowSkill() {
                        Name = "Cell Breaker"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Crying Table",
                Level = 24,
                HP = 139,
                SP = 177,
                Exp = 440,
                Yen = "¥220",
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 15,
                    Endurance = 15,
                    Agility = 16,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Magaru"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Curse Dice",
                Level = 60,
                HP = 200,
                SP = 271,
                Exp = 2410,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 64,
                    Endurance = 41,
                    Agility = 25,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Cursed Woman's Pot",
                Level = 55,
                HP = 55,
                SP = 400,
                Exp = 1400,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 62,
                    Endurance = 52,
                    Agility = 50,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mazionga"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Enervation"
                    },
                    new ShadowSkill() {
                        Name = "Enervate Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dancing Hand",
                Level = 20,
                HP = 135,
                SP = 121,
                Exp = 240,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 13,
                    Endurance = 8,
                    Agility = 17,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Balzac"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Daring Gigas",
                Level = 19,
                HP = 225,
                SP = 46,
                Exp = 230,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 23,
                    Magic = 6,
                    Endurance = 15,
                    Agility = 15,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Sonic Punch"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Daring Gigas",
                Level = 24,
                HP = 928,
                SP = 100,
                Exp = 2800,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 11,
                    Endurance = 17,
                    Agility = 18,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Sonic Punch"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Single Shot"
                    },
                    new ShadowSkill() {
                        Name = "Counter"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Dark Eagle",
                Level = 57,
                HP = 312,
                SP = 197,
                Exp = 2250,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 34,
                    Endurance = 26,
                    Agility = 43,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    },
                    new ShadowSkill() {
                        Name = "Evil Smile"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Death Dice",
                Level = 73,
                HP = 44,
                SP = 444,
                Exp = 4440,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 44,
                    Endurance = 44,
                    Agility = 44,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Last Resort"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Death Seeker",
                Level = 28,
                HP = 310,
                SP = 339,
                Exp = 640,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 1,
                    Magic = 25,
                    Endurance = 15,
                    Agility = 16,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Mazio"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dependent Basalt",
                Level = 36,
                HP = 162,
                SP = 23,
                Exp = 250,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 20,
                    Endurance = 26,
                    Agility = 10,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Devoted Cupid",
                Level = 62,
                HP = 258,
                SP = 274,
                Exp = 1960,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 37,
                    Endurance = 27,
                    Agility = 47,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    },
                    new ShadowSkill() {
                        Name = "Amrita"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dismayed Panzer",
                Level = 48,
                HP = 320,
                SP = 164,
                Exp = 2000,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 24,
                    Endurance = 25,
                    Agility = 26,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mustard Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Aeon Rain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Divine Mother",
                Level = 76,
                HP = 415,
                SP = 400,
                Exp = 1980,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 57,
                    Endurance = 52,
                    Agility = 50,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Maziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Media"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dogmatic Tower",
                Level = 48,
                HP = 259,
                SP = 339,
                Exp = 1210,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 37,
                    Endurance = 20,
                    Agility = 35,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Cell Breaker"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dominating Machine",
                Level = 57,
                HP = 3500,
                SP = 112,
                Exp = 5040,
                Yen = "¥330",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 31,
                    Endurance = 1,
                    Agility = 40,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dominating Machine",
                Level = 53,
                HP = 3070,
                SP = 300,
                Exp = 12400,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 32,
                    Endurance = 44,
                    Agility = 30,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Herculean Strike"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Last Resort"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Doom Sword",
                Level = 79,
                HP = 437,
                SP = 149,
                Exp = 1690,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 70,
                    Magic = 47,
                    Endurance = 39,
                    Agility = 44,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Vorpal Blade"
                    },
                    new ShadowSkill() {
                        Name = "Fear Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Dry Dexy",
                Level = 61,
                HP = 265,
                SP = 439,
                Exp = 1950,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 35,
                    Endurance = 44,
                    Agility = 45,
                    Luck = 50
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mabufula"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Earnest Calocy",
                Level = 74,
                HP = 420,
                SP = 629,
                Exp = 4800,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 54,
                    Endurance = 19,
                    Agility = 52,
                    Luck = 70
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    },
                    new ShadowSkill() {
                        Name = "Masukunda"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Egotistical King",
                Level = 23,
                HP = 206,
                SP = 105,
                Exp = 640,
                Yen = "¥220",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 16,
                    Endurance = 18,
                    Agility = 15,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mazio"
                    },
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "El Dorado Beast",
                Level = 82,
                HP = 412,
                SP = 194,
                Exp = 2080,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 65,
                    Magic = 50,
                    Endurance = 61,
                    Agility = 49,
                    Luck = 63
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Wind Amp"
                    },
                    new ShadowSkill() {
                        Name = "Regenerate 3"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    },
                    new ShadowSkill() {
                        Name = "High Counter"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Elegant Mother",
                Level = 54,
                HP = 250,
                SP = 455,
                Exp = 2010,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 47,
                    Endurance = 19,
                    Agility = 36,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mabufula"
                    },
                    new ShadowSkill() {
                        Name = "Mediarama"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Emaciated Garcy",
                Level = 74,
                HP = 500,
                SP = 629,
                Exp = 3000,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 54,
                    Endurance = 19,
                    Agility = 52,
                    Luck = 70
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    },
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Mazio"
                    },
                    new ShadowSkill() {
                        Name = "Magaru"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Emperor Beetle",
                Level = 77,
                HP = 420,
                SP = 231,
                Exp = 2190,
                Yen = "¥330",
                Stats = new Stats() {
                    Strength = 58,
                    Magic = 45,
                    Endurance = 55,
                    Agility = 46,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Regenerate 3"
                    },
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Gigantic Fist"
                    },
                    new ShadowSkill() {
                        Name = "Primal Force"
                    },
                    new ShadowSkill() {
                        Name = "Brave Blade"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Enslaved Beast",
                Level = 32,
                HP = 250,
                SP = 91,
                Exp = 430,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 17,
                    Endurance = 14,
                    Agility = 19,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Assault Dive"
                    },
                    new ShadowSkill() {
                        Name = "Swift Strike"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Escapist Soldier",
                Level = 47,
                HP = 3800,
                SP = 1000,
                Exp = 10500,
                Yen = "¥1000",
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 30,
                    Endurance = 20,
                    Agility = 28,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Crazy Chain"
                    },
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Foul Breath"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Eternal Eagle",
                Level = 79,
                HP = 200,
                SP = 262,
                Exp = 1500,
                Yen = "¥420",
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 51,
                    Endurance = 44,
                    Agility = 70,
                    Luck = 60
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Auto-Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Evil Touch"
                    },
                    new ShadowSkill() {
                        Name = "Evil Smile"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    },
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Eternal Sand",
                Level = 77,
                HP = 337,
                SP = 243,
                Exp = 2200,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 42,
                    Endurance = 43,
                    Agility = 55,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    },
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Exhaust Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Execution Sword",
                Level = 75,
                HP = 777,
                SP = 234,
                Exp = 2000,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 53,
                    Magic = 30,
                    Endurance = 11,
                    Agility = 52,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heaven's Blade"
                    },
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    },
                    new ShadowSkill() {
                        Name = "Fear Boost"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Extreme Vessel",
                Level = 57,
                HP = 4800,
                SP = 3000,
                Exp = 15000,
                Yen = "¥1000",
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 45,
                    Endurance = 35,
                    Agility = 56,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Maziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "God's Hand"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Fail Gene",
                Level = 52,
                HP = 263,
                SP = 315,
                Exp = 1150,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 35,
                    Endurance = 15,
                    Agility = 35,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "Blue Wall"
                    },
                    new ShadowSkill() {
                        Name = "Green Wall"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Re Patra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Fanatic Tower",
                Level = 69,
                HP = 325,
                SP = 422,
                Exp = 3850,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 52,
                    Endurance = 24,
                    Agility = 49,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    },
                    new ShadowSkill() {
                        Name = "Hamaon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Fate Seeker",
                Level = 40,
                HP = 200,
                SP = 333,
                Exp = 820,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 27,
                    Endurance = 22,
                    Agility = 28,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Maragion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Fickle Papillon",
                Level = 67,
                HP = 224,
                SP = 100,
                Exp = 2230,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 45,
                    Endurance = 25,
                    Agility = 48,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Poison Skewer"
                    },
                    new ShadowSkill() {
                        Name = "Cell Breaker"
                    },
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    },
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Fierce Cyclops",
                Level = 53,
                HP = 300,
                SP = 397,
                Exp = 2520,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 49,
                    Endurance = 25,
                    Agility = 38,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Counterstrike"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Finicky Papillon",
                Level = 56,
                HP = 227,
                SP = 331,
                Exp = 1500,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 55,
                    Endurance = 30,
                    Agility = 44,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Flattering Hablerie",
                Level = 47,
                HP = 324,
                SP = 199,
                Exp = 1220,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 32,
                    Endurance = 16,
                    Agility = 32,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.Resistant
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Fire Break"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Flowing Sand",
                Level = 47,
                HP = 274,
                SP = 351,
                Exp = 1050,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 30,
                    Endurance = 22,
                    Agility = 33,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Sukunda"
                    },
                    new ShadowSkill() {
                        Name = "Power Slash"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Forgotten Hablerie",
                Level = 31,
                HP = 220,
                SP = 133,
                Exp = 430,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 19,
                    Endurance = 8,
                    Agility = 19,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Free Bambino",
                Level = 66,
                HP = 254,
                SP = 170,
                Exp = 1820,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 28,
                    Endurance = 27,
                    Agility = 46,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Amrita"
                    },
                    new ShadowSkill() {
                        Name = "Brave Blade"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Leech"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Furious Gigas",
                Level = 50,
                HP = 318,
                SP = 117,
                Exp = 1840,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 26,
                    Endurance = 19,
                    Agility = 35,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Akasha Arts"
                    },
                    new ShadowSkill() {
                        Name = "Gigantic Fist"
                    },
                    new ShadowSkill() {
                        Name = "High Counter"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Gauntlet Hand",
                Level = 75,
                HP = 600,
                SP = 354,
                Exp = 1500,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 20,
                    Endurance = 10,
                    Agility = 44,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "High Counter"
                    },
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Gigantic Fist"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Elec"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Glorious Hand",
                Level = 70,
                HP = 9999,
                SP = 777,
                Exp = 40000,
                Yen = "¥15000",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 30,
                    Endurance = 1,
                    Agility = 85,
                    Luck = 75
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.Resistant
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Soul Break"
                    },
                    new ShadowSkill() {
                        Name = "Pulinpa"
                    },
                    new ShadowSkill() {
                        Name = "Poisma"
                    },
                    new ShadowSkill() {
                        Name = "Enervation"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Counter"
                    },
                    new ShadowSkill() {
                        Name = "Hama"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    },
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Golden Beetle",
                Level = 40,
                HP = 180,
                SP = 164,
                Exp = 730,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 20,
                    Endurance = 28,
                    Agility = 27,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Gracious Cupid",
                Level = 79,
                HP = 300,
                SP = 252,
                Exp = 1860,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 49,
                    Endurance = 42,
                    Agility = 59,
                    Luck = 56
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Amrita"
                    },
                    new ShadowSkill() {
                        Name = "Re Patra"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    },
                    new ShadowSkill() {
                        Name = "Torrent Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Grand Magus",
                Level = 79,
                HP = 550,
                SP = 644,
                Exp = 2390,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 80,
                    Endurance = 40,
                    Agility = 45,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Magaru"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Mazio"
                    },
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Grave Beetle",
                Level = 26,
                HP = 180,
                SP = 67,
                Exp = 330,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 10,
                    Endurance = 24,
                    Agility = 2,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mamudo"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Great King",
                Level = 68,
                HP = 359,
                SP = 199,
                Exp = 4680,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 37,
                    Endurance = 31,
                    Agility = 46,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Green Sigil",
                Level = 63,
                HP = 333,
                SP = 424,
                Exp = 3110,
                Yen = "¥340",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 44,
                    Endurance = 40,
                    Agility = 43,
                    Luck = 37
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Magarula"
                    },
                    new ShadowSkill() {
                        Name = "Mazionga"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Growth Relic",
                Level = 56,
                HP = 251,
                SP = 282,
                Exp = 1520,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 36,
                    Endurance = 33,
                    Agility = 40,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Rakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Poison Skewer"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Grudge Tower",
                Level = 78,
                HP = 300,
                SP = 475,
                Exp = 2480,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 62,
                    Endurance = 52,
                    Agility = 55,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Fire Break"
                    },
                    new ShadowSkill() {
                        Name = "Ice Break"
                    },
                    new ShadowSkill() {
                        Name = "Wind Break"
                    },
                    new ShadowSkill() {
                        Name = "Elec Break"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Hallowed Turret",
                Level = 66,
                HP = 776,
                SP = 146,
                Exp = 4530,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 60,
                    Magic = 20,
                    Endurance = 54,
                    Agility = 29,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Mahamaon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Happiness Hand",
                Level = 10,
                HP = 150,
                SP = 100,
                Exp = 1500,
                Yen = "¥2000",
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 7,
                    Endurance = 45,
                    Agility = 25,
                    Luck = 50
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.Resistant
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Happy Gene",
                Level = 73,
                HP = 193,
                SP = 354,
                Exp = 4370,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 45,
                    Endurance = 31,
                    Agility = 50,
                    Luck = 46
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    },
                    new ShadowSkill() {
                        Name = "Amrita"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Physical"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Harem Dancer",
                Level = 73,
                HP = 368,
                SP = 294,
                Exp = 3870,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 62,
                    Magic = 50,
                    Endurance = 27,
                    Agility = 47,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Apt Pupil"
                    },
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Harmonious Giant",
                Level = 76,
                HP = 250,
                SP = 169,
                Exp = 1900,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 12,
                    Endurance = 65,
                    Agility = 72,
                    Luck = 80
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Blight"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    },
                    new ShadowSkill() {
                        Name = "Poison Mist"
                    },
                    new ShadowSkill() {
                        Name = "Poison Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Harmony Giant",
                Level = 77,
                HP = 305,
                SP = 128,
                Exp = 5000,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 57,
                    Magic = 50,
                    Endurance = 31,
                    Agility = 58,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Re Patra"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "Blue Wall"
                    },
                    new ShadowSkill() {
                        Name = "Green Wall"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Heartless Machine",
                Level = 83,
                HP = 100,
                SP = 130,
                Exp = 8200,
                Yen = "¥450",
                Stats = new Stats() {
                    Strength = 71,
                    Magic = 56,
                    Endurance = 54,
                    Agility = 54,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Megidolaon"
                    },
                    new ShadowSkill() {
                        Name = "Rainy Death"
                    },
                    new ShadowSkill() {
                        Name = "Vorpal Blade"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Heat Balance",
                Level = 15,
                HP = 140,
                SP = 136,
                Exp = 210,
                Yen = "¥190",
                Stats = new Stats() {
                    Strength = 5,
                    Magic = 10,
                    Endurance = 7,
                    Agility = 15,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Hell Knight",
                Level = 55,
                HP = 520,
                SP = 153,
                Exp = 3780,
                Yen = "¥330",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 35,
                    Endurance = 28,
                    Agility = 39,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Idle Basalt",
                Level = 29,
                HP = 195,
                SP = 27,
                Exp = 350,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 15,
                    Endurance = 12,
                    Agility = 14,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Immoral Snake",
                Level = 52,
                HP = 269,
                SP = 148,
                Exp = 1530,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 33,
                    Endurance = 18,
                    Agility = 33,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Life Drain"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Poison Mist"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Immortal Gigas",
                Level = 52,
                HP = 269,
                SP = 148,
                Exp = 1530,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 33,
                    Endurance = 18,
                    Agility = 33,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Life Drain"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Poison Mist"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Indignant Machine",
                Level = 77,
                HP = 888,
                SP = 385,
                Exp = 4000,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 99,
                    Magic = 77,
                    Endurance = 1,
                    Agility = 43,
                    Luck = 58
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Skull Cracker"
                    },
                    new ShadowSkill() {
                        Name = "Fire Break"
                    },
                    new ShadowSkill() {
                        Name = "Ice Break"
                    },
                    new ShadowSkill() {
                        Name = "Elec Break"
                    },
                    new ShadowSkill() {
                        Name = "Wind Break"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Infinite Sand",
                Level = 67,
                HP = 256,
                SP = 197,
                Exp = 2480,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 32,
                    Endurance = 35,
                    Agility = 47,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Crazy Chain"
                    },
                    new ShadowSkill() {
                        Name = "Rage Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Insolent Basalt",
                Level = 45,
                HP = 300,
                SP = 25,
                Exp = 1150,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 31,
                    Magic = 16,
                    Endurance = 20,
                    Agility = 20,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Intolerant Officer",
                Level = 27,
                HP = 3000,
                SP = 1000,
                Exp = 4650,
                Yen = "¥1000",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 28,
                    Endurance = 15,
                    Agility = 12,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Single Shot"
                    },
                    new ShadowSkill() {
                        Name = "Poison Arrow"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Intrepid Knight",
                Level = 65,
                HP = 562,
                SP = 140,
                Exp = 5060,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 34,
                    Endurance = 40,
                    Agility = 46,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    },
                    new ShadowSkill() {
                        Name = "Blight"
                    },
                    new ShadowSkill() {
                        Name = "Revolution"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Inviting Nyogo",
                Level = 47,
                HP = 358,
                SP = 174,
                Exp = 1200,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 28,
                    Endurance = 17,
                    Agility = 32,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    },
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    },
                    new ShadowSkill() {
                        Name = "Torrent Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Iron Dice",
                Level = 21,
                HP = 178,
                SP = 44,
                Exp = 280,
                Yen = "¥140",
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 22,
                    Endurance = 10,
                    Agility = 14,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Isolated Hand",
                Level = 80,
                HP = 550,
                SP = 999,
                Exp = 10000,
                Yen = "¥10000",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 16,
                    Endurance = 62,
                    Agility = 42,
                    Luck = 99
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Megido"
                    },
                    new ShadowSkill() {
                        Name = "Megidolaon"
                    },
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Jotun of Blood",
                Level = 65,
                HP = 346,
                SP = 158,
                Exp = 3270,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 29,
                    Endurance = 49,
                    Agility = 44,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "God's Hand"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Jotun of Evil",
                Level = 73,
                HP = 560,
                SP = 344,
                Exp = -1,
                Yen = "¥-1",
                Stats = new Stats() {
                    Strength = 51,
                    Magic = 58,
                    Endurance = 32,
                    Agility = 40,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Aeon Rain"
                    },
                    new ShadowSkill() {
                        Name = "Ice Boost"
                    },
                    new ShadowSkill() {
                        Name = "Evade Physical"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Jotun of Grief",
                Level = 80,
                HP = 505,
                SP = 298,
                Exp = 1660,
                Yen = "¥420",
                Stats = new Stats() {
                    Strength = 53,
                    Magic = 59,
                    Endurance = 53,
                    Agility = 54,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "God's Hand"
                    },
                    new ShadowSkill() {
                        Name = "Revolution"
                    },
                    new ShadowSkill() {
                        Name = "Megido"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Jotun of Power",
                Level = 54,
                HP = 321,
                SP = 203,
                Exp = 2000,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 34,
                    Endurance = 25,
                    Agility = 33,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "God's Hand"
                    },
                    new ShadowSkill() {
                        Name = "Gigantic Fist"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Judgement Sword",
                Level = 72,
                HP = 388,
                SP = 139,
                Exp = 4150,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 42,
                    Endurance = 51,
                    Agility = 47,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Revolution"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Jupiter Eagle",
                Level = 72,
                HP = 388,
                SP = 139,
                Exp = 4150,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 42,
                    Endurance = 51,
                    Agility = 47,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Revolution"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Justice Sword",
                Level = 37,
                HP = 205,
                SP = 76,
                Exp = 540,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 18,
                    Endurance = 21,
                    Agility = 25,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Slash"
                    },
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Killer Drive",
                Level = 37,
                HP = 205,
                SP = 76,
                Exp = 540,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 18,
                    Endurance = 21,
                    Agility = 25,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Slash"
                    },
                    new ShadowSkill() {
                        Name = "Arm Chopper"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Killer Twins",
                Level = 24,
                HP = 160,
                SP = 48,
                Exp = 380,
                Yen = "¥220",
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 16,
                    Endurance = 13,
                    Agility = 17,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "Virus Wave"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Killing Hand",
                Level = 32,
                HP = 208,
                SP = 179,
                Exp = 490,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 20,
                    Endurance = 13,
                    Agility = 27,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Killing Hand",
                Level = 32,
                HP = 885,
                SP = 100,
                Exp = 8960,
                Yen = "¥600",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 27,
                    Endurance = 32,
                    Agility = 30,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "King Castle",
                Level = 69,
                HP = 431,
                SP = 243,
                Exp = 3940,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 30,
                    Endurance = 40,
                    Agility = 47,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rainy Death"
                    },
                    new ShadowSkill() {
                        Name = "Myriad Arrows"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Fire"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Large Basalt",
                Level = 33,
                HP = 200,
                SP = 29,
                Exp = 425,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 17,
                    Endurance = 10,
                    Agility = 20,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Counterstrike"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Laughing Table",
                Level = 10,
                HP = 164,
                SP = 154,
                Exp = 153,
                Yen = "¥190",
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 9,
                    Endurance = 8,
                    Agility = 7,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Mazio"
                    },
                    new ShadowSkill() {
                        Name = "Evil Smile"
                    },
                    new ShadowSkill() {
                        Name = "Rakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Lawless Fuzz",
                Level = 74,
                HP = 400,
                SP = 344,
                Exp = 1300,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 58,
                    Endurance = 32,
                    Agility = 40,
                    Luck = 64
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Counterstrike"
                    },
                    new ShadowSkill() {
                        Name = "Single Shot"
                    },
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Rakunda"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Leading Idol",
                Level = 43,
                HP = 327,
                SP = 322,
                Exp = 1520,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 24,
                    Magic = 29,
                    Endurance = 25,
                    Agility = 28,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    },
                    new ShadowSkill() {
                        Name = "Life Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Liberating Idol",
                Level = 31,
                HP = 265,
                SP = 232,
                Exp = 590,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 19,
                    Endurance = 14,
                    Agility = 23,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Valiant Dance"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Light Balance",
                Level = 62,
                HP = 333,
                SP = 363,
                Exp = 2480,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 37,
                    Endurance = 38,
                    Agility = 35,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hama"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    },
                    new ShadowSkill() {
                        Name = "Mahama"
                    },
                    new ShadowSkill() {
                        Name = "Mamudo"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Lost Okina",
                Level = 67,
                HP = 4000,
                SP = 500,
                Exp = 23000,
                Yen = "¥1000",
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 78,
                    Endurance = 32,
                    Agility = 50,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Dekunda"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Leech"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Seal Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Mustard Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Masukunda"
                    },
                    new ShadowSkill() {
                        Name = "Matarunda"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Lustful Snake",
                Level = 37,
                HP = 255,
                SP = 157,
                Exp = 600,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 28,
                    Endurance = 20,
                    Agility = 28,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Luxury Hand",
                Level = 60,
                HP = 999,
                SP = 200,
                Exp = 34000,
                Yen = "¥12500",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 30,
                    Endurance = 45,
                    Agility = 75,
                    Luck = 65
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Soul Break"
                    },
                    new ShadowSkill() {
                        Name = "Anima Freeze"
                    },
                    new ShadowSkill() {
                        Name = "Pulinpa"
                    },
                    new ShadowSkill() {
                        Name = "Poisma"
                    },
                    new ShadowSkill() {
                        Name = "Enervation"
                    },
                    new ShadowSkill() {
                        Name = "Tentarafoo"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Counter"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Lying Hablerie (Yukiko's Castle)",
                Level = 5,
                HP = 73,
                SP = 51,
                Exp = 32,
                Yen = "¥140",
                Stats = new Stats() {
                    Strength = 5,
                    Magic = 5,
                    Endurance = 3,
                    Agility = 3,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Dia"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Lying Hablerie (The Hollow Forest)",
                Level = 73,
                HP = 125,
                SP = 328,
                Exp = 1000,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 56,
                    Magic = 37,
                    Endurance = 50,
                    Agility = 42,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mach Wheel",
                Level = 52,
                HP = 240,
                SP = 151,
                Exp = 2340,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 29,
                    Endurance = 18,
                    Agility = 40,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Herculean Strike"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mad Cyclops",
                Level = 38,
                HP = 134,
                SP = 245,
                Exp = 850,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 27,
                    Endurance = 24,
                    Agility = 36,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Kill Rush"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Magic Hand",
                Level = 8,
                HP = 130,
                SP = 10,
                Exp = 78,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 1,
                    Magic = 6,
                    Endurance = 5,
                    Agility = 2,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Magical Magus",
                Level = 14,
                HP = 180,
                SP = 135,
                Exp = 352,
                Yen = "¥180",
                Stats = new Stats() {
                    Strength = 6,
                    Magic = 8,
                    Endurance = 8,
                    Agility = 6,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Media"
                    },
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Maniacal Book",
                Level = 58,
                HP = 305,
                SP = 411,
                Exp = 2020,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 24,
                    Magic = 48,
                    Endurance = 36,
                    Agility = 41,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mighty Beast",
                Level = 50,
                HP = 364,
                SP = 127,
                Exp = 2110,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 28,
                    Endurance = 20,
                    Agility = 33,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Crazy Chain"
                    },
                    new ShadowSkill() {
                        Name = "Fatal End"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mighty Cyclops",
                Level = 35,
                HP = 220,
                SP = 330,
                Exp = 675,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 35,
                    Endurance = 19,
                    Agility = 23,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mind Dice",
                Level = 53,
                HP = 312,
                SP = 155,
                Exp = 2550,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 35,
                    Endurance = 25,
                    Agility = 40,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Minotaur I",
                Level = 77,
                HP = 590,
                SP = 310,
                Exp = 9230,
                Yen = "¥570",
                Stats = new Stats() {
                    Strength = 65,
                    Magic = 40,
                    Endurance = 42,
                    Agility = 48,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Mahamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mamudoon"
                    },
                    new ShadowSkill() {
                        Name = "Diarahan"
                    },
                    new ShadowSkill() {
                        Name = "Counterstrike"
                    },
                    new ShadowSkill() {
                        Name = "Evade Elec"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Minotaur II",
                Level = 76,
                HP = 845,
                SP = 583,
                Exp = 8410,
                Yen = "¥470",
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 70,
                    Endurance = 18,
                    Agility = 50,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Minotaur III",
                Level = 75,
                HP = 680,
                SP = 234,
                Exp = 7250,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 72,
                    Magic = 30,
                    Endurance = 55,
                    Agility = 52,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Sonic Punch"
                    },
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Apt Pupil"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Minotaur IV",
                Level = 75,
                HP = 680,
                SP = 234,
                Exp = 7250,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 72,
                    Magic = 30,
                    Endurance = 55,
                    Agility = 52,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Sonic Punch"
                    },
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Apt Pupil"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Miss Gene",
                Level = 27,
                HP = 186,
                SP = 30,
                Exp = 390,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 16,
                    Endurance = 14,
                    Agility = 22,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mistress Pot",
                Level = 78,
                HP = 150,
                SP = 218,
                Exp = 2060,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 60,
                    Magic = 43,
                    Endurance = 50,
                    Agility = 44,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Life Drain"
                    },
                    new ShadowSkill() {
                        Name = "Life Leech"
                    },
                    new ShadowSkill() {
                        Name = "Agneyastra"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Momentary Child",
                Level = 37,
                HP = 4500,
                SP = 1000,
                Exp = 8200,
                Yen = "¥1000",
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 15,
                    Endurance = 30,
                    Agility = 38,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Herculean Strike"
                    },
                    new ShadowSkill() {
                        Name = "Assault Dive"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Monomaniac Fuzz",
                Level = 44,
                HP = 196,
                SP = 106,
                Exp = 770,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 22,
                    Endurance = 28,
                    Agility = 26,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Fatal End"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Monopolizing Cupid",
                Level = 18,
                HP = 100,
                SP = 88,
                Exp = 140,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 6,
                    Magic = 12,
                    Endurance = 8,
                    Agility = 18,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Pulinpa"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    },
                    new ShadowSkill() {
                        Name = "Skewer"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Moon Okina",
                Level = 80,
                HP = 445,
                SP = 383,
                Exp = 1700,
                Yen = "¥420",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 55,
                    Endurance = 53,
                    Agility = 60,
                    Luck = 46
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mahamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mamudoon"
                    },
                    new ShadowSkill() {
                        Name = "Old One"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Mythical Gigas",
                Level = 57,
                HP = 344,
                SP = 94,
                Exp = 1940,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 22,
                    Endurance = 48,
                    Agility = 40,
                    Luck = 23
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Gigantic Fist"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    },
                    new ShadowSkill() {
                        Name = "Counterstrike"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Natural Dancer",
                Level = 64,
                HP = 325,
                SP = 230,
                Exp = 2760,
                Yen = "¥350",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 37,
                    Endurance = 40,
                    Agility = 45,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Cleave"
                    },
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    },
                    new ShadowSkill() {
                        Name = "Diarama"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Nemean Beast",
                Level = 70,
                HP = 362,
                SP = 155,
                Exp = -1,
                Yen = "¥-1",
                Stats = new Stats() {
                    Strength = -1,
                    Magic = -1,
                    Endurance = -1,
                    Agility = -1,
                    Luck = -1
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Slash"
                    },
                    new ShadowSkill() {
                        Name = "Deathbound"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Neo Minotaur",
                Level = 82,
                HP = 5100,
                SP = 379,
                Exp = 3120,
                Yen = "¥450",
                Stats = new Stats() {
                    Strength = 63,
                    Magic = 59,
                    Endurance = 54,
                    Agility = 42,
                    Luck = 88
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Mataru"
                    },
                    new ShadowSkill() {
                        Name = "Evade Fire"
                    },
                    new ShadowSkill() {
                        Name = "Ice Amp"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Neo Minotaur",
                Level = 78,
                HP = 4240,
                SP = 100,
                Exp = 23220,
                Yen = "¥520",
                Stats = new Stats() {
                    Strength = 69,
                    Magic = 44,
                    Endurance = 63,
                    Agility = 50,
                    Luck = 51
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rampage"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Next Gene",
                Level = 80,
                HP = 355,
                SP = 339,
                Exp = 1720,
                Yen = "¥420",
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 45,
                    Endurance = 48,
                    Agility = 56,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "Blue Wall"
                    },
                    new ShadowSkill() {
                        Name = "Green Wall"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Sukukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Nizam Beast",
                Level = 18,
                HP = 288,
                SP = 57,
                Exp = 380,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 12,
                    Endurance = 12,
                    Agility = 14,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Double Fangs"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Noble Seeker",
                Level = 18,
                HP = 288,
                SP = 57,
                Exp = 380,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 12,
                    Endurance = 12,
                    Agility = 14,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Double Fangs"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Opulent Hand",
                Level = 50,
                HP = 750,
                SP = 500,
                Exp = 30000,
                Yen = "¥12000",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 30,
                    Endurance = 40,
                    Agility = 65,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Pulinpa"
                    },
                    new ShadowSkill() {
                        Name = "Poisma"
                    },
                    new ShadowSkill() {
                        Name = "Enervation"
                    },
                    new ShadowSkill() {
                        Name = "Tentarafoo"
                    },
                    new ShadowSkill() {
                        Name = "Counter"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Order Giant",
                Level = 53,
                HP = 470,
                SP = 87,
                Exp = 2720,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 30,
                    Endurance = 20,
                    Agility = 34,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Blade of Fury"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Perpetual Sand",
                Level = 55,
                HP = 230,
                SP = 263,
                Exp = 1530,
                Yen = "¥220",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 40,
                    Endurance = 30,
                    Agility = 38,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Enervation"
                    },
                    new ShadowSkill() {
                        Name = "Cell Breaker"
                    },
                    new ShadowSkill() {
                        Name = "Old One"
                    },
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Persistent Fuzz",
                Level = 29,
                HP = 150,
                SP = 100,
                Exp = 450,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 18,
                    Endurance = 10,
                    Agility = 19,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Phantom Hero",
                Level = 78,
                HP = 325,
                SP = 438,
                Exp = 1960,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 49,
                    Endurance = 52,
                    Agility = 50,
                    Luck = 58
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Phantom King",
                Level = 75,
                HP = 432,
                SP = 122,
                Exp = 4780,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 70,
                    Endurance = 20,
                    Agility = 48,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Mahama"
                    },
                    new ShadowSkill() {
                        Name = "Fire Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Phantom Lord",
                Level = 61,
                HP = 279,
                SP = 469,
                Exp = 2890,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 48,
                    Endurance = 24,
                    Agility = 44,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Megido"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Phantom Mage",
                Level = 13,
                HP = 124,
                SP = 152,
                Exp = 162,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 2,
                    Magic = 7,
                    Endurance = 7,
                    Agility = 8,
                    Luck = 13
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    },
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Tarunda"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Phantom Master",
                Level = 20,
                HP = 162,
                SP = 189,
                Exp = 350,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 16,
                    Endurance = 12,
                    Agility = 10,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Magaru"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Pistil Mother",
                Level = 69,
                HP = 370,
                SP = 483,
                Exp = 4560,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 55,
                    Endurance = 25,
                    Agility = 47,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Platinum Dice",
                Level = 43,
                HP = 256,
                SP = 59,
                Exp = 520,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 15,
                    Endurance = 25,
                    Agility = 20,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Positive King",
                Level = 11,
                HP = 350,
                SP = 43,
                Exp = 212,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 6,
                    Magic = 8,
                    Endurance = 7,
                    Agility = 5,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "Dia"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Power Castle",
                Level = 54,
                HP = 299,
                SP = 385,
                Exp = 1680,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 43,
                    Endurance = 26,
                    Agility = 34,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Praying Nyogo",
                Level = 75,
                HP = 175,
                SP = 256,
                Exp = 1100,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 35,
                    Endurance = 40,
                    Agility = 40,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    },
                    new ShadowSkill() {
                        Name = "Atom Smasher"
                    },
                    new ShadowSkill() {
                        Name = "Dia"
                    },
                    new ShadowSkill() {
                        Name = "Rage Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Praying Papillon",
                Level = 73,
                HP = 150,
                SP = 511,
                Exp = 1650,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 57,
                    Endurance = 59,
                    Agility = 37,
                    Luck = 59
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Media"
                    },
                    new ShadowSkill() {
                        Name = "Soul Break"
                    },
                    new ShadowSkill() {
                        Name = "Anima Freeze"
                    },
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Masuku"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Wind"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Elec"
                    },
                    new ShadowSkill() {
                        Name = "Exhaust Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Prime Magus",
                Level = 56,
                HP = 364,
                SP = 472,
                Exp = 1500,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 24,
                    Magic = 44,
                    Endurance = 35,
                    Agility = 38,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Primitive Idol",
                Level = 77,
                HP = 1000,
                SP = 523,
                Exp = 1950,
                Yen = "¥400",
                Stats = new Stats() {
                    Strength = 58,
                    Magic = 58,
                    Endurance = 45,
                    Agility = 53,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heaven's Blade"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Protective Lexy",
                Level = 46,
                HP = 153,
                SP = 451,
                Exp = 860,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 42,
                    Endurance = 14,
                    Agility = 38,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Ptarmigan Panzer",
                Level = 81,
                HP = 1111,
                SP = 120,
                Exp = 2480,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 64,
                    Magic = 46,
                    Endurance = 72,
                    Agility = 54,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Hama"
                    },
                    new ShadowSkill() {
                        Name = "Elec Amp"
                    },
                    new ShadowSkill() {
                        Name = "Wind Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Pure Papillon",
                Level = 76,
                HP = 325,
                SP = 511,
                Exp = 2070,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 57,
                    Endurance = 45,
                    Agility = 58,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarunda"
                    },
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Poison Arrow"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Purple Sigil",
                Level = 71,
                HP = 328,
                SP = 523,
                Exp = -1,
                Yen = "¥-1",
                Stats = new Stats() {
                    Strength = 49,
                    Magic = 57,
                    Endurance = 30,
                    Agility = 47,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Megido"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Pursuing Pesce",
                Level = 18,
                HP = 125,
                SP = 85,
                Exp = 240,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 12,
                    Endurance = 10,
                    Agility = 12,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Evil Touch"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rain End Musha",
                Level = 42,
                HP = 566,
                SP = 73,
                Exp = 2800,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 18,
                    Endurance = 31,
                    Agility = 30,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Vicious Strike"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Sharp Student"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rain Leg Musha",
                Level = 34,
                HP = 265,
                SP = 79,
                Exp = 1450,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 18,
                    Endurance = 23,
                    Agility = 22,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Rebellion"
                    },
                    new ShadowSkill() {
                        Name = "Gale Slash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rain Wheel",
                Level = 30,
                HP = 50,
                SP = 56,
                Exp = 760,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 9,
                    Endurance = 17,
                    Agility = 19,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rain Wind Musha",
                Level = 65,
                HP = 694,
                SP = 126,
                Exp = 4130,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 37,
                    Endurance = 37,
                    Agility = 46,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Physical"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainbow Twins",
                Level = 48,
                HP = 250,
                SP = 149,
                Exp = 1380,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 28,
                    Endurance = 23,
                    Agility = 36,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Raindrop Castle",
                Level = 48,
                HP = 250,
                SP = 149,
                Exp = 1380,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 28,
                    Endurance = 23,
                    Agility = 36,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Stagnant Air"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    },
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Raindrop Musha",
                Level = 51,
                HP = 1050,
                SP = 119,
                Exp = 1900,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 32,
                    Endurance = 16,
                    Agility = 37,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Physical"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Brother 1",
                Level = 44,
                HP = 110,
                SP = 193,
                Exp = 960,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 30,
                    Endurance = 24,
                    Agility = 30,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Re Patra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Brother 2",
                Level = 43,
                HP = 89,
                SP = 190,
                Exp = 680,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 30,
                    Endurance = 18,
                    Agility = 29,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Maragion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Brother 4",
                Level = 16,
                HP = 92,
                SP = 131,
                Exp = 200,
                Yen = "¥190",
                Stats = new Stats() {
                    Strength = 2,
                    Magic = 16,
                    Endurance = 12,
                    Agility = 10,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Castle",
                Level = 37,
                HP = 220,
                SP = 296,
                Exp = 880,
                Yen = "¥260",
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 29,
                    Endurance = 17,
                    Agility = 25,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Pot",
                Level = 41,
                HP = 62,
                SP = 178,
                Exp = 800,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 28,
                    Endurance = 25,
                    Agility = 26,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Sister 1",
                Level = 44,
                HP = 110,
                SP = 193,
                Exp = 940,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 30,
                    Endurance = 28,
                    Agility = 27,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Sister 2",
                Level = 40,
                HP = 42,
                SP = 40,
                Exp = 530,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 28,
                    Endurance = 22,
                    Agility = 26,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mabufula"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Sister 3",
                Level = 28,
                HP = 80,
                SP = 203,
                Exp = 580,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 28,
                    Endurance = 13,
                    Agility = 16,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Magaru"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rainy Sister 4",
                Level = 21,
                HP = 80,
                SP = 136,
                Exp = 240,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 6,
                    Endurance = 10,
                    Agility = 14,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rampage Drive",
                Level = 81,
                HP = 385,
                SP = 169,
                Exp = 2480,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 57,
                    Magic = 45,
                    Endurance = 62,
                    Agility = 50,
                    Luck = 58
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mudo"
                    },
                    new ShadowSkill() {
                        Name = "Fire Amp"
                    },
                    new ShadowSkill() {
                        Name = "Ice Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rash Panzer",
                Level = 58,
                HP = 284,
                SP = 113,
                Exp = 2310,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 20,
                    Endurance = 60,
                    Agility = 28,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mustard Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Seal Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Foul Breath"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Rebellious Cyclops",
                Level = 81,
                HP = 525,
                SP = 428,
                Exp = 1780,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 88,
                    Magic = 42,
                    Endurance = 49,
                    Agility = 54,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Primal Force"
                    },
                    new ShadowSkill() {
                        Name = "Cruel Attack"
                    },
                    new ShadowSkill() {
                        Name = "Diarahan"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Ice"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Reckless Okina",
                Level = 61,
                HP = 310,
                SP = 354,
                Exp = 2080,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 46,
                    Endurance = 36,
                    Agility = 42,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarula"
                    },
                    new ShadowSkill() {
                        Name = "Red Wall"
                    },
                    new ShadowSkill() {
                        Name = "White Wall"
                    },
                    new ShadowSkill() {
                        Name = "Blue Wall"
                    },
                    new ShadowSkill() {
                        Name = "Green Wall"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Reckoning Dice",
                Level = 82,
                HP = 777,
                SP = 77,
                Exp = 2660,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 1,
                    Magic = 77,
                    Endurance = 55,
                    Agility = 55,
                    Luck = 77
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Cleave"
                    },
                    new ShadowSkill() {
                        Name = "Last Resort"
                    },
                    new ShadowSkill() {
                        Name = "Apt Pupil"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Red Sigil",
                Level = 48,
                HP = 247,
                SP = 405,
                Exp = 2080,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 38,
                    Endurance = 21,
                    Agility = 32,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Maragion"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Ice"
                    },
                    new ShadowSkill() {
                        Name = "Balzac"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Reformed Okina",
                Level = 73,
                HP = 315,
                SP = 519,
                Exp = 4420,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 72,
                    Endurance = 38,
                    Agility = 48,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Vicious Strike"
                    },
                    new ShadowSkill() {
                        Name = "Debilitate"
                    },
                    new ShadowSkill() {
                        Name = "Media"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Regal Mother",
                Level = 60,
                HP = 228,
                SP = 386,
                Exp = 2100,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 42,
                    Endurance = 31,
                    Agility = 37,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragion"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Revelation Pesce",
                Level = 63,
                HP = 256,
                SP = 149,
                Exp = 2120,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 31,
                    Endurance = 31,
                    Agility = 44,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mediarama"
                    },
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Reverent Table",
                Level = 74,
                HP = 950,
                SP = 231,
                Exp = 950,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 58,
                    Magic = 29,
                    Endurance = 35,
                    Agility = 45,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Royal Dancer",
                Level = 47,
                HP = 282,
                SP = 210,
                Exp = 1580,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 30,
                    Endurance = 15,
                    Agility = 32,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Gale Slash"
                    },
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    },
                    new ShadowSkill() {
                        Name = "Poison Skewer"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Scarlet Turret",
                Level = 46,
                HP = 355,
                SP = 246,
                Exp = 2450,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 29,
                    Endurance = 38,
                    Agility = 30,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Maragion"
                    },
                    new ShadowSkill() {
                        Name = "Dia"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Secret Bambino",
                Level = 10,
                HP = 80,
                SP = 62,
                Exp = 82,
                Yen = "¥200",
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 5,
                    Endurance = 10,
                    Agility = 2,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Selfish Basalt",
                Level = 22,
                HP = 168,
                SP = 80,
                Exp = 240,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 12,
                    Endurance = 16,
                    Agility = 8,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Shallow Okina",
                Level = 49,
                HP = 267,
                SP = 322,
                Exp = 1350,
                Yen = "¥300",
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 38,
                    Endurance = 20,
                    Agility = 32,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Old One"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Herculean Strike"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Silent Book",
                Level = 72,
                HP = 307,
                SP = 421,
                Exp = 3250,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 53,
                    Endurance = 24,
                    Agility = 50,
                    Luck = 50
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Makajam"
                    },
                    new ShadowSkill() {
                        Name = "Foolish Whisper"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Seal Bomb"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Silent Nyogo",
                Level = 77,
                HP = 1500,
                SP = 179,
                Exp = 1430,
                Yen = "¥400",
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 35,
                    Endurance = 44,
                    Agility = 53,
                    Luck = 55
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    },
                    new ShadowSkill() {
                        Name = "Myriad Arrows"
                    },
                    new ShadowSkill() {
                        Name = "Gale Slash"
                    },
                    new ShadowSkill() {
                        Name = "Rainy Death"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    },
                    new ShadowSkill() {
                        Name = "Apt Pupil"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Silver Dice",
                Level = 31,
                HP = 250,
                SP = 83,
                Exp = 480,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 19,
                    Endurance = 19,
                    Agility = 20,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Last Resort"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Sky Balance",
                Level = 30,
                HP = 218,
                SP = 440,
                Exp = 1680,
                Yen = "¥250",
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 35,
                    Endurance = 18,
                    Agility = 24,
                    Luck = 17
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Slaughter Drive",
                Level = 74,
                HP = 380,
                SP = 150,
                Exp = 5040,
                Yen = "¥390",
                Stats = new Stats() {
                    Strength = 68,
                    Magic = 38,
                    Endurance = 36,
                    Agility = 47,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Double Fangs"
                    },
                    new ShadowSkill() {
                        Name = "Torrent Shot"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Sleeping Table",
                Level = 71,
                HP = 333,
                SP = 60,
                Exp = 3950,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 56,
                    Endurance = 30,
                    Agility = 50,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Brain Shake"
                    },
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Anima Freeze"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Sleeping Table",
                Level = 82,
                HP = 2000,
                SP = 2000,
                Exp = 24570,
                Yen = "¥520",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 54,
                    Endurance = 67,
                    Agility = 55,
                    Luck = 75
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Mahamaon"
                    },
                    new ShadowSkill() {
                        Name = "Megidolaon"
                    },
                    new ShadowSkill() {
                        Name = "Evil Smile"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Slipping Hablerie",
                Level = 1,
                HP = 40,
                SP = 35,
                Exp = 30,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 2,
                    Magic = 2,
                    Endurance = 5,
                    Agility = 1,
                    Luck = 1
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Attack"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Snowfall Musha",
                Level = 73,
                HP = 330,
                SP = 129,
                Exp = 1500,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 33,
                    Endurance = 55,
                    Agility = 37,
                    Luck = 46
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tempest Slash"
                    },
                    new ShadowSkill() {
                        Name = "Black Spot"
                    },
                    new ShadowSkill() {
                        Name = "Megido"
                    },
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Tarunda"
                    },
                    new ShadowSkill() {
                        Name = "Rakunda"
                    },
                    new ShadowSkill() {
                        Name = "Diarama"
                    },
                    new ShadowSkill() {
                        Name = "Rebellion"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Solemn Machine",
                Level = 78,
                HP = 5486,
                SP = 133,
                Exp = 9990,
                Yen = "¥770",
                Stats = new Stats() {
                    Strength = 60,
                    Magic = 42,
                    Endurance = 1,
                    Agility = 51,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Heaven's Blade"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Sonic Raven",
                Level = 29,
                HP = 210,
                SP = 84,
                Exp = 390,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 10,
                    Endurance = 12,
                    Agility = 19,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Soul Dancer",
                Level = 28,
                HP = 180,
                SP = 129,
                Exp = 420,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 16,
                    Endurance = 12,
                    Agility = 18,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agilao"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Source Basalt",
                Level = 45,
                HP = 270,
                SP = 44,
                Exp = 1100,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 28,
                    Endurance = 20,
                    Agility = 29,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Foul Breath"
                    },
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Skull Cracker"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Spastic Turret",
                Level = 75,
                HP = 400,
                SP = 429,
                Exp = 5000,
                Yen = "¥400",
                Stats = new Stats() {
                    Strength = 62,
                    Magic = 95,
                    Endurance = 48,
                    Agility = 60,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Ragnarok"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Spectral Raven",
                Level = 74,
                HP = 150,
                SP = 445,
                Exp = 950,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 23,
                    Magic = 58,
                    Endurance = 14,
                    Agility = 48,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Dodge Physical"
                    },
                    new ShadowSkill() {
                        Name = "Cleave"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    },
                    new ShadowSkill() {
                        Name = "Garula"
                    },
                    new ShadowSkill() {
                        Name = "Silence Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Spurious Book",
                Level = 39,
                HP = 142,
                SP = 242,
                Exp = 760,
                Yen = "¥270",
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 24,
                    Endurance = 25,
                    Agility = 30,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Stasis Giant",
                Level = 63,
                HP = 456,
                SP = 96,
                Exp = 2380,
                Yen = "¥350",
                Stats = new Stats() {
                    Strength = 55,
                    Magic = 35,
                    Endurance = 48,
                    Agility = 35,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mighty Swing"
                    },
                    new ShadowSkill() {
                        Name = "Vicious Strike"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Steel Machine",
                Level = 45,
                HP = 65,
                SP = 55,
                Exp = 3400,
                Yen = "¥290",
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 14,
                    Endurance = 34,
                    Agility = 30,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Navas Nebula"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Stoic Snake",
                Level = 81,
                HP = 441,
                SP = 259,
                Exp = 2110,
                Yen = "¥430",
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 69,
                    Endurance = 51,
                    Agility = 56,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Spirit Leech"
                    },
                    new ShadowSkill() {
                        Name = "Poison Arrow"
                    },
                    new ShadowSkill() {
                        Name = "Blight"
                    },
                    new ShadowSkill() {
                        Name = "Poison Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Stone Panzer",
                Level = 75,
                HP = 300,
                SP = 666,
                Exp = 1800,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 25,
                    Endurance = 58,
                    Agility = 49,
                    Luck = 52
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Stupendous Relic",
                Level = 73,
                HP = 50,
                SP = 485,
                Exp = 1750,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 67,
                    Endurance = 85,
                    Agility = 82,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Old One"
                    },
                    new ShadowSkill() {
                        Name = "Cell Breaker"
                    },
                    new ShadowSkill() {
                        Name = "Recarmdra"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Maraku"
                    },
                    new ShadowSkill() {
                        Name = "Null Dizzy"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Successful Junecy",
                Level = 82,
                HP = 307,
                SP = 300,
                Exp = 2430,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 34,
                    Endurance = 72,
                    Agility = 60,
                    Luck = 52
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Revolution"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Muzzle Shot"
                    },
                    new ShadowSkill() {
                        Name = "Silence Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Superstitious Okina",
                Level = 74,
                HP = 400,
                SP = 519,
                Exp = 1600,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 51,
                    Endurance = 5,
                    Agility = 65,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Auto-Rakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Dodge Ice"
                    },
                    new ShadowSkill() {
                        Name = "Evade Wind"
                    },
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Heat Riser"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Supreme Hand",
                Level = 40,
                HP = 500,
                SP = 500,
                Exp = 20000,
                Yen = "¥9000",
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 30,
                    Endurance = 45,
                    Agility = 55,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Poisma"
                    },
                    new ShadowSkill() {
                        Name = "Poison Mist"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "The Reaper",
                Level = 85,
                HP = 5000,
                SP = 12000,
                Exp = 5000,
                Yen = "¥13",
                Stats = new Stats() {
                    Strength = 99,
                    Magic = 80,
                    Endurance = 80,
                    Agility = 75,
                    Luck = 99
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Vile Assault"
                    },
                    new ShadowSkill() {
                        Name = "Myriad Arrows"
                    },
                    new ShadowSkill() {
                        Name = "Vorpal Blade"
                    },
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Maragidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mabufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Maziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    },
                    new ShadowSkill() {
                        Name = "Megidola"
                    },
                    new ShadowSkill() {
                        Name = "Megidolaon"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mahamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    },
                    new ShadowSkill() {
                        Name = "Mamudoon"
                    },
                    new ShadowSkill() {
                        Name = "Fire Break"
                    },
                    new ShadowSkill() {
                        Name = "Ice Break"
                    },
                    new ShadowSkill() {
                        Name = "Elec Break"
                    },
                    new ShadowSkill() {
                        Name = "Wind Break"
                    },
                    new ShadowSkill() {
                        Name = "Life Drain"
                    },
                    new ShadowSkill() {
                        Name = "Spirit Drain"
                    },
                    new ShadowSkill() {
                        Name = "Life Leech"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Trance Twins",
                Level = 7,
                HP = 222,
                SP = 22,
                Exp = 88,
                Yen = "¥160",
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 6,
                    Endurance = 5,
                    Agility = 6,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Evil Touch"
                    },
                    new ShadowSkill() {
                        Name = "Twin Shot"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Tranquil Idol",
                Level = 22,
                HP = 185,
                SP = 165,
                Exp = 380,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 15,
                    Endurance = 11,
                    Agility = 15,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Treasure Hand",
                Level = 22,
                HP = 185,
                SP = 165,
                Exp = 380,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 15,
                    Endurance = 11,
                    Agility = 15,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Mabufu"
                    },
                    new ShadowSkill() {
                        Name = "Marakukaja"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Truth Pesce",
                Level = 53,
                HP = 212,
                SP = 138,
                Exp = 1680,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 27,
                    Endurance = 24,
                    Agility = 41,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Fatal End"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Megido"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Valuing Nyogo",
                Level = 72,
                HP = 288,
                SP = 206,
                Exp = 4020,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 39,
                    Endurance = 30,
                    Agility = 48,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hysterical Slap"
                    },
                    new ShadowSkill() {
                        Name = "Valiant Dance"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Vehement Idol",
                Level = 68,
                HP = 301,
                SP = 487,
                Exp = 2480,
                Yen = "¥360",
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 48,
                    Endurance = 28,
                    Agility = 43,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bufula"
                    },
                    new ShadowSkill() {
                        Name = "Mabufula"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Mediarama"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Venus Eagle",
                Level = 31,
                HP = 216,
                SP = 140,
                Exp = 580,
                Yen = "¥240",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 20,
                    Endurance = 16,
                    Agility = 19,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hama"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Vicious Raven",
                Level = 20,
                HP = 150,
                SP = 98,
                Exp = 220,
                Yen = "¥210",
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 10,
                    Endurance = 12,
                    Agility = 18,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Marakunda"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Void Giant",
                Level = 82,
                HP = 455,
                SP = 133,
                Exp = 2670,
                Yen = "¥440",
                Stats = new Stats() {
                    Strength = 67,
                    Magic = 72,
                    Endurance = 54,
                    Agility = 58,
                    Luck = 49
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Fatal End"
                    },
                    new ShadowSkill() {
                        Name = "Seal Bomb"
                    },
                    new ShadowSkill() {
                        Name = "Silence Boost"
                    },
                    new ShadowSkill() {
                        Name = "Auto-Maraku"
                    },
                    new ShadowSkill() {
                        Name = "Power Charge"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Wealth Hand",
                Level = 20,
                HP = 300,
                SP = 250,
                Exp = 6000,
                Yen = "¥5000",
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 15,
                    Endurance = 50,
                    Agility = 35,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agi"
                    },
                    new ShadowSkill() {
                        Name = "Garu"
                    },
                    new ShadowSkill() {
                        Name = "Bufu"
                    },
                    new ShadowSkill() {
                        Name = "Zio"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Pulinpa"
                    },
                    new ShadowSkill() {
                        Name = "Tentarafoo"
                    },
                    new ShadowSkill() {
                        Name = "Summon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Wheeled Bambino",
                Level = 75,
                HP = 70,
                SP = 245,
                Exp = 1250,
                Yen = "¥0",
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 42,
                    Endurance = 75,
                    Agility = 38,
                    Luck = 66
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Bash"
                    },
                    new ShadowSkill() {
                        Name = "Rampage"
                    },
                    new ShadowSkill() {
                        Name = "Life Drain"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Whimsical Papillon",
                Level = 40,
                HP = 254,
                SP = 334,
                Exp = 740,
                Yen = "¥280",
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 29,
                    Endurance = 17,
                    Agility = 30,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Tarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Sukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Masukukaja"
                    },
                    new ShadowSkill() {
                        Name = "Rakukaja"
                    },
                    new ShadowSkill() {
                        Name = "Matarunda"
                    },
                    new ShadowSkill() {
                        Name = "Masukunda"
                    },
                    new ShadowSkill() {
                        Name = "Marakunda"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Wicked Turret",
                Level = 53,
                HP = 455,
                SP = 201,
                Exp = 3330,
                Yen = "¥320",
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 25,
                    Endurance = 29,
                    Agility = 35,
                    Luck = 23
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Magarudyne"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Wild Drive",
                Level = 51,
                HP = 270,
                SP = 120,
                Exp = 1530,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 27,
                    Endurance = 21,
                    Agility = 37,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Matarukaja"
                    },
                    new ShadowSkill() {
                        Name = "Kill Rush"
                    },
                    new ShadowSkill() {
                        Name = "Mind Slice"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Wondrous Magus",
                Level = 25,
                HP = 165,
                SP = 269,
                Exp = 420,
                Yen = "¥230",
                Stats = new Stats() {
                    Strength = 1,
                    Magic = 19,
                    Endurance = 10,
                    Agility = 16,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Maragi"
                    },
                    new ShadowSkill() {
                        Name = "Agilao"
                    },
                    new ShadowSkill() {
                        Name = "Mazio"
                    },
                    new ShadowSkill() {
                        Name = "Zionga"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "World Balance",
                Level = 52,
                HP = 210,
                SP = 576,
                Exp = 2300,
                Yen = "¥310",
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 55,
                    Endurance = 21,
                    Agility = 35,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Hamaon"
                    },
                    new ShadowSkill() {
                        Name = "Mudoon"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "World Balance",
                Level = 63,
                HP = 1200,
                SP = 1000,
                Exp = 22980,
                Yen = "¥410",
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 45,
                    Endurance = 45,
                    Agility = 45,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Agidyne"
                    },
                    new ShadowSkill() {
                        Name = "Bufudyne"
                    },
                    new ShadowSkill() {
                        Name = "Ziodyne"
                    },
                    new ShadowSkill() {
                        Name = "Garudyne"
                    },
                    new ShadowSkill() {
                        Name = "Mind Charge"
                    }
                },
                Type = ShadowType.MiniBoss
            },
            new Shadow() {
                Name = "Wrathful Book",
                Level = 76,
                HP = 341,
                SP = 445,
                Exp = 2080,
                Yen = "¥380",
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 58,
                    Endurance = 44,
                    Agility = 60,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Dodge Physical"
                    },
                    new ShadowSkill() {
                        Name = "Tetrakarn"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    },
                    new ShadowSkill() {
                        Name = "Crazy Chain"
                    },
                    new ShadowSkill() {
                        Name = "Balzac"
                    },
                    new ShadowSkill() {
                        Name = "Rage Boost"
                    }
                },
                Type = ShadowType.Normal
            },
            new Shadow() {
                Name = "Yearning Pot",
                Level = 70,
                HP = 298,
                SP = 230,
                Exp = 4740,
                Yen = "¥370",
                Stats = new Stats() {
                    Strength = 47,
                    Magic = 43,
                    Endurance = 34,
                    Agility = 43,
                    Luck = 37
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Absorb,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect
                },
                Skills = new List<ShadowSkill>() {
                    new ShadowSkill() {
                        Name = "Evil Touch"
                    },
                    new ShadowSkill() {
                        Name = "Evil Smile"
                    },
                    new ShadowSkill() {
                        Name = "Ghastly Wail"
                    },
                    new ShadowSkill() {
                        Name = "Makarakarn"
                    }
                },
                Type = ShadowType.Normal
            }
        };
    }
}
