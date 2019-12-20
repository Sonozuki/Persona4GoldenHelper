using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Context
{
    public class SkillContext
    {
        public List<Skill> Skills { get; set; } = new List<Skill>
        {
            new Skill(
                name: "Absorb Elec",
                effect: "Absorbs damage from Elec attacks. (Overwrites Resist/Null/Repel Elec)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lucifer", 98, true)
                }
            ),
            new Skill(
                name: "Absorb Fire",
                effect: "Absorbs damage from Fire attacks. (Overwrites Resist/Null/Repel Fire)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Taowu", 62),
                    new SkillPersona("Hell Biker", 71)
                }
            ),
            new Skill(
                name: "Absorb Ice",
                effect: "Absorbs damage from Ice attacks. (Overwrites Resist/Null/Repel Ice)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Isis", 82, true)
                }
            ),
            new Skill(
                name: "Absorb Physical",
                effect: "Absorbs damage from Phys attacks. (Overwrites Resist/Null/Repel Phys)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mara", 66)
                }
            ),
            new Skill(
                name: "Absorb Wind",
                effect: "Absorbs damage from Wind attacks. (Overwrites Resist/Null/Repel Wind)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lachesis", 55),
                    new SkillPersona("Horus", 73),
                    new SkillPersona("Ishtar", 77, true)
                }
            ),
            new Skill(
                name: "Aeon Rain",
                effect: "Deals medium Phys damage to all foes 1x to 3x.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Skadi", 0),
                    new SkillPersona("Taowu", 0),
                    new SkillPersona("Hell Biker", 0)
                }
            ),
            new Skill(
                name: "Agi",
                effect: "Deals light Fire damage to 1 foe.",
                cost: "4 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ukobach", 0),
                    new SkillPersona("Orobas", 0),
                    new SkillPersona("Senri", 0),
                    new SkillPersona("Eligor", 0)
                }
            ),
            new Skill(
                name: "Agidyne",
                effect: "Deals heavy Fire damage to 1 foe.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Decarabia", 0),
                    new SkillPersona("Throne", 0),
                    new SkillPersona("Yatsufusa", 0),
                    new SkillPersona("Cerberus", 0),
                    new SkillPersona("Kumbhanda", 0),
                    new SkillPersona("Jinn", 0),
                    new SkillPersona("Mara", 0),
                    new SkillPersona("Nebiros", 0),
                    new SkillPersona("Hell Biker", 0),
                    new SkillPersona("Surt", 0),
                    new SkillPersona("Saturnus", 0),
                    new SkillPersona("Mada", 0, true),
                    new SkillPersona("Mahakala", 0, true),
                    new SkillPersona("Attis", 0, true),
                    new SkillPersona("Black Frost", 43),
                    new SkillPersona("Dis", 43),
                    new SkillPersona("Rangda", 49),
                    new SkillPersona("Suzaku", 56),
                    new SkillPersona("Abaddon", 56),
                    new SkillPersona("White Rider", 60),
                    new SkillPersona("Uriel", 61),
                    new SkillPersona("Daisoujou", 62),
                    new SkillPersona("Belial", 69),
                    new SkillPersona("Izanagi-No-Okami", 92, false, true)
                }
            ),
            new Skill(
                name: "Agilao",
                effect: "Deals medium Fire damage to 1 foe.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hua Po", 0),
                    new SkillPersona("Lamia", 0),
                    new SkillPersona("Makami", 0),
                    new SkillPersona("Incubus", 0),
                    new SkillPersona("Sati", 0),
                    new SkillPersona("Gdon", 0),
                    new SkillPersona("Pyro Jack", 0),
                    new SkillPersona("Flauros", 0),
                    new SkillPersona("Orthrus", 0),
                    new SkillPersona("Yatagarasu", 0),
                    new SkillPersona("Succubus", 0),
                    new SkillPersona("Kikuri-Hime", 0),
                    new SkillPersona("Ippon-Datara", 20)
                }
            ),
            new Skill(
                name: "Agneyastra",
                effect: "Deals heavy Phys damage to all foes 1x to 3x.",
                cost: "24% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sandalphon", 88, true)
                }
            ),
            new Skill(
                name: "Ailment Boost",
                effect: "All status ailment attacks are 1.5 times more effective.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nozuchi", 0),
                    new SkillPersona("Narcissus", 30),
                    new SkillPersona("Pazuzu", 40),
                    new SkillPersona("Baphomet", 49),
                    new SkillPersona("Lilith", 57),
                    new SkillPersona("Mother Harlot", 65),
                    new SkillPersona("Mada", 83, true),
                    new SkillPersona("Ongyo-Ki", 84, true)
                }
            ),
            new Skill(
                name: "Akasha Arts",
                effect: "Deals heavy Phys damage to all foes 1x to 2x.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Siegfried", 0),
                    new SkillPersona("Melchizedek", 0),
                    new SkillPersona("Vishnu", 0, true)
                }
            ),
            new Skill(
                name: "Alertness",
                effect: "Lowers odds of being taken by surprise. (Decreases enemy advantage)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Anzu", 0),
                    new SkillPersona("Saki Mitama", 13),
                    new SkillPersona("Kumbhanda", 56),
                    new SkillPersona("Arahabaki", 74)
                }
            ),
            new Skill(
                name: "Ali Dance",
                effect: "The Hit rate of an attacking unit is reduced by half.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Futsunushi", 84, true)
                }
            ),
            new Skill(
                name: "Amrita",
                effect: "Cures all ailments except Down and Death (party).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Atavaka", 0),
                    new SkillPersona("Attis", 0, true),
                    new SkillPersona("Sandalphon", 0, true),
                    new SkillPersona("Raphael", 56),
                    new SkillPersona("Garuda", 60),
                    new SkillPersona("Jatayu", 62),
                    new SkillPersona("Byakko", 66),
                    new SkillPersona("Lakshmi", 71),
                    new SkillPersona("Ishtar", 75, true),
                    new SkillPersona("Scathach", 81, true)
                }
            ),
            new Skill(
                name: "Angelic Grace",
                effect: "Doubles evasion rate against all attacks but Light/Darkness/Almighty.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi-No-Okami", 0, false, true),
                    new SkillPersona("Vishnu", 79, true),
                    new SkillPersona("Sraosha", 81, true),
                    new SkillPersona("Sandalphon", 87, true),
                    new SkillPersona("Ardha", 95)
                }
            ),
            new Skill(
                name: "Anima Freeze",
                effect: "Exhausts to all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Narcissus", 27),
                    new SkillPersona("King Frost", 28),
                    new SkillPersona("Zaou Gongen", 92, true)
                }
            ),
            new Skill(
                name: "Apt Pupil",
                effect: "Increases user's Critical Rate.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Flauros", 39),
                    new SkillPersona("Okuninushi", 45),
                    new SkillPersona("Fuu-Ki", 46),
                    new SkillPersona("Shiki-Ouji", 58),
                    new SkillPersona("Futsunushi", 82, true)
                }
            ),
            new Skill(
                name: "Arm Chopper",
                effect: "Deals light Phys damage to 1 foe with a chance of Fear.",
                cost: "9% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Oberon", 0),
                    new SkillPersona("Yaksini", 0),
                    new SkillPersona("Valkyrie", 11),
                    new SkillPersona("Eligor", 14)
                }
            ),
            new Skill(
                name: "Arms Master",
                effect: "Halves HP cost for physical skills.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Thor", 67),
                    new SkillPersona("Seiten Taisei", 71),
                    new SkillPersona("Masakado", 74),
                    new SkillPersona("Atavaka", 79),
                    new SkillPersona("Futsunushi", 85, true),
                    new SkillPersona("Helel", 92, true)
                }
            ),
            new Skill(
                name: "Arrow Rain",
                effect: "Deals heavy Phys damage to all foes 2x.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Abaddon", 0),
                    new SkillPersona("Garuda", 0),
                    new SkillPersona("Pabilsag", 56),
                    new SkillPersona("Hariti", 62)
                }
            ),
            new Skill(
                name: "Assault Dive",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "10% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ara Mitama", 0)
                }
            ),
            new Skill(
                name: "Atom Smasher",
                effect: "Deals medium Phys damage to all foes 1x to 2x with a chance of Fear.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ose", 0),
                    new SkillPersona("Oni", 32)
                }
            ),
            new Skill(
                name: "Auto-Maraku",
                effect: "Party begins the battle with Marakukaja. (Overwrites Auto-Rakukaja)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Arahabaki", 0),
                    new SkillPersona("Setanta", 39),
                    new SkillPersona("Tam Lin", 54),
                    new SkillPersona("Alilat", 75)
                }
            ),
            new Skill(
                name: "Auto-Masuku",
                effect: "Party begins the battle with Masukukaja. (Overwrites Auto-Sukukaja)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kumbhanda", 0),
                    new SkillPersona("Kingu", 0),
                    new SkillPersona("Hitokoto-Nushi", 47),
                    new SkillPersona("Suzaku", 60),
                    new SkillPersona("Norn", 74, true)
                }
            ),
            new Skill(
                name: "Auto-Mataru",
                effect: "Party begins the battle with Matarukaja. (Overwrites Auto-Tarukaja)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kartikeya", 0),
                    new SkillPersona("Narasimha", 53)
                }
            ),
            new Skill(
                name: "Auto-Rakukaja",
                effect: "Automatic Rakukaja at the start of battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ame No Uzume", 23),
                    new SkillPersona("Take-Minakata", 30),
                    new SkillPersona("Pyro Jack", 37),
                    new SkillPersona("Ardha", 93)
                }
            ),
            new Skill(
                name: "Auto-Sukukaja",
                effect: "Automatic Sukukaja at the start of battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hitokoto-Nushi", 0),
                    new SkillPersona("Anzu", 20),
                    new SkillPersona("Matador", 29),
                    new SkillPersona("Makami", 29),
                    new SkillPersona("Ose", 35),
                    new SkillPersona("Fortuna", 39),
                    new SkillPersona("Cerberus", 58),
                    new SkillPersona("Garuda", 63),
                    new SkillPersona("Byakko", 64)
                }
            ),
            new Skill(
                name: "Auto-Tarukaja",
                effect: "Automatic Tarukaja at the start of battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Gurr", 0),
                    new SkillPersona("Yaksini", 23),
                    new SkillPersona("Rakshasa", 26)
                }
            ),
            new Skill(
                name: "Balzac",
                effect: "Enrages 1 foe (40% chance). (Doubles STR, uncontrollable, auto attacks with weapon)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Anzu", 0),
                    new SkillPersona("Shiisaa", 0)
                }
            ),
            new Skill(
                name: "Bash",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "6% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Slime", 0),
                    new SkillPersona("Nata Taishi", 0),
                    new SkillPersona("Ghoul", 0)
                }
            ),
            new Skill(
                name: "Black Spot",
                effect: "Deals medium Phys damage to 1 foe.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Neko Shogun", 0),
                    new SkillPersona("Orthrus", 0)
                }
            ),
            new Skill(
                name: "Black Viper",
                effect: "Deals massive Almighty damage to 1 foe.",
                cost: "64 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Satan", 81)
                }
            ),
            new Skill(
                name: "Blade of Fury",
                effect: "Deals medium Phys damage to all foes 2x to 4x.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Okuninushi", 0),
                    new SkillPersona("Hanuman", 44),
                    new SkillPersona("Hokuto Seikun", 47)
                }
            ),
            new Skill(
                name: "Blight",
                effect: "Deals heavy Phys damage to all foes with a chance of Poison.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Pabilsag", 0),
                    new SkillPersona("Mara", 0),
                    new SkillPersona("Girimehkala", 51)
                }
            ),
            new Skill(
                name: "Blue Wall",
                effect: "Add Elec resistance to 1 ally (for 3 turns).",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ara Mitama", 22),
                    new SkillPersona("Andras", 22),
                    new SkillPersona("Virtue", 37),
                    new SkillPersona("Genbu", 44),
                    new SkillPersona("Triglav", 48)
                }
            ),
            new Skill(
                name: "Brain Shake",
                effect: "Deals light Phys damage to 1 foe 1x to 3x with a chance of Exhaustion.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Rakshasa", 0),
                    new SkillPersona("Berith", 19),
                    new SkillPersona("Vetala", 22)
                }
            ),
            new Skill(
                name: "Brave Blade",
                effect: "Deals severe Phys damage to 1 foe.",
                cost: "20% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Seiten Taisei", 0),
                    new SkillPersona("Sraosha", 0, true),
                    new SkillPersona("Yoshitsune", 0),
                    new SkillPersona("Lucifer", 0, true),
                    new SkillPersona("Atavaka", 74)
                }
            ),
            new Skill(
                name: "Bufu",
                effect: "Deals light Ice damage to 1 foe.",
                cost: "4 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Forneus", 0),
                    new SkillPersona("Valkyrie", 0),
                    new SkillPersona("Saki Mitama", 0),
                    new SkillPersona("Apsaras", 7)
                }
            ),
            new Skill(
                name: "Bufudyne",
                effect: "Deals heavy Ice damage to 1 foe.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kali", 0),
                    new SkillPersona("Sui-Ki", 0),
                    new SkillPersona("Hariti", 0),
                    new SkillPersona("Byakko", 0),
                    new SkillPersona("Loki", 0, true),
                    new SkillPersona("Lakshmi", 0),
                    new SkillPersona("Yurlungur", 0),
                    new SkillPersona("Isis", 0, true),
                    new SkillPersona("Lucifer", 0, true),
                    new SkillPersona("Skadi", 54),
                    new SkillPersona("Nidhoggr", 58),
                    new SkillPersona("Ananta", 61),
                    new SkillPersona("Izanagi-No-Okami", 93, false, true)
                }
            ),
            new Skill(
                name: "Bufula",
                effect: "Deals medium Ice damage to 1 foe.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("King Frost", 0),
                    new SkillPersona("Ganga", 0),
                    new SkillPersona("Undine", 0),
                    new SkillPersona("Gorgon", 0),
                    new SkillPersona("Pazuzu", 0),
                    new SkillPersona("Black Frost", 0),
                    new SkillPersona("Jack Frost", 19),
                    new SkillPersona("Yaksini", 22)
                }
            ),
            new Skill(
                name: "Cell Breaker",
                effect: "Deals light Phys damage to 1 foe with a chance of Enervation.",
                cost: "10% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yomotsu-Ikusa", 0),
                    new SkillPersona("Kaiwan", 0)
                }
            ),
            new Skill(
                name: "Cleave",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "5% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi", 0),
                    new SkillPersona("Valkyrie", 0)
                }
            ),
            new Skill(
                name: "Confuse Boost",
                effect: "Increases odds of inflicting Confusion (1.5x).",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ukobach", 5),
                    new SkillPersona("Sandman", 7),
                    new SkillPersona("Legion", 24),
                    new SkillPersona("Ganga", 32),
                    new SkillPersona("Taotie", 37),
                    new SkillPersona("Raja Naga", 43),
                    new SkillPersona("Leanan Sidhe", 44)
                }
            ),
            new Skill(
                name: "Cool Breeze",
                effect: "Recover 8% HP and SP after a successful battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Pazuzu", 42),
                    new SkillPersona("Yatagarasu", 46),
                    new SkillPersona("Trumpeter", 69),
                    new SkillPersona("Isis", 80, true)
                }
            ),
            new Skill(
                name: "Counter",
                effect: "10% chance of reflecting Phys attacks. Does not stack.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Rakshasa", 0),
                    new SkillPersona("Ares", 0),
                    new SkillPersona("Oni", 0)
                }
            ),
            new Skill(
                name: "Counterstrike",
                effect: "15% chance of reflecting Phys attacks. Does not stack.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Triglav", 0),
                    new SkillPersona("Fuu-Ki", 0),
                    new SkillPersona("Pale Rider", 35),
                    new SkillPersona("Setanta", 36),
                    new SkillPersona("Okuninushi", 43),
                    new SkillPersona("Narasimha", 48),
                    new SkillPersona("Hokuto Seikun", 50)
                }
            ),
            new Skill(
                name: "Crazy Chain",
                effect: "Deals medium Phys damage to all foes with a chance of Rage.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Gorgon", 35),
                    new SkillPersona("Flauros", 41)
                }
            ),
            new Skill(
                name: "Cruel Attack",
                effect: "Medium Phys dmg, 1 foe. Bonus damage to foes that are knocked down.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Oni", 0)
                }
            ),
            new Skill(
                name: "Deathbound",
                effect: "Deals heavy Phys damage to all foes.",
                cost: "20% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Cu Chulainn", 0),
                    new SkillPersona("Tam Lin", 0),
                    new SkillPersona("Byakko", 0),
                    new SkillPersona("Thor", 0),
                    new SkillPersona("Surt", 0),
                    new SkillPersona("Kali", 52),
                    new SkillPersona("Kumbhanda", 60)
                }
            ),
            new Skill(
                name: "Debilitate",
                effect: "Decreases 1 foe's Attack, Defense, and Hit/Evasion rates for 3 turns.",
                cost: "30 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Trumpeter", 73),
                    new SkillPersona("Norn", 79, true)
                }
            ),
            new Skill(
                name: "Dekaja",
                effect: "Nullifies stat bonuses on all foes. (Offsets the effects of all enemies' '-kaja' magic.)",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Orobas", 0),
                    new SkillPersona("Obariyon", 0),
                    new SkillPersona("Mokoi", 0),
                    new SkillPersona("Ganga", 0),
                    new SkillPersona("Taowu", 0),
                    new SkillPersona("Nebiros", 0),
                    new SkillPersona("Sandman", 8),
                    new SkillPersona("Sarasvati", 21),
                    new SkillPersona("Ares", 29),
                    new SkillPersona("Take-Minakata", 31),
                    new SkillPersona("Tzitzimitl", 72)
                }
            ),
            new Skill(
                name: "Dekunda",
                effect: "Nullifies stat penalties on party. (Offsets the effects of '-nda' magic for all allies.)",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nata Taishi", 0),
                    new SkillPersona("Titan", 0),
                    new SkillPersona("Matador", 0),
                    new SkillPersona("Queen Mab", 0),
                    new SkillPersona("Taotie", 0),
                    new SkillPersona("Dis", 0),
                    new SkillPersona("Alice", 0),
                    new SkillPersona("Senri", 10),
                    new SkillPersona("Unicorn", 31),
                    new SkillPersona("Samael", 38),
                    new SkillPersona("Hachiman", 74)
                }
            ),
            new Skill(
                name: "Dia",
                effect: "Slightly restores 1 ally's HP.",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Pixie", 0),
                    new SkillPersona("Apsaras", 0),
                    new SkillPersona("Senri", 0),
                    new SkillPersona("Saki Mitama", 0)
                }
            ),
            new Skill(
                name: "Diarahan",
                effect: "Fully restores 1 ally's HP.",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Raphael", 0),
                    new SkillPersona("Hariti", 0),
                    new SkillPersona("Daisoujou", 0),
                    new SkillPersona("Horus", 0),
                    new SkillPersona("Atavaka", 0),
                    new SkillPersona("Norn", 0, true),
                    new SkillPersona("Yatagarasu", 45),
                    new SkillPersona("Kikuri-Hime", 52)
                }
            ),
            new Skill(
                name: "Diarama",
                effect: "Moderately restores 1 ally's HP.",
                cost: "6 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nigi Mitama", 0),
                    new SkillPersona("Titania", 0),
                    new SkillPersona("Ganga", 0),
                    new SkillPersona("Undine", 0),
                    new SkillPersona("Parvati", 0),
                    new SkillPersona("Dis", 0),
                    new SkillPersona("Garuda", 0),
                    new SkillPersona("Makami", 30),
                    new SkillPersona("Sati", 33)
                }
            ),
            new Skill(
                name: "Die for Me!",
                effect: "Darkness: very high chance of instant kill, all foes. (60% chance)",
                cost: "44 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Alice", 79)
                }
            ),
            new Skill(
                name: "Divine Grace",
                effect: "Effects of healing magic are increased by 50%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Neko Shogun", 37),
                    new SkillPersona("Parvati", 43),
                    new SkillPersona("Leanan Sidhe", 47),
                    new SkillPersona("Gabriel", 50),
                    new SkillPersona("Kikuri-Hime", 54)
                }
            ),
            new Skill(
                name: "Dodge Elec",
                effect: "Doubles evasion rate against Elec attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Forneus", 10),
                    new SkillPersona("Ara Mitama", 23),
                    new SkillPersona("Mithra", 35),
                    new SkillPersona("Fortuna", 37),
                    new SkillPersona("Parvati", 41)
                }
            ),
            new Skill(
                name: "Dodge Fire",
                effect: "Doubles evasion rate against Fire attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jack Frost", 20),
                    new SkillPersona("King Frost", 24),
                    new SkillPersona("High Pixie", 26)
                }
            ),
            new Skill(
                name: "Dodge Ice",
                effect: "Doubles evasion rate against Ice attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nata Taishi", 8),
                    new SkillPersona("Orobas", 10),
                    new SkillPersona("Titan", 16),
                    new SkillPersona("Phoenix", 25),
                    new SkillPersona("Hua Po", 29),
                    new SkillPersona("Flauros", 40),
                    new SkillPersona("Dis", 41),
                    new SkillPersona("Rangda", 50)
                }
            ),
            new Skill(
                name: "Dodge Physical",
                effect: "Doubles evasion rate against Phys attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Rakshasa", 27),
                    new SkillPersona("Makami", 32),
                    new SkillPersona("Take-Minakata", 33),
                    new SkillPersona("Baphomet", 50),
                    new SkillPersona("Yatsufusa", 53)
                }
            ),
            new Skill(
                name: "Dodge Wind",
                effect: "Doubles evasion rate against Wind attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Oberon", 17),
                    new SkillPersona("Andras", 25),
                    new SkillPersona("Queen Mab", 27),
                    new SkillPersona("Ares", 27)
                }
            ),
            new Skill(
                name: "Double Fangs",
                effect: "Deals light Phys damage to 1 foe 2x.",
                cost: "8% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Archangel", 0)
                }
            ),
            new Skill(
                name: "Elec Amp",
                effect: "Strengthens Elec attacks by 50%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Trumpeter", 0),
                    new SkillPersona("Tam Lin", 56),
                    new SkillPersona("Belphegor", 67),
                    new SkillPersona("Yoshitsune", 79),
                    new SkillPersona("Kohryu", 80, true),
                    new SkillPersona("Suparna", 83),
                    new SkillPersona("Ongyo-Ki", 85, true),
                    new SkillPersona("Izanagi-No-Okami", 98, false, true)
                }
            ),
            new Skill(
                name: "Elec Boost",
                effect: "Strengthens Elec attacks by 25%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Neko Shogun", 0),
                    new SkillPersona("Hokuto Seikun", 0),
                    new SkillPersona("Oberon", 15),
                    new SkillPersona("Xiezhai", 21),
                    new SkillPersona("Okuninushi", 46),
                    new SkillPersona("Hitokoto-Nushi", 46),
                    new SkillPersona("Seiryu", 52)
                }
            ),
            new Skill(
                name: "Elec Break",
                effect: "Nullifies 1 foe's Elec resistance (for 3 turns).",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mothman", 36),
                    new SkillPersona("Seiryu", 51),
                    new SkillPersona("Lilith", 56),
                    new SkillPersona("Hachiman", 72)
                }
            ),
            new Skill(
                name: "Endure",
                effect: "Restores 1 HP upon death 1x per battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Oni", 34),
                    new SkillPersona("Hanuman", 47),
                    new SkillPersona("Ganesha", 55),
                    new SkillPersona("Kingu", 63),
                    new SkillPersona("Hell Biker", 68)
                }
            ),
            new Skill(
                name: "Endure Dark",
                effect: "Automatically survive instant death 1 time from a Darkness attack with 1 HP.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Cu Chulainn", 50),
                    new SkillPersona("Throne", 55),
                    new SkillPersona("Uriel", 62),
                    new SkillPersona("Daisoujou", 63),
                    new SkillPersona("Sandalphon", 89, true)
                }
            ),
            new Skill(
                name: "Endure Light",
                effect: "Automatically survive instant death 1 time from a Light attack with 1 HP.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Girimehkala", 53),
                    new SkillPersona("Abaddon", 57),
                    new SkillPersona("Belial", 71),
                    new SkillPersona("Alice", 75),
                    new SkillPersona("Satan", 80)
                }
            ),
            new Skill(
                name: "Enduring Soul",
                effect: "Restores full HP upon death 1x per battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Shiva", 0, true),
                    new SkillPersona("Tam Lin", 59),
                    new SkillPersona("Sui-Ki", 62),
                    new SkillPersona("Masakado", 76),
                    new SkillPersona("Attis", 84, true),
                    new SkillPersona("Zaou Gongen", 94, true)
                }
            ),
            new Skill(
                name: "Energy Shower",
                effect: "Cures Exhaustion and Enervation (party).",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sati", 0),
                    new SkillPersona("Alraune", 0),
                    new SkillPersona("Suzaku", 0),
                    new SkillPersona("Leanan Sidhe", 45),
                    new SkillPersona("Gabriel", 45)
                }
            ),
            new Skill(
                name: "Enervate Boost",
                effect: "Enervation-based attacks are 1.5 times more effective.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lilim", 12),
                    new SkillPersona("Yomotsu-Ikusa", 24),
                    new SkillPersona("Alraune", 46),
                    new SkillPersona("Belphegor", 66)
                }
            ),
            new Skill(
                name: "Enervation",
                effect: "Enervates 1 foe (40% chance). (-50% STR/MAG/END)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lilim", 0),
                    new SkillPersona("Nozuchi", 0),
                    new SkillPersona("Ghoul", 11)
                }
            ),
            new Skill(
                name: "Evade Elec",
                effect: "Triples evasion rate against Elec attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Seiten Taisei", 0),
                    new SkillPersona("Genbu", 46),
                    new SkillPersona("Seth", 74)
                }
            ),
            new Skill(
                name: "Evade Fire",
                effect: "Triples evasion rate against Fire attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kingu", 0),
                    new SkillPersona("Ganga", 35),
                    new SkillPersona("Fuu-Ki", 45),
                    new SkillPersona("Atropos", 69),
                    new SkillPersona("Suparna", 82)
                }
            ),
            new Skill(
                name: "Evade Ice",
                effect: "Triples evasion rate against Ice attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Gdon", 36),
                    new SkillPersona("White Rider", 62),
                    new SkillPersona("Saturnus", 77),
                    new SkillPersona("Suparna", 79),
                    new SkillPersona("Mada", 82, true)
                }
            ),
            new Skill(
                name: "Evade Physical",
                effect: "Triples evasion rate against Phys attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Decarabia", 48),
                    new SkillPersona("Tam Lin", 58),
                    new SkillPersona("Taowu", 61),
                    new SkillPersona("Alilat", 73),
                    new SkillPersona("Zaou Gongen", 93, true)
                }
            ),
            new Skill(
                name: "Evade Wind",
                effect: "Triples evasion rate against Wind attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Neko Shogun", 36),
                    new SkillPersona("Narasimha", 49),
                    new SkillPersona("Vasuki", 75)
                }
            ),
            new Skill(
                name: "Evil Smile",
                effect: "Instills Fear in all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Legion", 0),
                    new SkillPersona("Incubus", 0),
                    new SkillPersona("Mot", 0),
                    new SkillPersona("Baphomet", 0),
                    new SkillPersona("Nidhoggr", 0),
                    new SkillPersona("Belphegor", 0)
                }
            ),
            new Skill(
                name: "Evil Touch",
                effect: "Instills Fear in 1 foe (40% chance). (-Crit. DEF and may lose turn or escape)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Slime", 0),
                    new SkillPersona("Yomotsu-Shikome", 0),
                    new SkillPersona("Vetala", 0)
                }
            ),
            new Skill(
                name: "Exhaust Boost",
                effect: "Exhaustion-based attacks are 1.5 times more effective.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mokoi", 19),
                    new SkillPersona("Kusi Mitama", 34)
                }
            ),
            new Skill(
                name: "Fast Heal",
                effect: "Halves the time needed to recover from ailments.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kaguya", 0)
                }
            ),
            new Skill(
                name: "Fatal End",
                effect: "Deals medium Phys damage to 1 foe.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Oni", 0),
                    new SkillPersona("Setanta", 0),
                    new SkillPersona("Flauros", 0),
                    new SkillPersona("Raja Naga", 0),
                    new SkillPersona("Virtue", 35)
                }
            ),
            new Skill(
                name: "Fear Boost",
                effect: "Increases odds of inflicting Fear (1.5x).",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Slime", 5),
                    new SkillPersona("Vetala", 24),
                    new SkillPersona("Belphegor", 64)
                }
            ),
            new Skill(
                name: "Fire Amp",
                effect: "Strengthens Fire attacks by 50%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Saturnus", 0),
                    new SkillPersona("Black Frost", 42),
                    new SkillPersona("Decarabia", 51),
                    new SkillPersona("Cerberus", 57),
                    new SkillPersona("Kumbhanda", 58),
                    new SkillPersona("Suzaku", 59),
                    new SkillPersona("Uriel", 63),
                    new SkillPersona("Mara", 67),
                    new SkillPersona("Belial", 72),
                    new SkillPersona("Hell Biker", 73),
                    new SkillPersona("Surt", 75),
                    new SkillPersona("Mada", 84, true),
                    new SkillPersona("Mahakala", 84, true),
                    new SkillPersona("Zaou Gongen", 95, true),
                    new SkillPersona("Izanagi-No-Okami", 96, false, true)
                }
            ),
            new Skill(
                name: "Fire Boost",
                effect: "Strengthens Fire attacks by 25%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yatsufusa", 0),
                    new SkillPersona("Mada", 0, true),
                    new SkillPersona("Eligor", 15),
                    new SkillPersona("Phoenix", 26),
                    new SkillPersona("Hua Po", 30),
                    new SkillPersona("Gdon", 35),
                    new SkillPersona("Orthrus", 42),
                    new SkillPersona("Jinn", 66)
                }
            ),
            new Skill(
                name: "Fire Break",
                effect: "Nullifies 1 foe's Fire resistance (for 3 turns).",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Gdon", 0),
                    new SkillPersona("Ukobach", 7),
                    new SkillPersona("Hua Po", 26)
                }
            ),
            new Skill(
                name: "Firm Stance",
                effect: "Always take half damage, but you can never dodge.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Futsunushi", 86, true),
                    new SkillPersona("Ongyo-Ki", 87, true)
                }
            ),
            new Skill(
                name: "Foolish Whisper",
                effect: "Silences all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Vetala", 0),
                    new SkillPersona("Narcissus", 0),
                    new SkillPersona("Hitokoto-Nushi", 0),
                    new SkillPersona("Pabilsag", 0),
                    new SkillPersona("Jinn", 0),
                    new SkillPersona("Mada", 0, true),
                    new SkillPersona("Ongyo-Ki", 0, true),
                    new SkillPersona("Mother Harlot", 63)
                }
            ),
            new Skill(
                name: "Foul Breath",
                effect: "Increase 1 foe's susceptibility to ailments and Light/Dark skills.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Vetala", 21),
                    new SkillPersona("Legion", 25),
                    new SkillPersona("Yomotsu-Ikusa", 25),
                    new SkillPersona("Mothman", 35)
                }
            ),
            new Skill(
                name: "Gale Slash",
                effect: "Deals light Phys damage to all foes.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ares", 0),
                    new SkillPersona("Rakshasa", 25)
                }
            ),
            new Skill(
                name: "Garu",
                effect: "Deals light Wind damage to 1 foe.",
                cost: "4 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Angel", 0),
                    new SkillPersona("Sandman", 0),
                    new SkillPersona("Cu Sith", 0),
                    new SkillPersona("Sylph", 0),
                    new SkillPersona("Anzu", 0)
                }
            ),
            new Skill(
                name: "Garudyne",
                effect: "Deals heavy Wind damage to 1 foe.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ganesha", 0),
                    new SkillPersona("Lachesis", 0),
                    new SkillPersona("Garuda", 0),
                    new SkillPersona("Jatayu", 0),
                    new SkillPersona("Atropos", 0),
                    new SkillPersona("Seth", 0),
                    new SkillPersona("Norn", 0, true),
                    new SkillPersona("Suparna", 0),
                    new SkillPersona("Scathach", 0, true),
                    new SkillPersona("Clotho", 49),
                    new SkillPersona("Cu Chulainn", 51),
                    new SkillPersona("Quetzalcoatl", 52),
                    new SkillPersona("Izanagi-No-Okami", 95, false, true)
                }
            ),
            new Skill(
                name: "Garula",
                effect: "Deals medium Wind damage to 1 foe.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Phoenix", 0),
                    new SkillPersona("Kusi Mitama", 0),
                    new SkillPersona("Virtue", 0),
                    new SkillPersona("Pale Rider", 0),
                    new SkillPersona("Yamata-No-Orochi", 0),
                    new SkillPersona("Fortuna", 0),
                    new SkillPersona("Fuu-Ki", 0),
                    new SkillPersona("Kurama Tengu", 0),
                    new SkillPersona("Nigi Mitama", 28),
                    new SkillPersona("Titania", 29)
                }
            ),
            new Skill(
                name: "Ghastly Wail",
                effect: "Instantly kills foes who are fearful.",
                cost: "28 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Baphomet", 0),
                    new SkillPersona("Yomotsu-Shikome", 11),
                    new SkillPersona("Vetala", 23),
                    new SkillPersona("Incubus", 33),
                    new SkillPersona("Mot", 49),
                    new SkillPersona("Nidhoggr", 57)
                }
            ),
            new Skill(
                name: "Gigantic Fist",
                effect: "Deals heavy Phys damage to 1 foe.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Cerberus", 0),
                    new SkillPersona("Kin-Ki", 56)
                }
            ),
            new Skill(
                name: "God's Hand",
                effect: "Deals severe Phys damage to 1 foe.",
                cost: "22% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Helel", 0, true),
                    new SkillPersona("Zaou Gongen", 0, true),
                    new SkillPersona("Ardha", 0),
                    new SkillPersona("Siegfried", 70),
                    new SkillPersona("Melchizedek", 72),
                    new SkillPersona("Vishnu", 76, true)
                }
            ),
            new Skill(
                name: "Green Wall",
                effect: "Add Wind resistance to 1 ally (for 3 turns).",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Berith", 18),
                    new SkillPersona("Yamata-No-Orochi", 36),
                    new SkillPersona("Alraune", 44),
                    new SkillPersona("Ananta", 62)
                }
            ),
            new Skill(
                name: "Growth 1",
                effect: "Persona gains 1/4 EXP while inactive.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Cu Sith", 11),
                    new SkillPersona("Gurr", 21),
                    new SkillPersona("Phoenix", 23)
                }
            ),
            new Skill(
                name: "Growth 2",
                effect: "Persona gains 1/2 EXP while inactive. (Overwrites Growth 1)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Quetzalcoatl", 0),
                    new SkillPersona("Gdon", 33),
                    new SkillPersona("Yatagarasu", 44),
                    new SkillPersona("Thoth", 48),
                    new SkillPersona("Kurama Tengu", 50),
                    new SkillPersona("Shiki-Ouji", 59),
                    new SkillPersona("Kartikeya", 70),
                    new SkillPersona("Alilat", 74)
                }
            ),
            new Skill(
                name: "Growth 3",
                effect: "Persona gains full EXP even while inactive. (Overwrites Growth 1/Growth 2)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jatayu", 64),
                    new SkillPersona("Yurlungur", 71),
                    new SkillPersona("Saturnus", 79)
                }
            ),
            new Skill(
                name: "Hama",
                effect: "Light: low chance of instant kill, 1 foe. (40% chance)",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Archangel", 0),
                    new SkillPersona("Ame No Uzume", 0),
                    new SkillPersona("Principality", 0),
                    new SkillPersona("Power", 0),
                    new SkillPersona("Angel", 5)
                }
            ),
            new Skill(
                name: "Hama Boost",
                effect: "Light-based attacks are 1.5 times more effective.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Throne", 0),
                    new SkillPersona("Angel", 9),
                    new SkillPersona("Power", 31),
                    new SkillPersona("Mithra", 36),
                    new SkillPersona("Virtue", 38),
                    new SkillPersona("Dominion", 40),
                    new SkillPersona("Anubis", 65),
                    new SkillPersona("Daisoujou", 65),
                    new SkillPersona("White Rider", 66),
                    new SkillPersona("Masakado", 73),
                    new SkillPersona("Kaguya", 78),
                    new SkillPersona("Sraosha", 78, true)
                }
            ),
            new Skill(
                name: "Hamaon",
                effect: "Light: high chance of instant kill, 1 foe. (60% chance)",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Dominion", 0),
                    new SkillPersona("Narasimha", 0),
                    new SkillPersona("Throne", 0),
                    new SkillPersona("Uriel", 0),
                    new SkillPersona("White Rider", 0),
                    new SkillPersona("Anubis", 0),
                    new SkillPersona("Daisoujou", 0),
                    new SkillPersona("Melchizedek", 0),
                    new SkillPersona("Vasuki", 0),
                    new SkillPersona("Michael", 0),
                    new SkillPersona("Kaguya", 0),
                    new SkillPersona("Mithra", 34)
                }
            ),
            new Skill(
                name: "Hassou Tobi",
                effect: "Deals light Phys damage to all foes 8x.",
                cost: "25% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yoshitsune", 83)
                }
            ),
            new Skill(
                name: "Heat Riser",
                effect: "Increases 1 ally's Attack, Defense, and Hit/Evasion rates for 3 turns.",
                cost: "30 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Trumpeter", 74),
                    new SkillPersona("Yoshitsune", 77)
                }
            ),
            new Skill(
                name: "Heat Wave",
                effect: "Deals medium Phys damage to all foes.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Triglav", 0),
                    new SkillPersona("Gabriel", 48),
                    new SkillPersona("Yatsufusa", 51),
                    new SkillPersona("Quetzalcoatl", 53)
                }
            ),
            new Skill(
                name: "Heaven's Blade",
                effect: "Deals heavy Phys damage to 1 foe.",
                cost: "19% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Metatron", 0),
                    new SkillPersona("Michael", 79)
                }
            ),
            new Skill(
                name: "Herculean Strike",
                effect: "Deals medium Phys damage to all foes.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Flauros", 38)
                }
            ),
            new Skill(
                name: "High Counter",
                effect: "20% chance of reflecting Phys attacks. Does not stack.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Tam Lin", 0),
                    new SkillPersona("Kin-Ki", 0),
                    new SkillPersona("Byakko", 0),
                    new SkillPersona("Thor", 0),
                    new SkillPersona("Surt", 0),
                    new SkillPersona("Kali", 54),
                    new SkillPersona("Ganesha", 54),
                    new SkillPersona("Uriel", 60),
                    new SkillPersona("Garuda", 61),
                    new SkillPersona("Siegfried", 65),
                    new SkillPersona("Loki", 67, true),
                    new SkillPersona("Kartikeya", 68),
                    new SkillPersona("Seiten Taisei", 69),
                    new SkillPersona("Barong", 71),
                    new SkillPersona("Vasuki", 74),
                    new SkillPersona("Asura", 89, true)
                }
            ),
            new Skill(
                name: "Hysterical Slap",
                effect: "Deals light Phys damage to 1 foe with a chance of Rage.",
                cost: "9% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Orobas", 0),
                    new SkillPersona("Mokoi", 0)
                }
            ),
            new Skill(
                name: "Ice Amp",
                effect: "Strengthens Ice attacks by 50%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Skadi", 56),
                    new SkillPersona("Loki", 66, true),
                    new SkillPersona("Byakko", 67),
                    new SkillPersona("Scathach", 83, true),
                    new SkillPersona("Lucifer", 94, true),
                    new SkillPersona("Izanagi-No-Okami", 97, false, true)
                }
            ),
            new Skill(
                name: "Ice Boost",
                effect: "Strengthens Ice attacks by 25%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Black Frost", 0),
                    new SkillPersona("Yaksini", 21),
                    new SkillPersona("King Frost", 26),
                    new SkillPersona("Undine", 37),
                    new SkillPersona("Gorgon", 39),
                    new SkillPersona("Yamata-No-Orochi", 39),
                    new SkillPersona("Nidhoggr", 61)
                }
            ),
            new Skill(
                name: "Ice Break",
                effect: "Nullifies 1 foe's Ice resistance (for 3 turns).",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jack Frost", 0),
                    new SkillPersona("King Frost", 0),
                    new SkillPersona("Lakshmi", 66)
                }
            ),
            new Skill(
                name: "Insta-Heal",
                effect: "Recovers from ailments in 1 turn.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Norn", 77, true),
                    new SkillPersona("Helel", 90, true)
                }
            ),
            new Skill(
                name: "Invigorate 1",
                effect: "Recovers 3 SP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ame No Uzume", 20),
                    new SkillPersona("High Pixie", 25)
                }
            ),
            new Skill(
                name: "Invigorate 2",
                effect: "Recovers 5 SP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sarasvati", 19),
                    new SkillPersona("Nigi Mitama", 26),
                    new SkillPersona("Barong", 69)
                }
            ),
            new Skill(
                name: "Invigorate 3",
                effect: "Recovers 7 SP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Succubus", 50),
                    new SkillPersona("Ananta", 63),
                    new SkillPersona("Chernobog", 69),
                    new SkillPersona("Norn", 75, true),
                    new SkillPersona("Satan", 78)
                }
            ),
            new Skill(
                name: "Kill Rush",
                effect: "Deals light Phys damage to 1 foe 1x to 3x.",
                cost: "10% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Rakshasa", 0),
                    new SkillPersona("Titan", 18)
                }
            ),
            new Skill(
                name: "Life Drain",
                effect: "Drains 30 HP from 1 foe.",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Loa", 0),
                    new SkillPersona("Vetala", 20),
                    new SkillPersona("Kaiwan", 28)
                }
            ),
            new Skill(
                name: "Mabufu",
                effect: "Deals light Ice damage to all foes.",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jack Frost", 0),
                    new SkillPersona("Sarasvati", 0),
                    new SkillPersona("Yaksini", 0),
                    new SkillPersona("King Frost", 0),
                    new SkillPersona("Yomotsu-Ikusa", 0),
                    new SkillPersona("Valkyrie", 12)
                }
            ),
            new Skill(
                name: "Mabufudyne",
                effect: "Deals heavy Ice damage to all foes.",
                cost: "22 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lakshmi", 0),
                    new SkillPersona("Alilat", 0),
                    new SkillPersona("Vishnu", 0, true),
                    new SkillPersona("Baal Zebul", 0),
                    new SkillPersona("Scathach", 0, true),
                    new SkillPersona("Beelzebub", 0, true),
                    new SkillPersona("Byakko", 68),
                    new SkillPersona("Loki", 68, true),
                    new SkillPersona("Isis", 83, true)
                }
            ),
            new Skill(
                name: "Mabufula",
                effect: "Deals medium Ice damage to all foes.",
                cost: "16 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yamata-No-Orochi", 0),
                    new SkillPersona("Genbu", 0),
                    new SkillPersona("Gabriel", 0),
                    new SkillPersona("Skadi", 0),
                    new SkillPersona("Ananta", 0),
                    new SkillPersona("Undine", 34),
                    new SkillPersona("Gorgon", 38)
                }
            ),
            new Skill(
                name: "Magaru",
                effect: "Deals light Wind damage to all foes.",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ame No Uzume", 0),
                    new SkillPersona("Narcissus", 0),
                    new SkillPersona("Titania", 0),
                    new SkillPersona("Cu Sith", 13),
                    new SkillPersona("Sylph", 14),
                    new SkillPersona("Anzu", 17)
                }
            ),
            new Skill(
                name: "Magarudyne",
                effect: "Deals heavy Wind damage to all foes.",
                cost: "22 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Seth", 0),
                    new SkillPersona("Horus", 0),
                    new SkillPersona("Norn", 0, true),
                    new SkillPersona("Odin", 0, true),
                    new SkillPersona("Shiva", 0, true),
                    new SkillPersona("Ganesha", 56),
                    new SkillPersona("Jatayu", 66),
                    new SkillPersona("Atropos", 68),
                    new SkillPersona("Suparna", 81),
                    new SkillPersona("Scathach", 82, true)
                }
            ),
            new Skill(
                name: "Magarula",
                effect: "Deals medium Wind damage to all foes.",
                cost: "16 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Clotho", 0),
                    new SkillPersona("Cu Chulainn", 0),
                    new SkillPersona("Quetzalcoatl", 0),
                    new SkillPersona("Fortuna", 38)
                }
            ),
            new Skill(
                name: "Mahama",
                effect: "Light: low chance of instant kill, all foes. (30% chance)",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Power", 0),
                    new SkillPersona("Unicorn", 0),
                    new SkillPersona("Mithra", 0),
                    new SkillPersona("Virtue", 0),
                    new SkillPersona("Thoth", 0),
                    new SkillPersona("Anzu", 19),
                    new SkillPersona("Principality", 21)
                }
            ),
            new Skill(
                name: "Mahamaon",
                effect: "Light: high chance of instant kill, all foes. (40% chance)",
                cost: "34 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Horus", 0),
                    new SkillPersona("Masakado", 0),
                    new SkillPersona("Atavaka", 0),
                    new SkillPersona("Sraosha", 0, true),
                    new SkillPersona("Metatron", 0),
                    new SkillPersona("Sandalphon", 0, true),
                    new SkillPersona("Narasimha", 51),
                    new SkillPersona("Quetzalcoatl", 55),
                    new SkillPersona("White Rider", 63),
                    new SkillPersona("Anubis", 64),
                    new SkillPersona("Daisoujou", 64),
                    new SkillPersona("Melchizedek", 69),
                    new SkillPersona("Michael", 75),
                    new SkillPersona("Vasuki", 76),
                    new SkillPersona("Kaguya", 77),
                    new SkillPersona("Asura", 88, true)
                }
            ),
            new Skill(
                name: "Makajam",
                effect: "Silences 1 foe (40% chance). (Unable to use Skills or change Persona)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Senri", 0),
                    new SkillPersona("Suparna", 0),
                    new SkillPersona("Oberon", 13),
                    new SkillPersona("Xiezhai", 17),
                    new SkillPersona("Hua Po", 27)
                }
            ),
            new Skill(
                name: "Makara Break",
                effect: "Negates all foes' Makarakarn.",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Genbu", 43),
                    new SkillPersona("Lachesis", 54)
                }
            ),
            new Skill(
                name: "Makarakarn",
                effect: "Barrier that reflects magic dmg once. (1 ally; excludes Almighty attacks)",
                cost: "36 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ganesha", 0),
                    new SkillPersona("Lilith", 0),
                    new SkillPersona("Anubis", 0),
                    new SkillPersona("Daisoujou", 0),
                    new SkillPersona("Alilat", 0),
                    new SkillPersona("Hachiman", 0),
                    new SkillPersona("Alraune", 43),
                    new SkillPersona("Clotho", 47),
                    new SkillPersona("Kushinada", 50),
                    new SkillPersona("Mara", 64)
                }
            ),
            new Skill(
                name: "Mamudo",
                effect: "Darkness: low chance of instant kill, all foes. (30% chance)",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Matador", 0),
                    new SkillPersona("Kaiwan", 0),
                    new SkillPersona("Pale Rider", 0),
                    new SkillPersona("Lilim", 15),
                    new SkillPersona("Ippon-Datara", 19)
                }
            ),
            new Skill(
                name: "Mamudoon",
                effect: "Darkness: high chance of instant kill, all foes. (40% chance)",
                cost: "34 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nidhoggr", 0),
                    new SkillPersona("Mother Harlot", 0),
                    new SkillPersona("Chernobog", 0),
                    new SkillPersona("Nebiros", 0),
                    new SkillPersona("Alice", 0),
                    new SkillPersona("Baal Zebul", 0),
                    new SkillPersona("Beelzebub", 0, true),
                    new SkillPersona("Girimehkala", 50),
                    new SkillPersona("Baphomet", 52),
                    new SkillPersona("White Rider", 65),
                    new SkillPersona("Mahakala", 83, true),
                    new SkillPersona("Attis", 88, true)
                }
            ),
            new Skill(
                name: "Maragi",
                effect: "Deals light Fire damage to all foes.",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ippon-Datara", 0),
                    new SkillPersona("Phoenix", 0),
                    new SkillPersona("Sati", 0),
                    new SkillPersona("Gdon", 0),
                    new SkillPersona("Eligor", 13),
                    new SkillPersona("Berith", 16)
                }
            ),
            new Skill(
                name: "Maragidyne",
                effect: "Deals heavy Fire damage to all foes.",
                cost: "22 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Saturnus", 0),
                    new SkillPersona("Satan", 0),
                    new SkillPersona("Asura", 0, true),
                    new SkillPersona("Helel", 0, true),
                    new SkillPersona("Zaou Gongen", 0, true),
                    new SkillPersona("Cerberus", 53),
                    new SkillPersona("Yatsufusa", 54),
                    new SkillPersona("Hell Biker", 70),
                    new SkillPersona("Surt", 71),
                    new SkillPersona("Belial", 73),
                    new SkillPersona("Mada", 81, true),
                    new SkillPersona("Mahakala", 82, true),
                    new SkillPersona("Attis", 87, true)
                }
            ),
            new Skill(
                name: "Maragion",
                effect: "Deals medium Fire damage to all foes.",
                cost: "16 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Black Frost", 0),
                    new SkillPersona("Dis", 0),
                    new SkillPersona("Rangda", 0),
                    new SkillPersona("Baphomet", 0),
                    new SkillPersona("Suzaku", 0),
                    new SkillPersona("Uriel", 0),
                    new SkillPersona("Phoenix", 27),
                    new SkillPersona("Lamia", 32),
                    new SkillPersona("Gdon", 34),
                    new SkillPersona("Sati", 36),
                    new SkillPersona("Pyro Jack", 36),
                    new SkillPersona("Orthrus", 44),
                    new SkillPersona("Kushinada", 46),
                    new SkillPersona("Succubus", 46)
                }
            ),
            new Skill(
                name: "Marakukaja",
                effect: "Increases Defense for 3 turns (party).",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Genbu", 0),
                    new SkillPersona("Hariti", 0),
                    new SkillPersona("Attis", 0, true),
                    new SkillPersona("Asura", 0, true),
                    new SkillPersona("Pyro Jack", 34),
                    new SkillPersona("Parvati", 40),
                    new SkillPersona("Orthrus", 41),
                    new SkillPersona("Triglav", 45),
                    new SkillPersona("Ananta", 59),
                    new SkillPersona("Barong", 67),
                    new SkillPersona("Trumpeter", 68)
                }
            ),
            new Skill(
                name: "Marakunda",
                effect: "Decreases all foes' Defense for 3 turns.",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kurama Tengu", 0),
                    new SkillPersona("Belphegor", 63)
                }
            ),
            new Skill(
                name: "Masukukaja",
                effect: "Increases Hit/Evasion rates for 3 turns (party).",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yatagarasu", 0),
                    new SkillPersona("Yatsufusa", 0),
                    new SkillPersona("Quetzalcoatl", 0),
                    new SkillPersona("Lachesis", 0),
                    new SkillPersona("Siegfried", 0),
                    new SkillPersona("Ongyo-Ki", 0, true),
                    new SkillPersona("Raphael", 55),
                    new SkillPersona("Suzaku", 55)
                }
            ),
            new Skill(
                name: "Masukunda",
                effect: "Decreases all foes' Hit/Evasion rates for 3 turns.",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Black Frost", 41),
                    new SkillPersona("Dis", 42)
                }
            ),
            new Skill(
                name: "Matarukaja",
                effect: "Increases Attack for 3 turns (party).",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kushinada", 0),
                    new SkillPersona("Taowu", 0),
                    new SkillPersona("Hachiman", 0),
                    new SkillPersona("Futsunushi", 0, true),
                    new SkillPersona("Neko Shogun", 35),
                    new SkillPersona("Raja Naga", 38),
                    new SkillPersona("Cu Chulainn", 47),
                    new SkillPersona("Melchizedek", 68),
                    new SkillPersona("Horus", 71)
                }
            ),
            new Skill(
                name: "Matarunda",
                effect: "Decreases all foes' Attack for 3 turns.",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Samael", 0),
                    new SkillPersona("Loa", 0),
                    new SkillPersona("Decarabia", 0),
                    new SkillPersona("Seiryu", 0),
                    new SkillPersona("Shiki-Ouji", 0)
                }
            ),
            new Skill(
                name: "Mazio",
                effect: "Deals light Elec damage to all foes.",
                cost: "10 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Titan", 0),
                    new SkillPersona("Xiezhai", 0),
                    new SkillPersona("Andras", 0),
                    new SkillPersona("Shiisaa", 0),
                    new SkillPersona("High Pixie", 0),
                    new SkillPersona("Take-Minakata", 0),
                    new SkillPersona("Oberon", 16)
                }
            ),
            new Skill(
                name: "Maziodyne",
                effect: "Deals heavy Elec damage to all foes.",
                cost: "22 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mother Harlot", 0),
                    new SkillPersona("Belphegor", 0),
                    new SkillPersona("Kartikeya", 0),
                    new SkillPersona("Hachiman", 0),
                    new SkillPersona("Lilith", 55),
                    new SkillPersona("Thor", 68),
                    new SkillPersona("Barong", 72),
                    new SkillPersona("Ishtar", 73, true),
                    new SkillPersona("Tzitzimitl", 76),
                    new SkillPersona("Odin", 78, true),
                    new SkillPersona("Kohryu", 78, true),
                    new SkillPersona("Baal Zebul", 79),
                    new SkillPersona("Beelzebub", 79, true),
                    new SkillPersona("Shiva", 82, true)
                }
            ),
            new Skill(
                name: "Mazionga",
                effect: "Deals medium Elec damage to all foes.",
                cost: "16 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Thoth", 0),
                    new SkillPersona("Seiryu", 0),
                    new SkillPersona("Queen Mab", 29),
                    new SkillPersona("Unicorn", 34),
                    new SkillPersona("Mothman", 37),
                    new SkillPersona("Raja Naga", 42),
                    new SkillPersona("Dominion", 42),
                    new SkillPersona("Okuninushi", 44)
                }
            ),
            new Skill(
                name: "Me Patra",
                effect: "Dispels Rage, Fear, and Confusion (party).",
                cost: "6 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sylph", 0),
                    new SkillPersona("High Pixie", 0),
                    new SkillPersona("Nigi Mitama", 0),
                    new SkillPersona("Gorgon", 0),
                    new SkillPersona("Leanan Sidhe", 0),
                    new SkillPersona("Barong", 0),
                    new SkillPersona("Pixie", 4),
                    new SkillPersona("Apsaras", 6)
                }
            ),
            new Skill(
                name: "Media",
                effect: "Slightly restores party's HP.",
                cost: "7 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sarasvati", 0),
                    new SkillPersona("Ame No Uzume", 0),
                    new SkillPersona("Andras", 0),
                    new SkillPersona("Valkyrie", 10),
                    new SkillPersona("Senri", 11),
                    new SkillPersona("Archangel", 12),
                    new SkillPersona("Sylph", 13),
                    new SkillPersona("Saki Mitama", 14),
                    new SkillPersona("Oberon", 14),
                    new SkillPersona("Principality", 22)
                }
            ),
            new Skill(
                name: "Mediarahan",
                effect: "Fully restores party's HP.",
                cost: "30 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Melchizedek", 0),
                    new SkillPersona("Ishtar", 0, true),
                    new SkillPersona("Kaguya", 0),
                    new SkillPersona("Kohryu", 0, true),
                    new SkillPersona("Isis", 0, true),
                    new SkillPersona("Raphael", 59),
                    new SkillPersona("Hariti", 61),
                    new SkillPersona("Cybele", 70),
                    new SkillPersona("Yurlungur", 72),
                    new SkillPersona("Ardha", 94)
                }
            ),
            new Skill(
                name: "Mediarama",
                effect: "Moderately restores party's HP.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Alraune", 0),
                    new SkillPersona("Leanan Sidhe", 0),
                    new SkillPersona("Gabriel", 0),
                    new SkillPersona("Kushinada", 0),
                    new SkillPersona("Kikuri-Hime", 0),
                    new SkillPersona("Kingu", 0),
                    new SkillPersona("Cybele", 0),
                    new SkillPersona("Ganga", 33),
                    new SkillPersona("Neko Shogun", 34),
                    new SkillPersona("Undine", 36),
                    new SkillPersona("Parvati", 39),
                    new SkillPersona("Thoth", 47)
                }
            ),
            new Skill(
                name: "Megido",
                effect: "Deals medium Almighty damage to all foes.",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Taotie", 0),
                    new SkillPersona("Thoth", 0),
                    new SkillPersona("Samael", 39)
                }
            ),
            new Skill(
                name: "Megidola",
                effect: "Deals heavy Almighty damage to all foes.",
                cost: "32 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Raphael", 0),
                    new SkillPersona("Trumpeter", 0),
                    new SkillPersona("Michael", 0),
                    new SkillPersona("Decarabia", 50),
                    new SkillPersona("Anubis", 62),
                    new SkillPersona("Chernobog", 68),
                    new SkillPersona("Alice", 76)
                }
            ),
            new Skill(
                name: "Megidolaon",
                effect: "Deals severe Almighty damage to all foes.",
                cost: "60 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Vishnu", 0, true),
                    new SkillPersona("Satan", 0),
                    new SkillPersona("Helel", 0, true),
                    new SkillPersona("Izanagi-No-Okami", 0, false, true),
                    new SkillPersona("Trumpeter", 70),
                    new SkillPersona("Michael", 74),
                    new SkillPersona("Atavaka", 75),
                    new SkillPersona("Sraosha", 80, true),
                    new SkillPersona("Shiva", 84, true),
                    new SkillPersona("Metatron", 86),
                    new SkillPersona("Ardha", 91)
                }
            ),
            new Skill(
                name: "Mighty Swing",
                effect: "Deals medium Phys damage to 1 foe.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hanuman", 0),
                    new SkillPersona("Girimehkala", 0)
                }
            ),
            new Skill(
                name: "Mind Charge",
                effect: "Next Fire, Ice, Elec, Wind, or Almighty magical attack will be 250% greater in power.",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi-No-Okami", 0, false, true),
                    new SkillPersona("Lucifer", 0, true),
                    new SkillPersona("Jack Frost", 25),
                    new SkillPersona("Titania", 32),
                    new SkillPersona("Taotie", 38),
                    new SkillPersona("Black Frost", 40),
                    new SkillPersona("Dis", 44),
                    new SkillPersona("Cu Chulainn", 48),
                    new SkillPersona("Throne", 51),
                    new SkillPersona("Yatsufusa", 55),
                    new SkillPersona("Nebiros", 65),
                    new SkillPersona("Atropos", 67),
                    new SkillPersona("Atavaka", 76),
                    new SkillPersona("Alice", 77),
                    new SkillPersona("Kohryu", 79, true),
                    new SkillPersona("Odin", 80, true),
                    new SkillPersona("Mahakala", 80, true),
                    new SkillPersona("Scathach", 85, true)
                }
            ),
            new Skill(
                name: "Mind Slice",
                effect: "Deals medium Phys damage to all foes with a chance of Confusion.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Incubus", 0),
                    new SkillPersona("Pale Rider", 0),
                    new SkillPersona("Taotie", 0),
                    new SkillPersona("Ganga", 31)
                }
            ),
            new Skill(
                name: "Morning Star",
                effect: "Deals massive Almighty damage to all foes.",
                cost: "72 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Helel", 94, true)
                }
            ),
            new Skill(
                name: "Mudo",
                effect: "Darkness: low chance of instant kill, 1 foe. (40% chance)",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lilim", 0),
                    new SkillPersona("Berith", 0),
                    new SkillPersona("Ippon-Datara", 0),
                    new SkillPersona("Legion", 0),
                    new SkillPersona("Yomotsu-Shikome", 10)
                }
            ),
            new Skill(
                name: "Mudo Boost",
                effect: "Darkness-based attacks are 1.5 times more effective.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Alice", 0),
                    new SkillPersona("Berith", 17),
                    new SkillPersona("Ippon-Datara", 22),
                    new SkillPersona("Matador", 26),
                    new SkillPersona("Samael", 40),
                    new SkillPersona("Loa", 45),
                    new SkillPersona("Succubus", 47),
                    new SkillPersona("Mot", 50),
                    new SkillPersona("Baphomet", 53),
                    new SkillPersona("Mother Harlot", 62),
                    new SkillPersona("White Rider", 67),
                    new SkillPersona("Nebiros", 67),
                    new SkillPersona("Baal Zebul", 80),
                    new SkillPersona("Beelzebub", 80, true),
                    new SkillPersona("Mahakala", 85, true)
                }
            ),
            new Skill(
                name: "Mudoon",
                effect: "Darkness: high chance of instant kill, 1 foe. (60% chance)",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Samael", 0),
                    new SkillPersona("Pazuzu", 0),
                    new SkillPersona("Loa", 0),
                    new SkillPersona("Succubus", 0),
                    new SkillPersona("Mot", 0),
                    new SkillPersona("Kali", 0),
                    new SkillPersona("Abaddon", 0),
                    new SkillPersona("White Rider", 0),
                    new SkillPersona("Anubis", 0),
                    new SkillPersona("Belial", 0),
                    new SkillPersona("Pale Rider", 37),
                    new SkillPersona("Black Frost", 44),
                    new SkillPersona("Pabilsag", 55),
                    new SkillPersona("Hell Biker", 69)
                }
            ),
            new Skill(
                name: "Mustard Bomb",
                effect: "Deals medium Phys damage to all foes with a chance of Enervation.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ganesha", 0),
                    new SkillPersona("Tzitzimitl", 0),
                    new SkillPersona("Triglav", 46),
                    new SkillPersona("Rangda", 51),
                    new SkillPersona("Anubis", 61)
                }
            ),
            new Skill(
                name: "Mutudi",
                effect: "Cures Silence (1 ally).",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Clotho", 0),
                    new SkillPersona("Ishtar", 0, true)
                }
            ),
            new Skill(
                name: "Muzzle Shot",
                effect: "Deals light Phys damage to 1 foe with a chance of Silence.",
                cost: "9% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Gurr", 0),
                    new SkillPersona("Archangel", 13),
                    new SkillPersona("Obariyon", 14)
                }
            ),
            new Skill(
                name: "Myriad Arrows",
                effect: "Deals heavy Phys damage to all foes 1x to 3x.",
                cost: "22% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Belial", 0),
                    new SkillPersona("Mahakala", 0, true),
                    new SkillPersona("Chernobog", 64),
                    new SkillPersona("Cybele", 67),
                    new SkillPersona("Kartikeya", 69),
                    new SkillPersona("Masakado", 71)
                }
            ),
            new Skill(
                name: "Navas Nebula",
                effect: "Deals medium Phys damage to all foes with a chance of Exhaustion.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hokuto Seikun", 0),
                    new SkillPersona("Shiki-Ouji", 0),
                    new SkillPersona("Pazuzu", 41),
                    new SkillPersona("Clotho", 45)
                }
            ),
            new Skill(
                name: "Nervundi",
                effect: "Cures Exhaustion and Enervation (1 ally).",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lamia", 0),
                    new SkillPersona("Unicorn", 0),
                    new SkillPersona("Parvati", 0),
                    new SkillPersona("Yatagarasu", 0)
                }
            ),
            new Skill(
                name: "Niflheim",
                effect: "Deals severe Ice damage to 1 foe.",
                cost: "48 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Loki", 70, true)
                }
            ),
            new Skill(
                name: "Null Confuse",
                effect: "Become immune to Confusion attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jatayu", 0),
                    new SkillPersona("Power", 33),
                    new SkillPersona("Gorgon", 36),
                    new SkillPersona("Raja Naga", 40),
                    new SkillPersona("Kingu", 59)
                }
            ),
            new Skill(
                name: "Null Dark",
                effect: "Becomes immune to Darkness attacks. (Overwrites Resist Dark)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Dominion", 44),
                    new SkillPersona("Uriel", 64),
                    new SkillPersona("Lakshmi", 68)
                }
            ),
            new Skill(
                name: "Null Dizzy",
                effect: "Cannot become Dizzy after being knocked down.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Triglav", 47),
                    new SkillPersona("Raphael", 57),
                    new SkillPersona("Futsunushi", 83, true),
                    new SkillPersona("Ardha", 92)
                }
            ),
            new Skill(
                name: "Null Elec",
                effect: "Becomes immune to Elec attacks. (Overwrites Resist Elec)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Isis", 86, true)
                }
            ),
            new Skill(
                name: "Null Enervate",
                effect: "Become immune to Enervation attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nozuchi", 32),
                    new SkillPersona("Taotie", 40),
                    new SkillPersona("Alraune", 45),
                    new SkillPersona("Clotho", 50),
                    new SkillPersona("Taowu", 58)
                }
            ),
            new Skill(
                name: "Null Exhaust",
                effect: "Become immune to Exhaustion attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Fuu-Ki", 49),
                    new SkillPersona("Ananta", 64)
                }
            ),
            new Skill(
                name: "Null Fear",
                effect: "Become immune to Fear attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Arahabaki", 0),
                    new SkillPersona("Yatagarasu", 43)
                }
            ),
            new Skill(
                name: "Null Fire",
                effect: "Becomes immune to Fire attacks. (Overwrites Resist Fire)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("King Frost", 27),
                    new SkillPersona("Setanta", 40),
                    new SkillPersona("Kushinada", 48),
                    new SkillPersona("Loki", 69, true)
                }
            ),
            new Skill(
                name: "Null Ice",
                effect: "Becomes immune to Ice attacks. (Overwrites Resist Ice)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Orthrus", 45),
                    new SkillPersona("Surt", 76)
                }
            ),
            new Skill(
                name: "Null Light",
                effect: "Becomes immune to Light attacks. (Overwrites Resist Light)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nebiros", 69),
                    new SkillPersona("Seth", 72)
                }
            ),
            new Skill(
                name: "Null Mute",
                effect: "Become immune to Silence attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mithra", 37),
                    new SkillPersona("Thoth", 49)
                }
            ),
            new Skill(
                name: "Null Physical",
                effect: "Become immune to Phys attacks. (Overwrites Resist Phys)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Abaddon", 62),
                    new SkillPersona("Shiki-Ouji", 62),
                    new SkillPersona("Jinn", 67),
                    new SkillPersona("Thor", 69),
                    new SkillPersona("Ardha", 96)
                }
            ),
            new Skill(
                name: "Null Poison",
                effect: "Become immune to Poison attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lamia", 29),
                    new SkillPersona("Nozuchi", 31),
                    new SkillPersona("Kingu", 60),
                    new SkillPersona("Vasuki", 73)
                }
            ),
            new Skill(
                name: "Null Rage",
                effect: "Become immune to Rage attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Saki Mitama", 16),
                    new SkillPersona("Shiisaa", 26)
                }
            ),
            new Skill(
                name: "Null Wind",
                effect: "Becomes immune to Wind attacks. (Overwrites Resist Wind)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sarasvati", 23),
                    new SkillPersona("Okuninushi", 47),
                    new SkillPersona("Satan", 82)
                }
            ),
            new Skill(
                name: "Old One",
                effect: "Enervates all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Alraune", 0),
                    new SkillPersona("Abaddon", 0),
                    new SkillPersona("Baal Zebul", 0),
                    new SkillPersona("Beelzebub", 0, true),
                    new SkillPersona("Narcissus", 25),
                    new SkillPersona("Lilith", 54),
                    new SkillPersona("Belphegor", 65)
                }
            ),
            new Skill(
                name: "Panta Rhei",
                effect: "Deals severe Wind damage to 1 foe.",
                cost: "48 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Odin", 81, true)
                }
            ),
            new Skill(
                name: "Patra",
                effect: "Dispels Rage, Fear, and Confusion (1 ally).",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Pixie", 0),
                    new SkillPersona("Angel", 0),
                    new SkillPersona("Apsaras", 0),
                    new SkillPersona("Archangel", 0),
                    new SkillPersona("Sarasvati", 0)
                }
            ),
            new Skill(
                name: "Poisma",
                effect: "Poisons 1 foe (40% chance). (-5% HP/turn, -50% STR)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yomotsu-Shikome", 0),
                    new SkillPersona("Ghoul", 0),
                    new SkillPersona("Forneus", 8)
                }
            ),
            new Skill(
                name: "Poison Arrow",
                effect: "Deals medium Phys damage to 1 foe with a chance of Poison.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hitokoto-Nushi", 0),
                    new SkillPersona("Anubis", 60)
                }
            ),
            new Skill(
                name: "Poison Boost",
                effect: "Increases odds of inflicting Poison (1.5x).",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ghoul", 14),
                    new SkillPersona("Gurr", 25),
                    new SkillPersona("Yomotsu-Ikusa", 27),
                    new SkillPersona("Lamia", 28),
                    new SkillPersona("Ose", 34)
                }
            ),
            new Skill(
                name: "Poison Mist",
                effect: "Poisons all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lamia", 0),
                    new SkillPersona("Nozuchi", 0),
                    new SkillPersona("Samael", 0),
                    new SkillPersona("Girimehkala", 0),
                    new SkillPersona("Barong", 0),
                    new SkillPersona("Omoikane", 8),
                    new SkillPersona("Yomotsu-Ikusa", 26),
                    new SkillPersona("Ose", 33),
                    new SkillPersona("Seiryu", 50)
                }
            ),
            new Skill(
                name: "Poison Skewer",
                effect: "Deals light Phys damage to 1 foe with a chance of Poison.",
                cost: "9% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Eligor", 0),
                    new SkillPersona("Ghoul", 12)
                }
            ),
            new Skill(
                name: "Posumudi",
                effect: "Neutralizes Poison (1 ally).",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Undine", 0),
                    new SkillPersona("Virtue", 0),
                    new SkillPersona("Kikuri-Hime", 0)
                }
            ),
            new Skill(
                name: "Power Charge",
                effect: "Next physical attack, physical skill, or Almighty physical attack will be 250% greater in power.",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ose", 0),
                    new SkillPersona("Girimehkala", 0),
                    new SkillPersona("Sui-Ki", 0),
                    new SkillPersona("Siegfried", 0),
                    new SkillPersona("Sraosha", 0, true),
                    new SkillPersona("Yoshitsune", 0),
                    new SkillPersona("Mahakala", 0, true),
                    new SkillPersona("Futsunushi", 0, true),
                    new SkillPersona("Zaou Gongen", 0, true),
                    new SkillPersona("Rakshasa", 28),
                    new SkillPersona("Ares", 30),
                    new SkillPersona("Oni", 35),
                    new SkillPersona("Setanta", 38),
                    new SkillPersona("Hanuman", 48),
                    new SkillPersona("Triglav", 49),
                    new SkillPersona("Yatsufusa", 52),
                    new SkillPersona("Ganesha", 52),
                    new SkillPersona("Kali", 55),
                    new SkillPersona("Tam Lin", 55),
                    new SkillPersona("Kin-Ki", 60),
                    new SkillPersona("Taowu", 60),
                    new SkillPersona("Mara", 63),
                    new SkillPersona("Vishnu", 78, true)
                }
            ),
            new Skill(
                name: "Power Slash",
                effect: "Deals medium Phys damage to 1 foe.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ose", 0),
                    new SkillPersona("Power", 30)
                }
            ),
            new Skill(
                name: "Pralaya",
                effect: "Deals severe Phys damage to all foes with a high chance of instant kills. (50% chance)",
                cost: "25% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Shiva", 87, true)
                }
            ),
            new Skill(
                name: "Primal Force",
                effect: "Deals severe Phys damage to 1 foe.",
                cost: "20% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Futsunushi", 0, true),
                    new SkillPersona("Asura", 0, true),
                    new SkillPersona("Ardha", 0),
                    new SkillPersona("Kartikeya", 75)
                }
            ),
            new Skill(
                name: "Pulinpa",
                effect: "Confuses 1 foe (40% chance). (May attack ally, lose turn, or waste 3% money)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sandman", 0),
                    new SkillPersona("Cu Sith", 0),
                    new SkillPersona("Ukobach", 4)
                }
            ),
            new Skill(
                name: "Rage Boost",
                effect: "Increases odds of inflicting Rage (1.5x).",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mokoi", 16),
                    new SkillPersona("Mothman", 38)
                }
            ),
            new Skill(
                name: "Ragnarok",
                effect: "Deals severe Fire damage to 1 foe.",
                cost: "48 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Surt", 74)
                }
            ),
            new Skill(
                name: "Rainy Death",
                effect: "Deals heavy Phys damage to 1 foe.",
                cost: "20% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Chernobog", 0),
                    new SkillPersona("Siegfried", 68)
                }
            ),
            new Skill(
                name: "Rakukaja",
                effect: "Increases 1 ally's Defense for 3 turns. (Raises one ally's physical/magical defensive strength for three turns.)",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi", 0),
                    new SkillPersona("Cu Sith", 0),
                    new SkillPersona("Hua Po", 0),
                    new SkillPersona("Fortuna", 0),
                    new SkillPersona("Pazuzu", 0),
                    new SkillPersona("Loki", 0, true),
                    new SkillPersona("Shiisaa", 22),
                    new SkillPersona("King Frost", 23),
                    new SkillPersona("Nozuchi", 30)
                }
            ),
            new Skill(
                name: "Rakunda",
                effect: "Decreases 1 foe's Defense for 3 turns. (Reduces one enemy's physical and magic defensive power for three turns.)",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nata Taishi", 0),
                    new SkillPersona("Valkyrie", 0),
                    new SkillPersona("Xiezhai", 0),
                    new SkillPersona("Yaksini", 0),
                    new SkillPersona("Ara Mitama", 0),
                    new SkillPersona("Hanuman", 0),
                    new SkillPersona("Izanagi", 3),
                    new SkillPersona("Apsaras", 5),
                    new SkillPersona("Forneus", 7),
                    new SkillPersona("Ghoul", 13)
                }
            ),
            new Skill(
                name: "Rampage",
                effect: "Deals light Phys damage to all foes 1x to 3x.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Xiezhai", 19),
                    new SkillPersona("Ippon-Datara", 21),
                    new SkillPersona("Legion", 23),
                    new SkillPersona("Matador", 27),
                    new SkillPersona("Ares", 28)
                }
            ),
            new Skill(
                name: "Re Patra",
                effect: "Recovers 1 ally from Knockdown or Dizzy status.",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nigi Mitama", 0),
                    new SkillPersona("Hua Po", 0),
                    new SkillPersona("Ame No Uzume", 21)
                }
            ),
            new Skill(
                name: "Rebellion",
                effect: "Increases Critical rate for 3 turns (1 ally).",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Seiten Taisei", 0)
                }
            ),
            new Skill(
                name: "Recarm",
                effect: "Revives 1 ally with 50% HP.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Hanuman", 0),
                    new SkillPersona("Cybele", 0),
                    new SkillPersona("Nigi Mitama", 25),
                    new SkillPersona("Queen Mab", 26),
                    new SkillPersona("Unicorn", 33),
                    new SkillPersona("Lachesis", 53)
                }
            ),
            new Skill(
                name: "Red Wall",
                effect: "Add Fire resistance to 1 ally (for 3 turns).",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yamata-No-Orochi", 0),
                    new SkillPersona("Kushinada", 0),
                    new SkillPersona("Slime", 4),
                    new SkillPersona("Anzu", 18),
                    new SkillPersona("Titania", 27),
                    new SkillPersona("Kurama Tengu", 52),
                    new SkillPersona("Lachesis", 56)
                }
            ),
            new Skill(
                name: "Regenerate 1",
                effect: "Restores 2% of max HP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Angel", 8),
                    new SkillPersona("Sylph", 12)
                }
            ),
            new Skill(
                name: "Regenerate 2",
                effect: "Recovers 4% of max HP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Andras", 23),
                    new SkillPersona("Titania", 31),
                    new SkillPersona("Genbu", 42),
                    new SkillPersona("Throne", 53),
                    new SkillPersona("Cerberus", 55),
                    new SkillPersona("Sui-Ki", 59)
                }
            ),
            new Skill(
                name: "Regenerate 3",
                effect: "Recovers 6% of max HP each turn in battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Siegfried", 66),
                    new SkillPersona("Alilat", 72),
                    new SkillPersona("Tzitzimitl", 73),
                    new SkillPersona("Seiten Taisei", 74),
                    new SkillPersona("Vishnu", 75, true),
                    new SkillPersona("Odin", 77, true),
                    new SkillPersona("Satan", 77)
                }
            ),
            new Skill(
                name: "Repel Dark",
                effect: "Repels Darkness attacks. (Overwrites Resist/Null Dark)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Michael", 76),
                    new SkillPersona("Sandalphon", 90, true)
                }
            ),
            new Skill(
                name: "Repel Elec",
                effect: "Repels Elec attacks. (Overwrites Resist/Null Elec)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Jatayu", 65),
                    new SkillPersona("Tzitzimitl", 77),
                    new SkillPersona("Yoshitsune", 78),
                    new SkillPersona("Metatron", 88)
                }
            ),
            new Skill(
                name: "Repel Fire",
                effect: "Repels Fire attacks. (Overwrites Resist/Null Fire)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Skadi", 59),
                    new SkillPersona("Metatron", 89)
                }
            ),
            new Skill(
                name: "Repel Ice",
                effect: "Repels Ice attacks. (Overwrites Resist/Null Ice)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Skadi", 57),
                    new SkillPersona("Metatron", 87)
                }
            ),
            new Skill(
                name: "Repel Light",
                effect: "Repels Light attacks. (Overwrites Resist/Null Light)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yurlungur", 75),
                    new SkillPersona("Lucifer", 96, true)
                }
            ),
            new Skill(
                name: "Repel Physical",
                effect: "Repels Phys attacks. (Overwrites Resist/Null Phys)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Rangda", 55),
                    new SkillPersona("Girimehkala", 56),
                    new SkillPersona("Arahabaki", 80)
                }
            ),
            new Skill(
                name: "Repel Wind",
                effect: "Repels Wind attacks. (Overwrites Resist/Null Wind)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Garuda", 62),
                    new SkillPersona("Helel", 91, true)
                }
            ),
            new Skill(
                name: "Resist Confuse",
                effect: "Reduces chance of being Confused.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Berith", 20),
                    new SkillPersona("Principality", 23),
                    new SkillPersona("Queen Mab", 30)
                }
            ),
            new Skill(
                name: "Resist Dark",
                effect: "Reduces chance of instant death from Darkness attacks. (Voids Dark weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Virtue", 39),
                    new SkillPersona("Kikuri-Hime", 53),
                    new SkillPersona("Throne", 54)
                }
            ),
            new Skill(
                name: "Resist Dizzy",
                effect: "Reduces chance of being Dizzy.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nata Taishi", 9),
                    new SkillPersona("Orobas", 11)
                }
            ),
            new Skill(
                name: "Resist Elec",
                effect: "Reduces damage from Elec attacks. (Voids Elec weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Omoikane", 12),
                    new SkillPersona("Kurama Tengu", 53),
                    new SkillPersona("Kumbhanda", 59)
                }
            ),
            new Skill(
                name: "Resist Enervate",
                effect: "Reduces chance of being Enervated.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Nigi Mitama", 29),
                    new SkillPersona("Yamata-No-Orochi", 38)
                }
            ),
            new Skill(
                name: "Resist Exhaust",
                effect: "Reduces chance of being Exhausted.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Eligor", 17),
                    new SkillPersona("Dominion", 41),
                    new SkillPersona("Hokuto Seikun", 48),
                    new SkillPersona("Seiryu", 53),
                    new SkillPersona("Lachesis", 57)
                }
            ),
            new Skill(
                name: "Resist Fear",
                effect: "Lessens instances of succumbing to Fear attacks.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Titan", 19)
                }
            ),
            new Skill(
                name: "Resist Fire",
                effect: "Reduces damage from Fire attacks. (Voids Fire weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ukobach", 6),
                    new SkillPersona("Shiisaa", 25),
                    new SkillPersona("Narcissus", 26),
                    new SkillPersona("Hitokoto-Nushi", 45),
                    new SkillPersona("Mother Harlot", 64),
                    new SkillPersona("Lakshmi", 70)
                }
            ),
            new Skill(
                name: "Resist Ice",
                effect: "Reduces damage from Ice attacks. (Voids Ice weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Makami", 33),
                    new SkillPersona("Pyro Jack", 38),
                    new SkillPersona("Suzaku", 58)
                }
            ),
            new Skill(
                name: "Resist Light",
                effect: "Reduces chance of instant death from Light attacks. (Voids Light weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kaiwan", 27),
                    new SkillPersona("Succubus", 49)
                }
            ),
            new Skill(
                name: "Resist Mute",
                effect: "Reduces chance of being Silenced.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Makami", 31)
                }
            ),
            new Skill(
                name: "Resist Physical",
                effect: "Reduces damage from Phys attacks. (Voids Phys weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Slime", 7),
                    new SkillPersona("Obariyon", 17),
                    new SkillPersona("Gurr", 27),
                    new SkillPersona("Oni", 33),
                    new SkillPersona("Genbu", 45),
                    new SkillPersona("Decarabia", 52),
                    new SkillPersona("Nidhoggr", 60),
                    new SkillPersona("Jinn", 65)
                }
            ),
            new Skill(
                name: "Resist Poison",
                effect: "Reduces chance of being Poisoned.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Omoikane", 11)
                }
            ),
            new Skill(
                name: "Resist Rage",
                effect: "Reduces chance of being Enraged.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sarasvati", 20)
                }
            ),
            new Skill(
                name: "Resist Wind",
                effect: "Reduces damage from Wind attacks. (Voids Wind weakness)",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Omoikane", 9),
                    new SkillPersona("Chernobog", 66)
                }
            ),
            new Skill(
                name: "Revolution",
                effect: "Greatly increases Critical rate for 3 turns (all).",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Shiki-Ouji", 0),
                    new SkillPersona("Kali", 53),
                    new SkillPersona("Kin-Ki", 59),
                    new SkillPersona("Hachiman", 75),
                    new SkillPersona("Ongyo-Ki", 86, true)
                }
            ),
            new Skill(
                name: "Salvation",
                effect: "Fully restores party's HP. Cures ailments.",
                cost: "40 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ishtar", 78, true),
                    new SkillPersona("Kohryu", 83, true),
                    new SkillPersona("Isis", 85, true),
                    new SkillPersona("Helel", 88, true)
                }
            ),
            new Skill(
                name: "Samarecarm",
                effect: "Revives 1 ally with full HP.",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ishtar", 0, true),
                    new SkillPersona("Kohryu", 0, true),
                    new SkillPersona("Sandalphon", 0, true),
                    new SkillPersona("Leanan Sidhe", 46),
                    new SkillPersona("Kikuri-Hime", 50),
                    new SkillPersona("Hariti", 64),
                    new SkillPersona("Cybele", 68),
                    new SkillPersona("Yurlungur", 74),
                    new SkillPersona("Attis", 86, true)
                }
            ),
            new Skill(
                name: "Samsara",
                effect: "Light: very high chance of instant kill, all foes. (60% chance)",
                cost: "44 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Daisoujou", 67)
                }
            ),
            new Skill(
                name: "Seal Bomb",
                effect: "Deals medium Phys damage to all foes with a chance of Silence.",
                cost: "14% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mithra", 0),
                    new SkillPersona("Kin-Ki", 57)
                }
            ),
            new Skill(
                name: "Sharp Student",
                effect: "Lowers odds of sustaining crit dmg.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Setanta", 0),
                    new SkillPersona("Loki", 0, true),
                    new SkillPersona("Orobas", 12),
                    new SkillPersona("Archangel", 14),
                    new SkillPersona("Ara Mitama", 21)
                }
            ),
            new Skill(
                name: "Silence Boost",
                effect: "Increases odds of inflicting Silence (1.5x).",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Obariyon", 15),
                    new SkillPersona("Xiezhai", 18),
                    new SkillPersona("Shiisaa", 24),
                    new SkillPersona("Pabilsag", 54),
                    new SkillPersona("Tzitzimitl", 71)
                }
            ),
            new Skill(
                name: "Single Shot",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "8% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Berith", 0),
                    new SkillPersona("Obariyon", 18)
                }
            ),
            new Skill(
                name: "Skewer",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "5% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Forneus", 0),
                    new SkillPersona("Yomotsu-Shikome", 0)
                }
            ),
            new Skill(
                name: "Skull Cracker",
                effect: "Deals light Phys damage to 1 foe with a chance of Confusion.",
                cost: "9% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Titan", 0),
                    new SkillPersona("Sandman", 6)
                }
            ),
            new Skill(
                name: "Sonic Punch",
                effect: "Deals light Phys damage to 1 foe.",
                cost: "8% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Obariyon", 0),
                    new SkillPersona("Mokoi", 0),
                    new SkillPersona("Nata Taishi", 7)
                }
            ),
            new Skill(
                name: "Soul Break",
                effect: "Exhausts 1 foe (40% chance). (-10% SP/turn)",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kusi Mitama", 0),
                    new SkillPersona("Nata Taishi", 10),
                    new SkillPersona("Eligor", 16),
                    new SkillPersona("Mokoi", 18),
                    new SkillPersona("Lamia", 30)
                }
            ),
            new Skill(
                name: "Spell Master",
                effect: "Halves SP cost for magic skills.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Skadi", 60),
                    new SkillPersona("Nebiros", 70),
                    new SkillPersona("Ishtar", 76, true),
                    new SkillPersona("Kaguya", 80),
                    new SkillPersona("Saturnus", 81),
                    new SkillPersona("Kohryu", 82, true),
                    new SkillPersona("Shiva", 83, true),
                    new SkillPersona("Asura", 90, true),
                    new SkillPersona("Lucifer", 95, true)
                }
            ),
            new Skill(
                name: "Spirit Drain",
                effect: "Drains 30 SP from 1 foe.",
                cost: "3 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kaiwan", 29),
                    new SkillPersona("Incubus", 32),
                    new SkillPersona("Succubus", 48)
                }
            ),
            new Skill(
                name: "Stagnant Air",
                effect: "Increase all foe's susceptibility to ailments and Light/Dark skills.",
                cost: "5 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kaiwan", 26),
                    new SkillPersona("Incubus", 30),
                    new SkillPersona("Pazuzu", 39),
                    new SkillPersona("Pabilsag", 53),
                    new SkillPersona("Nidhoggr", 59),
                    new SkillPersona("Baal Zebul", 82),
                    new SkillPersona("Beelzebub", 82, true)
                }
            ),
            new Skill(
                name: "Sukukaja",
                effect: "Increases 1 ally's Hit/Evasion rates for 3 turns.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sylph", 0),
                    new SkillPersona("Andras", 0),
                    new SkillPersona("High Pixie", 0),
                    new SkillPersona("Angel", 6),
                    new SkillPersona("Ghoul", 10),
                    new SkillPersona("Lilim", 13)
                }
            ),
            new Skill(
                name: "Sukunda",
                effect: "Decreases 1 foe's Hit/Evasion rates for 3 turns.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ukobach", 0),
                    new SkillPersona("Omoikane", 0),
                    new SkillPersona("Saki Mitama", 0),
                    new SkillPersona("Makami", 0),
                    new SkillPersona("Yomotsu-Shikome", 9)
                }
            ),
            new Skill(
                name: "Survive Dark",
                effect: "50% chance of surviving instant death 1 time from a Darkness attack with 1 HP.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Archangel", 15),
                    new SkillPersona("Principality", 24),
                    new SkillPersona("Power", 32),
                    new SkillPersona("Kusi Mitama", 32),
                    new SkillPersona("Dominion", 43),
                    new SkillPersona("Gabriel", 47)
                }
            ),
            new Skill(
                name: "Survive Light",
                effect: "50% chance of surviving instant death 1 time from a Light attack with 1 HP.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Legion", 26),
                    new SkillPersona("Take-Minakata", 29),
                    new SkillPersona("Matador", 30),
                    new SkillPersona("Kusi Mitama", 31),
                    new SkillPersona("Ose", 36),
                    new SkillPersona("Pale Rider", 39),
                    new SkillPersona("Samael", 41),
                    new SkillPersona("Loa", 42),
                    new SkillPersona("Mot", 48)
                }
            ),
            new Skill(
                name: "Swift Strike",
                effect: "Deals light Phys damage to all foes 1x to 2x.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Matador", 0),
                    new SkillPersona("Yaksini", 20),
                    new SkillPersona("Gurr", 22)
                }
            ),
            new Skill(
                name: "Tarukaja",
                effect: "Increases 1 ally's Attack for 3 turns. (Raises one ally's physical/magical offensive strength for three turns.)",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Forneus", 0),
                    new SkillPersona("Obariyon", 0),
                    new SkillPersona("Flauros", 0),
                    new SkillPersona("Izanagi", 5),
                    new SkillPersona("Ara Mitama", 20)
                }
            ),
            new Skill(
                name: "Tarunda",
                effect: "Decreases 1 foe's Attack for 3 turns. (Reduces one enemy's physical/offensive magic strength for three turns.)",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Omoikane", 0),
                    new SkillPersona("Pyro Jack", 0),
                    new SkillPersona("Slime", 3)
                }
            ),
            new Skill(
                name: "Tempest Slash",
                effect: "Deals heavy Phys damage to 1 foe 1x to 2x.",
                cost: "15% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Narasimha", 0),
                    new SkillPersona("Masakado", 0)
                }
            ),
            new Skill(
                name: "Tentarafoo",
                effect: "Confuses* all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Legion", 0),
                    new SkillPersona("Narcissus", 0),
                    new SkillPersona("Queen Mab", 0),
                    new SkillPersona("Power", 0),
                    new SkillPersona("Raja Naga", 0),
                    new SkillPersona("Mot", 0),
                    new SkillPersona("Rangda", 0),
                    new SkillPersona("Leanan Sidhe", 43),
                    new SkillPersona("Baal Zebul", 78),
                    new SkillPersona("Beelzebub", 78, true)
                }
            ),
            new Skill(
                name: "Tetra Break",
                effect: "Negates all foes' Tetrakarn.",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Chernobog", 0),
                    new SkillPersona("Mithra", 33),
                    new SkillPersona("Abaddon", 60),
                    new SkillPersona("Sui-Ki", 60)
                }
            ),
            new Skill(
                name: "Tetraja",
                effect: "Nullifies instant kill attack once (1 ally).",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Principality", 25),
                    new SkillPersona("Loa", 47),
                    new SkillPersona("Girimehkala", 52),
                    new SkillPersona("Kumbhanda", 61),
                    new SkillPersona("Kaguya", 75)
                }
            ),
            new Skill(
                name: "Tetrakarn",
                effect: "Barrier that reflects phys dmg once. (1 ally)",
                cost: "36 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kaiwan", 0),
                    new SkillPersona("Decarabia", 0),
                    new SkillPersona("Isis", 0, true),
                    new SkillPersona("Arahabaki", 76)
                }
            ),
            new Skill(
                name: "Thunder Reign",
                effect: "Deals severe Elec damage to 1 foe.",
                cost: "48 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Thor", 70)
                }
            ),
            new Skill(
                name: "Torrent Shot",
                effect: "Deals medium Phys damage to 1 foe 2x to 3x.",
                cost: "12% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Fuu-Ki", 0),
                    new SkillPersona("Raja Naga", 39),
                    new SkillPersona("Taotie", 41)
                }
            ),
            new Skill(
                name: "Traesto",
                effect: "Instantly escape from a dungeon. (Not available during combat)",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Sandman", 11),
                    new SkillPersona("Cu Sith", 15),
                    new SkillPersona("Kusi Mitama", 33)
                }
            ),
            new Skill(
                name: "Trafuri",
                effect: "Enables escape from most battles. (100% chance to escape normal battles)",
                cost: "24 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Pixie", 8),
                    new SkillPersona("Senri", 14),
                    new SkillPersona("Ame No Uzume", 24),
                    new SkillPersona("High Pixie", 27),
                    new SkillPersona("Unicorn", 32),
                    new SkillPersona("Sati", 34)
                }
            ),
            new Skill(
                name: "Twin Shot",
                effect: "Deals light Phys damage to 1 foe 2x.",
                cost: "10% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Principality", 0),
                    new SkillPersona("Phoenix", 22)
                }
            ),
            new Skill(
                name: "Unshaken Will",
                effect: "Protects user from Rage/Fear/Silence/Enervation/Confusion.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Asura", 92, true)
                }
            ),
            new Skill(
                name: "Valiant Dance",
                effect: "Enrages all foes (30% chance).",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Mothman", 0),
                    new SkillPersona("Mokoi", 15),
                    new SkillPersona("Jinn", 68)
                }
            ),
            new Skill(
                name: "Vicious Strike",
                effect: "Deals heavy Phys damage to all foes.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kurama Tengu", 0),
                    new SkillPersona("Sui-Ki", 0),
                    new SkillPersona("Cybele", 0),
                    new SkillPersona("Arahabaki", 0),
                    new SkillPersona("Cerberus", 53),
                    new SkillPersona("Kingu", 62)
                }
            ),
            new Skill(
                name: "Victory Cry",
                effect: "Recover full HP and SP after a successful battle.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi-No-Okami", 0, false, true),
                    new SkillPersona("Lucifer", 99, true)
                }
            ),
            new Skill(
                name: "Vile Assault",
                effect: "Deals heavy Phys damage to 1 foe. Bonus damage to foes that are knocked down.",
                cost: "18% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Kin-Ki", 0)
                }
            ),
            new Skill(
                name: "Virus Wave",
                effect: "Deals heavy Phys damage to all foes with a chance of Poison.",
                cost: "16% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Yurlungur", 0),
                    new SkillPersona("Tzitzimitl", 0),
                    new SkillPersona("Vasuki", 0)
                }
            ),
            new Skill(
                name: "Vorpal Blade",
                effect: "Deals heavy Phys damage to all foes.",
                cost: "25% HP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Michael", 0),
                    new SkillPersona("Seiten Taisei", 76),
                    new SkillPersona("Zaou Gongen", 96, true)
                }
            ),
            new Skill(
                name: "White Wall",
                effect: "Add Ice resistance to 1 ally (for 3 turns).",
                cost: "18 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Ananta", 0),
                    new SkillPersona("Cu Sith", 14),
                    new SkillPersona("Cu Chulainn", 49)
                }
            ),
            new Skill(
                name: "Wind Amp",
                effect: "Strengthens Wind attacks by 50%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Cu Chulainn", 53),
                    new SkillPersona("Quetzalcoatl", 57),
                    new SkillPersona("Atropos", 70),
                    new SkillPersona("Horus", 70),
                    new SkillPersona("Seth", 73),
                    new SkillPersona("Norn", 76, true),
                    new SkillPersona("Odin", 76, true),
                    new SkillPersona("Suparna", 80),
                    new SkillPersona("Scathach", 84, true),
                    new SkillPersona("Izanagi-No-Okami", 99, false, true)
                }
            ),
            new Skill(
                name: "Wind Boost",
                effect: "Strengthens Wind attacks by 25%.",
                cost: "",
                personas: new List<SkillPersona> {
                    new SkillPersona("Atropos", 0),
                    new SkillPersona("Fortuna", 40),
                    new SkillPersona("Fuu-Ki", 47),
                    new SkillPersona("Clotho", 48),
                    new SkillPersona("Kurama Tengu", 51)
                }
            ),
            new Skill(
                name: "Wind Break",
                effect: "Nullifies 1 foe's Wind resistance (for 3 turns).",
                cost: "15 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Seth", 71)
                }
            ),
            new Skill(
                name: "Zio",
                effect: "Deals light Elec damage to 1 foe.",
                cost: "4 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Izanagi", 0),
                    new SkillPersona("Omoikane", 0),
                    new SkillPersona("Lilim", 0),
                    new SkillPersona("Oberon", 0),
                    new SkillPersona("Xiezhai", 0),
                    new SkillPersona("Pixie", 3)
                }
            ),
            new Skill(
                name: "Ziodyne",
                effect: "Deals heavy Elec damage to 1 foe.",
                cost: "12 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Lilith", 0),
                    new SkillPersona("Tam Lin", 0),
                    new SkillPersona("Barong", 0),
                    new SkillPersona("Thor", 0),
                    new SkillPersona("Trumpeter", 0),
                    new SkillPersona("Tzitzimitl", 0),
                    new SkillPersona("Odin", 0, true),
                    new SkillPersona("Yoshitsune", 0),
                    new SkillPersona("Kohryu", 0, true),
                    new SkillPersona("Shiva", 0, true),
                    new SkillPersona("Ongyo-Ki", 0, true),
                    new SkillPersona("Loa", 43),
                    new SkillPersona("Seiryu", 49),
                    new SkillPersona("Thoth", 51),
                    new SkillPersona("Hokuto Seikun", 51),
                    new SkillPersona("Sraosha", 76, true),
                    new SkillPersona("Vasuki", 77),
                    new SkillPersona("Izanagi-No-Okami", 94, false, true)
                }
            ),
            new Skill(
                name: "Zionga",
                effect: "Deals medium Elec damage to 1 foe.",
                cost: "8 SP",
                personas: new List<SkillPersona> {
                    new SkillPersona("Queen Mab", 0),
                    new SkillPersona("Take-Minakata", 0),
                    new SkillPersona("Kusi Mitama", 0),
                    new SkillPersona("Unicorn", 0),
                    new SkillPersona("Neko Shogun", 0),
                    new SkillPersona("Mothman", 0),
                    new SkillPersona("Setanta", 0),
                    new SkillPersona("Dominion", 0),
                    new SkillPersona("Okuninushi", 0),
                    new SkillPersona("Hokuto Seikun", 0),
                    new SkillPersona("Shiisaa", 23),
                    new SkillPersona("Andras", 24),
                    new SkillPersona("High Pixie", 24),
                    new SkillPersona("Power", 29),
                    new SkillPersona("Nozuchi", 29),
                    new SkillPersona("Hitokoto-Nushi", 43)
                }
            )
    }
}
