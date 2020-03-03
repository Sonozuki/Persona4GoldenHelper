using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The persona data.</summary>
    public static class PersonaData
    {
        /// <summary>The persona data.</summary>
        public static List<Persona> Personas { get; } = new List<Persona>
        {
            new Persona() {
                Name = "Izanagi",
                Arcana = "Fool",
                Level = 1,
                Stats = new Stats() {
                    Strength = 3,
                    Magic = 2,
                    Endurance = 2,
                    Agility = 3,
                    Luck = 2
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Cleave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 3
                    },
                    new PersonaSkill() {
                        Name = "Tarukaja",
                        LevelRequired = 5
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Pixie",
                Arcana = "Magician",
                Level = 2,
                Stats = new Stats() {
                    Strength = 2,
                    Magic = 3,
                    Endurance = 2,
                    Agility = 4,
                    Luck = 2
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Dia",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 3
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 4
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 8
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Slime",
                Arcana = "Chariot",
                Level = 2,
                Stats = new Stats() {
                    Strength = 3,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 2,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Touch",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarunda",
                        LevelRequired = 3
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 4
                    },
                    new PersonaSkill() {
                        Name = "Fear Boost",
                        LevelRequired = 5
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 7
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ukobach",
                Arcana = "Devil",
                Level = 3,
                Stats = new Stats() {
                    Strength = 3,
                    Magic = 4,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 2
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Pulinpa",
                        LevelRequired = 4
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 5
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 6
                    },
                    new PersonaSkill() {
                        Name = "Fire Break",
                        LevelRequired = 7
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Angel",
                Arcana = "Justice",
                Level = 4,
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 5,
                    Endurance = 2,
                    Agility = 5,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hama",
                        LevelRequired = 5
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 6
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 1",
                        LevelRequired = 8
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 9
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Apsaras",
                Arcana = "Temperance",
                Level = 4,
                Stats = new Stats() {
                    Strength = 3,
                    Magic = 5,
                    Endurance = 3,
                    Agility = 5,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dia",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 5
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 6
                    },
                    new PersonaSkill() {
                        Name = "Bufu",
                        LevelRequired = 7
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sandman",
                Arcana = "Strength",
                Level = 5,
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 5,
                    Endurance = 6,
                    Agility = 4,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Pulinpa",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Skull Cracker",
                        LevelRequired = 6
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 7
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 8
                    },
                    new PersonaSkill() {
                        Name = "Traesto",
                        LevelRequired = 11
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Nata Taishi",
                Arcana = "Chariot",
                Level = 6,
                Stats = new Stats() {
                    Strength = 6,
                    Magic = 2,
                    Endurance = 6,
                    Agility = 7,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sonic Punch",
                        LevelRequired = 7
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 8
                    },
                    new PersonaSkill() {
                        Name = "Resist Dizzy",
                        LevelRequired = 9
                    },
                    new PersonaSkill() {
                        Name = "Soul Break",
                        LevelRequired = 10
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Forneus",
                Arcana = "Hermit",
                Level = 6,
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 5,
                    Endurance = 7,
                    Agility = 6,
                    Luck = 3
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Skewer",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 7
                    },
                    new PersonaSkill() {
                        Name = "Poisma",
                        LevelRequired = 8
                    },
                    new PersonaSkill() {
                        Name = "Dodge Elec",
                        LevelRequired = 10
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yomotsu-Shikome",
                Arcana = "Fool",
                Level = 7,
                Stats = new Stats() {
                    Strength = 2,
                    Magic = 7,
                    Endurance = 7,
                    Agility = 8,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Poisma",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Skewer",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Touch",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukunda",
                        LevelRequired = 9
                    },
                    new PersonaSkill() {
                        Name = "Mudo",
                        LevelRequired = 10
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 11
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Omoikane",
                Arcana = "Hierophant",
                Level = 7,
                Stats = new Stats() {
                    Strength = 5,
                    Magic = 8,
                    Endurance = 5,
                    Agility = 4,
                    Luck = 6
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 8
                    },
                    new PersonaSkill() {
                        Name = "Resist Wind",
                        LevelRequired = 9
                    },
                    new PersonaSkill() {
                        Name = "Resist Poison",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Resist Elec",
                        LevelRequired = 12
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Orobas",
                Arcana = "Magician",
                Level = 8,
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 10,
                    Endurance = 6,
                    Agility = 7,
                    Luck = 4
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hysterical Slap",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 10
                    },
                    new PersonaSkill() {
                        Name = "Resist Dizzy",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Sharp Student",
                        LevelRequired = 12
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Valkyrie",
                Arcana = "Strength",
                Level = 8,
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 6,
                    Endurance = 6,
                    Agility = 7,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Cleave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 10
                    },
                    new PersonaSkill() {
                        Name = "Arm Chopper",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 12
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Senri",
                Arcana = "Empress",
                Level = 9,
                Stats = new Stats() {
                    Strength = 7,
                    Magic = 7,
                    Endurance = 4,
                    Agility = 11,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Dia",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makajam",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 10
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 14
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ghoul",
                Arcana = "Death",
                Level = 9,
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 7,
                    Endurance = 9,
                    Agility = 5,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poisma",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 10
                    },
                    new PersonaSkill() {
                        Name = "Enervation",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Poison Skewer",
                        LevelRequired = 12
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Poison Boost",
                        LevelRequired = 14
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Lilim",
                Arcana = "Devil",
                Level = 10,
                Stats = new Stats() {
                    Strength = 4,
                    Magic = 11,
                    Endurance = 5,
                    Agility = 9,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enervation",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enervate Boost",
                        LevelRequired = 12
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Mamudo",
                        LevelRequired = 15
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Cu Sith",
                Arcana = "Sun",
                Level = 10,
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 5,
                    Endurance = 6,
                    Agility = 9,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Pulinpa",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 1",
                        LevelRequired = 11
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "White Wall",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Traesto",
                        LevelRequired = 15
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Saki Mitama",
                Arcana = "Priestess",
                Level = 11,
                Stats = new Stats() {
                    Strength = 5,
                    Magic = 12,
                    Endurance = 5,
                    Agility = 8,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Dia",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Alertness",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Null Rage",
                        LevelRequired = 16
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Archangel",
                Arcana = "Justice",
                Level = 11,
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 9,
                    Endurance = 7,
                    Agility = 7,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Double Fangs",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 12
                    },
                    new PersonaSkill() {
                        Name = "Muzzle Shot",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Sharp Student",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 15
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sylph",
                Arcana = "Temperance",
                Level = 11,
                Stats = new Stats() {
                    Strength = 8,
                    Magic = 10,
                    Endurance = 5,
                    Agility = 10,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 1",
                        LevelRequired = 12
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 14
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Oberon",
                Arcana = "Emperor",
                Level = 12,
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 12,
                    Endurance = 8,
                    Agility = 8,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Arm Chopper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makajam",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 15
                    },
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 16
                    },
                    new PersonaSkill() {
                        Name = "Dodge Wind",
                        LevelRequired = 17
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Eligor",
                Arcana = "Chariot",
                Level = 12,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 6,
                    Endurance = 13,
                    Agility = 8,
                    Luck = 5
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Poison Skewer",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 13
                    },
                    new PersonaSkill() {
                        Name = "Arm Chopper",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 15
                    },
                    new PersonaSkill() {
                        Name = "Soul Break",
                        LevelRequired = 16
                    },
                    new PersonaSkill() {
                        Name = "Resist Exhaust",
                        LevelRequired = 17
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Obariyon",
                Arcana = "Fool",
                Level = 13,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 6,
                    Endurance = 11,
                    Agility = 9,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Sonic Punch",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Muzzle Shot",
                        LevelRequired = 14
                    },
                    new PersonaSkill() {
                        Name = "Silence Boost",
                        LevelRequired = 15
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 17
                    },
                    new PersonaSkill() {
                        Name = "Single Shot",
                        LevelRequired = 18
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Titan",
                Arcana = "Strength",
                Level = 14,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 12,
                    Endurance = 10,
                    Agility = 10,
                    Luck = 6
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Skull Cracker",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 16
                    },
                    new PersonaSkill() {
                        Name = "Kill Rush",
                        LevelRequired = 18
                    },
                    new PersonaSkill() {
                        Name = "Resist Fear",
                        LevelRequired = 19
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mokoi",
                Arcana = "Death",
                Level = 14,
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 7,
                    Endurance = 9,
                    Agility = 11,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Sonic Punch",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hysterical Slap",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Valiant Dance",
                        LevelRequired = 15
                    },
                    new PersonaSkill() {
                        Name = "Rage Boost",
                        LevelRequired = 16
                    },
                    new PersonaSkill() {
                        Name = "Soul Break",
                        LevelRequired = 18
                    },
                    new PersonaSkill() {
                        Name = "Exhaust Boost",
                        LevelRequired = 19
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Anzu",
                Arcana = "Hierophant",
                Level = 15,
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 11,
                    Endurance = 10,
                    Agility = 13,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Balzac",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Alertness",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 17
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 18
                    },
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 20
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Berith",
                Arcana = "Hanged Man",
                Level = 15,
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 10,
                    Endurance = 9,
                    Agility = 12,
                    Luck = 9
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Single Shot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 16
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 17
                    },
                    new PersonaSkill() {
                        Name = "Green Wall",
                        LevelRequired = 18
                    },
                    new PersonaSkill() {
                        Name = "Brain Shake",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Resist Confuse",
                        LevelRequired = 20
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Jack Frost",
                Arcana = "Magician",
                Level = 16,
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 14,
                    Endurance = 12,
                    Agility = 11,
                    Luck = 8
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Break",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Dodge Fire",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 25
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Xiezhai",
                Arcana = "Temperance",
                Level = 16,
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 12,
                    Endurance = 9,
                    Agility = 13,
                    Luck = 7
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makajam",
                        LevelRequired = 17
                    },
                    new PersonaSkill() {
                        Name = "Silence Boost",
                        LevelRequired = 18
                    },
                    new PersonaSkill() {
                        Name = "Rampage",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 21
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sarasvati",
                Arcana = "Pristess",
                Level = 17,
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 16,
                    Endurance = 10,
                    Agility = 13,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 2",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Resist Rage",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Null Wind",
                        LevelRequired = 23
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ippon-Datara",
                Arcana = "Hermit",
                Level = 17,
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 6,
                    Endurance = 14,
                    Agility = 13,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudo",
                        LevelRequired = 19
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Rampage",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 22
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yaksini",
                Arcana = "Empress",
                Level = 18,
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 16,
                    Endurance = 10,
                    Agility = 12,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Resistant,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Arm Chopper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Swift Strike",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Auto-Tarukaja",
                        LevelRequired = 23
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ame No Uzume",
                Arcana = "Aeon",
                Level = 18,
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 15,
                    Endurance = 12,
                    Agility = 10,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 1",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Re Patra",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Auto-Rakukaja",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 24
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ara Mitama",
                Arcana = "Chariot",
                Level = 18,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 11,
                    Endurance = 11,
                    Agility = 11,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Assault Dive",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarukaja",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Sharp Student",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Blue Wall",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Dodge Elec",
                        LevelRequired = 23
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Principality",
                Arcana = "Justice",
                Level = 19,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 15,
                    Endurance = 10,
                    Agility = 18,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Twin Shot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Resist Confuse",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Tetraja",
                        LevelRequired = 25
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Vetala",
                Arcana = "Devil",
                Level = 19,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 10,
                    Endurance = 14,
                    Agility = 12,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Touch",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Life Drain",
                        LevelRequired = 20
                    },
                    new PersonaSkill() {
                        Name = "Foul Breath",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Brain Shake",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Fear Boost",
                        LevelRequired = 24
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Andra",
                Arcana = "Moon",
                Level = 20,
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 16,
                    Endurance = 13,
                    Agility = 12,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Media",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Blue Wall",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Dodge Wind",
                        LevelRequired = 25
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Gurr",
                Arcana = "Jester",
                Level = 20,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 11,
                    Endurance = 14,
                    Agility = 15,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Muzzle Shot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Tarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 1",
                        LevelRequired = 21
                    },
                    new PersonaSkill() {
                        Name = "Swift Strike",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Poison Boost",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 27
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Phoenix",
                Arcana = "Sun",
                Level = 20,
                Stats = new Stats() {
                    Strength = 9,
                    Magic = 15,
                    Endurance = 9,
                    Agility = 20,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Twin Shot",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Growth 1",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 27
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Legion",
                Arcana = "Fool",
                Level = 21,
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 14,
                    Endurance = 18,
                    Agility = 13,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rampage",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Foul Breath",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 26
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Shiisaa",
                Arcana = "Hierophant",
                Level = 21,
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 18,
                    Endurance = 9,
                    Agility = 14,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Balzac",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 22
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Silence Boost",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Null Rage",
                        LevelRequired = 26
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "High Pixie",
                Arcana = "Priestess",
                Level = 22,
                Stats = new Stats() {
                    Strength = 10,
                    Magic = 21,
                    Endurance = 10,
                    Agility = 19,
                    Luck = 13
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 1",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Dodge Fire",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 27
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "King Frost",
                Arcana = "Emperor",
                Level = 22,
                Stats = new Stats() {
                    Strength = 11,
                    Magic = 20,
                    Endurance = 17,
                    Agility = 13,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Break",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 23
                    },
                    new PersonaSkill() {
                        Name = "Dodge Fire",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Null Fire",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Anima Freeze",
                        LevelRequired = 28
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yomotsu-Ikusa",
                Arcana = "Hanged Man",
                Level = 22,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 16,
                    Endurance = 18,
                    Agility = 12,
                    Luck = 10
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Cell Breaker",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufu",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enervate Boost",
                        LevelRequired = 24
                    },
                    new PersonaSkill() {
                        Name = "Foul Breath",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Poison Boost",
                        LevelRequired = 27
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Rakshasa",
                Arcana = "Strength",
                Level = 23,
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 12,
                    Endurance = 18,
                    Agility = 14,
                    Luck = 13
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Kill Rush",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Brain Shake",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Gale Slash",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Auto-Tarukaja",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Dodge Physical",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 28
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Nigi Mitama",
                Arcana = "Temperance",
                Level = 23,
                Stats = new Stats() {
                    Strength = 15,
                    Magic = 16,
                    Endurance = 14,
                    Agility = 15,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Re Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 2",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 28
                    },
                    new PersonaSkill() {
                        Name = "Resist Enervate",
                        LevelRequired = 29
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Matador",
                Arcana = "Death",
                Level = 24,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 10,
                    Endurance = 16,
                    Agility = 25,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Swift Strike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Rampage",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 30
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Narcissus",
                Arcana = "Aeon",
                Level = 24,
                Stats = new Stats() {
                    Strength = 13,
                    Magic = 18,
                    Endurance = 11,
                    Agility = 16,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 25
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Anima Freeze",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 30
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kaiwan",
                Arcana = "Star",
                Level = 24,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 23,
                    Endurance = 14,
                    Agility = 15,
                    Luck = 11
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Tetrakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Cell Breaker",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Resist Light",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Life Drain",
                        LevelRequired = 28
                    },
                    new PersonaSkill() {
                        Name = "Spirit Drain",
                        LevelRequired = 29
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hua Po",
                Arcana = "Magician",
                Level = 25,
                Stats = new Stats() {
                    Strength = 14,
                    Magic = 21,
                    Endurance = 15,
                    Agility = 17,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Re Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fire Break",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Makajam",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 30
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Queen Mab",
                Arcana = "Lovers",
                Level = 25,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 19,
                    Endurance = 15,
                    Agility = 17,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 26
                    },
                    new PersonaSkill() {
                        Name = "Dodge Wind",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Resist Confuse",
                        LevelRequired = 30
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ares",
                Arcana = "Chariot",
                Level = 25,
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 15,
                    Endurance = 20,
                    Agility = 15,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Gale Slash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dodge Wind",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Rampage",
                        LevelRequired = 28
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 30
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Titania",
                Arcana = "Empress",
                Level = 26,
                Stats = new Stats() {
                    Strength = 12,
                    Magic = 23,
                    Endurance = 15,
                    Agility = 19,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magaru",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 27
                    },
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 32
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Lamia",
                Arcana = "Hermit",
                Level = 26,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 23,
                    Endurance = 12,
                    Agility = 20,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Nervundi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Boost",
                        LevelRequired = 28
                    },
                    new PersonaSkill() {
                        Name = "Null Poison",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Soul Break",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 32
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Power",
                Arcana = "Justice",
                Level = 27,
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 20,
                    Endurance = 11,
                    Agility = 17,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Power Slash",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Null Confuse",
                        LevelRequired = 33
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Take-Minakata",
                Arcana = "Jester",
                Level = 27,
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 20,
                    Endurance = 22,
                    Agility = 14,
                    Luck = 12
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazio",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Auto-Rakukaja",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Dodge Physical",
                        LevelRequired = 33
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Makami",
                Arcana = "Hanged Man",
                Level = 27,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 21,
                    Endurance = 13,
                    Agility = 22,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sukunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Resist Mute",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Dodge Physical",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Resist Ice",
                        LevelRequired = 33
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Nozuchi",
                Arcana = "Moon",
                Level = 27,
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 13,
                    Endurance = 19,
                    Agility = 15,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enervation",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 29
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Null Poison",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Null Enervate",
                        LevelRequired = 32
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kusi Mitama",
                Arcana = "Strength",
                Level = 28,
                Stats = new Stats() {
                    Strength = 18,
                    Magic = 21,
                    Endurance = 12,
                    Agility = 19,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Soul Break",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Traesto",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Exhaust Boost",
                        LevelRequired = 34
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Incubus",
                Arcana = "Devil",
                Level = 28,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 22,
                    Endurance = 16,
                    Agility = 19,
                    Luck = 17
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Slice",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 30
                    },
                    new PersonaSkill() {
                        Name = "Spirit Drain",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 33
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ganga",
                Arcana = "Priestess",
                Level = 29,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 22,
                    Endurance = 16,
                    Agility = 19,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Slice",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Evade Fire",
                        LevelRequired = 35
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Unicorn",
                Arcana = "Hierophant",
                Level = 29,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 22,
                    Endurance = 19,
                    Agility = 22,
                    Luck = 14
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Nervundi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 31
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 34
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Oni",
                Arcana = "Strength",
                Level = 30,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 12,
                    Endurance = 26,
                    Agility = 18,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Fatal End",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Cruel Attack",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Atom Smasher",
                        LevelRequired = 32
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Endure",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 35
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ose",
                Arcana = "Fool",
                Level = 31,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 12,
                    Endurance = 20,
                    Agility = 25,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Power Slash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Atom Smasher",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Poison Boost",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 36
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mithra",
                Arcana = "Temperance",
                Level = 31,
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 26,
                    Endurance = 21,
                    Agility = 16,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Seal Bomb",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tetra Break",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Dodge Elec",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Null Mute",
                        LevelRequired = 37
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sati",
                Arcana = "Aeon",
                Level = 31,
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 27,
                    Endurance = 20,
                    Agility = 17,
                    Luck = 17
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Energy Shower",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Trafuri",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 36
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Gdon",
                Arcana = "Sun",
                Level = 31,
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 10,
                    Endurance = 23,
                    Agility = 22,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fire Break",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 33
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Evade Ice",
                        LevelRequired = 36
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Pyro Jack",
                Arcana = "Magician",
                Level = 32,
                Stats = new Stats() {
                    Strength = 16,
                    Magic = 26,
                    Endurance = 19,
                    Agility = 22,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Auto-Rakukaja",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Resist Ice",
                        LevelRequired = 38
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Neko Shogun",
                Arcana = "Star",
                Level = 32,
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 20,
                    Endurance = 19,
                    Agility = 23,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Black Spot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Evade Wind",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Divine Grace",
                        LevelRequired = 37
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Undine",
                Arcana = "Lovers",
                Level = 33,
                Stats = new Stats() {
                    Strength = 21,
                    Magic = 27,
                    Endurance = 13,
                    Agility = 26,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Posumudi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 34
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 37
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Virtue",
                Arcana = "Justice",
                Level = 33,
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 29,
                    Endurance = 21,
                    Agility = 19,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Posumudi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fatal End",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Blue Wall",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Resist Dark",
                        LevelRequired = 39
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mothman",
                Arcana = "Hermit",
                Level = 33,
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 23,
                    Endurance = 17,
                    Agility = 28,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Valiant Dance",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Foul Breath",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Elec Break",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Rage Boost",
                        LevelRequired = 38
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Gorgon",
                Arcana = "Empress",
                Level = 34,
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 21,
                    Endurance = 25,
                    Agility = 24,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Crazy Chain",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Null Confuse",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 39
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Setanta",
                Arcana = "Emperor",
                Level = 34,
                Stats = new Stats() {
                    Strength = 23,
                    Magic = 21,
                    Endurance = 25,
                    Agility = 24,
                    Luck = 16
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Fatal End",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sharp Student",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Auto-Maraku",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Null Fire",
                        LevelRequired = 40
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Pale Rider",
                Arcana = "Jester",
                Level = 34,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 24,
                    Endurance = 21,
                    Agility = 24,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Slice",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 35
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 39
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yamata-No-Orochi",
                Arcana = "Moon",
                Level = 34,
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 21,
                    Endurance = 26,
                    Agility = 18,
                    Luck = 15
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Green Wall",
                        LevelRequired = 36
                    },
                    new PersonaSkill() {
                        Name = "Resist Enervate",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 39
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Fortuna",
                Arcana = "Fortune",
                Level = 35,
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 23,
                    Endurance = 22,
                    Agility = 26,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dodge Elec",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Magarula",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Wind Boost",
                        LevelRequired = 40
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Taotie",
                Arcana = "Tower",
                Level = 35,
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 27,
                    Endurance = 30,
                    Agility = 22,
                    Luck = 13
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megido",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Slice",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 37
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Null Enervate",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Torrent Shot",
                        LevelRequired = 41
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Flauros",
                Arcana = "Hierophant",
                Level = 36,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 20,
                    Endurance = 24,
                    Agility = 20,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Fatal End",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Herculean Strike",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Apt Pupil",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Crazy Chain",
                        LevelRequired = 41
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Samael",
                Arcana = "Death",
                Level = 36,
                Stats = new Stats() {
                    Strength = 24,
                    Magic = 29,
                    Endurance = 25,
                    Agility = 19,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Megido",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 41
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Parvati",
                Arcana = "Priestess",
                Level = 37,
                Stats = new Stats() {
                    Strength = 20,
                    Magic = 29,
                    Endurance = 17,
                    Agility = 25,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Nervundi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Dodge Elec",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Divine Grace",
                        LevelRequired = 43
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Raja Naga",
                Arcana = "Aeon",
                Level = 37,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 26,
                    Endurance = 24,
                    Agility = 22,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Fatal End",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 38
                    },
                    new PersonaSkill() {
                        Name = "Torrent Shot",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Null Confuse",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 43
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Pazuzu",
                Arcana = "Devil",
                Level = 37,
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 15,
                    Endurance = 28,
                    Agility = 29,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 39
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Navas Nebula",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Cool Breeze",
                        LevelRequired = 42
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Black Frost",
                Arcana = "Fool",
                Level = 38,
                Stats = new Stats() {
                    Strength = 23,
                    Magic = 31,
                    Endurance = 22,
                    Agility = 23,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Masukunda",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 44
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Dominion",
                Arcana = "Justice",
                Level = 38,
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 32,
                    Endurance = 25,
                    Agility = 24,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 40
                    },
                    new PersonaSkill() {
                        Name = "Resist Exhaust",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Null Dark",
                        LevelRequired = 44
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Dis",
                Arcana = "Magician",
                Level = 39,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 31,
                    Endurance = 24,
                    Agility = 26,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Masukunda",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 44
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Orthrus",
                Arcana = "Hanged Man",
                Level = 39,
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 21,
                    Endurance = 28,
                    Agility = 23,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Black Spot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 41
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Null Ice",
                        LevelRequired = 45
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Genbu",
                Arcana = "Temperance",
                Level = 40,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 27,
                    Endurance = 39,
                    Agility = 12,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Makara Break",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Blue Wall",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Evade Elec",
                        LevelRequired = 46
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Loa",
                Arcana = "Jester",
                Level = 40,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 30,
                    Endurance = 28,
                    Agility = 23,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Life Drain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 42
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Tetraja",
                        LevelRequired = 47
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yatagarasu",
                Arcana = "Sun",
                Level = 40,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 27,
                    Endurance = 22,
                    Agility = 31,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Nervundi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Fear",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Cool Breeze",
                        LevelRequired = 46
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Okuninushi",
                Arcana = "Emperor",
                Level = 41,
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 34,
                    Endurance = 25,
                    Agility = 20,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Blade of Fury",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Apt Pupil",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Null Wind",
                        LevelRequired = 47
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hitokoto-Nushi",
                Arcana = "Hermit",
                Level = 41,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 33,
                    Endurance = 30,
                    Agility = 20,
                    Luck = 19
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Arrow",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Auto-Masuku",
                        LevelRequired = 47
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Alraune",
                Arcana = "Moon",
                Level = 41,
                Stats = new Stats() {
                    Strength = 17,
                    Magic = 35,
                    Endurance = 21,
                    Agility = 29,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Energy Shower",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Green Wall",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Null Enervate",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Enervate Boost",
                        LevelRequired = 46
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Leanan Sidhe",
                Arcana = "Lovers",
                Level = 42,
                Stats = new Stats() {
                    Strength = 19,
                    Magic = 33,
                    Endurance = 26,
                    Agility = 29,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 43
                    },
                    new PersonaSkill() {
                        Name = "Confuse Boost",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Energy Shower",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Divine Grace",
                        LevelRequired = 47
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hanuman",
                Arcana = "Strength",
                Level = 42,
                Stats = new Stats() {
                    Strength = 31,
                    Magic = 25,
                    Endurance = 31,
                    Agility = 21,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mighty Swing",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Blade of Fury",
                        LevelRequired = 44
                    },
                    new PersonaSkill() {
                        Name = "Endure",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 48
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Triglav",
                Arcana = "Chariot",
                Level = 43,
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 23,
                    Endurance = 27,
                    Agility = 32,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Heat Wave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Mustard Bomb",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Null Dizzy",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Blue Wall",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 49
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Fuu-Ki",
                Arcana = "Star",
                Level = 43,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 32,
                    Endurance = 34,
                    Agility = 27,
                    Luck = 18
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Torrent Shot",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Fire",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Apt Pupil",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Wind Boost",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Null Exhaust",
                        LevelRequired = 49
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Gabriel",
                Arcana = "Empress",
                Level = 44,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 34,
                    Endurance = 22,
                    Agility = 30,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Energy Shower",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Survive Dark",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Heat Wave",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Divine Grace",
                        LevelRequired = 50
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Clotho",
                Arcana = "Fortune",
                Level = 44,
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 31,
                    Endurance = 28,
                    Agility = 26,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Magarula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mutudi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Navas Nebula",
                        LevelRequired = 45
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Wind Boost",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Null Enervate",
                        LevelRequired = 50
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kushinada",
                Arcana = "Aeon",
                Level = 44,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 32,
                    Endurance = 27,
                    Agility = 24,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Null Fire",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 50
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Succubus",
                Arcana = "Devil",
                Level = 44,
                Stats = new Stats() {
                    Strength = 22,
                    Magic = 33,
                    Endurance = 28,
                    Agility = 32,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 46
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Spirit Drain",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Resist Light",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 3",
                        LevelRequired = 50
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Thoth",
                Arcana = "Emperor",
                Level = 45,
                Stats = new Stats() {
                    Strength = 28,
                    Magic = 43,
                    Endurance = 23,
                    Agility = 21,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megido",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Null Mute",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 51
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hokuto Seikun",
                Arcana = "Hierophant",
                Level = 45,
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 34,
                    Endurance = 31,
                    Agility = 26,
                    Luck = 22
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Zionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Navas Nebula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Blade of Fury",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Resist Exhaust",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 51
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Decarabia",
                Arcana = "Fool",
                Level = 46,
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 36,
                    Endurance = 25,
                    Agility = 26,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Weak,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tetrakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Physical",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 52
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mot",
                Arcana = "Death",
                Level = 46,
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 38,
                    Endurance = 30,
                    Agility = 24,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Survive Light",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 50
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Cu Chulainn",
                Arcana = "Tower",
                Level = 46,
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 32,
                    Endurance = 28,
                    Agility = 25,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Magarula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 47
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "White Wall",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Endure Dark",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 53
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Rangda",
                Arcana = "Magician",
                Level = 47,
                Stats = new Stats() {
                    Strength = 24,
                    Magic = 37,
                    Endurance = 30,
                    Agility = 25,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Dodge Ice",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Mustard Bomb",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Repel Physical",
                        LevelRequired = 55
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Baphomet",
                Arcana = "Jester",
                Level = 47,
                Stats = new Stats() {
                    Strength = 25,
                    Magic = 35,
                    Endurance = 35,
                    Agility = 26,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Dodge Physical",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 53
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Seiryu",
                Arcana = "Temperance",
                Level = 47,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 31,
                    Endurance = 33,
                    Agility = 28,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mazionga",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Elec Break",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Elec Boost",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Resist Exhaust",
                        LevelRequired = 53
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Narasimha",
                Arcana = "Sun",
                Level = 47,
                Stats = new Stats() {
                    Strength = 29,
                    Magic = 27,
                    Endurance = 30,
                    Agility = 35,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tempest Slash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Counterstrike",
                        LevelRequired = 48
                    },
                    new PersonaSkill() {
                        Name = "Evade Wind",
                        LevelRequired = 49
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Auto-Mataru",
                        LevelRequired = 53
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kikuri-Hime",
                Arcana = "Priestess",
                Level = 48,
                Stats = new Stats() {
                    Strength = 26,
                    Magic = 36,
                    Endurance = 28,
                    Agility = 31,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Posumudi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agilao",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Resist Dark",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Divine Grace",
                        LevelRequired = 54
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kurama Tengu",
                Arcana = "Hermit",
                Level = 48,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 34,
                    Endurance = 28,
                    Agility = 38,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Wind Boost",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Resist Elec",
                        LevelRequired = 53
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Girimehkala",
                Arcana = "Moon",
                Level = 48,
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 35,
                    Endurance = 23,
                    Agility = 30,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mighty Swing",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 50
                    },
                    new PersonaSkill() {
                        Name = "Blight",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Tetraja",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Endure Light",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Repel Physical",
                        LevelRequired = 56
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Throne",
                Arcana = "Justice",
                Level = 49,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 30,
                    Endurance = 24,
                    Agility = 37,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Resist Dark",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Endure Dark",
                        LevelRequired = 55
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yatsufusa",
                Arcana = "Hanged Man",
                Level = 49,
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 33,
                    Endurance = 27,
                    Agility = 36,
                    Luck = 26
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Heat Wave",
                        LevelRequired = 51
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Dodge Physical",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 55
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kali",
                Arcana = "Strength",
                Level = 50,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 25,
                    Endurance = 36,
                    Agility = 35,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Revolution",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 55
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ganesha",
                Arcana = "Star",
                Level = 50,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 29,
                    Endurance = 31,
                    Agility = 27,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mustard Bomb",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Endure",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 56
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Pabilsag",
                Arcana = "Emperor",
                Level = 51,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 29,
                    Endurance = 30,
                    Agility = 33,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Blight",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Silence Boost",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Arrow Rain",
                        LevelRequired = 56
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Quetzalcoatl",
                Arcana = "Aeon",
                Level = 51,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 31,
                    Endurance = 31,
                    Agility = 35,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Magarula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 52
                    },
                    new PersonaSkill() {
                        Name = "Heat Wave",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 57
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Lachesis",
                Arcana = "Fortune",
                Level = 51,
                Stats = new Stats() {
                    Strength = 31,
                    Magic = 39,
                    Endurance = 25,
                    Agility = 34,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Makara Break",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Absorb Wind",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Red Wall",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Resist Exhaust",
                        LevelRequired = 57
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Skadi",
                Arcana = "Empress",
                Level = 52,
                Stats = new Stats() {
                    Strength = 27,
                    Magic = 37,
                    Endurance = 32,
                    Agility = 36,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Aeon Rain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Repel Ice",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Repel Fire",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 60
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Cerberus",
                Arcana = "Hierophant",
                Level = 52,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 30,
                    Endurance = 32,
                    Agility = 35,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Gigantic Fist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 53
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 58
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Raphael",
                Arcana = "Lovers",
                Level = 53,
                Stats = new Stats() {
                    Strength = 32,
                    Magic = 38,
                    Endurance = 24,
                    Agility = 33,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Null Dizzy",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 59
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Lilith",
                Arcana = "Devil",
                Level = 53,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 43,
                    Endurance = 30,
                    Agility = 36,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Elec Break",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 57
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Tam Lin",
                Arcana = "Sun",
                Level = 53,
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 31,
                    Endurance = 34,
                    Agility = 39,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Maraku",
                        LevelRequired = 54
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Evade Physical",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 59
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kin-Ki",
                Arcana = "Chariot",
                Level = 54,
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 25,
                    Endurance = 53,
                    Agility = 23,
                    Luck = 27
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Vile Assault",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Gigantic Fist",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Seal Bomb",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Revolution",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 60
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Suzaku",
                Arcana = "Temperance",
                Level = 54,
                Stats = new Stats() {
                    Strength = 30,
                    Magic = 36,
                    Endurance = 31,
                    Agility = 42,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Energy Shower",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 55
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Resist Ice",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Auto-Masuku",
                        LevelRequired = 60
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Nidhoggr",
                Arcana = "Hermit",
                Level = 55,
                Stats = new Stats() {
                    Strength = 23,
                    Magic = 41,
                    Endurance = 35,
                    Agility = 31,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ghastly Wail",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Ice Boost",
                        LevelRequired = 61
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kumbhanda",
                Arcana = "Jester",
                Level = 55,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 36,
                    Endurance = 35,
                    Agility = 44,
                    Luck = 20
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Masuku",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Alertness",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Resist Elec",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Tetraja",
                        LevelRequired = 61
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Abaddon",
                Arcana = "Tower",
                Level = 55,
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 27,
                    Endurance = 50,
                    Agility = 23,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Arrow Rain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 56
                    },
                    new PersonaSkill() {
                        Name = "Endure Light",
                        LevelRequired = 57
                    },
                    new PersonaSkill() {
                        Name = "Tetra Break",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Null Physical",
                        LevelRequired = 62
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Shiki-Ouji",
                Arcana = "Fool",
                Level = 56,
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 29,
                    Endurance = 31,
                    Agility = 41,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Navas Nebula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Revolution",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Apt Pupil",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Null Physical",
                        LevelRequired = 62
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Taowu",
                Arcana = "Hanged Man",
                Level = 56,
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 37,
                    Endurance = 31,
                    Agility = 38,
                    Luck = 29
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Aeon Rain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Enervate",
                        LevelRequired = 58
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Evade Physical",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Absorb Fire",
                        LevelRequired = 62
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Garuda",
                Arcana = "Star",
                Level = 57,
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 33,
                    Endurance = 28,
                    Agility = 47,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Arrow Rain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Repel Wind",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 63
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sui-Ki",
                Arcana = "Moon",
                Level = 57,
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 49,
                    Endurance = 43,
                    Agility = 33,
                    Luck = 17
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 2",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Tetra Break",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 62
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Uriel",
                Arcana = "Justice",
                Level = 58,
                Stats = new Stats() {
                    Strength = 35,
                    Magic = 42,
                    Endurance = 37,
                    Agility = 36,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Endure Dark",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Null Dark",
                        LevelRequired = 64
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ananta",
                Arcana = "Fortune",
                Level = 58,
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 42,
                    Endurance = 45,
                    Agility = 28,
                    Luck = 23
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufula",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "White Wall",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Green Wall",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 3",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Null Exhaust",
                        LevelRequired = 64
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kingu",
                Arcana = "Aeon",
                Level = 58,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 44,
                    Endurance = 38,
                    Agility = 30,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Resistant,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Fire",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Masuku",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Confuse",
                        LevelRequired = 59
                    },
                    new PersonaSkill() {
                        Name = "Null Poison",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Endure",
                        LevelRequired = 63
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "White Rider",
                Arcana = "Death",
                Level = 58,
                Stats = new Stats() {
                    Strength = 49,
                    Magic = 31,
                    Endurance = 37,
                    Agility = 40,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Evade Ice",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 67
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hariti",
                Arcana = "Priestess",
                Level = 59,
                Stats = new Stats() {
                    Strength = 31,
                    Magic = 47,
                    Endurance = 33,
                    Agility = 34,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Arrow Rain",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 64
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Anubis",
                Arcana = "Judgement",
                Level = 59,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 41,
                    Endurance = 37,
                    Agility = 37,
                    Luck = 31
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Arrow",
                        LevelRequired = 60
                    },
                    new PersonaSkill() {
                        Name = "Mustard Bomb",
                        LevelRequired = 61
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 65
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mother Harlot",
                Arcana = "Empress",
                Level = 60,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 47,
                    Endurance = 37,
                    Agility = 29,
                    Luck = 36
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 65
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Daisoujou",
                Arcana = "Hierophant",
                Level = 60,
                Stats = new Stats() {
                    Strength = 34,
                    Magic = 45,
                    Endurance = 40,
                    Agility = 30,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Endure Dark",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Samsara",
                        LevelRequired = 67
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Belphegor",
                Arcana = "Devil",
                Level = 61,
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 48,
                    Endurance = 42,
                    Agility = 39,
                    Luck = 21
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evil Smile",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakunda",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Fear Boost",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Enervate Boost",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 67
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Jatayu",
                Arcana = "Sun",
                Level = 61,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 44,
                    Endurance = 35,
                    Agility = 48,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Confuse",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 62
                    },
                    new PersonaSkill() {
                        Name = "Growth 3",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Repel Elec",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 66
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Jinn",
                Arcana = "Magician",
                Level = 62,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 51,
                    Endurance = 38,
                    Agility = 39,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Resist Physical",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Null Physical",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Valiant Dance",
                        LevelRequired = 68
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Chernobog",
                Arcana = "Jester",
                Level = 62,
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 47,
                    Endurance = 32,
                    Agility = 35,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rainy Death",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tetra Break",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Resist Wind",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 3",
                        LevelRequired = 69
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Byakko",
                Arcana = "Temperance",
                Level = 62,
                Stats = new Stats() {
                    Strength = 47,
                    Magic = 32,
                    Endurance = 35,
                    Agility = 49,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Sukukaja",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 68
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mara",
                Arcana = "Tower",
                Level = 62,
                Stats = new Stats() {
                    Strength = 44,
                    Magic = 35,
                    Endurance = 48,
                    Agility = 36,
                    Luck = 30
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Blight",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 63
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 64
                    },
                    new PersonaSkill() {
                        Name = "Absorb Physical",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 67
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Nebiros",
                Arcana = "Hermit",
                Level = 63,
                Stats = new Stats() {
                    Strength = 38,
                    Magic = 47,
                    Endurance = 39,
                    Agility = 40,
                    Luck = 32
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Null Light",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 70
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Siegfried",
                Arcana = "Strength",
                Level = 63,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 36,
                    Endurance = 41,
                    Agility = 38,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Akasha Arts",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 65
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Rainy Death",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 70
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Loki",
                Arcana = "Fool",
                Level = 64,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 50,
                    Endurance = 31,
                    Agility = 47,
                    Luck = 23
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Sharp Student",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Null Fire",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Niflheim",
                        LevelRequired = 70
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Cybele",
                Arcana = "Lovers",
                Level = 64,
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 47,
                    Endurance = 37,
                    Agility = 39,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarama",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Recarm",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 70
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Barong",
                Arcana = "Emperor",
                Level = 65,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 44,
                    Endurance = 40,
                    Agility = 36,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Poison Mist",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Me Patra",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 2",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 72
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Lakshmi",
                Arcana = "Aeon",
                Level = 65,
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 50,
                    Endurance = 37,
                    Agility = 38,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Break",
                        LevelRequired = 66
                    },
                    new PersonaSkill() {
                        Name = "Null Dark",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Resist Fire",
                        LevelRequired = 70
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 71
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Thor",
                Arcana = "Chariot",
                Level = 65,
                Stats = new Stats() {
                    Strength = 43,
                    Magic = 39,
                    Endurance = 53,
                    Agility = 32,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Null Physical",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Thunder Reign",
                        LevelRequired = 70
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Atropos",
                Arcana = "Fortune",
                Level = 65,
                Stats = new Stats() {
                    Strength = 36,
                    Magic = 48,
                    Endurance = 36,
                    Agility = 37,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Wind Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 67
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Evade Fire",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 70
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Melchizedek",
                Arcana = "Justice",
                Level = 66,
                Stats = new Stats() {
                    Strength = 51,
                    Magic = 46,
                    Endurance = 46,
                    Agility = 34,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Akasha Arts",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 72
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hell Biker",
                Arcana = "Hanged Man",
                Level = 66,
                Stats = new Stats() {
                    Strength = 49,
                    Magic = 40,
                    Endurance = 40,
                    Agility = 48,
                    Luck = 28
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Aeon Rain",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Endure",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 70
                    },
                    new PersonaSkill() {
                        Name = "Absorb Fire",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 73
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kartikeya",
                Arcana = "Star",
                Level = 67,
                Stats = new Stats() {
                    Strength = 47,
                    Magic = 39,
                    Endurance = 40,
                    Agility = 44,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Mataru",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 70
                    },
                    new PersonaSkill() {
                        Name = "Primal Force",
                        LevelRequired = 75
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Trumpeter",
                Arcana = "Judgement",
                Level = 67,
                Stats = new Stats() {
                    Strength = 40,
                    Magic = 47,
                    Endurance = 39,
                    Agility = 45,
                    Luck = 37
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 68
                    },
                    new PersonaSkill() {
                        Name = "Cool Breeze",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 70
                    },
                    new PersonaSkill() {
                        Name = "Debilitate",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Heat Riser",
                        LevelRequired = 74
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Belial",
                Arcana = "Devil",
                Level = 68,
                Stats = new Stats() {
                    Strength = 51,
                    Magic = 31,
                    Endurance = 48,
                    Agility = 40,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Endure Light",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 73
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Seth",
                Arcana = "Moon",
                Level = 68,
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 51,
                    Endurance = 40,
                    Agility = 39,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Wind Break",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Null Light",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Evade Elec",
                        LevelRequired = 74
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Seiten Taisei",
                Arcana = "Jester",
                Level = 68,
                Stats = new Stats() {
                    Strength = 47,
                    Magic = 34,
                    Endurance = 40,
                    Agility = 48,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Brave Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Rebellion",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Elec",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 69
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Vorpal Blade",
                        LevelRequired = 76
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Horus",
                Arcana = "Sun",
                Level = 68,
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 48,
                    Endurance = 35,
                    Agility = 45,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 70
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Absorb Wind",
                        LevelRequired = 73
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Surt",
                Arcana = "Magician",
                Level = 69,
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 54,
                    Endurance = 39,
                    Agility = 40,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Deathbound",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Ragnarok",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Null Ice",
                        LevelRequired = 76
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Yurlungur",
                Arcana = "Temperance",
                Level = 69,
                Stats = new Stats() {
                    Strength = 41,
                    Magic = 50,
                    Endurance = 45,
                    Agility = 43,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Virus Wave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Growth 3",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Repel Light",
                        LevelRequired = 75
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Masakado",
                Arcana = "Tower",
                Level = 69,
                Stats = new Stats() {
                    Strength = 51,
                    Magic = 32,
                    Endurance = 45,
                    Agility = 46,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tempest Slash",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 76
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Tzitzimitl",
                Arcana = "Priestess",
                Level = 70,
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 56,
                    Endurance = 41,
                    Agility = 39,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Virus Wave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mustard Bomb",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Silence Boost",
                        LevelRequired = 71
                    },
                    new PersonaSkill() {
                        Name = "Dekaja",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Repel Elec",
                        LevelRequired = 77
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Alilat",
                Arcana = "Empress",
                Level = 70,
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 48,
                    Endurance = 49,
                    Agility = 39,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Evade Physical",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Growth 2",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Auto-Maraku",
                        LevelRequired = 75
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Hachiman",
                Arcana = "Hierophant",
                Level = 70,
                Stats = new Stats() {
                    Strength = 33,
                    Magic = 60,
                    Endurance = 39,
                    Agility = 38,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makarakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Elec Break",
                        LevelRequired = 72
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Revolution",
                        LevelRequired = 75
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Ishtar",
                Arcana = "Lovers",
                Level = 71,
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 44,
                    Endurance = 33,
                    Agility = 48,
                    Luck = 49
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mutudi",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Absorb Wind",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Salvation",
                        LevelRequired = 78
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Vasuki",
                Arcana = "Hanged Man",
                Level = 71,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 47,
                    Endurance = 50,
                    Agility = 340,
                    Luck = 35
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Virus Wave",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Poison",
                        LevelRequired = 73
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Evade Wind",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 77
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Atavaka",
                Arcana = "Chariot",
                Level = 72,
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 41,
                    Endurance = 43,
                    Agility = 41,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Brave Blade",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 79
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Norn",
                Arcana = "Fortune",
                Level = 72,
                Stats = new Stats() {
                    Strength = 42,
                    Magic = 53,
                    Endurance = 31,
                    Agility = 48,
                    Luck = 46
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Diarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Masuku",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 3",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Insta-Heal",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Debilitate",
                        LevelRequired = 79
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Alice",
                Arcana = "Death",
                Level = 72,
                Stats = new Stats() {
                    Strength = 39,
                    Magic = 56,
                    Endurance = 33,
                    Agility = 45,
                    Luck = 44
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Dekunda",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Endure Light",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Die for Me!",
                        LevelRequired = 79
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Michael",
                Arcana = "Judgement",
                Level = 72,
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 42,
                    Endurance = 43,
                    Agility = 48,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Vorpal Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megidola",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Repel Dark",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Heaven's Blade",
                        LevelRequired = 79
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Arahabaki",
                Arcana = "Hermit",
                Level = 73,
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 55,
                    Endurance = 62,
                    Agility = 37,
                    Luck = 25
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Reflect,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Vicious Strike",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Auto-Maraku",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Null Fear",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Alertness",
                        LevelRequired = 74
                    },
                    new PersonaSkill() {
                        Name = "Tetrakarn",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Repel Physical",
                        LevelRequired = 80
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Vishnu",
                Arcana = "Temperance",
                Level = 73,
                Stats = new Stats() {
                    Strength = 46,
                    Magic = 52,
                    Endurance = 34,
                    Agility = 54,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Akasha Arts",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Angelic Grace",
                        LevelRequired = 79
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Odin",
                Arcana = "Emperor",
                Level = 74,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 60,
                    Endurance = 42,
                    Agility = 39,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Panta Rhei",
                        LevelRequired = 81
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Kaguya",
                Arcana = "Aeon",
                Level = 74,
                Stats = new Stats() {
                    Strength = 37,
                    Magic = 65,
                    Endurance = 36,
                    Agility = 44,
                    Luck = 47
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Hamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fast Heal",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tetraja",
                        LevelRequired = 75
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 80
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sraosha",
                Arcana = "Justice",
                Level = 74,
                Stats = new Stats() {
                    Strength = 57,
                    Magic = 36,
                    Endurance = 44,
                    Agility = 62,
                    Luck = 33
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Absorb,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Brave Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 76
                    },
                    new PersonaSkill() {
                        Name = "Hama Boost",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Angelic Grace",
                        LevelRequired = 81
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Yoshitsune",
                Arcana = "Tower",
                Level = 75,
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 39,
                    Endurance = 49,
                    Agility = 61,
                    Luck = 34
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Brave Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Heat Riser",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Repel Elec",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Hassou Tobi",
                        LevelRequired = 83
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Saturnus",
                Arcana = "Star",
                Level = 75,
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 57,
                    Endurance = 36,
                    Agility = 43,
                    Luck = 49
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Ice",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Growth 3",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 81
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Kohryu",
                Arcana = "Hierophant",
                Level = 76,
                Stats = new Stats() {
                    Strength = 50,
                    Magic = 53,
                    Endurance = 54,
                    Agility = 40,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Salvation",
                        LevelRequired = 83
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Satan",
                Arcana = "Judgement",
                Level = 76,
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 60,
                    Endurance = 47,
                    Agility = 40,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Regenerate 3",
                        LevelRequired = 77
                    },
                    new PersonaSkill() {
                        Name = "Invigorate 3",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Endure Light",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Black Viper",
                        LevelRequired = 81
                    },
                    new PersonaSkill() {
                        Name = "Null Wind",
                        LevelRequired = 82
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Baal Zebul",
                Arcana = "Moon",
                Level = 77,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 60,
                    Endurance = 49,
                    Agility = 40,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 82
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Suparna",
                Arcana = "Sun",
                Level = 77,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 52,
                    Endurance = 45,
                    Agility = 55,
                    Luck = 38
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Makajam",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Evade Ice",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 81
                    },
                    new PersonaSkill() {
                        Name = "Evade Fire",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 83
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Mada",
                Arcana = "Magician",
                Level = 78,
                Stats = new Stats() {
                    Strength = 45,
                    Magic = 63,
                    Endurance = 52,
                    Agility = 38,
                    Luck = 43
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Weak,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Fire Boost",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 81
                    },
                    new PersonaSkill() {
                        Name = "Evade Ice",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 84
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Mahakala",
                Arcana = "Death",
                Level = 78,
                Stats = new Stats() {
                    Strength = 58,
                    Magic = 38,
                    Endurance = 57,
                    Agility = 49,
                    Luck = 39
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Myriad Arrows",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 85
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Scathach",
                Arcana = "Priestess",
                Level = 79,
                Stats = new Stats() {
                    Strength = 54,
                    Magic = 59,
                    Endurance = 37,
                    Agility = 49,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Weak,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 81
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 85
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Isis",
                Arcana = "Empress",
                Level = 79,
                Stats = new Stats() {
                    Strength = 52,
                    Magic = 48,
                    Endurance = 42,
                    Agility = 48,
                    Luck = 54
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Reflect,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tetrakarn",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Cool Breeze",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Absorb Ice",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Salvation",
                        LevelRequired = 85
                    },
                    new PersonaSkill() {
                        Name = "Null Elec",
                        LevelRequired = 86
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Futsunushi",
                Arcana = "Chariot",
                Level = 80,
                Stats = new Stats() {
                    Strength = 59,
                    Magic = 38,
                    Endurance = 61,
                    Agility = 44,
                    Luck = 45
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Null,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Primal Force",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Matarukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Apt Pupil",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Null Dizzy",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Ali Dance",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 85
                    },
                    new PersonaSkill() {
                        Name = "Firm Stance",
                        LevelRequired = 86
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Shiva",
                Arcana = "Tower",
                Level = 80,
                Stats = new Stats() {
                    Strength = 59,
                    Magic = 48,
                    Endurance = 44,
                    Agility = 54,
                    Luck = 42
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Absorb,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Magarudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 82
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 83
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Pralaya",
                        LevelRequired = 87
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Beelzebub",
                Arcana = "Devil",
                Level = 81,
                Stats = new Stats() {
                    Strength = 48,
                    Magic = 60,
                    Endurance = 49,
                    Agility = 40,
                    Luck = 41
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Absorb,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Reflect,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Reflect,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mabufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Old One",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Tentarafoo",
                        LevelRequired = 78
                    },
                    new PersonaSkill() {
                        Name = "Maziodyne",
                        LevelRequired = 79
                    },
                    new PersonaSkill() {
                        Name = "Mudo Boost",
                        LevelRequired = 80
                    },
                    new PersonaSkill() {
                        Name = "Stagnant Air",
                        LevelRequired = 82
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Ongyo-Ki",
                Arcana = "Hermit",
                Level = 82,
                Stats = new Stats() {
                    Strength = 59,
                    Magic = 64,
                    Endurance = 59,
                    Agility = 47,
                    Luck = 24
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.Absorb,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Foolish Whisper",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Masukukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ailment Boost",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 85
                    },
                    new PersonaSkill() {
                        Name = "Revolution",
                        LevelRequired = 86
                    },
                    new PersonaSkill() {
                        Name = "Firm Stance",
                        LevelRequired = 87
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Attis",
                Arcana = "Hanged Man",
                Level = 82,
                Stats = new Stats() {
                    Strength = 51,
                    Magic = 56,
                    Endurance = 56,
                    Agility = 50,
                    Luck = 40
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Reflect,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 84
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 86
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 87
                    },
                    new PersonaSkill() {
                        Name = "Mamudoon",
                        LevelRequired = 88
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Metatron",
                Arcana = "Judgement",
                Level = 83,
                Stats = new Stats() {
                    Strength = 54,
                    Magic = 55,
                    Endurance = 53,
                    Agility = 46,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Heaven's Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 86
                    },
                    new PersonaSkill() {
                        Name = "Repel Ice",
                        LevelRequired = 87
                    },
                    new PersonaSkill() {
                        Name = "Repel Elec",
                        LevelRequired = 88
                    },
                    new PersonaSkill() {
                        Name = "Repel Fire",
                        LevelRequired = 89
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Sandalphon",
                Arcana = "Moon",
                Level = 84,
                Stats = new Stats() {
                    Strength = 56,
                    Magic = 61,
                    Endurance = 46,
                    Agility = 47,
                    Luck = 49
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Null,
                    Light = ElementAffinity.Reflect,
                    Darkness = ElementAffinity.Weak,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Samarecarm",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Amrita",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Angelic Grace",
                        LevelRequired = 87
                    },
                    new PersonaSkill() {
                        Name = "Agneyastra",
                        LevelRequired = 88
                    },
                    new PersonaSkill() {
                        Name = "Endure Dark",
                        LevelRequired = 89
                    },
                    new PersonaSkill() {
                        Name = "Repel Dark",
                        LevelRequired = 90
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Asura",
                Arcana = "Sun",
                Level = 86,
                Stats = new Stats() {
                    Strength = 59,
                    Magic = 57,
                    Endurance = 51,
                    Agility = 50,
                    Luck = 48
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Primal Force",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Marakukaja",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mahamaon",
                        LevelRequired = 88
                    },
                    new PersonaSkill() {
                        Name = "High Counter",
                        LevelRequired = 89
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 90
                    },
                    new PersonaSkill() {
                        Name = "Unshaken Will",
                        LevelRequired = 92
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Helel",
                Arcana = "Star",
                Level = 87,
                Stats = new Stats() {
                    Strength = 56,
                    Magic = 57,
                    Endurance = 56,
                    Agility = 49,
                    Luck = 50
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Null,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.Weak,
                    Light = ElementAffinity.Null,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Salvation",
                        LevelRequired = 88
                    },
                    new PersonaSkill() {
                        Name = "Insta-Heal",
                        LevelRequired = 90
                    },
                    new PersonaSkill() {
                        Name = "Repel Wind",
                        LevelRequired = 91
                    },
                    new PersonaSkill() {
                        Name = "Arms Master",
                        LevelRequired = 92
                    },
                    new PersonaSkill() {
                        Name = "Morning Star",
                        LevelRequired = 94
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Zaou Gongen",
                Arcana = "Strength",
                Level = 90,
                Stats = new Stats() {
                    Strength = 61,
                    Magic = 48,
                    Endurance = 71,
                    Agility = 47,
                    Luck = 50
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.None,
                    Fire = ElementAffinity.Reflect,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.Weak,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Maragidyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Power Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Anima Freeze",
                        LevelRequired = 92
                    },
                    new PersonaSkill() {
                        Name = "Evade Physical",
                        LevelRequired = 93
                    },
                    new PersonaSkill() {
                        Name = "Enduring Soul",
                        LevelRequired = 94
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 95
                    },
                    new PersonaSkill() {
                        Name = "Vorpal Blade",
                        LevelRequired = 96
                    }
                },
                Ultimate = true,
                NewGame = false,
            },
            new Persona() {
                Name = "Ardha",
                Arcana = "Judgement",
                Level = 90,
                Stats = new Stats() {
                    Strength = 62,
                    Magic = 52,
                    Endurance = 64,
                    Agility = 41,
                    Luck = 58
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.Null,
                    Electricity = ElementAffinity.Null,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Primal Force",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "God's Hand",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 91
                    },
                    new PersonaSkill() {
                        Name = "Null Dizzy",
                        LevelRequired = 92
                    },
                    new PersonaSkill() {
                        Name = "Auto-Rakukaja",
                        LevelRequired = 93
                    },
                    new PersonaSkill() {
                        Name = "Mediarahan",
                        LevelRequired = 94
                    },
                    new PersonaSkill() {
                        Name = "Angelic Grace",
                        LevelRequired = 95
                    },
                    new PersonaSkill() {
                        Name = "Null Physical",
                        LevelRequired = 96
                    }
                },
                Ultimate = false,
                NewGame = false,
            },
            new Persona() {
                Name = "Izanagi-No-Okami",
                Arcana = "World",
                Level = 91,
                Stats = new Stats() {
                    Strength = 80,
                    Magic = 80,
                    Endurance = 80,
                    Agility = 80,
                    Luck = 80
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.Resistant,
                    Ice = ElementAffinity.Resistant,
                    Electricity = ElementAffinity.Resistant,
                    Wind = ElementAffinity.Resistant,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Megidolaon",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Victory Cry",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Angelic Grace",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Agidyne",
                        LevelRequired = 92
                    },
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 93
                    },
                    new PersonaSkill() {
                        Name = "Ziodyne",
                        LevelRequired = 94
                    },
                    new PersonaSkill() {
                        Name = "Garudyne",
                        LevelRequired = 95
                    },
                    new PersonaSkill() {
                        Name = "Fire Amp",
                        LevelRequired = 96
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 97
                    },
                    new PersonaSkill() {
                        Name = "Elec Amp",
                        LevelRequired = 98
                    },
                    new PersonaSkill() {
                        Name = "Wind Amp",
                        LevelRequired = 99
                    }
                },
                Ultimate = false,
                NewGame = true,
            },
            new Persona() {
                Name = "Lucifer",
                Arcana = "Judgement",
                Level = 93,
                Stats = new Stats() {
                    Strength = 62,
                    Magic = 69,
                    Endurance = 61,
                    Agility = 52,
                    Luck = 51
                },
                Elements = new Elements() {
                    Physical = ElementAffinity.Resistant,
                    Fire = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.Weak,
                    Darkness = ElementAffinity.Null,
                },
                Skills = new List<PersonaSkill>() {
                    new PersonaSkill() {
                        Name = "Bufudyne",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Brave Blade",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Mind Charge",
                        LevelRequired = 0
                    },
                    new PersonaSkill() {
                        Name = "Ice Amp",
                        LevelRequired = 94
                    },
                    new PersonaSkill() {
                        Name = "Spell Master",
                        LevelRequired = 95
                    },
                    new PersonaSkill() {
                        Name = "Repel Light",
                        LevelRequired = 96
                    },
                    new PersonaSkill() {
                        Name = "Absorb Elec",
                        LevelRequired = 98
                    },
                    new PersonaSkill() {
                        Name = "Victory Cry",
                        LevelRequired = 99
                    }
                },
                Ultimate = true,
                NewGame = false,
            }
        };
    }
}
