using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    /// <summary>The persona skills data.</summary>
    public static class SkillData
    {
        /// <summary>The persona skills data.</summary>
        public static List<Skill> Skills { get; set; } = new List<Skill>
        {
            new Skill() {
                Name = "Absorb Elec",
                Effect = "Absorbs damage from Elec attacks. (Overwrites Resist/Null/Repel Elec)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 98,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Absorb Fire",
                Effect = "Absorbs damage from Fire attacks. (Overwrites Resist/Null/Repel Fire)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Absorb Ice",
                Effect = "Absorbs damage from Ice attacks. (Overwrites Resist/Null/Repel Ice)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Absorb Physical",
                Effect = "Absorbs damage from Phys attacks. (Overwrites Resist/Null/Repel Phys)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Absorb Wind",
                Effect = "Absorbs damage from Wind attacks. (Overwrites Resist/Null/Repel Wind)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 77,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Aeon Rain",
                Effect = "Deals medium Phys damage to all foes 1x to 3x.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Agi",
                Effect = "Deals light Fire damage to 1 foe.",
                Cost = "4 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Agidyne",
                Effect = "Deals heavy Fire damage to 1 foe.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 92,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Agilao",
                Effect = "Deals medium Fire damage to 1 foe.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Agneyastra",
                Effect = "Deals heavy Phys damage to all foes 1x to 3x.",
                Cost = "24% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 88,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ailment Boost",
                Effect = "All status ailment attacks are 1.5 times more effective.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Akasha Arts",
                Effect = "Deals heavy Phys damage to all foes 1x to 2x.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Alertness",
                Effect = "Lowers odds of being taken by surprise. (Decreases enemy advantage)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ali Dance",
                Effect = "The Hit rate of an attacking unit is reduced by half.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Amrita",
                Effect = "Cures all ailments except Down and Death (party).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 75,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 81,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Angelic Grace",
                Effect = "Doubles evasion rate against all attacks but Light/Darkness/Almighty.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = true
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 79,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 81,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 87,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 95,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Anima Freeze",
                Effect = "Exhausts to all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 92,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Apt Pupil",
                Effect = "Increases user's Critical Rate.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Arm Chopper",
                Effect = "Deals light Phys damage to 1 foe with a chance of Fear.",
                Cost = "9% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Arms Master",
                Effect = "Halves HP cost for physical skills.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 85,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 92,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Arrow Rain",
                Effect = "Deals heavy Phys damage to all foes 2x.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Assault Dive",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "10% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Atom Smasher",
                Effect = "Deals medium Phys damage to all foes 1x to 2x with a chance of Fear.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Maraku",
                Effect = "Party begins the battle with Marakukaja. (Overwrites Auto-Rakukaja)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Masuku",
                Effect = "Party begins the battle with Masukukaja. (Overwrites Auto-Sukukaja)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 74,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Mataru",
                Effect = "Party begins the battle with Matarukaja. (Overwrites Auto-Tarukaja)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Rakukaja",
                Effect = "Automatic Rakukaja at the start of battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 93,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Sukukaja",
                Effect = "Automatic Sukukaja at the start of battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Auto-Tarukaja",
                Effect = "Automatic Tarukaja at the start of battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Balzac",
                Effect = "Enrages 1 foe (40% chance). (Doubles STR, uncontrollable, auto attacks with weapon)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Bash",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "6% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Black Spot",
                Effect = "Deals medium Phys damage to 1 foe.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Black Viper",
                Effect = "Deals massive Almighty damage to 1 foe.",
                Cost = "64 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 81,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Blade of Fury",
                Effect = "Deals medium Phys damage to all foes 2x to 4x.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Blight",
                Effect = "Deals heavy Phys damage to all foes with a chance of Poison.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Blue Wall",
                Effect = "Add Elec resistance to 1 ally (for 3 turns).",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Brain Shake",
                Effect = "Deals light Phys damage to 1 foe 1x to 3x with a chance of Exhaustion.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Brave Blade",
                Effect = "Deals severe Phys damage to 1 foe.",
                Cost = "20% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Bufu",
                Effect = "Deals light Ice damage to 1 foe.",
                Cost = "4 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Apsaras",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Bufudyne",
                Effect = "Deals heavy Ice damage to 1 foe.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 93,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Bufula",
                Effect = "Deals medium Ice damage to 1 foe.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jack Frost",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Cell Breaker",
                Effect = "Deals light Phys damage to 1 foe with a chance of Enervation.",
                Cost = "10% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Cleave",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "5% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Confuse Boost",
                Effect = "Increases odds of inflicting Confusion (1.5x).",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 5,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Cool Breeze",
                Effect = "Recover 8% HP and SP after a successful battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Counter",
                Effect = "10% chance of reflecting Phys attacks. Does not stack.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Counterstrike",
                Effect = "15% chance of reflecting Phys attacks. Does not stack.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Crazy Chain",
                Effect = "Deals medium Phys damage to all foes with a chance of Rage.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Cruel Attack",
                Effect = "Medium Phys dmg, 1 foe. Bonus damage to foes that are knocked down.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Deathbound",
                Effect = "Deals heavy Phys damage to all foes.",
                Cost = "20% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Debilitate",
                Effect = "Decreases 1 foe's Attack, Defense, and Hit/Evasion rates for 3 turns.",
                Cost = "30 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 79,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dekaja",
                Effect = "Nullifies stat bonuses on all foes. (Offsets the effects of all enemies' '-kaja' magic.)",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dekunda",
                Effect = "Nullifies stat penalties on party. (Offsets the effects of '-nda' magic for all allies.)",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dia",
                Effect = "Slightly restores 1 ally's HP.",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Pixie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Apsaras",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Diarahan",
                Effect = "Fully restores 1 ally's HP.",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Diarama",
                Effect = "Moderately restores 1 ally's HP.",
                Cost = "6 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Die for Me!",
                Effect = "Darkness: very high chance of instant kill, all foes. (60% chance)",
                Cost = "44 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Divine Grace",
                Effect = "Effects of healing magic are increased by 50%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dodge Elec",
                Effect = "Doubles evasion rate against Elec attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dodge Fire",
                Effect = "Doubles evasion rate against Fire attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jack Frost",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dodge Ice",
                Effect = "Doubles evasion rate against Ice attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dodge Physical",
                Effect = "Doubles evasion rate against Phys attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Dodge Wind",
                Effect = "Doubles evasion rate against Wind attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Double Fangs",
                Effect = "Deals light Phys damage to 1 foe 2x.",
                Cost = "8% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Elec Amp",
                Effect = "Strengthens Elec attacks by 50%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 83,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 85,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 98,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Elec Boost",
                Effect = "Strengthens Elec attacks by 25%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Elec Break",
                Effect = "Nullifies 1 foe's Elec resistance (for 3 turns).",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Endure",
                Effect = "Restores 1 HP upon death 1x per battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Endure Dark",
                Effect = "Automatically survive instant death 1 time from a Darkness attack with 1 HP.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 89,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Endure Light",
                Effect = "Automatically survive instant death 1 time from a Light attack with 1 HP.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 80,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Enduring Soul",
                Effect = "Restores full HP upon death 1x per battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 94,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Energy Shower",
                Effect = "Cures Exhaustion and Enervation (party).",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Enervate Boost",
                Effect = "Enervation-based attacks are 1.5 times more effective.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Enervation",
                Effect = "Enervates 1 foe (40% chance). (-50% STR/MAG/END)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evade Elec",
                Effect = "Triples evasion rate against Elec attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evade Fire",
                Effect = "Triples evasion rate against Fire attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 82,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evade Ice",
                Effect = "Triples evasion rate against Ice attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evade Physical",
                Effect = "Triples evasion rate against Phys attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 93,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evade Wind",
                Effect = "Triples evasion rate against Wind attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evil Smile",
                Effect = "Instills Fear in all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Evil Touch",
                Effect = "Instills Fear in 1 foe (40% chance). (-Crit. DEF and may lose turn or escape)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Exhaust Boost",
                Effect = "Exhaustion-based attacks are 1.5 times more effective.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Fast Heal",
                Effect = "Halves the time needed to recover from ailments.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Fatal End",
                Effect = "Deals medium Phys damage to 1 foe.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Fear Boost",
                Effect = "Increases odds of inflicting Fear (1.5x).",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 5,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Fire Amp",
                Effect = "Strengthens Fire attacks by 50%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 95,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 96,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Fire Boost",
                Effect = "Strengthens Fire attacks by 25%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Fire Break",
                Effect = "Nullifies 1 foe's Fire resistance (for 3 turns).",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Firm Stance",
                Effect = "Always take half damage, but you can never dodge.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 86,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 87,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Foolish Whisper",
                Effect = "Silences all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Foul Breath",
                Effect = "Increase 1 foe's susceptibility to ailments and Light/Dark skills.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Gale Slash",
                Effect = "Deals light Phys damage to all foes.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Garu",
                Effect = "Deals light Wind damage to 1 foe.",
                Cost = "4 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Garudyne",
                Effect = "Deals heavy Wind damage to 1 foe.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 95,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Garula",
                Effect = "Deals medium Wind damage to 1 foe.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ghastly Wail",
                Effect = "Instantly kills foes who are fearful.",
                Cost = "28 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Gigantic Fist",
                Effect = "Deals heavy Phys damage to 1 foe.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "God's Hand",
                Effect = "Deals severe Phys damage to 1 foe.",
                Cost = "22% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 76,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Green Wall",
                Effect = "Add Wind resistance to 1 ally (for 3 turns).",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Growth 1",
                Effect = "Persona gains 1/4 EXP while inactive.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Growth 2",
                Effect = "Persona gains 1/2 EXP while inactive. (Overwrites Growth 1)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Growth 3",
                Effect = "Persona gains full EXP even while inactive. (Overwrites Growth 1/Growth 2)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Hama",
                Effect = "Light: low chance of instant kill, 1 foe. (40% chance)",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 5,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Hama Boost",
                Effect = "Light-based attacks are 1.5 times more effective.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 9,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 78,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Hamaon",
                Effect = "Light: high chance of instant kill, 1 foe. (60% chance)",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Hassou Tobi",
                Effect = "Deals light Phys damage to all foes 8x.",
                Cost = "25% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 83,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Heat Riser",
                Effect = "Increases 1 ally's Attack, Defense, and Hit/Evasion rates for 3 turns.",
                Cost = "30 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Heat Wave",
                Effect = "Deals medium Phys damage to all foes.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Heaven's Blade",
                Effect = "Deals heavy Phys damage to 1 foe.",
                Cost = "19% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Herculean Strike",
                Effect = "Deals medium Phys damage to all foes.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "High Counter",
                Effect = "20% chance of reflecting Phys attacks. Does not stack.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 67,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 89,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Hysterical Slap",
                Effect = "Deals light Phys damage to 1 foe with a chance of Rage.",
                Cost = "9% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ice Amp",
                Effect = "Strengthens Ice attacks by 50%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 66,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 94,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 97,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Ice Boost",
                Effect = "Strengthens Ice attacks by 25%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ice Break",
                Effect = "Nullifies 1 foe's Ice resistance (for 3 turns).",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jack Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Insta-Heal",
                Effect = "Recovers from ailments in 1 turn.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 77,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 90,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Invigorate 1",
                Effect = "Recovers 3 SP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Invigorate 2",
                Effect = "Recovers 5 SP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Invigorate 3",
                Effect = "Recovers 7 SP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 75,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 78,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Kill Rush",
                Effect = "Deals light Phys damage to 1 foe 1x to 3x.",
                Cost = "10% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Life Drain",
                Effect = "Drains 30 HP from 1 foe.",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vetala",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mabufu",
                Effect = "Deals light Ice damage to all foes.",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jack Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mabufudyne",
                Effect = "Deals heavy Ice damage to all foes.",
                Cost = "22 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Byakko",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 68,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mabufula",
                Effect = "Deals medium Ice damage to all foes.",
                Cost = "16 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Magaru",
                Effect = "Deals light Wind damage to all foes.",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Magarudyne",
                Effect = "Deals heavy Wind damage to all foes.",
                Cost = "22 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 81,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Magarula",
                Effect = "Deals medium Wind damage to all foes.",
                Cost = "16 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mahama",
                Effect = "Light: low chance of instant kill, all foes. (30% chance)",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mahamaon",
                Effect = "Light: high chance of instant kill, all foes. (40% chance)",
                Cost = "34 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 88,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Makajam",
                Effect = "Silences 1 foe (40% chance). (Unable to use Skills or change Persona)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Makara Break",
                Effect = "Negates all foes' Makarakarn.",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Makarakarn",
                Effect = "Barrier that reflects magic dmg once. (1 ally; excludes Almighty attacks)",
                Cost = "36 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mamudo",
                Effect = "Darkness: low chance of instant kill, all foes. (30% chance)",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mamudoon",
                Effect = "Darkness: high chance of instant kill, all foes. (40% chance)",
                Cost = "34 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 88,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Maragi",
                Effect = "Deals light Fire damage to all foes.",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Maragidyne",
                Effect = "Deals heavy Fire damage to all foes.",
                Cost = "22 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mada",
                        LevelRequired = 81,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 87,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Maragion",
                Effect = "Deals medium Fire damage to all foes.",
                Cost = "16 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gdon",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Marakukaja",
                Effect = "Increases Defense for 3 turns (party).",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Marakunda",
                Effect = "Decreases all foes' Defense for 3 turns.",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Masukukaja",
                Effect = "Increases Hit/Evasion rates for 3 turns (party).",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Masukunda",
                Effect = "Decreases all foes' Hit/Evasion rates for 3 turns.",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Matarukaja",
                Effect = "Increases Attack for 3 turns (party).",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Matarunda",
                Effect = "Decreases all foes' Attack for 3 turns.",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mazio",
                Effect = "Deals light Elec damage to all foes.",
                Cost = "10 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Maziodyne",
                Effect = "Deals heavy Elec damage to all foes.",
                Cost = "22 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 73,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 79,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 79,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mazionga",
                Effect = "Deals medium Elec damage to all foes.",
                Cost = "16 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Me Patra",
                Effect = "Dispels Rage, Fear, and Confusion (party).",
                Cost = "6 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pixie",
                        LevelRequired = 4,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Apsaras",
                        LevelRequired = 6,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Media",
                Effect = "Slightly restores party's HP.",
                Cost = "7 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mediarahan",
                Effect = "Fully restores party's HP.",
                Cost = "30 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Melchizedek",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 94,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mediarama",
                Effect = "Moderately restores party's HP.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Megido",
                Effect = "Deals medium Almighty damage to all foes.",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Megidola",
                Effect = "Deals heavy Almighty damage to all foes.",
                Cost = "32 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Megidolaon",
                Effect = "Deals severe Almighty damage to all foes.",
                Cost = "60 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = true
                    },
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 86,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 91,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mighty Swing",
                Effect = "Deals medium Phys damage to 1 foe.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mind Charge",
                Effect = "Next Fire, Ice, Elec, Wind, or Almighty magical attack will be 250% greater in power.",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = true
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jack Frost",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dis",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atavaka",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 79,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 85,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mind Slice",
                Effect = "Deals medium Phys damage to all foes with a chance of Confusion.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganga",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Morning Star",
                Effect = "Deals massive Almighty damage to all foes.",
                Cost = "72 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 94,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mudo",
                Effect = "Darkness: low chance of instant kill, 1 foe. (40% chance)",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mudo Boost",
                Effect = "Darkness-based attacks are 1.5 times more effective.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Alice",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baphomet",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 80,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 80,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 85,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mudoon",
                Effect = "Darkness: high chance of instant kill, 1 foe. (60% chance)",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "White Rider",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Black Frost",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hell Biker",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mustard Bomb",
                Effect = "Deals medium Phys damage to all foes with a chance of Enervation.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Mutudi",
                Effect = "Cures Silence (1 ally).",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Muzzle Shot",
                Effect = "Deals light Phys damage to 1 foe with a chance of Silence.",
                Cost = "9% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Myriad Arrows",
                Effect = "Deals heavy Phys damage to all foes 1x to 3x.",
                Cost = "22% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Belial",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Navas Nebula",
                Effect = "Deals medium Phys damage to all foes with a chance of Exhaustion.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Nervundi",
                Effect = "Cures Exhaustion and Enervation (1 ally).",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Parvati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Niflheim",
                Effect = "Deals severe Ice damage to 1 foe.",
                Cost = "48 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 70,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Confuse",
                Effect = "Become immune to Confusion attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gorgon",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Dark",
                Effect = "Becomes immune to Darkness attacks. (Overwrites Resist Dark)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 44,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Uriel",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Dizzy",
                Effect = "Cannot become Dizzy after being knocked down.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raphael",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 92,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Elec",
                Effect = "Becomes immune to Elec attacks. (Overwrites Resist Elec)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 86,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Enervate",
                Effect = "Become immune to Enervation attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Exhaust",
                Effect = "Become immune to Exhaustion attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Fear",
                Effect = "Become immune to Fear attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatagarasu",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Fire",
                Effect = "Becomes immune to Fire attacks. (Overwrites Resist Fire)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 69,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Ice",
                Effect = "Becomes immune to Ice attacks. (Overwrites Resist Ice)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Orthrus",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Light",
                Effect = "Becomes immune to Light attacks. (Overwrites Resist Light)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Mute",
                Effect = "Become immune to Silence attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 37,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Physical",
                Effect = "Become immune to Phys attacks. (Overwrites Resist Phys)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 69,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 96,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Poison",
                Effect = "Become immune to Poison attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Rage",
                Effect = "Become immune to Rage attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Null Wind",
                Effect = "Becomes immune to Wind attacks. (Overwrites Resist Wind)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 82,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Old One",
                Effect = "Enervates all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Alraune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Belphegor",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Panta Rhei",
                Effect = "Deals severe Wind damage to 1 foe.",
                Cost = "48 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 81,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Patra",
                Effect = "Dispels Rage, Fear, and Confusion (1 ally).",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Pixie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Apsaras",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Poisma",
                Effect = "Poisons 1 foe (40% chance). (-5% HP/turn, -50% STR)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Poison Arrow",
                Effect = "Deals medium Phys damage to 1 foe with a chance of Poison.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anubis",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Poison Boost",
                Effect = "Increases odds of inflicting Poison (1.5x).",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Poison Mist",
                Effect = "Poisons all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Ikusa",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Poison Skewer",
                Effect = "Deals light Phys damage to 1 foe with a chance of Poison.",
                Cost = "9% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Posumudi",
                Effect = "Neutralizes Poison (1 ally).",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Undine",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Power Charge",
                Effect = "Next physical attack, physical skill, or Almighty physical attack will be 250% greater in power.",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mahakala",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rakshasa",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 35,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Triglav",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yatsufusa",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ganesha",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taowu",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mara",
                        LevelRequired = 63,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Power Slash",
                Effect = "Deals medium Phys damage to 1 foe.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Pralaya",
                Effect = "Deals severe Phys damage to all foes with a high chance of instant kills. (50% chance)",
                Cost = "25% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 87,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Primal Force",
                Effect = "Deals severe Phys damage to 1 foe.",
                Cost = "20% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Futsunushi",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ardha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kartikeya",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Pulinpa",
                Effect = "Confuses 1 foe (40% chance). (May attack ally, lose turn, or waste 3% money)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 4,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rage Boost",
                Effect = "Increases odds of inflicting Rage (1.5x).",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ragnarok",
                Effect = "Deals severe Fire damage to 1 foe.",
                Cost = "48 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Surt",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rainy Death",
                Effect = "Deals heavy Phys damage to 1 foe.",
                Cost = "20% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rakukaja",
                Effect = "Increases 1 ally's Defense for 3 turns. (Raises one ally's physical/magical defensive strength for three turns.)",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "King Frost",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rakunda",
                Effect = "Decreases 1 foe's Defense for 3 turns. (Reduces one enemy's physical and magic defensive power for three turns.)",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Valkyrie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi",
                        LevelRequired = 3,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Apsaras",
                        LevelRequired = 5,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rampage",
                Effect = "Deals light Phys damage to all foes 1x to 3x.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ippon-Datara",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ares",
                        LevelRequired = 28,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Re Patra",
                Effect = "Recovers 1 ally from Knockdown or Dizzy status.",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hua Po",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Rebellion",
                Effect = "Increases Critical rate for 3 turns (1 ally).",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Recarm",
                Effect = "Revives 1 ally with 50% HP.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Hanuman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Red Wall",
                Effect = "Add Fire resistance to 1 ally (for 3 turns).",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kushinada",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 4,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Anzu",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Regenerate 1",
                Effect = "Restores 2% of max HP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Regenerate 2",
                Effect = "Recovers 4% of max HP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Titania",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Regenerate 3",
                Effect = "Recovers 6% of max HP each turn in battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Siegfried",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Alilat",
                        LevelRequired = 72,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vishnu",
                        LevelRequired = 75,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 77,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Satan",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Dark",
                Effect = "Repels Darkness attacks. (Overwrites Resist/Null Dark)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 90,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Elec",
                Effect = "Repels Elec attacks. (Overwrites Resist/Null Elec)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Jatayu",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 78,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 88,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Fire",
                Effect = "Repels Fire attacks. (Overwrites Resist/Null Fire)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 89,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Ice",
                Effect = "Repels Ice attacks. (Overwrites Resist/Null Ice)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Metatron",
                        LevelRequired = 87,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Light",
                Effect = "Repels Light attacks. (Overwrites Resist/Null Light)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 96,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Physical",
                Effect = "Repels Phys attacks. (Overwrites Resist/Null Phys)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 55,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 56,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 80,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Repel Wind",
                Effect = "Repels Wind attacks. (Overwrites Resist/Null Wind)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Garuda",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 91,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Confuse",
                Effect = "Reduces chance of being Confused.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Dark",
                Effect = "Reduces chance of instant death from Darkness attacks. (Voids Dark weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Virtue",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Throne",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Dizzy",
                Effect = "Reduces chance of being Dizzy.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 9,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Elec",
                Effect = "Reduces damage from Elec attacks. (Voids Elec weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Enervate",
                Effect = "Reduces chance of being Enervated.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Nigi Mitama",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yamata-No-Orochi",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Exhaust",
                Effect = "Reduces chance of being Exhausted.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lachesis",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Fear",
                Effect = "Lessens instances of succumbing to Fear attacks.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 19,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Fire",
                Effect = "Reduces damage from Fire attacks. (Voids Fire weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 6,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mother Harlot",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lakshmi",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Ice",
                Effect = "Reduces damage from Ice attacks. (Voids Ice weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 38,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suzaku",
                        LevelRequired = 58,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Light",
                Effect = "Reduces chance of instant death from Light attacks. (Voids Light weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Mute",
                Effect = "Reduces chance of being Silenced.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Physical",
                Effect = "Reduces damage from Phys attacks. (Voids Phys weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 17,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oni",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Genbu",
                        LevelRequired = 45,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 65,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Poison",
                Effect = "Reduces chance of being Poisoned.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Rage",
                Effect = "Reduces chance of being Enraged.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sarasvati",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Resist Wind",
                Effect = "Reduces damage from Wind attacks. (Voids Wind weakness)",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 9,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 66,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Revolution",
                Effect = "Greatly increases Critical rate for 3 turns (all).",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Shiki-Ouji",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kali",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hachiman",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 86,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Salvation",
                Effect = "Fully restores party's HP. Cures ailments.",
                Cost = "40 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 85,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Helel",
                        LevelRequired = 88,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Samarecarm",
                Effect = "Revives 1 ally with full HP.",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandalphon",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 46,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kikuri-Hime",
                        LevelRequired = 50,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hariti",
                        LevelRequired = 64,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 74,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Attis",
                        LevelRequired = 86,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Samsara",
                Effect = "Light: very high chance of instant kill, all foes. (60% chance)",
                Cost = "44 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Daisoujou",
                        LevelRequired = 67,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Seal Bomb",
                Effect = "Deals medium Phys damage to all foes with a chance of Silence.",
                Cost = "14% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Sharp Student",
                Effect = "Lowers odds of sustaining crit dmg.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Orobas",
                        LevelRequired = 12,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 21,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Silence Boost",
                Effect = "Increases odds of inflicting Silence (1.5x).",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 54,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Single Shot",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "8% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Berith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Skewer",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "5% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Skull Cracker",
                Effect = "Deals light Phys damage to 1 foe with a chance of Confusion.",
                Cost = "9% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Titan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 6,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Sonic Punch",
                Effect = "Deals light Phys damage to 1 foe.",
                Cost = "8% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 7,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Soul Break",
                Effect = "Exhausts 1 foe (40% chance). (-10% SP/turn)",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nata Taishi",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Eligor",
                        LevelRequired = 16,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 18,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lamia",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Spell Master",
                Effect = "Halves SP cost for magic skills.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Skadi",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nebiros",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ishtar",
                        LevelRequired = 76,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 80,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saturnus",
                        LevelRequired = 81,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 83,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 90,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 95,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Spirit Drain",
                Effect = "Drains 30 SP from 1 foe.",
                Cost = "3 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Succubus",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Stagnant Air",
                Effect = "Increase all foe's susceptibility to ailments and Light/Dark skills.",
                Cost = "5 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Incubus",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pazuzu",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pabilsag",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nidhoggr",
                        LevelRequired = 59,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 82,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 82,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Sukukaja",
                Effect = "Increases 1 ally's Hit/Evasion rates for 3 turns.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sylph",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Angel",
                        LevelRequired = 6,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ghoul",
                        LevelRequired = 10,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 13,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Sukunda",
                Effect = "Decreases 1 foe's Hit/Evasion rates for 3 turns.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ukobach",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Saki Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Makami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yomotsu-Shikome",
                        LevelRequired = 9,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Survive Dark",
                Effect = "50% chance of surviving instant death 1 time from a Darkness attack with 1 HP.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Archangel",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gabriel",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Survive Light",
                Effect = "50% chance of surviving instant death 1 time from a Light attack with 1 HP.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 26,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 30,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 31,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ose",
                        LevelRequired = 36,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pale Rider",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Samael",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 42,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Swift Strike",
                Effect = "Deals light Phys damage to all foes 1x to 2x.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Matador",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yaksini",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Gurr",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tarukaja",
                Effect = "Increases 1 ally's Attack for 3 turns. (Raises one ally's physical/magical offensive strength for three turns.)",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Forneus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Obariyon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Flauros",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi",
                        LevelRequired = 5,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ara Mitama",
                        LevelRequired = 20,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tarunda",
                Effect = "Decreases 1 foe's Attack for 3 turns. (Reduces one enemy's physical/offensive magic strength for three turns.)",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pyro Jack",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Slime",
                        LevelRequired = 3,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tempest Slash",
                Effect = "Deals heavy Phys damage to 1 foe 1x to 2x.",
                Cost = "15% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Narasimha",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Masakado",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tentarafoo",
                Effect = "Confuses* all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Legion",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Narcissus",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mot",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Rangda",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Leanan Sidhe",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Baal Zebul",
                        LevelRequired = 78,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Beelzebub",
                        LevelRequired = 78,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tetra Break",
                Effect = "Negates all foes' Tetrakarn.",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Chernobog",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mithra",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Abaddon",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 60,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tetraja",
                Effect = "Nullifies instant kill attack once (1 ally).",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 25,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Girimehkala",
                        LevelRequired = 52,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kumbhanda",
                        LevelRequired = 61,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kaguya",
                        LevelRequired = 75,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Tetrakarn",
                Effect = "Barrier that reflects phys dmg once. (1 ally)",
                Cost = "36 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kaiwan",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Decarabia",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Isis",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Thunder Reign",
                Effect = "Deals severe Elec damage to 1 foe.",
                Cost = "48 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Torrent Shot",
                Effect = "Deals medium Phys damage to 1 foe 2x to 3x.",
                Cost = "12% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Raja Naga",
                        LevelRequired = 39,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Taotie",
                        LevelRequired = 41,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Traesto",
                Effect = "Instantly escape from a dungeon. (Not available during combat)",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Sandman",
                        LevelRequired = 11,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 33,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Trafuri",
                Effect = "Enables escape from most battles. (100% chance to escape normal battles)",
                Cost = "24 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Pixie",
                        LevelRequired = 8,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Senri",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ame No Uzume",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 27,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 32,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sati",
                        LevelRequired = 34,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Twin Shot",
                Effect = "Deals light Phys damage to 1 foe 2x.",
                Cost = "10% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Principality",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Phoenix",
                        LevelRequired = 22,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Unshaken Will",
                Effect = "Protects user from Rage/Fear/Silence/Enervation/Confusion.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Asura",
                        LevelRequired = 92,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Valiant Dance",
                Effect = "Enrages all foes (30% chance).",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mokoi",
                        LevelRequired = 15,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Jinn",
                        LevelRequired = 68,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Vicious Strike",
                Effect = "Deals heavy Phys damage to all foes.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sui-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cybele",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Arahabaki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cerberus",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kingu",
                        LevelRequired = 62,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Victory Cry",
                Effect = "Recover full HP and SP after a successful battle.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = true
                    },
                    new SkillPersona() {
                        Name = "Lucifer",
                        LevelRequired = 99,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Vile Assault",
                Effect = "Deals heavy Phys damage to 1 foe. Bonus damage to foes that are knocked down.",
                Cost = "18% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Kin-Ki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Virus Wave",
                Effect = "Deals heavy Phys damage to all foes with a chance of Poison.",
                Cost = "16% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Yurlungur",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Vorpal Blade",
                Effect = "Deals heavy Phys damage to all foes.",
                Cost = "25% HP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Michael",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiten Taisei",
                        LevelRequired = 76,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Zaou Gongen",
                        LevelRequired = 96,
                        Ultimate = true,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "White Wall",
                Effect = "Add Ice resistance to 1 ally (for 3 turns).",
                Cost = "18 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Ananta",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Sith",
                        LevelRequired = 14,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Wind Amp",
                Effect = "Strengthens Wind attacks by 50%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Cu Chulainn",
                        LevelRequired = 53,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Quetzalcoatl",
                        LevelRequired = 57,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Horus",
                        LevelRequired = 70,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 73,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Norn",
                        LevelRequired = 76,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 76,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Suparna",
                        LevelRequired = 80,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Scathach",
                        LevelRequired = 84,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 99,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Wind Boost",
                Effect = "Strengthens Wind attacks by 25%.",
                Cost = "",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Atropos",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fortuna",
                        LevelRequired = 40,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Fuu-Ki",
                        LevelRequired = 47,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Clotho",
                        LevelRequired = 48,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kurama Tengu",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Wind Break",
                Effect = "Nullifies 1 foe's Wind resistance (for 3 turns).",
                Cost = "15 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Seth",
                        LevelRequired = 71,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Zio",
                Effect = "Deals light Elec damage to 1 foe.",
                Cost = "4 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Izanagi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Omoikane",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Lilim",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Oberon",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Xiezhai",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Pixie",
                        LevelRequired = 3,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            },
            new Skill() {
                Name = "Ziodyne",
                Effect = "Deals heavy Elec damage to 1 foe.",
                Cost = "12 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Lilith",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tam Lin",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Barong",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thor",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Trumpeter",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Tzitzimitl",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Odin",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Yoshitsune",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kohryu",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiva",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Ongyo-Ki",
                        LevelRequired = 0,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Loa",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Seiryu",
                        LevelRequired = 49,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Thoth",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 51,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Sraosha",
                        LevelRequired = 76,
                        Ultimate = true,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Vasuki",
                        LevelRequired = 77,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Izanagi-No-Okami",
                        LevelRequired = 94,
                        Ultimate = false,
                        NewGame = true
                    }
                }
            },
            new Skill() {
                Name = "Zionga",
                Effect = "Deals medium Elec damage to 1 foe.",
                Cost = "8 SP",
                Personas = new List<SkillPersona>() {
                    new SkillPersona() {
                        Name = "Queen Mab",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Take-Minakata",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Kusi Mitama",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Unicorn",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Neko Shogun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Mothman",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Setanta",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Dominion",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Okuninushi",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hokuto Seikun",
                        LevelRequired = 0,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Shiisaa",
                        LevelRequired = 23,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Andra",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "High Pixie",
                        LevelRequired = 24,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Power",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Nozuchi",
                        LevelRequired = 29,
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona() {
                        Name = "Hitokoto-Nushi",
                        LevelRequired = 43,
                        Ultimate = false,
                        NewGame = false
                    }
                }
            }
        };
    }
}
