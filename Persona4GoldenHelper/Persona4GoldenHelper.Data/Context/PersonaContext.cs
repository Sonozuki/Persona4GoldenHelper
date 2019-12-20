using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Context
{
    public class PersonaContext
    {
        public List<Persona> Personas { get; } = new List<Persona>
        {
            new Persona(
                name: "Izanagi",
                arcana: "Fool",
                level: 1,
                stats: new PersonaStats(
                    strength: 3,
                    magic: 2,
                    endurance: 2,
                    agility: 3,
                    luck: 2
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zio", 0),
                    new PersonaSkill("Cleave", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Rakunda", 3),
                    new PersonaSkill("Tarukaja", 5)
                }
            ),
            new Persona(
                name: "Pixie",
                arcana: "Magician",
                level: 2,
                stats: new PersonaStats(
                    strength: 2,
                    magic: 3,
                    endurance: 2,
                    agility: 4,
                    luck: 2
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Dia", 0),
                    new PersonaSkill("Patra", 0),
                    new PersonaSkill("Zio", 3),
                    new PersonaSkill("Me Patra", 4),
                    new PersonaSkill("Trafuri", 8)
                }
            ),
            new Persona(
                name: "Slime",
                arcana: "Chariot",
                level: 2,
                stats: new PersonaStats(
                    strength: 3,
                    magic: 2,
                    endurance: 3,
                    agility: 2,
                    luck: 3
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bash", 0),
                    new PersonaSkill("Evil Touch", 0),
                    new PersonaSkill("Tarunda", 3),
                    new PersonaSkill("Red Wall", 4),
                    new PersonaSkill("Fear Boost", 5),
                    new PersonaSkill("Resist Physical", 7)
                }
            ),
            new Persona(
                name: "Ukobach",
                arcana: "Devil",
                level: 3,
                stats: new PersonaStats(
                    strength: 3,
                    magic: 4,
                    endurance: 3,
                    agility: 4,
                    luck: 2
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agi", 0),
                    new PersonaSkill("Sukunda", 0),
                    new PersonaSkill("Pulinpa", 4),
                    new PersonaSkill("Confuse Boost", 5),
                    new PersonaSkill("Resist Fire", 6),
                    new PersonaSkill("Fire Break", 7)
                }
            ),
            new Persona(
                name: "Angel",
                arcana: "Justice",
                level: 4,
                stats: new PersonaStats(
                    strength: 4,
                    magic: 5,
                    endurance: 2,
                    agility: 5,
                    luck: 3
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Resistant,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garu", 0),
                    new PersonaSkill("Patra", 0),
                    new PersonaSkill("Hama", 5),
                    new PersonaSkill("Sukukaja", 6),
                    new PersonaSkill("Regenerate 1", 8),
                    new PersonaSkill("Hama Boost", 9)
                }
            ),
            new Persona(
                name: "Apsaras",
                arcana: "Temperance",
                level: 4,
                stats: new PersonaStats(
                    strength: 3,
                    magic: 5,
                    endurance: 3,
                    agility: 5,
                    luck: 3
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Patra", 0),
                    new PersonaSkill("Dia", 0),
                    new PersonaSkill("Rakunda", 5),
                    new PersonaSkill("Me Patra", 6),
                    new PersonaSkill("Bufu", 7)
                }
            ),
            new Persona(
                name: "Sandman",
                arcana: "Strength",
                level: 5,
                stats: new PersonaStats(
                    strength: 4,
                    magic: 5,
                    endurance: 6,
                    agility: 4,
                    luck: 3
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garu", 0),
                    new PersonaSkill("Pulinpa", 0),
                    new PersonaSkill("Skull Cracker", 6),
                    new PersonaSkill("Confuse Boost", 7),
                    new PersonaSkill("Dekaja", 8),
                    new PersonaSkill("Traesto", 11)
                }
            ),
            new Persona(
                name: "Nata Taishi",
                arcana: "Chariot",
                level: 6,
                stats: new PersonaStats(
                    strength: 6,
                    magic: 2,
                    endurance: 6,
                    agility: 7,
                    luck: 4
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bash", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Sonic Punch", 7),
                    new PersonaSkill("Dodge Ice", 8),
                    new PersonaSkill("Resist Dizzy", 9),
                    new PersonaSkill("Soul Break", 10)
                }
            ),
            new Persona(
                name: "Forneus",
                arcana: "Hermit",
                level: 6,
                stats: new PersonaStats(
                    strength: 4,
                    magic: 5,
                    endurance: 7,
                    agility: 6,
                    luck: 3
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufu", 0),
                    new PersonaSkill("Skewer", 0),
                    new PersonaSkill("Tarukaja", 0),
                    new PersonaSkill("Rakunda", 7),
                    new PersonaSkill("Poisma", 8),
                    new PersonaSkill("Dodge Elec", 10)
                }
            ),
            new Persona(
                name: "Yomotsu-Shikome",
                arcana: "Fool",
                level: 7,
                stats: new PersonaStats(
                    strength: 2,
                    magic: 7,
                    endurance: 7,
                    agility: 8,
                    luck: 4
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Poisma", 0),
                    new PersonaSkill("Skewer", 0),
                    new PersonaSkill("Evil Touch", 0),
                    new PersonaSkill("Sukunda", 9),
                    new PersonaSkill("Mudo", 10),
                    new PersonaSkill("Ghastly Wail", 11)
                }
            ),
            new Persona(
                name: "Omoikane",
                arcana: "Hierophant",
                level: 7,
                stats: new PersonaStats(
                    strength: 5,
                    magic: 8,
                    endurance: 5,
                    agility: 4,
                    luck: 6
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zio", 0),
                    new PersonaSkill("Sukunda", 0),
                    new PersonaSkill("Tarunda", 0),
                    new PersonaSkill("Poison Mist", 8),
                    new PersonaSkill("Resist Wind", 9),
                    new PersonaSkill("Resist Poison", 11),
                    new PersonaSkill("Resist Elec", 12)
                }
            ),
            new Persona(
                name: "Orobas",
                arcana: "Magician",
                level: 8,
                stats: new PersonaStats(
                    strength: 4,
                    magic: 10,
                    endurance: 6,
                    agility: 7,
                    luck: 4
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agi", 0),
                    new PersonaSkill("Hysterical Slap", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Dodge Ice", 10),
                    new PersonaSkill("Resist Dizzy", 11),
                    new PersonaSkill("Sharp Student", 12)
                }
            ),
            new Persona(
                name: "Valkyrie",
                arcana: "Strength",
                level: 8,
                stats: new PersonaStats(
                    strength: 7,
                    magic: 6,
                    endurance: 6,
                    agility: 7,
                    luck: 5
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufu", 0),
                    new PersonaSkill("Cleave", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Media", 10),
                    new PersonaSkill("Arm Chopper", 11),
                    new PersonaSkill("Mabufu", 12)
                }
            ),
            new Persona(
                name: "Senri",
                arcana: "Empress",
                level: 9,
                stats: new PersonaStats(
                    strength: 7,
                    magic: 7,
                    endurance: 4,
                    agility: 11,
                    luck: 5
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Dia", 0),
                    new PersonaSkill("Makajam", 0),
                    new PersonaSkill("Agi", 0),
                    new PersonaSkill("Dekunda", 10),
                    new PersonaSkill("Media", 11),
                    new PersonaSkill("Trafuri", 14)
                }
            ),
            new Persona(
                name: "Ghoul",
                arcana: "Death",
                level: 9,
                stats: new PersonaStats(
                    strength: 8,
                    magic: 7,
                    endurance: 9,
                    agility: 5,
                    luck: 5
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bash", 0),
                    new PersonaSkill("Poisma", 0),
                    new PersonaSkill("Sukukaja", 10),
                    new PersonaSkill("Enervation", 11),
                    new PersonaSkill("Poison Skewer", 12),
                    new PersonaSkill("Rakunda", 13),
                    new PersonaSkill("Poison Boost", 14)
                }
            ),
            new Persona(
                name: "Lilim",
                arcana: "Devil",
                level: 10,
                stats: new PersonaStats(
                    strength: 4,
                    magic: 11,
                    endurance: 5,
                    agility: 9,
                    luck: 8
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zio", 0),
                    new PersonaSkill("Mudo", 0),
                    new PersonaSkill("Enervation", 0),
                    new PersonaSkill("Enervate Boost", 12),
                    new PersonaSkill("Sukukaja", 13),
                    new PersonaSkill("Mamudo", 15)
                }
            ),
            new Persona(
                name: "Cu Sith",
                arcana: "Sun",
                level: 10,
                stats: new PersonaStats(
                    strength: 10,
                    magic: 5,
                    endurance: 6,
                    agility: 9,
                    luck: 7
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garu", 0),
                    new PersonaSkill("Pulinpa", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Growth 1", 11),
                    new PersonaSkill("Magaru", 13),
                    new PersonaSkill("White Wall", 14),
                    new PersonaSkill("Traesto", 15)
                }
            ),
            new Persona(
                name: "Saki Mitama",
                arcana: "Priestess",
                level: 11,
                stats: new PersonaStats(
                    strength: 5,
                    magic: 12,
                    endurance: 5,
                    agility: 8,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Dia", 0),
                    new PersonaSkill("Bufu", 0),
                    new PersonaSkill("Sukunda", 0),
                    new PersonaSkill("Alertness", 13),
                    new PersonaSkill("Media", 14),
                    new PersonaSkill("Null Rage", 16)
                }
            ),
            new Persona(
                name: "Archangel",
                arcana: "Justice",
                level: 11,
                stats: new PersonaStats(
                    strength: 8,
                    magic: 9,
                    endurance: 7,
                    agility: 7,
                    luck: 9
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hama", 0),
                    new PersonaSkill("Double Fangs", 0),
                    new PersonaSkill("Patra", 0),
                    new PersonaSkill("Media", 12),
                    new PersonaSkill("Muzzle Shot", 13),
                    new PersonaSkill("Sharp Student", 14),
                    new PersonaSkill("Survive Dark", 15)
                }
            ),
            new Persona(
                name: "Sylph",
                arcana: "Temperance",
                level: 11,
                stats: new PersonaStats(
                    strength: 8,
                    magic: 10,
                    endurance: 5,
                    agility: 10,
                    luck: 7
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garu", 0),
                    new PersonaSkill("Sukukaja", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Regenerate 1", 12),
                    new PersonaSkill("Media", 13),
                    new PersonaSkill("Magaru", 14)
                }
            ),
            new Persona(
                name: "Oberon",
                arcana: "Emperor",
                level: 12,
                stats: new PersonaStats(
                    strength: 10,
                    magic: 12,
                    endurance: 8,
                    agility: 8,
                    luck: 5
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zio", 0),
                    new PersonaSkill("Arm Chopper", 0),
                    new PersonaSkill("Makajam", 13),
                    new PersonaSkill("Media", 14),
                    new PersonaSkill("Elec Boost", 15),
                    new PersonaSkill("Mazio", 16),
                    new PersonaSkill("Dodge Wind", 17)
                }
            ),
            new Persona(
                name: "Eligor",
                arcana: "Chariot",
                level: 12,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 6,
                    endurance: 13,
                    agility: 8,
                    luck: 5
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Poison Skewer", 0),
                    new PersonaSkill("Agi", 0),
                    new PersonaSkill("Maragi", 13),
                    new PersonaSkill("Arm Chopper", 14),
                    new PersonaSkill("Fire Boost", 15),
                    new PersonaSkill("Soul Break", 16),
                    new PersonaSkill("Resist Exhaust", 17)
                }
            ),
            new Persona(
                name: "Obariyon",
                arcana: "Fool",
                level: 13,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 6,
                    endurance: 11,
                    agility: 9,
                    luck: 9
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Sonic Punch", 0),
                    new PersonaSkill("Tarukaja", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Muzzle Shot", 14),
                    new PersonaSkill("Silence Boost", 15),
                    new PersonaSkill("Resist Physical", 17),
                    new PersonaSkill("Single Shot", 18)
                }
            ),
            new Persona(
                name: "Titan",
                arcana: "Strength",
                level: 14,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 12,
                    endurance: 10,
                    agility: 10,
                    luck: 6
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Skull Cracker", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Dodge Ice", 16),
                    new PersonaSkill("Kill Rush", 18),
                    new PersonaSkill("Resist Fear", 19)
                }
            ),
            new Persona(
                name: "Mokoi",
                arcana: "Death",
                level: 14,
                stats: new PersonaStats(
                    strength: 13,
                    magic: 7,
                    endurance: 9,
                    agility: 11,
                    luck: 9
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Sonic Punch", 0),
                    new PersonaSkill("Hysterical Slap", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Valiant Dance", 15),
                    new PersonaSkill("Rage Boost", 16),
                    new PersonaSkill("Soul Break", 18),
                    new PersonaSkill("Exhaust Boost", 19)
                }
            ),
            new Persona(
                name: "Anzu",
                arcana: "Hierophant",
                level: 15,
                stats: new PersonaStats(
                    strength: 9,
                    magic: 11,
                    endurance: 10,
                    agility: 13,
                    luck: 9
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garu", 0),
                    new PersonaSkill("Balzac", 0),
                    new PersonaSkill("Alertness", 0),
                    new PersonaSkill("Magaru", 17),
                    new PersonaSkill("Red Wall", 18),
                    new PersonaSkill("Mahama", 19),
                    new PersonaSkill("Auto-Sukukaja", 20)
                }
            ),
            new Persona(
                name: "Berith",
                arcana: "Hanged Man",
                level: 15,
                stats: new PersonaStats(
                    strength: 12,
                    magic: 10,
                    endurance: 9,
                    agility: 12,
                    luck: 9
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Single Shot", 0),
                    new PersonaSkill("Mudo", 0),
                    new PersonaSkill("Maragi", 16),
                    new PersonaSkill("Mudo Boost", 17),
                    new PersonaSkill("Green Wall", 18),
                    new PersonaSkill("Brain Shake", 19),
                    new PersonaSkill("Resist Confuse", 20)
                }
            ),
            new Persona(
                name: "Jack Frost",
                arcana: "Magician",
                level: 16,
                stats: new PersonaStats(
                    strength: 10,
                    magic: 14,
                    endurance: 12,
                    agility: 11,
                    luck: 8
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufu", 0),
                    new PersonaSkill("Ice Break", 0),
                    new PersonaSkill("Bufula", 19),
                    new PersonaSkill("Dodge Fire", 20),
                    new PersonaSkill("Mind Charge", 25)
                }
            ),
            new Persona(
                name: "Xiezhai",
                arcana: "Temperance",
                level: 16,
                stats: new PersonaStats(
                    strength: 14,
                    magic: 12,
                    endurance: 9,
                    agility: 13,
                    luck: 7
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zio", 0),
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Makajam", 17),
                    new PersonaSkill("Silence Boost", 18),
                    new PersonaSkill("Rampage", 19),
                    new PersonaSkill("Elec Boost", 21)
                }
            ),
            new Persona(
                name: "Sarasvati",
                arcana: "Pristess",
                level: 17,
                stats: new PersonaStats(
                    strength: 9,
                    magic: 16,
                    endurance: 10,
                    agility: 13,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Media", 0),
                    new PersonaSkill("Mabufu", 0),
                    new PersonaSkill("Patra", 0),
                    new PersonaSkill("Invigorate 2", 19),
                    new PersonaSkill("Resist Rage", 20),
                    new PersonaSkill("Dekaja", 21),
                    new PersonaSkill("Null Wind", 23)
                }
            ),
            new Persona(
                name: "Ippon-Datara",
                arcana: "Hermit",
                level: 17,
                stats: new PersonaStats(
                    strength: 15,
                    magic: 6,
                    endurance: 14,
                    agility: 13,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudo", 0),
                    new PersonaSkill("Maragi", 0),
                    new PersonaSkill("Mamudo", 19),
                    new PersonaSkill("Agilao", 20),
                    new PersonaSkill("Rampage", 21),
                    new PersonaSkill("Mudo Boost", 22)
                }
            ),
            new Persona(
                name: "Yaksini",
                arcana: "Empress",
                level: 18,
                stats: new PersonaStats(
                    strength: 13,
                    magic: 16,
                    endurance: 10,
                    agility: 12,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Resistant,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufu", 0),
                    new PersonaSkill("Arm Chopper", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Swift Strike", 20),
                    new PersonaSkill("Ice Boost", 21),
                    new PersonaSkill("Bufula", 22),
                    new PersonaSkill("Auto-Tarukaja", 23)
                }
            ),
            new Persona(
                name: "Ame No Uzume",
                arcana: "Aeon",
                level: 18,
                stats: new PersonaStats(
                    strength: 9,
                    magic: 15,
                    endurance: 12,
                    agility: 10,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Media", 0),
                    new PersonaSkill("Magaru", 0),
                    new PersonaSkill("Hama", 0),
                    new PersonaSkill("Invigorate 1", 20),
                    new PersonaSkill("Re Patra", 21),
                    new PersonaSkill("Auto-Rakukaja", 23),
                    new PersonaSkill("Trafuri", 24)
                }
            ),
            new Persona(
                name: "Ara Mitama",
                arcana: "Chariot",
                level: 18,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 11,
                    endurance: 11,
                    agility: 11,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Assault Dive", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Tarukaja", 20),
                    new PersonaSkill("Sharp Student", 21),
                    new PersonaSkill("Blue Wall", 22),
                    new PersonaSkill("Dodge Elec", 23)
                }
            ),
            new Persona(
                name: "Principality",
                arcana: "Justice",
                level: 19,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 15,
                    endurance: 10,
                    agility: 18,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hama", 0),
                    new PersonaSkill("Twin Shot", 0),
                    new PersonaSkill("Mahama", 21),
                    new PersonaSkill("Media", 22),
                    new PersonaSkill("Resist Confuse", 23),
                    new PersonaSkill("Survive Dark", 24),
                    new PersonaSkill("Tetraja", 25)
                }
            ),
            new Persona(
                name: "Vetala",
                arcana: "Devil",
                level: 19,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 10,
                    endurance: 14,
                    agility: 12,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Evil Touch", 0),
                    new PersonaSkill("Life Drain", 20),
                    new PersonaSkill("Foul Breath", 21),
                    new PersonaSkill("Brain Shake", 22),
                    new PersonaSkill("Ghastly Wail", 23),
                    new PersonaSkill("Fear Boost", 24)
                }
            ),
            new Persona(
                name: "Andras",
                arcana: "Moon",
                level: 20,
                stats: new PersonaStats(
                    strength: 14,
                    magic: 16,
                    endurance: 13,
                    agility: 12,
                    luck: 12
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Media", 0),
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Sukukaja", 0),
                    new PersonaSkill("Blue Wall", 22),
                    new PersonaSkill("Regenerate 2", 23),
                    new PersonaSkill("Zionga", 24),
                    new PersonaSkill("Dodge Wind", 25)
                }
            ),
            new Persona(
                name: "Gurr",
                arcana: "Jester",
                level: 20,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 11,
                    endurance: 14,
                    agility: 15,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Muzzle Shot", 0),
                    new PersonaSkill("Auto-Tarukaja", 0),
                    new PersonaSkill("Growth 1", 21),
                    new PersonaSkill("Swift Strike", 22),
                    new PersonaSkill("Poison Boost", 25),
                    new PersonaSkill("Resist Physical", 27)
                }
            ),
            new Persona(
                name: "Phoenix",
                arcana: "Sun",
                level: 20,
                stats: new PersonaStats(
                    strength: 9,
                    magic: 15,
                    endurance: 9,
                    agility: 20,
                    luck: 14
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Maragi", 0),
                    new PersonaSkill("Twin Shot", 22),
                    new PersonaSkill("Growth 1", 23),
                    new PersonaSkill("Dodge Ice", 25),
                    new PersonaSkill("Fire Boost", 26),
                    new PersonaSkill("Maragion", 27)
                }
            ),
            new Persona(
                name: "Legion",
                arcana: "Fool",
                level: 21,
                stats: new PersonaStats(
                    strength: 14,
                    magic: 14,
                    endurance: 18,
                    agility: 13,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Mudo", 0),
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Rampage", 23),
                    new PersonaSkill("Confuse Boost", 24),
                    new PersonaSkill("Foul Breath", 25),
                    new PersonaSkill("Survive Light", 26)
                }
            ),
            new Persona(
                name: "Shiisaa",
                arcana: "Hierophant",
                level: 21,
                stats: new PersonaStats(
                    strength: 18,
                    magic: 18,
                    endurance: 9,
                    agility: 14,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Balzac", 0),
                    new PersonaSkill("Rakukaja", 22),
                    new PersonaSkill("Zionga", 23),
                    new PersonaSkill("Silence Boost", 24),
                    new PersonaSkill("Resist Fire", 25),
                    new PersonaSkill("Null Rage", 26)
                }
            ),
            new Persona(
                name: "High Pixie",
                arcana: "Priestess",
                level: 22,
                stats: new PersonaStats(
                    strength: 10,
                    magic: 21,
                    endurance: 10,
                    agility: 19,
                    luck: 13
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Sukukaja", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Zionga", 24),
                    new PersonaSkill("Invigorate 1", 25),
                    new PersonaSkill("Dodge Fire", 26),
                    new PersonaSkill("Trafuri", 27)
                }
            ),
            new Persona(
                name: "King Frost",
                arcana: "Emperor",
                level: 22,
                stats: new PersonaStats(
                    strength: 11,
                    magic: 20,
                    endurance: 17,
                    agility: 13,
                    luck: 12
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Mabufu", 0),
                    new PersonaSkill("Ice Break", 0),
                    new PersonaSkill("Rakukaja", 23),
                    new PersonaSkill("Dodge Fire", 24),
                    new PersonaSkill("Ice Boost", 26),
                    new PersonaSkill("Null Fire", 27),
                    new PersonaSkill("Anima Freeze", 28)
                }
            ),
            new Persona(
                name: "Yomotsu-Ikusa",
                arcana: "Hanged Man",
                level: 22,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 16,
                    endurance: 18,
                    agility: 12,
                    luck: 10
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Cell Breaker", 0),
                    new PersonaSkill("Mabufu", 0),
                    new PersonaSkill("Enervate Boost", 24),
                    new PersonaSkill("Foul Breath", 25),
                    new PersonaSkill("Poison Mist", 26),
                    new PersonaSkill("Poison Boost", 27)
                }
            ),
            new Persona(
                name: "Rakshasa",
                arcana: "Strength",
                level: 23,
                stats: new PersonaStats(
                    strength: 19,
                    magic: 12,
                    endurance: 18,
                    agility: 14,
                    luck: 13
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Kill Rush", 0),
                    new PersonaSkill("Brain Shake", 0),
                    new PersonaSkill("Counter", 0),
                    new PersonaSkill("Gale Slash", 25),
                    new PersonaSkill("Auto-Tarukaja", 26),
                    new PersonaSkill("Dodge Physical", 27),
                    new PersonaSkill("Power Charge", 28)
                }
            ),
            new Persona(
                name: "Nigi Mitama",
                arcana: "Temperance",
                level: 23,
                stats: new PersonaStats(
                    strength: 15,
                    magic: 16,
                    endurance: 14,
                    agility: 15,
                    luck: 16
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Re Patra", 0),
                    new PersonaSkill("Recarm", 25),
                    new PersonaSkill("Invigorate 2", 26),
                    new PersonaSkill("Garula", 28),
                    new PersonaSkill("Resist Enervate", 29)
                }
            ),
            new Persona(
                name: "Matador",
                arcana: "Death",
                level: 24,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 10,
                    endurance: 16,
                    agility: 25,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudo", 0),
                    new PersonaSkill("Swift Strike", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Mudo Boost", 26),
                    new PersonaSkill("Rampage", 27),
                    new PersonaSkill("Auto-Sukukaja", 29),
                    new PersonaSkill("Survive Light", 30)
                }
            ),
            new Persona(
                name: "Narcissus",
                arcana: "Aeon",
                level: 24,
                stats: new PersonaStats(
                    strength: 13,
                    magic: 18,
                    endurance: 11,
                    agility: 16,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Weak,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Magaru", 0),
                    new PersonaSkill("Old One", 25),
                    new PersonaSkill("Resist Fire", 26),
                    new PersonaSkill("Anima Freeze", 27),
                    new PersonaSkill("Ailment Boost", 30)
                }
            ),
            new Persona(
                name: "Kaiwan",
                arcana: "Star",
                level: 24,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 23,
                    endurance: 14,
                    agility: 15,
                    luck: 11
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Weak,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Tetrakarn", 0),
                    new PersonaSkill("Cell Breaker", 0),
                    new PersonaSkill("Mamudo", 0),
                    new PersonaSkill("Stagnant Air", 26),
                    new PersonaSkill("Resist Light", 27),
                    new PersonaSkill("Life Drain", 28),
                    new PersonaSkill("Spirit Drain", 29)
                }
            ),
            new Persona(
                name: "Hua Po",
                arcana: "Magician",
                level: 25,
                stats: new PersonaStats(
                    strength: 14,
                    magic: 21,
                    endurance: 15,
                    agility: 17,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Re Patra", 0),
                    new PersonaSkill("Fire Break", 26),
                    new PersonaSkill("Makajam", 27),
                    new PersonaSkill("Dodge Ice", 29),
                    new PersonaSkill("Fire Boost", 30)
                }
            ),
            new Persona(
                name: "Queen Mab",
                arcana: "Lovers",
                level: 25,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 19,
                    endurance: 15,
                    agility: 17,
                    luck: 14
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Recarm", 26),
                    new PersonaSkill("Dodge Wind", 27),
                    new PersonaSkill("Mazionga", 29),
                    new PersonaSkill("Resist Confuse", 30)
                }
            ),
            new Persona(
                name: "Ares",
                arcana: "Chariot",
                level: 25,
                stats: new PersonaStats(
                    strength: 18,
                    magic: 15,
                    endurance: 20,
                    agility: 15,
                    luck: 14
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Gale Slash", 0),
                    new PersonaSkill("Counter", 0),
                    new PersonaSkill("Dodge Wind", 27),
                    new PersonaSkill("Rampage", 28),
                    new PersonaSkill("Dekaja", 29),
                    new PersonaSkill("Power Charge", 30)
                }
            ),
            new Persona(
                name: "Titania",
                arcana: "Empress",
                level: 26,
                stats: new PersonaStats(
                    strength: 12,
                    magic: 23,
                    endurance: 15,
                    agility: 19,
                    luck: 16
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Magaru", 0),
                    new PersonaSkill("Red Wall", 27),
                    new PersonaSkill("Garula", 29),
                    new PersonaSkill("Regenerate 2", 31),
                    new PersonaSkill("Mind Charge", 32)
                }
            ),
            new Persona(
                name: "Lamia",
                arcana: "Hermit",
                level: 26,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 23,
                    endurance: 12,
                    agility: 20,
                    luck: 14
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Poison Mist", 0),
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Nervundi", 0),
                    new PersonaSkill("Poison Boost", 28),
                    new PersonaSkill("Null Poison", 29),
                    new PersonaSkill("Soul Break", 30),
                    new PersonaSkill("Maragion", 32)
                }
            ),
            new Persona(
                name: "Power",
                arcana: "Justice",
                level: 27,
                stats: new PersonaStats(
                    strength: 21,
                    magic: 20,
                    endurance: 11,
                    agility: 17,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hama", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Mahama", 0),
                    new PersonaSkill("Zionga", 29),
                    new PersonaSkill("Power Slash", 30),
                    new PersonaSkill("Hama Boost", 31),
                    new PersonaSkill("Survive Dark", 32),
                    new PersonaSkill("Null Confuse", 33)
                }
            ),
            new Persona(
                name: "Take-Minakata",
                arcana: "Jester",
                level: 27,
                stats: new PersonaStats(
                    strength: 20,
                    magic: 20,
                    endurance: 22,
                    agility: 14,
                    luck: 12
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazio", 0),
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Survive Light", 29),
                    new PersonaSkill("Auto-Rakukaja", 30),
                    new PersonaSkill("Dekaja", 31),
                    new PersonaSkill("Dodge Physical", 33)
                }
            ),
            new Persona(
                name: "Makami",
                arcana: "Hanged Man",
                level: 27,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 21,
                    endurance: 13,
                    agility: 22,
                    luck: 16
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Sukunda", 0),
                    new PersonaSkill("Auto-Sukukaja", 29),
                    new PersonaSkill("Diarama", 30),
                    new PersonaSkill("Resist Mute", 31),
                    new PersonaSkill("Dodge Physical", 32),
                    new PersonaSkill("Resist Ice", 33)
                }
            ),
            new Persona(
                name: "Nozuchi",
                arcana: "Moon",
                level: 27,
                stats: new PersonaStats(
                    strength: 26,
                    magic: 13,
                    endurance: 19,
                    agility: 15,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Poison Mist", 0),
                    new PersonaSkill("Enervation", 0),
                    new PersonaSkill("Ailment Boost", 0),
                    new PersonaSkill("Zionga", 29),
                    new PersonaSkill("Rakukaja", 30),
                    new PersonaSkill("Null Poison", 31),
                    new PersonaSkill("Null Enervate", 32)
                }
            ),
            new Persona(
                name: "Kusi Mitama",
                arcana: "Strength",
                level: 28,
                stats: new PersonaStats(
                    strength: 18,
                    magic: 21,
                    endurance: 12,
                    agility: 19,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Soul Break", 0),
                    new PersonaSkill("Survive Light", 31),
                    new PersonaSkill("Survive Dark", 32),
                    new PersonaSkill("Traesto", 33),
                    new PersonaSkill("Exhaust Boost", 34)
                }
            ),
            new Persona(
                name: "Incubus",
                arcana: "Devil",
                level: 28,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 22,
                    endurance: 16,
                    agility: 19,
                    luck: 17
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Mind Slice", 0),
                    new PersonaSkill("Stagnant Air", 30),
                    new PersonaSkill("Spirit Drain", 32),
                    new PersonaSkill("Ghastly Wail", 33)
                }
            ),
            new Persona(
                name: "Ganga",
                arcana: "Priestess",
                level: 29,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 22,
                    endurance: 16,
                    agility: 19,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Mind Slice", 31),
                    new PersonaSkill("Confuse Boost", 32),
                    new PersonaSkill("Mediarama", 33),
                    new PersonaSkill("Evade Fire", 35)
                }
            ),
            new Persona(
                name: "Unicorn",
                arcana: "Hierophant",
                level: 29,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 22,
                    endurance: 19,
                    agility: 22,
                    luck: 14
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Mahama", 0),
                    new PersonaSkill("Nervundi", 0),
                    new PersonaSkill("Dekunda", 31),
                    new PersonaSkill("Trafuri", 32),
                    new PersonaSkill("Recarm", 33),
                    new PersonaSkill("Mazionga", 34)
                }
            ),
            new Persona(
                name: "Oni",
                arcana: "Strength",
                level: 30,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 12,
                    endurance: 26,
                    agility: 18,
                    luck: 16
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Fatal End", 0),
                    new PersonaSkill("Counter", 0),
                    new PersonaSkill("Cruel Attack", 0),
                    new PersonaSkill("Atom Smasher", 32),
                    new PersonaSkill("Resist Physical", 33),
                    new PersonaSkill("Endure", 34),
                    new PersonaSkill("Power Charge", 35)
                }
            ),
            new Persona(
                name: "Ose",
                arcana: "Fool",
                level: 31,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 12,
                    endurance: 20,
                    agility: 25,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Power Slash", 0),
                    new PersonaSkill("Atom Smasher", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Poison Mist", 33),
                    new PersonaSkill("Poison Boost", 34),
                    new PersonaSkill("Auto-Sukukaja", 35),
                    new PersonaSkill("Survive Light", 36)
                }
            ),
            new Persona(
                name: "Mithra",
                arcana: "Temperance",
                level: 31,
                stats: new PersonaStats(
                    strength: 22,
                    magic: 26,
                    endurance: 21,
                    agility: 16,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahama", 0),
                    new PersonaSkill("Seal Bomb", 0),
                    new PersonaSkill("Tetra Break", 33),
                    new PersonaSkill("Hamaon", 34),
                    new PersonaSkill("Dodge Elec", 35),
                    new PersonaSkill("Hama Boost", 36),
                    new PersonaSkill("Null Mute", 37)
                }
            ),
            new Persona(
                name: "Sati",
                arcana: "Aeon",
                level: 31,
                stats: new PersonaStats(
                    strength: 19,
                    magic: 27,
                    endurance: 20,
                    agility: 17,
                    luck: 17
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragi", 0),
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Energy Shower", 0),
                    new PersonaSkill("Diarama", 33),
                    new PersonaSkill("Trafuri", 34),
                    new PersonaSkill("Maragion", 36)
                }
            ),
            new Persona(
                name: "Gdon",
                arcana: "Sun",
                level: 31,
                stats: new PersonaStats(
                    strength: 27,
                    magic: 10,
                    endurance: 23,
                    agility: 22,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Maragi", 0),
                    new PersonaSkill("Fire Break", 0),
                    new PersonaSkill("Growth 2", 33),
                    new PersonaSkill("Maragion", 34),
                    new PersonaSkill("Fire Boost", 35),
                    new PersonaSkill("Evade Ice", 36)
                }
            ),
            new Persona(
                name: "Pyro Jack",
                arcana: "Magician",
                level: 32,
                stats: new PersonaStats(
                    strength: 16,
                    magic: 26,
                    endurance: 19,
                    agility: 22,
                    luck: 20
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Tarunda", 0),
                    new PersonaSkill("Marakukaja", 34),
                    new PersonaSkill("Maragion", 36),
                    new PersonaSkill("Auto-Rakukaja", 37),
                    new PersonaSkill("Resist Ice", 38)
                }
            ),
            new Persona(
                name: "Neko Shogun",
                arcana: "Star",
                level: 32,
                stats: new PersonaStats(
                    strength: 26,
                    magic: 20,
                    endurance: 19,
                    agility: 23,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Elec Boost", 0),
                    new PersonaSkill("Black Spot", 0),
                    new PersonaSkill("Mediarama", 34),
                    new PersonaSkill("Matarukaja", 35),
                    new PersonaSkill("Evade Wind", 36),
                    new PersonaSkill("Divine Grace", 37)
                }
            ),
            new Persona(
                name: "Undine",
                arcana: "Lovers",
                level: 33,
                stats: new PersonaStats(
                    strength: 21,
                    magic: 27,
                    endurance: 13,
                    agility: 26,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Posumudi", 0),
                    new PersonaSkill("Mabufula", 34),
                    new PersonaSkill("Mediarama", 36),
                    new PersonaSkill("Ice Boost", 37)
                }
            ),
            new Persona(
                name: "Virtue",
                arcana: "Justice",
                level: 33,
                stats: new PersonaStats(
                    strength: 22,
                    magic: 29,
                    endurance: 21,
                    agility: 19,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahama", 0),
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Posumudi", 0),
                    new PersonaSkill("Fatal End", 35),
                    new PersonaSkill("Blue Wall", 37),
                    new PersonaSkill("Hama Boost", 38),
                    new PersonaSkill("Resist Dark", 39)
                }
            ),
            new Persona(
                name: "Mothman",
                arcana: "Hermit",
                level: 33,
                stats: new PersonaStats(
                    strength: 20,
                    magic: 23,
                    endurance: 17,
                    agility: 28,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Valiant Dance", 0),
                    new PersonaSkill("Foul Breath", 35),
                    new PersonaSkill("Elec Break", 36),
                    new PersonaSkill("Mazionga", 37),
                    new PersonaSkill("Rage Boost", 38)
                }
            ),
            new Persona(
                name: "Gorgon",
                arcana: "Empress",
                level: 34,
                stats: new PersonaStats(
                    strength: 20,
                    magic: 21,
                    endurance: 25,
                    agility: 24,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Crazy Chain", 35),
                    new PersonaSkill("Null Confuse", 36),
                    new PersonaSkill("Mabufula", 38),
                    new PersonaSkill("Ice Boost", 39)
                }
            ),
            new Persona(
                name: "Setanta",
                arcana: "Emperor",
                level: 34,
                stats: new PersonaStats(
                    strength: 23,
                    magic: 21,
                    endurance: 25,
                    agility: 24,
                    luck: 16
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Fatal End", 0),
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Sharp Student", 0),
                    new PersonaSkill("Counterstrike", 36),
                    new PersonaSkill("Power Charge", 38),
                    new PersonaSkill("Auto-Maraku", 39),
                    new PersonaSkill("Null Fire", 40)
                }
            ),
            new Persona(
                name: "Pale Rider",
                arcana: "Jester",
                level: 34,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 24,
                    endurance: 21,
                    agility: 24,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudo", 0),
                    new PersonaSkill("Mind Slice", 0),
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Counterstrike", 35),
                    new PersonaSkill("Mudoon", 37),
                    new PersonaSkill("Survive Light", 39)
                }
            ),
            new Persona(
                name: "Yamata-No-Orochi",
                arcana: "Moon",
                level: 34,
                stats: new PersonaStats(
                    strength: 29,
                    magic: 21,
                    endurance: 26,
                    agility: 18,
                    luck: 15
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufula", 0),
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Red Wall", 0),
                    new PersonaSkill("Green Wall", 36),
                    new PersonaSkill("Resist Enervate", 38),
                    new PersonaSkill("Ice Boost", 39)
                }
            ),
            new Persona(
                name: "Fortuna",
                arcana: "Fortune",
                level: 35,
                stats: new PersonaStats(
                    strength: 19,
                    magic: 23,
                    endurance: 22,
                    agility: 26,
                    luck: 22
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Dodge Elec", 37),
                    new PersonaSkill("Magarula", 38),
                    new PersonaSkill("Auto-Sukukaja", 39),
                    new PersonaSkill("Wind Boost", 40)
                }
            ),
            new Persona(
                name: "Taotie",
                arcana: "Tower",
                level: 35,
                stats: new PersonaStats(
                    strength: 20,
                    magic: 27,
                    endurance: 30,
                    agility: 22,
                    luck: 13
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megido", 0),
                    new PersonaSkill("Mind Slice", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Confuse Boost", 37),
                    new PersonaSkill("Mind Charge", 38),
                    new PersonaSkill("Null Enervate", 40),
                    new PersonaSkill("Torrent Shot", 41)
                }
            ),
            new Persona(
                name: "Flauros",
                arcana: "Hierophant",
                level: 36,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 20,
                    endurance: 24,
                    agility: 20,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Fatal End", 0),
                    new PersonaSkill("Tarukaja", 0),
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Herculean Strike", 38),
                    new PersonaSkill("Apt Pupil", 39),
                    new PersonaSkill("Dodge Ice", 40),
                    new PersonaSkill("Crazy Chain", 41)
                }
            ),
            new Persona(
                name: "Samael",
                arcana: "Death",
                level: 36,
                stats: new PersonaStats(
                    strength: 24,
                    magic: 29,
                    endurance: 25,
                    agility: 19,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Matarunda", 0),
                    new PersonaSkill("Poison Mist", 0),
                    new PersonaSkill("Dekunda", 38),
                    new PersonaSkill("Megido", 39),
                    new PersonaSkill("Mudo Boost", 40),
                    new PersonaSkill("Survive Light", 41)
                }
            ),
            new Persona(
                name: "Parvati",
                arcana: "Priestess",
                level: 37,
                stats: new PersonaStats(
                    strength: 20,
                    magic: 29,
                    endurance: 17,
                    agility: 25,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Nervundi", 0),
                    new PersonaSkill("Mediarama", 39),
                    new PersonaSkill("Marakukaja", 40),
                    new PersonaSkill("Dodge Elec", 41),
                    new PersonaSkill("Divine Grace", 43)
                }
            ),
            new Persona(
                name: "Raja Naga",
                arcana: "Aeon",
                level: 37,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 26,
                    endurance: 24,
                    agility: 22,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Fatal End", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Matarukaja", 38),
                    new PersonaSkill("Torrent Shot", 39),
                    new PersonaSkill("Null Confuse", 40),
                    new PersonaSkill("Mazionga", 42),
                    new PersonaSkill("Confuse Boost", 43)
                }
            ),
            new Persona(
                name: "Pazuzu",
                arcana: "Devil",
                level: 37,
                stats: new PersonaStats(
                    strength: 27,
                    magic: 15,
                    endurance: 28,
                    agility: 29,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Reflect,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Stagnant Air", 39),
                    new PersonaSkill("Ailment Boost", 40),
                    new PersonaSkill("Navas Nebula", 41),
                    new PersonaSkill("Cool Breeze", 42)
                }
            ),
            new Persona(
                name: "Black Frost",
                arcana: "Fool",
                level: 38,
                stats: new PersonaStats(
                    strength: 23,
                    magic: 31,
                    endurance: 22,
                    agility: 23,
                    luck: 22
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Bufula", 0),
                    new PersonaSkill("Ice Boost", 0),
                    new PersonaSkill("Mind Charge", 40),
                    new PersonaSkill("Masukunda", 41),
                    new PersonaSkill("Fire Amp", 42),
                    new PersonaSkill("Agidyne", 43),
                    new PersonaSkill("Mudoon", 44)
                }
            ),
            new Persona(
                name: "Dominion",
                arcana: "Justice",
                level: 38,
                stats: new PersonaStats(
                    strength: 22,
                    magic: 32,
                    endurance: 25,
                    agility: 24,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Hama Boost", 40),
                    new PersonaSkill("Resist Exhaust", 41),
                    new PersonaSkill("Mazionga", 42),
                    new PersonaSkill("Survive Dark", 43),
                    new PersonaSkill("Null Dark", 44)
                }
            ),
            new Persona(
                name: "Dis",
                arcana: "Magician",
                level: 39,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 31,
                    endurance: 24,
                    agility: 26,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Dodge Ice", 41),
                    new PersonaSkill("Masukunda", 42),
                    new PersonaSkill("Agidyne", 43),
                    new PersonaSkill("Mind Charge", 44)
                }
            ),
            new Persona(
                name: "Orthrus",
                arcana: "Hanged Man",
                level: 39,
                stats: new PersonaStats(
                    strength: 34,
                    magic: 21,
                    endurance: 28,
                    agility: 23,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Black Spot", 0),
                    new PersonaSkill("Marakukaja", 41),
                    new PersonaSkill("Fire Boost", 42),
                    new PersonaSkill("Maragion", 44),
                    new PersonaSkill("Null Ice", 45)
                }
            ),
            new Persona(
                name: "Genbu",
                arcana: "Temperance",
                level: 40,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 27,
                    endurance: 39,
                    agility: 12,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufula", 0),
                    new PersonaSkill("Marakukaja", 0),
                    new PersonaSkill("Regenerate 2", 42),
                    new PersonaSkill("Makara Break", 43),
                    new PersonaSkill("Blue Wall", 44),
                    new PersonaSkill("Resist Physical", 45),
                    new PersonaSkill("Evade Elec", 46)
                }
            ),
            new Persona(
                name: "Loa",
                arcana: "Jester",
                level: 40,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 30,
                    endurance: 28,
                    agility: 23,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Life Drain", 0),
                    new PersonaSkill("Matarunda", 0),
                    new PersonaSkill("Survive Light", 42),
                    new PersonaSkill("Ziodyne", 43),
                    new PersonaSkill("Mudo Boost", 45),
                    new PersonaSkill("Tetraja", 47)
                }
            ),
            new Persona(
                name: "Yatagarasu",
                arcana: "Sun",
                level: 40,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 27,
                    endurance: 22,
                    agility: 31,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("Nervundi", 0),
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Null Fear", 43),
                    new PersonaSkill("Growth 2", 44),
                    new PersonaSkill("Diarahan", 45),
                    new PersonaSkill("Cool Breeze", 46)
                }
            ),
            new Persona(
                name: "Okuninushi",
                arcana: "Emperor",
                level: 41,
                stats: new PersonaStats(
                    strength: 29,
                    magic: 34,
                    endurance: 25,
                    agility: 20,
                    luck: 22
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Blade of Fury", 0),
                    new PersonaSkill("Counterstrike", 43),
                    new PersonaSkill("Mazionga", 44),
                    new PersonaSkill("Apt Pupil", 45),
                    new PersonaSkill("Elec Boost", 46),
                    new PersonaSkill("Null Wind", 47)
                }
            ),
            new Persona(
                name: "Hitokoto-Nushi",
                arcana: "Hermit",
                level: 41,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 33,
                    endurance: 30,
                    agility: 20,
                    luck: 19
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Auto-Sukukaja", 0),
                    new PersonaSkill("Poison Arrow", 0),
                    new PersonaSkill("Zionga", 43),
                    new PersonaSkill("Resist Fire", 45),
                    new PersonaSkill("Elec Boost", 46),
                    new PersonaSkill("Auto-Masuku", 47)
                }
            ),
            new Persona(
                name: "Alraune",
                arcana: "Moon",
                level: 41,
                stats: new PersonaStats(
                    strength: 17,
                    magic: 35,
                    endurance: 21,
                    agility: 29,
                    luck: 28
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Energy Shower", 0),
                    new PersonaSkill("Old One", 0),
                    new PersonaSkill("Makarakarn", 43),
                    new PersonaSkill("Green Wall", 44),
                    new PersonaSkill("Null Enervate", 45),
                    new PersonaSkill("Enervate Boost", 46)
                }
            ),
            new Persona(
                name: "Leanan Sidhe",
                arcana: "Lovers",
                level: 42,
                stats: new PersonaStats(
                    strength: 19,
                    magic: 33,
                    endurance: 26,
                    agility: 29,
                    luck: 36
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Tentarafoo", 43),
                    new PersonaSkill("Confuse Boost", 44),
                    new PersonaSkill("Energy Shower", 45),
                    new PersonaSkill("Samarecarm", 46),
                    new PersonaSkill("Divine Grace", 47)
                }
            ),
            new Persona(
                name: "Hanuman",
                arcana: "Strength",
                level: 42,
                stats: new PersonaStats(
                    strength: 31,
                    magic: 25,
                    endurance: 31,
                    agility: 21,
                    luck: 25
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mighty Swing", 0),
                    new PersonaSkill("Rakunda", 0),
                    new PersonaSkill("Recarm", 0),
                    new PersonaSkill("Blade of Fury", 44),
                    new PersonaSkill("Endure", 47),
                    new PersonaSkill("Power Charge", 48)
                }
            ),
            new Persona(
                name: "Triglav",
                arcana: "Chariot",
                level: 43,
                stats: new PersonaStats(
                    strength: 33,
                    magic: 23,
                    endurance: 27,
                    agility: 32,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Heat Wave", 0),
                    new PersonaSkill("Counterstrike", 0),
                    new PersonaSkill("Marakukaja", 45),
                    new PersonaSkill("Mustard Bomb", 46),
                    new PersonaSkill("Null Dizzy", 47),
                    new PersonaSkill("Blue Wall", 48),
                    new PersonaSkill("Power Charge", 49)
                }
            ),
            new Persona(
                name: "Fuu-Ki",
                arcana: "Star",
                level: 43,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 32,
                    endurance: 34,
                    agility: 27,
                    luck: 18
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Torrent Shot", 0),
                    new PersonaSkill("Counterstrike", 0),
                    new PersonaSkill("Evade Fire", 45),
                    new PersonaSkill("Apt Pupil", 46),
                    new PersonaSkill("Wind Boost", 47),
                    new PersonaSkill("Null Exhaust", 49)
                }
            ),
            new Persona(
                name: "Gabriel",
                arcana: "Empress",
                level: 44,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 34,
                    endurance: 22,
                    agility: 30,
                    luck: 25
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufula", 0),
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Energy Shower", 45),
                    new PersonaSkill("Survive Dark", 47),
                    new PersonaSkill("Heat Wave", 48),
                    new PersonaSkill("Divine Grace", 50)
                }
            ),
            new Persona(
                name: "Clotho",
                arcana: "Fortune",
                level: 44,
                stats: new PersonaStats(
                    strength: 22,
                    magic: 31,
                    endurance: 28,
                    agility: 26,
                    luck: 32
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Reflect,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Magarula", 0),
                    new PersonaSkill("Mutudi", 0),
                    new PersonaSkill("Navas Nebula", 45),
                    new PersonaSkill("Makarakarn", 47),
                    new PersonaSkill("Wind Boost", 48),
                    new PersonaSkill("Garudyne", 49),
                    new PersonaSkill("Null Enervate", 50)
                }
            ),
            new Persona(
                name: "Kushinada",
                arcana: "Aeon",
                level: 44,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 32,
                    endurance: 27,
                    agility: 24,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Matarukaja", 0),
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Red Wall", 0),
                    new PersonaSkill("Maragion", 46),
                    new PersonaSkill("Null Fire", 48),
                    new PersonaSkill("Makarakarn", 50)
                }
            ),
            new Persona(
                name: "Succubus",
                arcana: "Devil",
                level: 44,
                stats: new PersonaStats(
                    strength: 22,
                    magic: 33,
                    endurance: 28,
                    agility: 32,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Maragion", 46),
                    new PersonaSkill("Mudo Boost", 47),
                    new PersonaSkill("Spirit Drain", 48),
                    new PersonaSkill("Resist Light", 49),
                    new PersonaSkill("Invigorate 3", 50)
                }
            ),
            new Persona(
                name: "Thoth",
                arcana: "Emperor",
                level: 45,
                stats: new PersonaStats(
                    strength: 28,
                    magic: 43,
                    endurance: 23,
                    agility: 21,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazionga", 0),
                    new PersonaSkill("Mahama", 0),
                    new PersonaSkill("Megido", 0),
                    new PersonaSkill("Mediarama", 47),
                    new PersonaSkill("Growth 2", 48),
                    new PersonaSkill("Null Mute", 49),
                    new PersonaSkill("Ziodyne", 51)
                }
            ),
            new Persona(
                name: "Hokuto Seikun",
                arcana: "Hierophant",
                level: 45,
                stats: new PersonaStats(
                    strength: 29,
                    magic: 34,
                    endurance: 31,
                    agility: 26,
                    luck: 22
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Zionga", 0),
                    new PersonaSkill("Elec Boost", 0),
                    new PersonaSkill("Navas Nebula", 0),
                    new PersonaSkill("Blade of Fury", 47),
                    new PersonaSkill("Resist Exhaust", 48),
                    new PersonaSkill("Counterstrike", 50),
                    new PersonaSkill("Ziodyne", 51)
                }
            ),
            new Persona(
                name: "Decarabia",
                arcana: "Fool",
                level: 46,
                stats: new PersonaStats(
                    strength: 27,
                    magic: 36,
                    endurance: 25,
                    agility: 26,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Weak,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Matarunda", 0),
                    new PersonaSkill("Tetrakarn", 0),
                    new PersonaSkill("Evade Physical", 48),
                    new PersonaSkill("Megidola", 50),
                    new PersonaSkill("Fire Amp", 51),
                    new PersonaSkill("Resist Physical", 52)
                }
            ),
            new Persona(
                name: "Mot",
                arcana: "Death",
                level: 46,
                stats: new PersonaStats(
                    strength: 32,
                    magic: 38,
                    endurance: 30,
                    agility: 24,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Survive Light", 48),
                    new PersonaSkill("Ghastly Wail", 49),
                    new PersonaSkill("Mudo Boost", 50)
                }
            ),
            new Persona(
                name: "Cu Chulainn",
                arcana: "Tower",
                level: 46,
                stats: new PersonaStats(
                    strength: 40,
                    magic: 32,
                    endurance: 28,
                    agility: 25,
                    luck: 20
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Reflect,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Magarula", 0),
                    new PersonaSkill("Deathbound", 0),
                    new PersonaSkill("Matarukaja", 47),
                    new PersonaSkill("Mind Charge", 48),
                    new PersonaSkill("White Wall", 49),
                    new PersonaSkill("Endure Dark", 50),
                    new PersonaSkill("Garudyne", 51),
                    new PersonaSkill("Wind Amp", 53)
                }
            ),
            new Persona(
                name: "Rangda",
                arcana: "Magician",
                level: 47,
                stats: new PersonaStats(
                    strength: 24,
                    magic: 37,
                    endurance: 30,
                    agility: 25,
                    luck: 32
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Reflect,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Tentarafoo", 0),
                    new PersonaSkill("Agidyne", 49),
                    new PersonaSkill("Dodge Ice", 50),
                    new PersonaSkill("Mustard Bomb", 51),
                    new PersonaSkill("Repel Physical", 55)
                }
            ),
            new Persona(
                name: "Baphomet",
                arcana: "Jester",
                level: 47,
                stats: new PersonaStats(
                    strength: 25,
                    magic: 35,
                    endurance: 35,
                    agility: 26,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Ghastly Wail", 0),
                    new PersonaSkill("Ailment Boost", 49),
                    new PersonaSkill("Dodge Physical", 50),
                    new PersonaSkill("Mamudoon", 52),
                    new PersonaSkill("Mudo Boost", 53)
                }
            ),
            new Persona(
                name: "Seiryu",
                arcana: "Temperance",
                level: 47,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 31,
                    endurance: 33,
                    agility: 28,
                    luck: 26
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mazionga", 0),
                    new PersonaSkill("Matarunda", 0),
                    new PersonaSkill("Ziodyne", 49),
                    new PersonaSkill("Poison Mist", 50),
                    new PersonaSkill("Elec Break", 51),
                    new PersonaSkill("Elec Boost", 52),
                    new PersonaSkill("Resist Exhaust", 53)
                }
            ),
            new Persona(
                name: "Narasimha",
                arcana: "Sun",
                level: 47,
                stats: new PersonaStats(
                    strength: 29,
                    magic: 27,
                    endurance: 30,
                    agility: 35,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Tempest Slash", 0),
                    new PersonaSkill("Counterstrike", 48),
                    new PersonaSkill("Evade Wind", 49),
                    new PersonaSkill("Mahamaon", 51),
                    new PersonaSkill("Auto-Mataru", 53)
                }
            ),
            new Persona(
                name: "Kikuri-Hime",
                arcana: "Priestess",
                level: 48,
                stats: new PersonaStats(
                    strength: 26,
                    magic: 36,
                    endurance: 28,
                    agility: 31,
                    luck: 30
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Posumudi", 0),
                    new PersonaSkill("Agilao", 0),
                    new PersonaSkill("Samarecarm", 50),
                    new PersonaSkill("Diarahan", 52),
                    new PersonaSkill("Resist Dark", 53),
                    new PersonaSkill("Divine Grace", 54)
                }
            ),
            new Persona(
                name: "Kurama Tengu",
                arcana: "Hermit",
                level: 48,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 34,
                    endurance: 28,
                    agility: 38,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garula", 0),
                    new PersonaSkill("Marakunda", 0),
                    new PersonaSkill("Vicious Strike", 0),
                    new PersonaSkill("Growth 2", 50),
                    new PersonaSkill("Wind Boost", 51),
                    new PersonaSkill("Red Wall", 52),
                    new PersonaSkill("Resist Elec", 53)
                }
            ),
            new Persona(
                name: "Girimehkala",
                arcana: "Moon",
                level: 48,
                stats: new PersonaStats(
                    strength: 36,
                    magic: 35,
                    endurance: 23,
                    agility: 30,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Reflect,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Mighty Swing", 0),
                    new PersonaSkill("Poison Mist", 0),
                    new PersonaSkill("Mamudoon", 50),
                    new PersonaSkill("Blight", 51),
                    new PersonaSkill("Tetraja", 52),
                    new PersonaSkill("Endure Light", 53),
                    new PersonaSkill("Repel Physical", 56)
                }
            ),
            new Persona(
                name: "Throne",
                arcana: "Justice",
                level: 49,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 30,
                    endurance: 24,
                    agility: 37,
                    luck: 26
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Hama Boost", 0),
                    new PersonaSkill("Mind Charge", 51),
                    new PersonaSkill("Regenerate 2", 53),
                    new PersonaSkill("Resist Dark", 54),
                    new PersonaSkill("Endure Dark", 55)
                }
            ),
            new Persona(
                name: "Yatsufusa",
                arcana: "Hanged Man",
                level: 49,
                stats: new PersonaStats(
                    strength: 32,
                    magic: 33,
                    endurance: 27,
                    agility: 36,
                    luck: 26
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Reflect,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("Fire Boost", 0),
                    new PersonaSkill("Heat Wave", 51),
                    new PersonaSkill("Power Charge", 52),
                    new PersonaSkill("Dodge Physical", 53),
                    new PersonaSkill("Maragidyne", 54),
                    new PersonaSkill("Mind Charge", 55)
                }
            ),
            new Persona(
                name: "Kali",
                arcana: "Strength",
                level: 50,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 25,
                    endurance: 36,
                    agility: 35,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Deathbound", 52),
                    new PersonaSkill("Revolution", 53),
                    new PersonaSkill("High Counter", 54),
                    new PersonaSkill("Power Charge", 55)
                }
            ),
            new Persona(
                name: "Ganesha",
                arcana: "Star",
                level: 50,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 29,
                    endurance: 31,
                    agility: 27,
                    luck: 32
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Mustard Bomb", 0),
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Power Charge", 52),
                    new PersonaSkill("High Counter", 54),
                    new PersonaSkill("Endure", 55),
                    new PersonaSkill("Magarudyne", 56)
                }
            ),
            new Persona(
                name: "Pabilsag",
                arcana: "Emperor",
                level: 51,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 29,
                    endurance: 30,
                    agility: 33,
                    luck: 30
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Blight", 0),
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Stagnant Air", 53),
                    new PersonaSkill("Silence Boost", 54),
                    new PersonaSkill("Mudoon", 55),
                    new PersonaSkill("Arrow Rain", 56)
                }
            ),
            new Persona(
                name: "Quetzalcoatl",
                arcana: "Aeon",
                level: 51,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 31,
                    endurance: 31,
                    agility: 35,
                    luck: 33
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Magarula", 0),
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("Growth 2", 0),
                    new PersonaSkill("Garudyne", 52),
                    new PersonaSkill("Heat Wave", 53),
                    new PersonaSkill("Mahamaon", 55),
                    new PersonaSkill("Wind Amp", 57)
                }
            ),
            new Persona(
                name: "Lachesis",
                arcana: "Fortune",
                level: 51,
                stats: new PersonaStats(
                    strength: 31,
                    magic: 39,
                    endurance: 25,
                    agility: 34,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("Recarm", 53),
                    new PersonaSkill("Makara Break", 54),
                    new PersonaSkill("Absorb Wind", 55),
                    new PersonaSkill("Red Wall", 56),
                    new PersonaSkill("Resist Exhaust", 57)
                }
            ),
            new Persona(
                name: "Skadi",
                arcana: "Empress",
                level: 52,
                stats: new PersonaStats(
                    strength: 27,
                    magic: 37,
                    endurance: 32,
                    agility: 36,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufula", 0),
                    new PersonaSkill("Aeon Rain", 0),
                    new PersonaSkill("Bufudyne", 54),
                    new PersonaSkill("Ice Amp", 56),
                    new PersonaSkill("Repel Ice", 57),
                    new PersonaSkill("Repel Fire", 59),
                    new PersonaSkill("Spell Master", 60)
                }
            ),
            new Persona(
                name: "Cerberus",
                arcana: "Hierophant",
                level: 52,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 30,
                    endurance: 32,
                    agility: 35,
                    luck: 29
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Gigantic Fist", 0),
                    new PersonaSkill("Vicious Strike", 53),
                    new PersonaSkill("Maragidyne", 53),
                    new PersonaSkill("Regenerate 2", 55),
                    new PersonaSkill("Fire Amp", 57),
                    new PersonaSkill("Auto-Sukukaja", 58)
                }
            ),
            new Persona(
                name: "Raphael",
                arcana: "Lovers",
                level: 53,
                stats: new PersonaStats(
                    strength: 32,
                    magic: 38,
                    endurance: 24,
                    agility: 33,
                    luck: 39
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Reflect,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Megidola", 0),
                    new PersonaSkill("Masukukaja", 55),
                    new PersonaSkill("Amrita", 56),
                    new PersonaSkill("Null Dizzy", 57),
                    new PersonaSkill("Mediarahan", 59)
                }
            ),
            new Persona(
                name: "Lilith",
                arcana: "Devil",
                level: 53,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 43,
                    endurance: 30,
                    agility: 36,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Old One", 54),
                    new PersonaSkill("Maziodyne", 55),
                    new PersonaSkill("Elec Break", 56),
                    new PersonaSkill("Ailment Boost", 57)
                }
            ),
            new Persona(
                name: "Tam Lin",
                arcana: "Sun",
                level: 53,
                stats: new PersonaStats(
                    strength: 45,
                    magic: 31,
                    endurance: 34,
                    agility: 39,
                    luck: 25
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Deathbound", 0),
                    new PersonaSkill("High Counter", 0),
                    new PersonaSkill("Auto-Maraku", 54),
                    new PersonaSkill("Power Charge", 55),
                    new PersonaSkill("Elec Amp", 56),
                    new PersonaSkill("Evade Physical", 58),
                    new PersonaSkill("Enduring Soul", 59)
                }
            ),
            new Persona(
                name: "Kin-Ki",
                arcana: "Chariot",
                level: 54,
                stats: new PersonaStats(
                    strength: 41,
                    magic: 25,
                    endurance: 53,
                    agility: 23,
                    luck: 27
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Vile Assault", 0),
                    new PersonaSkill("High Counter", 0),
                    new PersonaSkill("Gigantic Fist", 56),
                    new PersonaSkill("Seal Bomb", 57),
                    new PersonaSkill("Revolution", 59),
                    new PersonaSkill("Power Charge", 60)
                }
            ),
            new Persona(
                name: "Suzaku",
                arcana: "Temperance",
                level: 54,
                stats: new PersonaStats(
                    strength: 30,
                    magic: 36,
                    endurance: 31,
                    agility: 42,
                    luck: 30
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Energy Shower", 0),
                    new PersonaSkill("Masukukaja", 55),
                    new PersonaSkill("Agidyne", 56),
                    new PersonaSkill("Resist Ice", 58),
                    new PersonaSkill("Fire Amp", 59),
                    new PersonaSkill("Auto-Masuku", 60)
                }
            ),
            new Persona(
                name: "Nidhoggr",
                arcana: "Hermit",
                level: 55,
                stats: new PersonaStats(
                    strength: 23,
                    magic: 41,
                    endurance: 35,
                    agility: 31,
                    luck: 42
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Ghastly Wail", 57),
                    new PersonaSkill("Bufudyne", 58),
                    new PersonaSkill("Stagnant Air", 59),
                    new PersonaSkill("Resist Physical", 60),
                    new PersonaSkill("Ice Boost", 61)
                }
            ),
            new Persona(
                name: "Kumbhanda",
                arcana: "Jester",
                level: 55,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 36,
                    endurance: 35,
                    agility: 44,
                    luck: 20
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Auto-Masuku", 0),
                    new PersonaSkill("Alertness", 56),
                    new PersonaSkill("Fire Amp", 58),
                    new PersonaSkill("Resist Elec", 59),
                    new PersonaSkill("Deathbound", 60),
                    new PersonaSkill("Tetraja", 61)
                }
            ),
            new Persona(
                name: "Abaddon",
                arcana: "Tower",
                level: 55,
                stats: new PersonaStats(
                    strength: 43,
                    magic: 27,
                    endurance: 50,
                    agility: 23,
                    luck: 29
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Old One", 0),
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Arrow Rain", 0),
                    new PersonaSkill("Agidyne", 56),
                    new PersonaSkill("Endure Light", 57),
                    new PersonaSkill("Tetra Break", 60),
                    new PersonaSkill("Null Physical", 62)
                }
            ),
            new Persona(
                name: "Shiki-Ouji",
                arcana: "Fool",
                level: 56,
                stats: new PersonaStats(
                    strength: 50,
                    magic: 29,
                    endurance: 31,
                    agility: 41,
                    luck: 24
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Navas Nebula", 0),
                    new PersonaSkill("Matarunda", 0),
                    new PersonaSkill("Revolution", 0),
                    new PersonaSkill("Apt Pupil", 58),
                    new PersonaSkill("Growth 2", 59),
                    new PersonaSkill("Null Physical", 62)
                }
            ),
            new Persona(
                name: "Taowu",
                arcana: "Hanged Man",
                level: 56,
                stats: new PersonaStats(
                    strength: 40,
                    magic: 37,
                    endurance: 31,
                    agility: 38,
                    luck: 29
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Aeon Rain", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Matarukaja", 0),
                    new PersonaSkill("Null Enervate", 58),
                    new PersonaSkill("Power Charge", 60),
                    new PersonaSkill("Evade Physical", 61),
                    new PersonaSkill("Absorb Fire", 62)
                }
            ),
            new Persona(
                name: "Garuda",
                arcana: "Star",
                level: 57,
                stats: new PersonaStats(
                    strength: 39,
                    magic: 33,
                    endurance: 28,
                    agility: 47,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Reflect,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarama", 0),
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Arrow Rain", 0),
                    new PersonaSkill("Amrita", 60),
                    new PersonaSkill("High Counter", 61),
                    new PersonaSkill("Repel Wind", 62),
                    new PersonaSkill("Auto-Sukukaja", 63)
                }
            ),
            new Persona(
                name: "Sui-Ki",
                arcana: "Moon",
                level: 57,
                stats: new PersonaStats(
                    strength: 42,
                    magic: 49,
                    endurance: 43,
                    agility: 33,
                    luck: 17
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Vicious Strike", 0),
                    new PersonaSkill("Regenerate 2", 59),
                    new PersonaSkill("Tetra Break", 60),
                    new PersonaSkill("Enduring Soul", 62)
                }
            ),
            new Persona(
                name: "Uriel",
                arcana: "Justice",
                level: 58,
                stats: new PersonaStats(
                    strength: 35,
                    magic: 42,
                    endurance: 37,
                    agility: 36,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragion", 0),
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("High Counter", 60),
                    new PersonaSkill("Agidyne", 61),
                    new PersonaSkill("Endure Dark", 62),
                    new PersonaSkill("Fire Amp", 63),
                    new PersonaSkill("Null Dark", 64)
                }
            ),
            new Persona(
                name: "Ananta",
                arcana: "Fortune",
                level: 58,
                stats: new PersonaStats(
                    strength: 43,
                    magic: 42,
                    endurance: 45,
                    agility: 28,
                    luck: 23
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufula", 0),
                    new PersonaSkill("White Wall", 0),
                    new PersonaSkill("Marakukaja", 59),
                    new PersonaSkill("Bufudyne", 61),
                    new PersonaSkill("Green Wall", 62),
                    new PersonaSkill("Invigorate 3", 63),
                    new PersonaSkill("Null Exhaust", 64)
                }
            ),
            new Persona(
                name: "Kingu",
                arcana: "Aeon",
                level: 58,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 44,
                    endurance: 38,
                    agility: 30,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Resistant
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Evade Fire", 0),
                    new PersonaSkill("Auto-Masuku", 0),
                    new PersonaSkill("Null Confuse", 59),
                    new PersonaSkill("Null Poison", 60),
                    new PersonaSkill("Vicious Strike", 62),
                    new PersonaSkill("Endure", 63)
                }
            ),
            new Persona(
                name: "White Rider",
                arcana: "Death",
                level: 58,
                stats: new PersonaStats(
                    strength: 49,
                    magic: 31,
                    endurance: 37,
                    agility: 40,
                    luck: 24
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Agidyne", 60),
                    new PersonaSkill("Evade Ice", 62),
                    new PersonaSkill("Mahamaon", 63),
                    new PersonaSkill("Mamudoon", 65),
                    new PersonaSkill("Hama Boost", 66),
                    new PersonaSkill("Mudo Boost", 67)
                }
            ),
            new Persona(
                name: "Hariti",
                arcana: "Priestess",
                level: 59,
                stats: new PersonaStats(
                    strength: 31,
                    magic: 47,
                    endurance: 33,
                    agility: 34,
                    luck: 39
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Marakukaja", 0),
                    new PersonaSkill("Mediarahan", 61),
                    new PersonaSkill("Arrow Rain", 62),
                    new PersonaSkill("Samarecarm", 64)
                }
            ),
            new Persona(
                name: "Anubis",
                arcana: "Judgement",
                level: 59,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 41,
                    endurance: 37,
                    agility: 37,
                    luck: 31
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Poison Arrow", 60),
                    new PersonaSkill("Mustard Bomb", 61),
                    new PersonaSkill("Megidola", 62),
                    new PersonaSkill("Mahamaon", 64),
                    new PersonaSkill("Hama Boost", 65)
                }
            ),
            new Persona(
                name: "Mother Harlot",
                arcana: "Empress",
                level: 60,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 47,
                    endurance: 37,
                    agility: 29,
                    luck: 36
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maziodyne", 0),
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Mudo Boost", 62),
                    new PersonaSkill("Foolish Whisper", 63),
                    new PersonaSkill("Resist Fire", 64),
                    new PersonaSkill("Ailment Boost", 65)
                }
            ),
            new Persona(
                name: "Daisoujou",
                arcana: "Hierophant",
                level: 60,
                stats: new PersonaStats(
                    strength: 34,
                    magic: 45,
                    endurance: 40,
                    agility: 30,
                    luck: 41
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Agidyne", 62),
                    new PersonaSkill("Endure Dark", 63),
                    new PersonaSkill("Mahamaon", 64),
                    new PersonaSkill("Hama Boost", 65),
                    new PersonaSkill("Samsara", 67)
                }
            ),
            new Persona(
                name: "Belphegor",
                arcana: "Devil",
                level: 61,
                stats: new PersonaStats(
                    strength: 40,
                    magic: 48,
                    endurance: 42,
                    agility: 39,
                    luck: 21
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Absorb,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maziodyne", 0),
                    new PersonaSkill("Evil Smile", 0),
                    new PersonaSkill("Marakunda", 63),
                    new PersonaSkill("Fear Boost", 64),
                    new PersonaSkill("Old One", 65),
                    new PersonaSkill("Enervate Boost", 66),
                    new PersonaSkill("Elec Amp", 67)
                }
            ),
            new Persona(
                name: "Jatayu",
                arcana: "Sun",
                level: 61,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 44,
                    endurance: 35,
                    agility: 48,
                    luck: 25
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Null Confuse", 0),
                    new PersonaSkill("Amrita", 62),
                    new PersonaSkill("Growth 3", 64),
                    new PersonaSkill("Repel Elec", 65),
                    new PersonaSkill("Magarudyne", 66)
                }
            ),
            new Persona(
                name: "Jinn",
                arcana: "Magician",
                level: 62,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 51,
                    endurance: 38,
                    agility: 39,
                    luck: 28
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Resist Physical", 65),
                    new PersonaSkill("Fire Boost", 66),
                    new PersonaSkill("Null Physical", 67),
                    new PersonaSkill("Valiant Dance", 68)
                }
            ),
            new Persona(
                name: "Chernobog",
                arcana: "Jester",
                level: 62,
                stats: new PersonaStats(
                    strength: 46,
                    magic: 47,
                    endurance: 32,
                    agility: 35,
                    luck: 33
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Rainy Death", 0),
                    new PersonaSkill("Tetra Break", 0),
                    new PersonaSkill("Myriad Arrows", 64),
                    new PersonaSkill("Resist Wind", 66),
                    new PersonaSkill("Megidola", 68),
                    new PersonaSkill("Invigorate 3", 69)
                }
            ),
            new Persona(
                name: "Byakko",
                arcana: "Temperance",
                level: 62,
                stats: new PersonaStats(
                    strength: 47,
                    magic: 32,
                    endurance: 35,
                    agility: 49,
                    luck: 30
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Deathbound", 0),
                    new PersonaSkill("High Counter", 0),
                    new PersonaSkill("Auto-Sukukaja", 64),
                    new PersonaSkill("Amrita", 66),
                    new PersonaSkill("Ice Amp", 67),
                    new PersonaSkill("Mabufudyne", 68)
                }
            ),
            new Persona(
                name: "Mara",
                arcana: "Tower",
                level: 62,
                stats: new PersonaStats(
                    strength: 44,
                    magic: 35,
                    endurance: 48,
                    agility: 36,
                    luck: 30
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Blight", 0),
                    new PersonaSkill("Power Charge", 63),
                    new PersonaSkill("Makarakarn", 64),
                    new PersonaSkill("Absorb Physical", 66),
                    new PersonaSkill("Fire Amp", 67)
                }
            ),
            new Persona(
                name: "Nebiros",
                arcana: "Hermit",
                level: 63,
                stats: new PersonaStats(
                    strength: 38,
                    magic: 47,
                    endurance: 39,
                    agility: 40,
                    luck: 32
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Dekaja", 0),
                    new PersonaSkill("Mind Charge", 65),
                    new PersonaSkill("Mudo Boost", 67),
                    new PersonaSkill("Null Light", 69),
                    new PersonaSkill("Spell Master", 70)
                }
            ),
            new Persona(
                name: "Siegfried",
                arcana: "Strength",
                level: 63,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 36,
                    endurance: 41,
                    agility: 38,
                    luck: 33
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Akasha Arts", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("High Counter", 65),
                    new PersonaSkill("Regenerate 3", 66),
                    new PersonaSkill("Rainy Death", 68),
                    new PersonaSkill("God's Hand", 70)
                }
            ),
            new Persona(
                name: "Loki",
                arcana: "Fool",
                level: 64,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 50,
                    endurance: 31,
                    agility: 47,
                    luck: 23
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Rakukaja", 0),
                    new PersonaSkill("Sharp Student", 0),
                    new PersonaSkill("Ice Amp", 66),
                    new PersonaSkill("High Counter", 67),
                    new PersonaSkill("Mabufudyne", 68),
                    new PersonaSkill("Null Fire", 69),
                    new PersonaSkill("Niflheim", 70)
                },
                ultimate: true
            ),
            new Persona(
                name: "Cybele",
                arcana: "Lovers",
                level: 64,
                stats: new PersonaStats(
                    strength: 41,
                    magic: 47,
                    endurance: 37,
                    agility: 39,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarama", 0),
                    new PersonaSkill("Vicious Strike", 0),
                    new PersonaSkill("Recarm", 0),
                    new PersonaSkill("Myriad Arrows", 67),
                    new PersonaSkill("Samarecarm", 68),
                    new PersonaSkill("Mediarahan", 70)
                }
            ),
            new Persona(
                name: "Barong",
                arcana: "Emperor",
                level: 65,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 44,
                    endurance: 40,
                    agility: 36,
                    luck: 34
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Poison Mist", 0),
                    new PersonaSkill("Me Patra", 0),
                    new PersonaSkill("Marakukaja", 67),
                    new PersonaSkill("Invigorate 2", 69),
                    new PersonaSkill("High Counter", 71),
                    new PersonaSkill("Maziodyne", 72)
                }
            ),
            new Persona(
                name: "Lakshmi",
                arcana: "Aeon",
                level: 65,
                stats: new PersonaStats(
                    strength: 36,
                    magic: 50,
                    endurance: 37,
                    agility: 38,
                    luck: 41
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Ice Break", 66),
                    new PersonaSkill("Null Dark", 68),
                    new PersonaSkill("Resist Fire", 70),
                    new PersonaSkill("Amrita", 71)
                }
            ),
            new Persona(
                name: "Thor",
                arcana: "Chariot",
                level: 65,
                stats: new PersonaStats(
                    strength: 43,
                    magic: 39,
                    endurance: 53,
                    agility: 32,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Absorb,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Deathbound", 0),
                    new PersonaSkill("High Counter", 0),
                    new PersonaSkill("Arms Master", 67),
                    new PersonaSkill("Maziodyne", 68),
                    new PersonaSkill("Null Physical", 69),
                    new PersonaSkill("Thunder Reign", 70)
                }
            ),
            new Persona(
                name: "Atropos",
                arcana: "Fortune",
                level: 65,
                stats: new PersonaStats(
                    strength: 36,
                    magic: 48,
                    endurance: 36,
                    agility: 37,
                    luck: 45
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Wind Boost", 0),
                    new PersonaSkill("Mind Charge", 67),
                    new PersonaSkill("Magarudyne", 68),
                    new PersonaSkill("Evade Fire", 69),
                    new PersonaSkill("Wind Amp", 70)
                }
            ),
            new Persona(
                name: "Melchizedek",
                arcana: "Justice",
                level: 66,
                stats: new PersonaStats(
                    strength: 51,
                    magic: 46,
                    endurance: 46,
                    agility: 34,
                    luck: 28
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarahan", 0),
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Akasha Arts", 0),
                    new PersonaSkill("Matarukaja", 68),
                    new PersonaSkill("Mahamaon", 69),
                    new PersonaSkill("God's Hand", 72)
                }
            ),
            new Persona(
                name: "Hell Biker",
                arcana: "Hanged Man",
                level: 66,
                stats: new PersonaStats(
                    strength: 49,
                    magic: 40,
                    endurance: 40,
                    agility: 48,
                    luck: 28
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Aeon Rain", 0),
                    new PersonaSkill("Endure", 68),
                    new PersonaSkill("Mudoon", 69),
                    new PersonaSkill("Maragidyne", 70),
                    new PersonaSkill("Absorb Fire", 71),
                    new PersonaSkill("Fire Amp", 73)
                }
            ),
            new Persona(
                name: "Kartikeya",
                arcana: "Star",
                level: 67,
                stats: new PersonaStats(
                    strength: 47,
                    magic: 39,
                    endurance: 40,
                    agility: 44,
                    luck: 38
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maziodyne", 0),
                    new PersonaSkill("Auto-Mataru", 0),
                    new PersonaSkill("High Counter", 68),
                    new PersonaSkill("Myriad Arrows", 69),
                    new PersonaSkill("Growth 2", 70),
                    new PersonaSkill("Primal Force", 75)
                }
            ),
            new Persona(
                name: "Trumpeter",
                arcana: "Judgement",
                level: 67,
                stats: new PersonaStats(
                    strength: 40,
                    magic: 47,
                    endurance: 39,
                    agility: 45,
                    luck: 37
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megidola", 0),
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Elec Amp", 0),
                    new PersonaSkill("Marakukaja", 68),
                    new PersonaSkill("Cool Breeze", 69),
                    new PersonaSkill("Megidolaon", 70),
                    new PersonaSkill("Debilitate", 73),
                    new PersonaSkill("Heat Riser", 74)
                }
            ),
            new Persona(
                name: "Belial",
                arcana: "Devil",
                level: 68,
                stats: new PersonaStats(
                    strength: 51,
                    magic: 31,
                    endurance: 48,
                    agility: 40,
                    luck: 41
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mudoon", 0),
                    new PersonaSkill("Myriad Arrows", 0),
                    new PersonaSkill("Agidyne", 69),
                    new PersonaSkill("Endure Light", 71),
                    new PersonaSkill("Fire Amp", 72),
                    new PersonaSkill("Maragidyne", 73)
                }
            ),
            new Persona(
                name: "Seth",
                arcana: "Moon",
                level: 68,
                stats: new PersonaStats(
                    strength: 46,
                    magic: 51,
                    endurance: 40,
                    agility: 39,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Reflect,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Magarudyne", 0),
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Wind Break", 71),
                    new PersonaSkill("Null Light", 72),
                    new PersonaSkill("Wind Amp", 73),
                    new PersonaSkill("Evade Elec", 74)
                }
            ),
            new Persona(
                name: "Seiten Taisei",
                arcana: "Jester",
                level: 68,
                stats: new PersonaStats(
                    strength: 47,
                    magic: 34,
                    endurance: 40,
                    agility: 48,
                    luck: 42
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Brave Blade", 0),
                    new PersonaSkill("Rebellion", 0),
                    new PersonaSkill("Evade Elec", 0),
                    new PersonaSkill("High Counter", 69),
                    new PersonaSkill("Arms Master", 71),
                    new PersonaSkill("Regenerate 3", 74),
                    new PersonaSkill("Vorpal Blade", 76)
                }
            ),
            new Persona(
                name: "Horus",
                arcana: "Sun",
                level: 68,
                stats: new PersonaStats(
                    strength: 45,
                    magic: 48,
                    endurance: 35,
                    agility: 45,
                    luck: 38
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Magarudyne", 0),
                    new PersonaSkill("Wind Amp", 70),
                    new PersonaSkill("Matarukaja", 71),
                    new PersonaSkill("Absorb Wind", 73)
                }
            ),
            new Persona(
                name: "Surt",
                arcana: "Magician",
                level: 69,
                stats: new PersonaStats(
                    strength: 41,
                    magic: 54,
                    endurance: 39,
                    agility: 40,
                    luck: 40
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Deathbound", 0),
                    new PersonaSkill("High Counter", 0),
                    new PersonaSkill("Maragidyne", 71),
                    new PersonaSkill("Ragnarok", 74),
                    new PersonaSkill("Fire Amp", 75),
                    new PersonaSkill("Null Ice", 76)
                }
            ),
            new Persona(
                name: "Yurlungur",
                arcana: "Temperance",
                level: 69,
                stats: new PersonaStats(
                    strength: 41,
                    magic: 50,
                    endurance: 45,
                    agility: 43,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Virus Wave", 0),
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Growth 3", 71),
                    new PersonaSkill("Mediarahan", 72),
                    new PersonaSkill("Samarecarm", 74),
                    new PersonaSkill("Repel Light", 75)
                }
            ),
            new Persona(
                name: "Masakado",
                arcana: "Tower",
                level: 69,
                stats: new PersonaStats(
                    strength: 51,
                    magic: 32,
                    endurance: 45,
                    agility: 46,
                    luck: 40
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Tempest Slash", 0),
                    new PersonaSkill("Myriad Arrows", 71),
                    new PersonaSkill("Hama Boost", 73),
                    new PersonaSkill("Arms Master", 74),
                    new PersonaSkill("Enduring Soul", 76)
                }
            ),
            new Persona(
                name: "Tzitzimitl",
                arcana: "Priestess",
                level: 70,
                stats: new PersonaStats(
                    strength: 46,
                    magic: 56,
                    endurance: 41,
                    agility: 39,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Virus Wave", 0),
                    new PersonaSkill("Mustard Bomb", 0),
                    new PersonaSkill("Silence Boost", 71),
                    new PersonaSkill("Dekaja", 72),
                    new PersonaSkill("Regenerate 3", 73),
                    new PersonaSkill("Maziodyne", 76),
                    new PersonaSkill("Repel Elec", 77)
                }
            ),
            new Persona(
                name: "Alilat",
                arcana: "Empress",
                level: 70,
                stats: new PersonaStats(
                    strength: 39,
                    magic: 48,
                    endurance: 49,
                    agility: 39,
                    luck: 42
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Regenerate 3", 72),
                    new PersonaSkill("Evade Physical", 73),
                    new PersonaSkill("Growth 2", 74),
                    new PersonaSkill("Auto-Maraku", 75)
                }
            ),
            new Persona(
                name: "Hachiman",
                arcana: "Hierophant",
                level: 70,
                stats: new PersonaStats(
                    strength: 33,
                    magic: 60,
                    endurance: 39,
                    agility: 38,
                    luck: 47
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maziodyne", 0),
                    new PersonaSkill("Makarakarn", 0),
                    new PersonaSkill("Matarukaja", 0),
                    new PersonaSkill("Elec Break", 72),
                    new PersonaSkill("Dekunda", 74),
                    new PersonaSkill("Revolution", 75)
                }
            ),
            new Persona(
                name: "Ishtar",
                arcana: "Lovers",
                level: 71,
                stats: new PersonaStats(
                    strength: 46,
                    magic: 44,
                    endurance: 33,
                    agility: 48,
                    luck: 49
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarahan", 0),
                    new PersonaSkill("Samarecarm", 0),
                    new PersonaSkill("Mutudi", 0),
                    new PersonaSkill("Maziodyne", 73),
                    new PersonaSkill("Amrita", 75),
                    new PersonaSkill("Spell Master", 76),
                    new PersonaSkill("Absorb Wind", 77),
                    new PersonaSkill("Salvation", 78)
                },
                ultimate: true
            ),
            new Persona(
                name: "Vasuki",
                arcana: "Hanged Man",
                level: 71,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 47,
                    endurance: 50,
                    agility: 340,
                    luck: 35
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Virus Wave", 0),
                    new PersonaSkill("Null Poison", 73),
                    new PersonaSkill("High Counter", 74),
                    new PersonaSkill("Evade Wind", 75),
                    new PersonaSkill("Mahamaon", 76),
                    new PersonaSkill("Ziodyne", 77)
                }
            ),
            new Persona(
                name: "Atavaka",
                arcana: "Chariot",
                level: 72,
                stats: new PersonaStats(
                    strength: 50,
                    magic: 41,
                    endurance: 43,
                    agility: 41,
                    luck: 48
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Amrita", 0),
                    new PersonaSkill("Brave Blade", 74),
                    new PersonaSkill("Megidolaon", 75),
                    new PersonaSkill("Mind Charge", 76),
                    new PersonaSkill("Arms Master", 79)
                }
            ),
            new Persona(
                name: "Norn",
                arcana: "Fortune",
                level: 72,
                stats: new PersonaStats(
                    strength: 42,
                    magic: 53,
                    endurance: 31,
                    agility: 48,
                    luck: 46
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Magarudyne", 0),
                    new PersonaSkill("Diarahan", 0),
                    new PersonaSkill("Auto-Masuku", 74),
                    new PersonaSkill("Invigorate 3", 75),
                    new PersonaSkill("Wind Amp", 76),
                    new PersonaSkill("Insta-Heal", 77),
                    new PersonaSkill("Debilitate", 79)
                },
                ultimate: true
            ),
            new Persona(
                name: "Alice",
                arcana: "Death",
                level: 72,
                stats: new PersonaStats(
                    strength: 39,
                    magic: 56,
                    endurance: 33,
                    agility: 45,
                    luck: 44
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Mudo Boost", 0),
                    new PersonaSkill("Dekunda", 0),
                    new PersonaSkill("Endure Light", 75),
                    new PersonaSkill("Megidola", 76),
                    new PersonaSkill("Mind Charge", 77),
                    new PersonaSkill("Die for Me!", 79)
                }
            ),
            new Persona(
                name: "Michael",
                arcana: "Judgement",
                level: 72,
                stats: new PersonaStats(
                    strength: 45,
                    magic: 42,
                    endurance: 43,
                    agility: 48,
                    luck: 45
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Vorpal Blade", 0),
                    new PersonaSkill("Megidola", 0),
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Megidolaon", 74),
                    new PersonaSkill("Mahamaon", 75),
                    new PersonaSkill("Repel Dark", 76),
                    new PersonaSkill("Heaven's Blade", 79)
                }
            ),
            new Persona(
                name: "Arahabaki",
                arcana: "Hermit",
                level: 73,
                stats: new PersonaStats(
                    strength: 50,
                    magic: 55,
                    endurance: 62,
                    agility: 37,
                    luck: 25
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Reflect,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Vicious Strike", 0),
                    new PersonaSkill("Auto-Maraku", 0),
                    new PersonaSkill("Null Fear", 0),
                    new PersonaSkill("Alertness", 74),
                    new PersonaSkill("Tetrakarn", 76),
                    new PersonaSkill("Repel Physical", 80)
                }
            ),
            new Persona(
                name: "Vishnu",
                arcana: "Temperance",
                level: 73,
                stats: new PersonaStats(
                    strength: 46,
                    magic: 52,
                    endurance: 34,
                    agility: 54,
                    luck: 43
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megidolaon", 0),
                    new PersonaSkill("Akasha Arts", 0),
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Regenerate 3", 75),
                    new PersonaSkill("God's Hand", 76),
                    new PersonaSkill("Power Charge", 78),
                    new PersonaSkill("Angelic Grace", 79)
                },
                ultimate: true
            ),
            new Persona(
                name: "Odin",
                arcana: "Emperor",
                level: 74,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 60,
                    endurance: 42,
                    agility: 39,
                    luck: 43
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Magarudyne", 0),
                    new PersonaSkill("Wind Amp", 76),
                    new PersonaSkill("Regenerate 3", 77),
                    new PersonaSkill("Maziodyne", 78),
                    new PersonaSkill("Mind Charge", 80),
                    new PersonaSkill("Panta Rhei", 81)
                },
                ultimate: true
            ),
            new Persona(
                name: "Kaguya",
                arcana: "Aeon",
                level: 74,
                stats: new PersonaStats(
                    strength: 37,
                    magic: 65,
                    endurance: 36,
                    agility: 44,
                    luck: 47
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Hamaon", 0),
                    new PersonaSkill("Mediarahan", 0),
                    new PersonaSkill("Fast Heal", 0),
                    new PersonaSkill("Tetraja", 75),
                    new PersonaSkill("Mahamaon", 77),
                    new PersonaSkill("Hama Boost", 78),
                    new PersonaSkill("Spell Master", 80)
                }
            ),
            new Persona(
                name: "Sraosha",
                arcana: "Justice",
                level: 74,
                stats: new PersonaStats(
                    strength: 57,
                    magic: 36,
                    endurance: 44,
                    agility: 62,
                    luck: 33
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Absorb,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Brave Blade", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Ziodyne", 76),
                    new PersonaSkill("Hama Boost", 78),
                    new PersonaSkill("Megidolaon", 80),
                    new PersonaSkill("Angelic Grace", 81)
                },
                ultimate: true
            ),
            new Persona(
                name: "Yoshitsune",
                arcana: "Tower",
                level: 75,
                stats: new PersonaStats(
                    strength: 52,
                    magic: 39,
                    endurance: 49,
                    agility: 61,
                    luck: 34
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Brave Blade", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Heat Riser", 77),
                    new PersonaSkill("Repel Elec", 78),
                    new PersonaSkill("Elec Amp", 79),
                    new PersonaSkill("Hassou Tobi", 83)
                }
            ),
            new Persona(
                name: "Saturnus",
                arcana: "Star",
                level: 75,
                stats: new PersonaStats(
                    strength: 50,
                    magic: 57,
                    endurance: 36,
                    agility: 43,
                    luck: 49
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Maragidyne", 0),
                    new PersonaSkill("Fire Amp", 0),
                    new PersonaSkill("Evade Ice", 77),
                    new PersonaSkill("Growth 3", 79),
                    new PersonaSkill("Spell Master", 81)
                }
            ),
            new Persona(
                name: "Kohryu",
                arcana: "Hierophant",
                level: 76,
                stats: new PersonaStats(
                    strength: 50,
                    magic: 53,
                    endurance: 54,
                    agility: 40,
                    luck: 38
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Mediarahan", 0),
                    new PersonaSkill("Samarecarm", 0),
                    new PersonaSkill("Maziodyne", 78),
                    new PersonaSkill("Mind Charge", 79),
                    new PersonaSkill("Elec Amp", 80),
                    new PersonaSkill("Spell Master", 82),
                    new PersonaSkill("Salvation", 83)
                },
                ultimate: true
            ),
            new Persona(
                name: "Satan",
                arcana: "Judgement",
                level: 76,
                stats: new PersonaStats(
                    strength: 45,
                    magic: 60,
                    endurance: 47,
                    agility: 40,
                    luck: 43
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megidolaon", 0),
                    new PersonaSkill("Maragidyne", 0),
                    new PersonaSkill("Regenerate 3", 77),
                    new PersonaSkill("Invigorate 3", 78),
                    new PersonaSkill("Endure Light", 80),
                    new PersonaSkill("Black Viper", 81),
                    new PersonaSkill("Null Wind", 82)
                }
            ),
            new Persona(
                name: "Baal Zebul",
                arcana: "Moon",
                level: 77,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 60,
                    endurance: 49,
                    agility: 40,
                    luck: 41
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Old One", 0),
                    new PersonaSkill("Tentarafoo", 78),
                    new PersonaSkill("Maziodyne", 79),
                    new PersonaSkill("Mudo Boost", 80),
                    new PersonaSkill("Stagnant Air", 82)
                }
            ),
            new Persona(
                name: "Suparna",
                arcana: "Sun",
                level: 77,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 52,
                    endurance: 45,
                    agility: 55,
                    luck: 38
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Makajam", 0),
                    new PersonaSkill("Evade Ice", 79),
                    new PersonaSkill("Wind Amp", 80),
                    new PersonaSkill("Magarudyne", 81),
                    new PersonaSkill("Evade Fire", 82),
                    new PersonaSkill("Elec Amp", 83)
                }
            ),
            new Persona(
                name: "Mada",
                arcana: "Magician",
                level: 78,
                stats: new PersonaStats(
                    strength: 45,
                    magic: 63,
                    endurance: 52,
                    agility: 38,
                    luck: 43
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Weak,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Fire Boost", 0),
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Maragidyne", 81),
                    new PersonaSkill("Evade Ice", 82),
                    new PersonaSkill("Ailment Boost", 83),
                    new PersonaSkill("Fire Amp", 84)
                },
                ultimate: true
            ),
            new Persona(
                name: "Mahakala",
                arcana: "Death",
                level: 78,
                stats: new PersonaStats(
                    strength: 58,
                    magic: 38,
                    endurance: 57,
                    agility: 49,
                    luck: 39
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Myriad Arrows", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Mind Charge", 80),
                    new PersonaSkill("Maragidyne", 82),
                    new PersonaSkill("Mamudoon", 83),
                    new PersonaSkill("Fire Amp", 84),
                    new PersonaSkill("Mudo Boost", 85)
                },
                ultimate: true
            ),
            new Persona(
                name: "Scathach",
                arcana: "Priestess",
                level: 79,
                stats: new PersonaStats(
                    strength: 54,
                    magic: 59,
                    endurance: 37,
                    agility: 49,
                    luck: 45
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Weak,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Garudyne", 0),
                    new PersonaSkill("Amrita", 81),
                    new PersonaSkill("Magarudyne", 82),
                    new PersonaSkill("Ice Amp", 83),
                    new PersonaSkill("Wind Amp", 84),
                    new PersonaSkill("Mind Charge", 85)
                },
                ultimate: true
            ),
            new Persona(
                name: "Isis",
                arcana: "Empress",
                level: 79,
                stats: new PersonaStats(
                    strength: 52,
                    magic: 48,
                    endurance: 42,
                    agility: 48,
                    luck: 54
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Reflect,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mediarahan", 0),
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Tetrakarn", 0),
                    new PersonaSkill("Cool Breeze", 80),
                    new PersonaSkill("Absorb Ice", 82),
                    new PersonaSkill("Mabufudyne", 83),
                    new PersonaSkill("Salvation", 85),
                    new PersonaSkill("Null Elec", 86)
                },
                ultimate: true
            ),
            new Persona(
                name: "Futsunushi",
                arcana: "Chariot",
                level: 80,
                stats: new PersonaStats(
                    strength: 59,
                    magic: 38,
                    endurance: 61,
                    agility: 44,
                    luck: 45
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Null,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Primal Force", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("Matarukaja", 0),
                    new PersonaSkill("Apt Pupil", 82),
                    new PersonaSkill("Null Dizzy", 83),
                    new PersonaSkill("Ali Dance", 84),
                    new PersonaSkill("Arms Master", 85),
                    new PersonaSkill("Firm Stance", 86)
                },
                ultimate: true
            ),
            new Persona(
                name: "Shiva",
                arcana: "Tower",
                level: 80,
                stats: new PersonaStats(
                    strength: 59,
                    magic: 48,
                    endurance: 44,
                    agility: 54,
                    luck: 42
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Absorb,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Magarudyne", 0),
                    new PersonaSkill("Enduring Soul", 0),
                    new PersonaSkill("Maziodyne", 82),
                    new PersonaSkill("Spell Master", 83),
                    new PersonaSkill("Megidolaon", 84),
                    new PersonaSkill("Pralaya", 87)
                },
                ultimate: true
            ),
            new Persona(
                name: "Beelzebub",
                arcana: "Devil",
                level: 81,
                stats: new PersonaStats(
                    strength: 48,
                    magic: 60,
                    endurance: 49,
                    agility: 40,
                    luck: 41
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Absorb,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Reflect,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Reflect
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mabufudyne", 0),
                    new PersonaSkill("Mamudoon", 0),
                    new PersonaSkill("Old One", 0),
                    new PersonaSkill("Tentarafoo", 78),
                    new PersonaSkill("Maziodyne", 79),
                    new PersonaSkill("Mudo Boost", 80),
                    new PersonaSkill("Stagnant Air", 82)
                },
                ultimate: true
            ),
            new Persona(
                name: "Ongyo-Ki",
                arcana: "Hermit",
                level: 82,
                stats: new PersonaStats(
                    strength: 59,
                    magic: 64,
                    endurance: 59,
                    agility: 47,
                    luck: 24
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.Absorb,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Foolish Whisper", 0),
                    new PersonaSkill("Ziodyne", 0),
                    new PersonaSkill("Masukukaja", 0),
                    new PersonaSkill("Ailment Boost", 84),
                    new PersonaSkill("Elec Amp", 85),
                    new PersonaSkill("Revolution", 86),
                    new PersonaSkill("Firm Stance", 87)
                },
                ultimate: true
            ),
            new Persona(
                name: "Attis",
                arcana: "Hanged Man",
                level: 82,
                stats: new PersonaStats(
                    strength: 51,
                    magic: 56,
                    endurance: 56,
                    agility: 50,
                    luck: 40
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Reflect,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Agidyne", 0),
                    new PersonaSkill("Amrita", 0),
                    new PersonaSkill("Marakukaja", 0),
                    new PersonaSkill("Enduring Soul", 84),
                    new PersonaSkill("Samarecarm", 86),
                    new PersonaSkill("Maragidyne", 87),
                    new PersonaSkill("Mamudoon", 88)
                },
                ultimate: true
            ),
            new Persona(
                name: "Metatron",
                arcana: "Judgement",
                level: 83,
                stats: new PersonaStats(
                    strength: 54,
                    magic: 55,
                    endurance: 53,
                    agility: 46,
                    luck: 48
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Heaven's Blade", 0),
                    new PersonaSkill("Megidolaon", 86),
                    new PersonaSkill("Repel Ice", 87),
                    new PersonaSkill("Repel Elec", 88),
                    new PersonaSkill("Repel Fire", 89)
                }
            ),
            new Persona(
                name: "Sandalphon",
                arcana: "Moon",
                level: 84,
                stats: new PersonaStats(
                    strength: 56,
                    magic: 61,
                    endurance: 46,
                    agility: 47,
                    luck: 49
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Null,
                    light: ElementAffinity.Reflect,
                    darkness: ElementAffinity.Weak
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Mahamaon", 0),
                    new PersonaSkill("Samarecarm", 0),
                    new PersonaSkill("Amrita", 0),
                    new PersonaSkill("Angelic Grace", 87),
                    new PersonaSkill("Agneyastra", 88),
                    new PersonaSkill("Endure Dark", 89),
                    new PersonaSkill("Repel Dark", 90)
                },
                ultimate: true
            ),
            new Persona(
                name: "Asura",
                arcana: "Sun",
                level: 86,
                stats: new PersonaStats(
                    strength: 59,
                    magic: 57,
                    endurance: 51,
                    agility: 50,
                    luck: 48
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragidyne", 0),
                    new PersonaSkill("Primal Force", 0),
                    new PersonaSkill("Marakukaja", 0),
                    new PersonaSkill("Mahamaon", 88),
                    new PersonaSkill("High Counter", 89),
                    new PersonaSkill("Spell Master", 90),
                    new PersonaSkill("Unshaken Will", 92)
                },
                ultimate: true
            ),
            new Persona(
                name: "Helel",
                arcana: "Star",
                level: 87,
                stats: new PersonaStats(
                    strength: 56,
                    magic: 57,
                    endurance: 56,
                    agility: 49,
                    luck: 50
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Null,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.Weak,
                    light: ElementAffinity.Null,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megidolaon", 0),
                    new PersonaSkill("Maragidyne", 0),
                    new PersonaSkill("God's Hand", 0),
                    new PersonaSkill("Salvation", 88),
                    new PersonaSkill("Insta-Heal", 90),
                    new PersonaSkill("Repel Wind", 91),
                    new PersonaSkill("Arms Master", 92),
                    new PersonaSkill("Morning Star", 94)
                },
                ultimate: true
            ),
            new Persona(
                name: "Zaou Gongen",
                arcana: "Strength",
                level: 90,
                stats: new PersonaStats(
                    strength: 61,
                    magic: 48,
                    endurance: 71,
                    agility: 47,
                    luck: 50
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.None,
                    fire: ElementAffinity.Reflect,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.Weak,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Maragidyne", 0),
                    new PersonaSkill("Power Charge", 0),
                    new PersonaSkill("God's Hand", 0),
                    new PersonaSkill("Anima Freeze", 92),
                    new PersonaSkill("Evade Physical", 93),
                    new PersonaSkill("Enduring Soul", 94),
                    new PersonaSkill("Fire Amp", 95),
                    new PersonaSkill("Vorpal Blade", 96)
                },
                ultimate: true
            ),
            new Persona(
                name: "Ardha",
                arcana: "Judgement",
                level: 90,
                stats: new PersonaStats(
                    strength: 62,
                    magic: 52,
                    endurance: 64,
                    agility: 41,
                    luck: 58
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.Null,
                    electricity: ElementAffinity.Null,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Primal Force", 0),
                    new PersonaSkill("God's Hand", 0),
                    new PersonaSkill("Megidolaon", 91),
                    new PersonaSkill("Null Dizzy", 92),
                    new PersonaSkill("Auto-Rakukaja", 93),
                    new PersonaSkill("Mediarahan", 94),
                    new PersonaSkill("Angelic Grace", 95),
                    new PersonaSkill("Null Physical", 96)
                }
            ),
            new Persona(
                name: "Izanagi-No-Okami",
                arcana: "World",
                level: 91,
                stats: new PersonaStats(
                    strength: 80,
                    magic: 80,
                    endurance: 80,
                    agility: 80,
                    luck: 80
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.Resistant,
                    ice: ElementAffinity.Resistant,
                    electricity: ElementAffinity.Resistant,
                    wind: ElementAffinity.Resistant,
                    light: ElementAffinity.None,
                    darkness: ElementAffinity.None
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Megidolaon", 0),
                    new PersonaSkill("Victory Cry", 0),
                    new PersonaSkill("Angelic Grace", 0),
                    new PersonaSkill("Mind Charge", 0),
                    new PersonaSkill("Agidyne", 92),
                    new PersonaSkill("Bufudyne", 93),
                    new PersonaSkill("Ziodyne", 94),
                    new PersonaSkill("Garudyne", 95),
                    new PersonaSkill("Fire Amp", 96),
                    new PersonaSkill("Ice Amp", 97),
                    new PersonaSkill("Elec Amp", 98),
                    new PersonaSkill("Wind Amp", 99)
                },
                newGame: true
            ),
            new Persona(
                name: "Lucifer",
                arcana: "Judgement",
                level: 93,
                stats: new PersonaStats(
                    strength: 62,
                    magic: 69,
                    endurance: 61,
                    agility: 52,
                    luck: 51
                ),
                elements: new PersonaElements(
                    physical: ElementAffinity.Resistant,
                    fire: ElementAffinity.None,
                    ice: ElementAffinity.None,
                    electricity: ElementAffinity.None,
                    wind: ElementAffinity.None,
                    light: ElementAffinity.Weak,
                    darkness: ElementAffinity.Null
                ),
                new List<PersonaSkill> {
                    new PersonaSkill("Bufudyne", 0),
                    new PersonaSkill("Brave Blade", 0),
                    new PersonaSkill("Mind Charge", 0),
                    new PersonaSkill("Ice Amp", 94),
                    new PersonaSkill("Spell Master", 95),
                    new PersonaSkill("Repel Light", 96),
                    new PersonaSkill("Absorb Elec", 98),
                    new PersonaSkill("Victory Cry", 99)
                },
                ultimate: true
            )
        };
    }
}
