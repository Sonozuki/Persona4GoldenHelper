using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The persona/shadow skills data.</summary>
    public static class SkillData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The persona/shadow skills data.</summary>
        public static List<Skill> Skills { get; } = new()
        {
            new("Absorb Elec", "Absorbs damage from Elec attacks. (Overwrites Resist/Null/Repel Elec)", "", new()
            {
                new("Lucifer", 98, true, false)
            }),
            new("Absorb Fire", "Absorbs damage from Fire attacks. (Overwrites Resist/Null/Repel Fire)", "", new()
            {
                new("Taowu", 62, false, false),
                new("Hell Biker", 71, false, false)
            }),
            new("Absorb Ice", "Absorbs damage from Ice attacks. (Overwrites Resist/Null/Repel Ice)", "", new()
            {
                new("Isis", 82, true, false)
            }),
            new("Absorb Physical", "Absorbs damage from Phys attacks. (Overwrites Resist/Null/Repel Phys)", "", new()
            {
                new("Mara", 66, false, false)
            }),
            new("Absorb Wind", "Absorbs damage from Wind attacks. (Overwrites Resist/Null/Repel Wind)", "", new()
            {
                new("Lachesis", 55, false, false),
                new("Horus", 73, false, false),
                new("Ishtar", 77, true, false)
            }),
            new("Aeon Rain", "Deals medium Phys damage to all foes 1x to 3x.", "18% HP", new()
            {
                new("Skadi", 0, false, false),
                new("Taowu", 0, false, false),
                new("Hell Biker", 0, false, false)
            }),
            new("Agi", "Deals light Fire damage to 1 foe.", "4 SP", new()
            {
                new("Ukobach", 0, false, false),
                new("Orobas", 0, false, false),
                new("Senri", 0, false, false),
                new("Eligor", 0, false, false)
            }),
            new("Agidyne", "Deals heavy Fire damage to 1 foe.", "12 SP", new()
            {
                new("Decarabia", 0, false, false),
                new("Throne", 0, false, false),
                new("Yatsufusa", 0, false, false),
                new("Cerberus", 0, false, false),
                new("Kumbhanda", 0, false, false),
                new("Jinn", 0, false, false),
                new("Mara", 0, false, false),
                new("Nebiros", 0, false, false),
                new("Hell Biker", 0, false, false),
                new("Surt", 0, false, false),
                new("Saturnus", 0, false, false),
                new("Mada", 0, true, false),
                new("Mahakala", 0, true, false),
                new("Attis", 0, true, false),
                new("Black Frost", 43, false, false),
                new("Dis", 43, false, false),
                new("Rangda", 49, false, false),
                new("Suzaku", 56, false, false),
                new("Abaddon", 56, false, false),
                new("White Rider", 60, false, false),
                new("Uriel", 61, false, false),
                new("Daisoujou", 62, false, false),
                new("Belial", 69, false, false),
                new("Izanagi-No-Okami", 92, false, true)
            }),
            new("Agilao", "Deals medium Fire damage to 1 foe.", "8 SP", new()
            {
                new("Hua Po", 0, false, false),
                new("Lamia", 0, false, false),
                new("Makami", 0, false, false),
                new("Incubus", 0, false, false),
                new("Sati", 0, false, false),
                new("Gdon", 0, false, false),
                new("Pyro Jack", 0, false, false),
                new("Flauros", 0, false, false),
                new("Orthrus", 0, false, false),
                new("Yatagarasu", 0, false, false),
                new("Succubus", 0, false, false),
                new("Kikuri-Hime", 0, false, false),
                new("Ippon-Datara", 20, false, false)
            }),
            new("Agneyastra", "Deals heavy Phys damage to all foes 1x to 3x.", "24% HP", new()
            {
                new("Sandalphon", 88, true, false)
            }),
            new("Ailment Boost", "All status ailment attacks are 1.5 times more effective.", "", new()
            {
                new("Nozuchi", 0, false, false),
                new("Narcissus", 30, false, false),
                new("Pazuzu", 40, false, false),
                new("Baphomet", 49, false, false),
                new("Lilith", 57, false, false),
                new("Mother Harlot", 65, false, false),
                new("Mada", 83, true, false),
                new("Ongyo-Ki", 84, true, false)
            }),
            new("Akasha Arts", "Deals heavy Phys damage to all foes 1x to 2x.", "18% HP", new()
            {
                new("Siegfried", 0, false, false),
                new("Melchizedek", 0, false, false),
                new("Vishnu", 0, true, false)
            }),
            new("Alertness", "Lowers odds of being taken by surprise. (Decreases enemy advantage)", "", new()
            {
                new("Anzu", 0, false, false),
                new("Saki Mitama", 13, false, false),
                new("Kumbhanda", 56, false, false),
                new("Arahabaki", 74, false, false)
            }),
            new("Ali Dance", "The Hit rate of an attacking unit is reduced by half.", "", new()
            {
                new("Futsunushi", 84, true, false)
            }),
            new("Amrita", "Cures all ailments except Down and Death (party).", "12 SP", new()
            {
                new("Atavaka", 0, false, false),
                new("Attis", 0, true, false),
                new("Sandalphon", 0, true, false),
                new("Raphael", 56, false, false),
                new("Garuda", 60, false, false),
                new("Jatayu", 62, false, false),
                new("Byakko", 66, false, false),
                new("Lakshmi", 71, false, false),
                new("Ishtar", 75, true, false),
                new("Scathach", 81, true, false)
            }),
            new("Angelic Grace", "Doubles evasion rate against all attacks but Light/Darkness/Almighty.", "", new()
            {
                new("Izanagi-No-Okami", 0, false, true),
                new("Vishnu", 79, true, false),
                new("Sraosha", 81, true, false),
                new("Sandalphon", 87, true, false),
                new("Ardha", 95, false, false)
            }),
            new("Anima Freeze", "Exhausts to all foes (30% chance).", "12 SP", new()
            {
                new("Narcissus", 27, false, false),
                new("King Frost", 28, false, false),
                new("Zaou Gongen", 92, true, false)
            }),
            new("Apt Pupil", "Increases user's Critical Rate.", "", new()
            {
                new("Flauros", 39, false, false),
                new("Okuninushi", 45, false, false),
                new("Fuu-Ki", 46, false, false),
                new("Shiki-Ouji", 58, false, false),
                new("Futsunushi", 82, true, false)
            }),
            new("Arm Chopper", "Deals light Phys damage to 1 foe with a chance of Fear.", "9% HP", new()
            {
                new("Oberon", 0, false, false),
                new("Yaksini", 0, false, false),
                new("Valkyrie", 11, false, false),
                new("Eligor", 14, false, false)
            }),
            new("Arms Master", "Halves HP cost for physical skills.", "", new()
            {
                new("Thor", 67, false, false),
                new("Seiten Taisei", 71, false, false),
                new("Masakado", 74, false, false),
                new("Atavaka", 79, false, false),
                new("Futsunushi", 85, true, false),
                new("Helel", 92, true, false)
            }),
            new("Arrow Rain", "Deals heavy Phys damage to all foes 2x.", "18% HP", new()
            {
                new("Abaddon", 0, false, false),
                new("Garuda", 0, false, false),
                new("Pabilsag", 56, false, false),
                new("Hariti", 62, false, false)
            }),
            new("Assault Dive", "Deals light Phys damage to 1 foe.", "10% HP", new()
            {
                new("Ara Mitama", 0, false, false)
            }),
            new("Atom Smasher", "Deals medium Phys damage to all foes 1x to 2x with a chance of Fear.", "16% HP", new()
            {
                new("Ose", 0, false, false),
                new("Oni", 32, false, false)
            }),
            new("Auto-Maraku", "Party begins the battle with Marakukaja. (Overwrites Auto-Rakukaja)", "", new()
            {
                new("Arahabaki", 0, false, false),
                new("Setanta", 39, false, false),
                new("Tam Lin", 54, false, false),
                new("Alilat", 75, false, false)
            }),
            new("Auto-Masuku", "Party begins the battle with Masukukaja. (Overwrites Auto-Sukukaja)", "", new()
            {
                new("Kumbhanda", 0, false, false),
                new("Kingu", 0, false, false),
                new("Hitokoto-Nushi", 47, false, false),
                new("Suzaku", 60, false, false),
                new("Norn", 74, true, false)
            }),
            new("Auto-Mataru", "Party begins the battle with Matarukaja. (Overwrites Auto-Tarukaja)", "", new()
            {
                new("Kartikeya", 0, false, false),
                new("Narasimha", 53, false, false)
            }),
            new("Auto-Rakukaja", "Automatic Rakukaja at the start of battle.", "", new()
            {
                new("Ame No Uzume", 23, false, false),
                new("Take-Minakata", 30, false, false),
                new("Pyro Jack", 37, false, false),
                new("Ardha", 93, false, false)
            }),
            new("Auto-Sukukaja", "Automatic Sukukaja at the start of battle.", "", new()
            {
                new("Hitokoto-Nushi", 0, false, false),
                new("Anzu", 20, false, false),
                new("Matador", 29, false, false),
                new("Makami", 29, false, false),
                new("Ose", 35, false, false),
                new("Fortuna", 39, false, false),
                new("Cerberus", 58, false, false),
                new("Garuda", 63, false, false),
                new("Byakko", 64, false, false)
            }),
            new("Auto-Tarukaja", "Automatic Tarukaja at the start of battle.", "", new()
            {
                new("Gurr", 0, false, false),
                new("Yaksini", 23, false, false),
                new("Rakshasa", 26, false, false)
            }),
            new("Balzac", "Enrages 1 foe (40% chance). (Doubles STR, uncontrollable, auto attacks with weapon)", "5 SP", new()
            {
                new("Anzu", 0, false, false),
                new("Shiisaa", 0, false, false)
            }),
            new("Bash", "Deals light Phys damage to 1 foe.", "6% HP", new()
            {
                new("Slime", 0, false, false),
                new("Nata Taishi", 0, false, false),
                new("Ghoul", 0, false, false)
            }),
            new("Black Spot", "Deals medium Phys damage to 1 foe.", "16% HP", new()
            {
                new("Neko Shogun", 0, false, false),
                new("Orthrus", 0, false, false)
            }),
            new("Black Viper", "Deals massive Almighty damage to 1 foe.", "64 SP", new()
            {
                new("Satan", 81, false, false)
            }),
            new("Blade of Fury", "Deals medium Phys damage to all foes 2x to 4x.", "18% HP", new()
            {
                new("Okuninushi", 0, false, false),
                new("Hanuman", 44, false, false),
                new("Hokuto Seikun", 47, false, false)
            }),
            new("Blight", "Deals heavy Phys damage to all foes with a chance of Poison.", "16% HP", new()
            {
                new("Pabilsag", 0, false, false),
                new("Mara", 0, false, false),
                new("Girimehkala", 51, false, false)
            }),
            new("Blue Wall", "Add Elec resistance to 1 ally (for 3 turns).", "18 SP", new()
            {
                new("Ara Mitama", 22, false, false),
                new("Andra", 22, false, false),
                new("Virtue", 37, false, false),
                new("Genbu", 44, false, false),
                new("Triglav", 48, false, false)
            }),
            new("Brain Shake", "Deals light Phys damage to 1 foe 1x to 3x with a chance of Exhaustion.", "12% HP", new()
            {
                new("Rakshasa", 0, false, false),
                new("Berith", 19, false, false),
                new("Vetala", 22, false, false)
            }),
            new("Brave Blade", "Deals severe Phys damage to 1 foe.", "20% HP", new()
            {
                new("Seiten Taisei", 0, false, false),
                new("Sraosha", 0, true, false),
                new("Yoshitsune", 0, false, false),
                new("Lucifer", 0, true, false),
                new("Atavaka", 74, false, false)
            }),
            new("Bufu", "Deals light Ice damage to 1 foe.", "4 SP", new()
            {
                new("Forneus", 0, false, false),
                new("Valkyrie", 0, false, false),
                new("Saki Mitama", 0, false, false),
                new("Apsaras", 7, false, false)
            }),
            new("Bufudyne", "Deals heavy Ice damage to 1 foe.", "12 SP", new()
            {
                new("Kali", 0, false, false),
                new("Sui-Ki", 0, false, false),
                new("Hariti", 0, false, false),
                new("Byakko", 0, false, false),
                new("Loki", 0, true, false),
                new("Lakshmi", 0, false, false),
                new("Yurlungur", 0, false, false),
                new("Isis", 0, true, false),
                new("Lucifer", 0, true, false),
                new("Skadi", 54, false, false),
                new("Nidhoggr", 58, false, false),
                new("Ananta", 61, false, false),
                new("Izanagi-No-Okami", 93, false, true)
            }),
            new("Bufula", "Deals medium Ice damage to 1 foe.", "8 SP", new()
            {
                new("King Frost", 0, false, false),
                new("Ganga", 0, false, false),
                new("Undine", 0, false, false),
                new("Gorgon", 0, false, false),
                new("Pazuzu", 0, false, false),
                new("Black Frost", 0, false, false),
                new("Jack Frost", 19, false, false),
                new("Yaksini", 22, false, false)
            }),
            new("Cell Breaker", "Deals light Phys damage to 1 foe with a chance of Enervation.", "10% HP", new()
            {
                new("Yomotsu-Ikusa", 0, false, false),
                new("Kaiwan", 0, false, false)
            }),
            new("Cleave", "Deals light Phys damage to 1 foe.", "5% HP", new()
            {
                new("Izanagi", 0, false, false),
                new("Valkyrie", 0, false, false)
            }),
            new("Confuse Boost", "Increases odds of inflicting Confusion (1.5x).", "", new()
            {
                new("Ukobach", 5, false, false),
                new("Sandman", 7, false, false),
                new("Legion", 24, false, false),
                new("Ganga", 32, false, false),
                new("Taotie", 37, false, false),
                new("Raja Naga", 43, false, false),
                new("Leanan Sidhe", 44, false, false)
            }),
            new("Cool Breeze", "Recover 8% HP and SP after a successful battle.", "", new()
            {
                new("Pazuzu", 42, false, false),
                new("Yatagarasu", 46, false, false),
                new("Trumpeter", 69, false, false),
                new("Isis", 80, true, false)
            }),
            new("Counter", "10% chance of reflecting Phys attacks. Does not stack.", "", new()
            {
                new("Rakshasa", 0, false, false),
                new("Ares", 0, false, false),
                new("Oni", 0, false, false)
            }),
            new("Counterstrike", "15% chance of reflecting Phys attacks. Does not stack.", "", new()
            {
                new("Triglav", 0, false, false),
                new("Fuu-Ki", 0, false, false),
                new("Pale Rider", 35, false, false),
                new("Setanta", 36, false, false),
                new("Okuninushi", 43, false, false),
                new("Narasimha", 48, false, false),
                new("Hokuto Seikun", 50, false, false)
            }),
            new("Crazy Chain", "Deals medium Phys damage to all foes with a chance of Rage.", "14% HP", new()
            {
                new("Gorgon", 35, false, false),
                new("Flauros", 41, false, false)
            }),
            new("Cruel Attack", "Medium Phys dmg, 1 foe. Bonus damage to foes that are knocked down.", "12% HP", new()
            {
                new("Oni", 0, false, false)
            }),
            new("Deathbound", "Deals heavy Phys damage to all foes.", "20% HP", new()
            {
                new("Cu Chulainn", 0, false, false),
                new("Tam Lin", 0, false, false),
                new("Byakko", 0, false, false),
                new("Thor", 0, false, false),
                new("Surt", 0, false, false),
                new("Kali", 52, false, false),
                new("Kumbhanda", 60, false, false)
            }),
            new("Debilitate", "Decreases 1 foe's Attack, Defense, and Hit/Evasion rates for 3 turns.", "30 SP", new()
            {
                new("Trumpeter", 73, false, false),
                new("Norn", 79, true, false)
            }),
            new("Dekaja", "Nullifies stat bonuses on all foes. (Offsets the effects of all enemies' '-kaja' magic.)", "10 SP", new()
            {
                new("Orobas", 0, false, false),
                new("Obariyon", 0, false, false),
                new("Mokoi", 0, false, false),
                new("Ganga", 0, false, false),
                new("Taowu", 0, false, false),
                new("Nebiros", 0, false, false),
                new("Sandman", 8, false, false),
                new("Sarasvati", 21, false, false),
                new("Ares", 29, false, false),
                new("Take-Minakata", 31, false, false),
                new("Tzitzimitl", 72, false, false)
            }),
            new("Dekunda", "Nullifies stat penalties on party. (Offsets the effects of '-nda' magic for all allies.)", "10 SP", new()
            {
                new("Nata Taishi", 0, false, false),
                new("Titan", 0, false, false),
                new("Matador", 0, false, false),
                new("Queen Mab", 0, false, false),
                new("Taotie", 0, false, false),
                new("Dis", 0, false, false),
                new("Alice", 0, false, false),
                new("Senri", 10, false, false),
                new("Unicorn", 31, false, false),
                new("Samael", 38, false, false),
                new("Hachiman", 74, false, false)
            }),
            new("Dia", "Slightly restores 1 ally's HP.", "3 SP", new()
            {
                new("Pixie", 0, false, false),
                new("Apsaras", 0, false, false),
                new("Senri", 0, false, false),
                new("Saki Mitama", 0, false, false)
            }),
            new("Diarahan", "Fully restores 1 ally's HP.", "18 SP", new()
            {
                new("Raphael", 0, false, false),
                new("Hariti", 0, false, false),
                new("Daisoujou", 0, false, false),
                new("Horus", 0, false, false),
                new("Atavaka", 0, false, false),
                new("Norn", 0, true, false),
                new("Yatagarasu", 45, false, false),
                new("Kikuri-Hime", 52, false, false)
            }),
            new("Diarama", "Moderately restores 1 ally's HP.", "6 SP", new()
            {
                new("Nigi Mitama", 0, false, false),
                new("Titania", 0, false, false),
                new("Ganga", 0, false, false),
                new("Undine", 0, false, false),
                new("Parvati", 0, false, false),
                new("Dis", 0, false, false),
                new("Garuda", 0, false, false),
                new("Makami", 30, false, false),
                new("Sati", 33, false, false)
            }),
            new("Die for Me!", "Darkness: very high chance of instant kill, all foes. (60% chance)", "44 SP", new()
            {
                new("Alice", 79, false, false)
            }),
            new("Divine Grace", "Effects of healing magic are increased by 50%.", "", new()
            {
                new("Neko Shogun", 37, false, false),
                new("Parvati", 43, false, false),
                new("Leanan Sidhe", 47, false, false),
                new("Gabriel", 50, false, false),
                new("Kikuri-Hime", 54, false, false)
            }),
            new("Dodge Elec", "Doubles evasion rate against Elec attacks.", "", new()
            {
                new("Forneus", 10, false, false),
                new("Ara Mitama", 23, false, false),
                new("Mithra", 35, false, false),
                new("Fortuna", 37, false, false),
                new("Parvati", 41, false, false)
            }),
            new("Dodge Fire", "Doubles evasion rate against Fire attacks.", "", new()
            {
                new("Jack Frost", 20, false, false),
                new("King Frost", 24, false, false),
                new("High Pixie", 26, false, false)
            }),
            new("Dodge Ice", "Doubles evasion rate against Ice attacks.", "", new()
            {
                new("Nata Taishi", 8, false, false),
                new("Orobas", 10, false, false),
                new("Titan", 16, false, false),
                new("Phoenix", 25, false, false),
                new("Hua Po", 29, false, false),
                new("Flauros", 40, false, false),
                new("Dis", 41, false, false),
                new("Rangda", 50, false, false)
            }),
            new("Dodge Physical", "Doubles evasion rate against Phys attacks.", "", new()
            {
                new("Rakshasa", 27, false, false),
                new("Makami", 32, false, false),
                new("Take-Minakata", 33, false, false),
                new("Baphomet", 50, false, false),
                new("Yatsufusa", 53, false, false)
            }),
            new("Dodge Wind", "Doubles evasion rate against Wind attacks.", "", new()
            {
                new("Oberon", 17, false, false),
                new("Andra", 25, false, false),
                new("Queen Mab", 27, false, false),
                new("Ares", 27, false, false)
            }),
            new("Double Fangs", "Deals light Phys damage to 1 foe 2x.", "8% HP", new()
            {
                new("Archangel", 0, false, false)
            }),
            new("Elec Amp", "Strengthens Elec attacks by 50%.", "", new()
            {
                new("Trumpeter", 0, false, false),
                new("Tam Lin", 56, false, false),
                new("Belphegor", 67, false, false),
                new("Yoshitsune", 79, false, false),
                new("Kohryu", 80, true, false),
                new("Suparna", 83, false, false),
                new("Ongyo-Ki", 85, true, false),
                new("Izanagi-No-Okami", 98, false, true)
            }),
            new("Elec Boost", "Strengthens Elec attacks by 25%.", "", new()
            {
                new("Neko Shogun", 0, false, false),
                new("Hokuto Seikun", 0, false, false),
                new("Oberon", 15, false, false),
                new("Xiezhai", 21, false, false),
                new("Okuninushi", 46, false, false),
                new("Hitokoto-Nushi", 46, false, false),
                new("Seiryu", 52, false, false)
            }),
            new("Elec Break", "Nullifies 1 foe's Elec resistance (for 3 turns).", "15 SP", new()
            {
                new("Mothman", 36, false, false),
                new("Seiryu", 51, false, false),
                new("Lilith", 56, false, false),
                new("Hachiman", 72, false, false)
            }),
            new("Endure", "Restores 1 HP upon death 1x per battle.", "", new()
            {
                new("Oni", 34, false, false),
                new("Hanuman", 47, false, false),
                new("Ganesha", 55, false, false),
                new("Kingu", 63, false, false),
                new("Hell Biker", 68, false, false)
            }),
            new("Endure Dark", "Automatically survive instant death 1 time from a Darkness attack with 1 HP.", "", new()
            {
                new("Cu Chulainn", 50, false, false),
                new("Throne", 55, false, false),
                new("Uriel", 62, false, false),
                new("Daisoujou", 63, false, false),
                new("Sandalphon", 89, true, false)
            }),
            new("Endure Light", "Automatically survive instant death 1 time from a Light attack with 1 HP.", "", new()
            {
                new("Girimehkala", 53, false, false),
                new("Abaddon", 57, false, false),
                new("Belial", 71, false, false),
                new("Alice", 75, false, false),
                new("Satan", 80, false, false)
            }),
            new("Enduring Soul", "Restores full HP upon death 1x per battle.", "", new()
            {
                new("Shiva", 0, true, false),
                new("Tam Lin", 59, false, false),
                new("Sui-Ki", 62, false, false),
                new("Masakado", 76, false, false),
                new("Attis", 84, true, false),
                new("Zaou Gongen", 94, true, false)
            }),
            new("Energy Shower", "Cures Exhaustion and Enervation (party).", "18 SP", new()
            {
                new("Sati", 0, false, false),
                new("Alraune", 0, false, false),
                new("Suzaku", 0, false, false),
                new("Leanan Sidhe", 45, false, false),
                new("Gabriel", 45, false, false)
            }),
            new("Enervate Boost", "Enervation-based attacks are 1.5 times more effective.", "", new()
            {
                new("Lilim", 12, false, false),
                new("Yomotsu-Ikusa", 24, false, false),
                new("Alraune", 46, false, false),
                new("Belphegor", 66, false, false)
            }),
            new("Enervation", "Enervates 1 foe (40% chance). (-50% STR/MAG/END)", "5 SP", new()
            {
                new("Lilim", 0, false, false),
                new("Nozuchi", 0, false, false),
                new("Ghoul", 11, false, false)
            }),
            new("Evade Elec", "Triples evasion rate against Elec attacks.", "", new()
            {
                new("Seiten Taisei", 0, false, false),
                new("Genbu", 46, false, false),
                new("Seth", 74, false, false)
            }),
            new("Evade Fire", "Triples evasion rate against Fire attacks.", "", new()
            {
                new("Kingu", 0, false, false),
                new("Ganga", 35, false, false),
                new("Fuu-Ki", 45, false, false),
                new("Atropos", 69, false, false),
                new("Suparna", 82, false, false)
            }),
            new("Evade Ice", "Triples evasion rate against Ice attacks.", "", new()
            {
                new("Gdon", 36, false, false),
                new("White Rider", 62, false, false),
                new("Saturnus", 77, false, false),
                new("Suparna", 79, false, false),
                new("Mada", 82, true, false)
            }),
            new("Evade Physical", "Triples evasion rate against Phys attacks.", "", new()
            {
                new("Decarabia", 48, false, false),
                new("Tam Lin", 58, false, false),
                new("Taowu", 61, false, false),
                new("Alilat", 73, false, false),
                new("Zaou Gongen", 93, true, false)
            }),
            new("Evade Wind", "Triples evasion rate against Wind attacks.", "", new()
            {
                new("Neko Shogun", 36, false, false),
                new("Narasimha", 49, false, false),
                new("Vasuki", 75, false, false)
            }),
            new("Evil Smile", "Instills Fear in all foes (30% chance).", "12 SP", new()
            {
                new("Legion", 0, false, false),
                new("Incubus", 0, false, false),
                new("Mot", 0, false, false),
                new("Baphomet", 0, false, false),
                new("Nidhoggr", 0, false, false),
                new("Belphegor", 0, false, false)
            }),
            new("Evil Touch", "Instills Fear in 1 foe (40% chance). (-Crit. DEF and may lose turn or escape)", "5 SP", new()
            {
                new("Slime", 0, false, false),
                new("Yomotsu-Shikome", 0, false, false),
                new("Vetala", 0, false, false)
            }),
            new("Exhaust Boost", "Exhaustion-based attacks are 1.5 times more effective.", "", new()
            {
                new("Mokoi", 19, false, false),
                new("Kusi Mitama", 34, false, false)
            }),
            new("Fast Heal", "Halves the time needed to recover from ailments.", "", new()
            {
                new("Kaguya", 0, false, false)
            }),
            new("Fatal End", "Deals medium Phys damage to 1 foe.", "14% HP", new()
            {
                new("Oni", 0, false, false),
                new("Setanta", 0, false, false),
                new("Flauros", 0, false, false),
                new("Raja Naga", 0, false, false),
                new("Virtue", 35, false, false)
            }),
            new("Fear Boost", "Increases odds of inflicting Fear (1.5x).", "", new()
            {
                new("Slime", 5, false, false),
                new("Vetala", 24, false, false),
                new("Belphegor", 64, false, false)
            }),
            new("Fire Amp", "Strengthens Fire attacks by 50%.", "", new()
            {
                new("Saturnus", 0, false, false),
                new("Black Frost", 42, false, false),
                new("Decarabia", 51, false, false),
                new("Cerberus", 57, false, false),
                new("Kumbhanda", 58, false, false),
                new("Suzaku", 59, false, false),
                new("Uriel", 63, false, false),
                new("Mara", 67, false, false),
                new("Belial", 72, false, false),
                new("Hell Biker", 73, false, false),
                new("Surt", 75, false, false),
                new("Mada", 84, true, false),
                new("Mahakala", 84, true, false),
                new("Zaou Gongen", 95, true, false),
                new("Izanagi-No-Okami", 96, false, true)
            }),
            new("Fire Boost", "Strengthens Fire attacks by 25%.", "", new()
            {
                new("Yatsufusa", 0, false, false),
                new("Mada", 0, true, false),
                new("Eligor", 15, false, false),
                new("Phoenix", 26, false, false),
                new("Hua Po", 30, false, false),
                new("Gdon", 35, false, false),
                new("Orthrus", 42, false, false),
                new("Jinn", 66, false, false)
            }),
            new("Fire Break", "Nullifies 1 foe's Fire resistance (for 3 turns).", "15 SP", new()
            {
                new("Gdon", 0, false, false),
                new("Ukobach", 7, false, false),
                new("Hua Po", 26, false, false)
            }),
            new("Firm Stance", "Always take half damage, but you can never dodge.", "", new()
            {
                new("Futsunushi", 86, true, false),
                new("Ongyo-Ki", 87, true, false)
            }),
            new("Foolish Whisper", "Silences all foes (30% chance).", "12 SP", new()
            {
                new("Vetala", 0, false, false),
                new("Narcissus", 0, false, false),
                new("Hitokoto-Nushi", 0, false, false),
                new("Pabilsag", 0, false, false),
                new("Jinn", 0, false, false),
                new("Mada", 0, true, false),
                new("Ongyo-Ki", 0, true, false),
                new("Mother Harlot", 63, false, false)
            }),
            new("Foul Breath", "Increase 1 foe's susceptibility to ailments and Light/Dark skills.", "8 SP", new()
            {
                new("Vetala", 21, false, false),
                new("Legion", 25, false, false),
                new("Yomotsu-Ikusa", 25, false, false),
                new("Mothman", 35, false, false)
            }),
            new("Gale Slash", "Deals light Phys damage to all foes.", "12% HP", new()
            {
                new("Ares", 0, false, false),
                new("Rakshasa", 25, false, false)
            }),
            new("Garu", "Deals light Wind damage to 1 foe.", "4 SP", new()
            {
                new("Angel", 0, false, false),
                new("Sandman", 0, false, false),
                new("Cu Sith", 0, false, false),
                new("Sylph", 0, false, false),
                new("Anzu", 0, false, false)
            }),
            new("Garudyne", "Deals heavy Wind damage to 1 foe.", "12 SP", new()
            {
                new("Ganesha", 0, false, false),
                new("Lachesis", 0, false, false),
                new("Garuda", 0, false, false),
                new("Jatayu", 0, false, false),
                new("Atropos", 0, false, false),
                new("Seth", 0, false, false),
                new("Norn", 0, true, false),
                new("Suparna", 0, false, false),
                new("Scathach", 0, true, false),
                new("Clotho", 49, false, false),
                new("Cu Chulainn", 51, false, false),
                new("Quetzalcoatl", 52, false, false),
                new("Izanagi-No-Okami", 95, false, true)
            }),
            new("Garula", "Deals medium Wind damage to 1 foe.", "8 SP", new()
            {
                new("Phoenix", 0, false, false),
                new("Kusi Mitama", 0, false, false),
                new("Virtue", 0, false, false),
                new("Pale Rider", 0, false, false),
                new("Yamata-No-Orochi", 0, false, false),
                new("Fortuna", 0, false, false),
                new("Fuu-Ki", 0, false, false),
                new("Kurama Tengu", 0, false, false),
                new("Nigi Mitama", 28, false, false),
                new("Titania", 29, false, false)
            }),
            new("Ghastly Wail", "Instantly kills foes who are fearful.", "28 SP", new()
            {
                new("Baphomet", 0, false, false),
                new("Yomotsu-Shikome", 11, false, false),
                new("Vetala", 23, false, false),
                new("Incubus", 33, false, false),
                new("Mot", 49, false, false),
                new("Nidhoggr", 57, false, false)
            }),
            new("Gigantic Fist", "Deals heavy Phys damage to 1 foe.", "16% HP", new()
            {
                new("Cerberus", 0, false, false),
                new("Kin-Ki", 56, false, false)
            }),
            new("God's Hand", "Deals severe Phys damage to 1 foe.", "22% HP", new()
            {
                new("Helel", 0, true, false),
                new("Zaou Gongen", 0, true, false),
                new("Ardha", 0, false, false),
                new("Siegfried", 70, false, false),
                new("Melchizedek", 72, false, false),
                new("Vishnu", 76, true, false)
            }),
            new("Green Wall", "Add Wind resistance to 1 ally (for 3 turns).", "18 SP", new()
            {
                new("Berith", 18, false, false),
                new("Yamata-No-Orochi", 36, false, false),
                new("Alraune", 44, false, false),
                new("Ananta", 62, false, false)
            }),
            new("Growth 1", "Persona gains 1/4 EXP while inactive.", "", new()
            {
                new("Cu Sith", 11, false, false),
                new("Gurr", 21, false, false),
                new("Phoenix", 23, false, false)
            }),
            new("Growth 2", "Persona gains 1/2 EXP while inactive. (Overwrites Growth 1)", "", new()
            {
                new("Quetzalcoatl", 0, false, false),
                new("Gdon", 33, false, false),
                new("Yatagarasu", 44, false, false),
                new("Thoth", 48, false, false),
                new("Kurama Tengu", 50, false, false),
                new("Shiki-Ouji", 59, false, false),
                new("Kartikeya", 70, false, false),
                new("Alilat", 74, false, false)
            }),
            new("Growth 3", "Persona gains full EXP even while inactive. (Overwrites Growth 1/Growth 2)", "", new()
            {
                new("Jatayu", 64, false, false),
                new("Yurlungur", 71, false, false),
                new("Saturnus", 79, false, false)
            }),
            new("Hama", "Light: low chance of instant kill, 1 foe. (40% chance)", "8 SP", new()
            {
                new("Archangel", 0, false, false),
                new("Ame No Uzume", 0, false, false),
                new("Principality", 0, false, false),
                new("Power", 0, false, false),
                new("Angel", 5, false, false)
            }),
            new("Hama Boost", "Light-based attacks are 1.5 times more effective.", "", new()
            {
                new("Throne", 0, false, false),
                new("Angel", 9, false, false),
                new("Power", 31, false, false),
                new("Mithra", 36, false, false),
                new("Virtue", 38, false, false),
                new("Dominion", 40, false, false),
                new("Anubis", 65, false, false),
                new("Daisoujou", 65, false, false),
                new("White Rider", 66, false, false),
                new("Masakado", 73, false, false),
                new("Kaguya", 78, false, false),
                new("Sraosha", 78, true, false)
            }),
            new("Hamaon", "Light: high chance of instant kill, 1 foe. (60% chance)", "15 SP", new()
            {
                new("Dominion", 0, false, false),
                new("Narasimha", 0, false, false),
                new("Throne", 0, false, false),
                new("Uriel", 0, false, false),
                new("White Rider", 0, false, false),
                new("Anubis", 0, false, false),
                new("Daisoujou", 0, false, false),
                new("Melchizedek", 0, false, false),
                new("Vasuki", 0, false, false),
                new("Michael", 0, false, false),
                new("Kaguya", 0, false, false),
                new("Mithra", 34, false, false)
            }),
            new("Hassou Tobi", "Deals light Phys damage to all foes 8x.", "25% HP", new()
            {
                new("Yoshitsune", 83, false, false)
            }),
            new("Heat Riser", "Increases 1 ally's Attack, Defense, and Hit/Evasion rates for 3 turns.", "30 SP", new()
            {
                new("Trumpeter", 74, false, false),
                new("Yoshitsune", 77, false, false)
            }),
            new("Heat Wave", "Deals medium Phys damage to all foes.", "16% HP", new()
            {
                new("Triglav", 0, false, false),
                new("Gabriel", 48, false, false),
                new("Yatsufusa", 51, false, false),
                new("Quetzalcoatl", 53, false, false)
            }),
            new("Heaven's Blade", "Deals heavy Phys damage to 1 foe.", "19% HP", new()
            {
                new("Metatron", 0, false, false),
                new("Michael", 79, false, false)
            }),
            new("Herculean Strike", "Deals medium Phys damage to all foes.", "16% HP", new()
            {
                new("Flauros", 38, false, false)
            }),
            new("High Counter", "20% chance of reflecting Phys attacks. Does not stack.", "", new()
            {
                new("Tam Lin", 0, false, false),
                new("Kin-Ki", 0, false, false),
                new("Byakko", 0, false, false),
                new("Thor", 0, false, false),
                new("Surt", 0, false, false),
                new("Kali", 54, false, false),
                new("Ganesha", 54, false, false),
                new("Uriel", 60, false, false),
                new("Garuda", 61, false, false),
                new("Siegfried", 65, false, false),
                new("Loki", 67, true, false),
                new("Kartikeya", 68, false, false),
                new("Seiten Taisei", 69, false, false),
                new("Barong", 71, false, false),
                new("Vasuki", 74, false, false),
                new("Asura", 89, true, false)
            }),
            new("Hysterical Slap", "Deals light Phys damage to 1 foe with a chance of Rage.", "9% HP", new()
            {
                new("Orobas", 0, false, false),
                new("Mokoi", 0, false, false)
            }),
            new("Ice Amp", "Strengthens Ice attacks by 50%.", "", new()
            {
                new("Skadi", 56, false, false),
                new("Loki", 66, true, false),
                new("Byakko", 67, false, false),
                new("Scathach", 83, true, false),
                new("Lucifer", 94, true, false),
                new("Izanagi-No-Okami", 97, false, true)
            }),
            new("Ice Boost", "Strengthens Ice attacks by 25%.", "", new()
            {
                new("Black Frost", 0, false, false),
                new("Yaksini", 21, false, false),
                new("King Frost", 26, false, false),
                new("Undine", 37, false, false),
                new("Gorgon", 39, false, false),
                new("Yamata-No-Orochi", 39, false, false),
                new("Nidhoggr", 61, false, false)
            }),
            new("Ice Break", "Nullifies 1 foe's Ice resistance (for 3 turns).", "15 SP", new()
            {
                new("Jack Frost", 0, false, false),
                new("King Frost", 0, false, false),
                new("Lakshmi", 66, false, false)
            }),
            new("Insta-Heal", "Recovers from ailments in 1 turn.", "", new()
            {
                new("Norn", 77, true, false),
                new("Helel", 90, true, false)
            }),
            new("Invigorate 1", "Recovers 3 SP each turn in battle.", "", new()
            {
                new("Ame No Uzume", 20, false, false),
                new("High Pixie", 25, false, false)
            }),
            new("Invigorate 2", "Recovers 5 SP each turn in battle.", "", new()
            {
                new("Sarasvati", 19, false, false),
                new("Nigi Mitama", 26, false, false),
                new("Barong", 69, false, false)
            }),
            new("Invigorate 3", "Recovers 7 SP each turn in battle.", "", new()
            {
                new("Succubus", 50, false, false),
                new("Ananta", 63, false, false),
                new("Chernobog", 69, false, false),
                new("Norn", 75, true, false),
                new("Satan", 78, false, false)
            }),
            new("Kill Rush", "Deals light Phys damage to 1 foe 1x to 3x.", "10% HP", new()
            {
                new("Rakshasa", 0, false, false),
                new("Titan", 18, false, false)
            }),
            new("Life Drain", "Drains 30 HP from 1 foe.", "3 SP", new()
            {
                new("Loa", 0, false, false),
                new("Vetala", 20, false, false),
                new("Kaiwan", 28, false, false)
            }),
            new("Mabufu", "Deals light Ice damage to all foes.", "10 SP", new()
            {
                new("Jack Frost", 0, false, false),
                new("Sarasvati", 0, false, false),
                new("Yaksini", 0, false, false),
                new("King Frost", 0, false, false),
                new("Yomotsu-Ikusa", 0, false, false),
                new("Valkyrie", 12, false, false)
            }),
            new("Mabufudyne", "Deals heavy Ice damage to all foes.", "22 SP", new()
            {
                new("Lakshmi", 0, false, false),
                new("Alilat", 0, false, false),
                new("Vishnu", 0, true, false),
                new("Baal Zebul", 0, false, false),
                new("Scathach", 0, true, false),
                new("Beelzebub", 0, true, false),
                new("Byakko", 68, false, false),
                new("Loki", 68, true, false),
                new("Isis", 83, true, false)
            }),
            new("Mabufula", "Deals medium Ice damage to all foes.", "16 SP", new()
            {
                new("Yamata-No-Orochi", 0, false, false),
                new("Genbu", 0, false, false),
                new("Gabriel", 0, false, false),
                new("Skadi", 0, false, false),
                new("Ananta", 0, false, false),
                new("Undine", 34, false, false),
                new("Gorgon", 38, false, false)
            }),
            new("Magaru", "Deals light Wind damage to all foes.", "10 SP", new()
            {
                new("Ame No Uzume", 0, false, false),
                new("Narcissus", 0, false, false),
                new("Titania", 0, false, false),
                new("Cu Sith", 13, false, false),
                new("Sylph", 14, false, false),
                new("Anzu", 17, false, false)
            }),
            new("Magarudyne", "Deals heavy Wind damage to all foes.", "22 SP", new()
            {
                new("Seth", 0, false, false),
                new("Horus", 0, false, false),
                new("Norn", 0, true, false),
                new("Odin", 0, true, false),
                new("Shiva", 0, true, false),
                new("Ganesha", 56, false, false),
                new("Jatayu", 66, false, false),
                new("Atropos", 68, false, false),
                new("Suparna", 81, false, false),
                new("Scathach", 82, true, false)
            }),
            new("Magarula", "Deals medium Wind damage to all foes.", "16 SP", new()
            {
                new("Clotho", 0, false, false),
                new("Cu Chulainn", 0, false, false),
                new("Quetzalcoatl", 0, false, false),
                new("Fortuna", 38, false, false)
            }),
            new("Mahama", "Light: low chance of instant kill, all foes. (30% chance)", "18 SP", new()
            {
                new("Power", 0, false, false),
                new("Unicorn", 0, false, false),
                new("Mithra", 0, false, false),
                new("Virtue", 0, false, false),
                new("Thoth", 0, false, false),
                new("Anzu", 19, false, false),
                new("Principality", 21, false, false)
            }),
            new("Mahamaon", "Light: high chance of instant kill, all foes. (40% chance)", "34 SP", new()
            {
                new("Horus", 0, false, false),
                new("Masakado", 0, false, false),
                new("Atavaka", 0, false, false),
                new("Sraosha", 0, true, false),
                new("Metatron", 0, false, false),
                new("Sandalphon", 0, true, false),
                new("Narasimha", 51, false, false),
                new("Quetzalcoatl", 55, false, false),
                new("White Rider", 63, false, false),
                new("Anubis", 64, false, false),
                new("Daisoujou", 64, false, false),
                new("Melchizedek", 69, false, false),
                new("Michael", 75, false, false),
                new("Vasuki", 76, false, false),
                new("Kaguya", 77, false, false),
                new("Asura", 88, true, false)
            }),
            new("Makajam", "Silences 1 foe (40% chance). (Unable to use Skills or change Persona)", "5 SP", new()
            {
                new("Senri", 0, false, false),
                new("Suparna", 0, false, false),
                new("Oberon", 13, false, false),
                new("Xiezhai", 17, false, false),
                new("Hua Po", 27, false, false)
            }),
            new("Makara Break", "Negates all foes' Makarakarn.", "18 SP", new()
            {
                new("Genbu", 43, false, false),
                new("Lachesis", 54, false, false)
            }),
            new("Makarakarn", "Barrier that reflects magic dmg once. (1 ally; excludes Almighty attacks)", "36 SP", new()
            {
                new("Ganesha", 0, false, false),
                new("Lilith", 0, false, false),
                new("Anubis", 0, false, false),
                new("Daisoujou", 0, false, false),
                new("Alilat", 0, false, false),
                new("Hachiman", 0, false, false),
                new("Alraune", 43, false, false),
                new("Clotho", 47, false, false),
                new("Kushinada", 50, false, false),
                new("Mara", 64, false, false)
            }),
            new("Mamudo", "Darkness: low chance of instant kill, all foes. (30% chance)", "18 SP", new()
            {
                new("Matador", 0, false, false),
                new("Kaiwan", 0, false, false),
                new("Pale Rider", 0, false, false),
                new("Lilim", 15, false, false),
                new("Ippon-Datara", 19, false, false)
            }),
            new("Mamudoon", "Darkness: high chance of instant kill, all foes. (40% chance)", "34 SP", new()
            {
                new("Nidhoggr", 0, false, false),
                new("Mother Harlot", 0, false, false),
                new("Chernobog", 0, false, false),
                new("Nebiros", 0, false, false),
                new("Alice", 0, false, false),
                new("Baal Zebul", 0, false, false),
                new("Beelzebub", 0, true, false),
                new("Girimehkala", 50, false, false),
                new("Baphomet", 52, false, false),
                new("White Rider", 65, false, false),
                new("Mahakala", 83, true, false),
                new("Attis", 88, true, false)
            }),
            new("Maragi", "Deals light Fire damage to all foes.", "10 SP", new()
            {
                new("Ippon-Datara", 0, false, false),
                new("Phoenix", 0, false, false),
                new("Sati", 0, false, false),
                new("Gdon", 0, false, false),
                new("Eligor", 13, false, false),
                new("Berith", 16, false, false)
            }),
            new("Maragidyne", "Deals heavy Fire damage to all foes.", "22 SP", new()
            {
                new("Saturnus", 0, false, false),
                new("Satan", 0, false, false),
                new("Asura", 0, true, false),
                new("Helel", 0, true, false),
                new("Zaou Gongen", 0, true, false),
                new("Cerberus", 53, false, false),
                new("Yatsufusa", 54, false, false),
                new("Hell Biker", 70, false, false),
                new("Surt", 71, false, false),
                new("Belial", 73, false, false),
                new("Mada", 81, true, false),
                new("Mahakala", 82, true, false),
                new("Attis", 87, true, false)
            }),
            new("Maragion", "Deals medium Fire damage to all foes.", "16 SP", new()
            {
                new("Black Frost", 0, false, false),
                new("Dis", 0, false, false),
                new("Rangda", 0, false, false),
                new("Baphomet", 0, false, false),
                new("Suzaku", 0, false, false),
                new("Uriel", 0, false, false),
                new("Phoenix", 27, false, false),
                new("Lamia", 32, false, false),
                new("Gdon", 34, false, false),
                new("Sati", 36, false, false),
                new("Pyro Jack", 36, false, false),
                new("Orthrus", 44, false, false),
                new("Kushinada", 46, false, false),
                new("Succubus", 46, false, false)
            }),
            new("Marakukaja", "Increases Defense for 3 turns (party).", "24 SP", new()
            {
                new("Genbu", 0, false, false),
                new("Hariti", 0, false, false),
                new("Attis", 0, true, false),
                new("Asura", 0, true, false),
                new("Pyro Jack", 34, false, false),
                new("Parvati", 40, false, false),
                new("Orthrus", 41, false, false),
                new("Triglav", 45, false, false),
                new("Ananta", 59, false, false),
                new("Barong", 67, false, false),
                new("Trumpeter", 68, false, false)
            }),
            new("Marakunda", "Decreases all foes' Defense for 3 turns.", "24 SP", new()
            {
                new("Kurama Tengu", 0, false, false),
                new("Belphegor", 63, false, false)
            }),
            new("Masukukaja", "Increases Hit/Evasion rates for 3 turns (party).", "24 SP", new()
            {
                new("Yatagarasu", 0, false, false),
                new("Yatsufusa", 0, false, false),
                new("Quetzalcoatl", 0, false, false),
                new("Lachesis", 0, false, false),
                new("Siegfried", 0, false, false),
                new("Ongyo-Ki", 0, true, false),
                new("Raphael", 55, false, false),
                new("Suzaku", 55, false, false)
            }),
            new("Masukunda", "Decreases all foes' Hit/Evasion rates for 3 turns.", "24 SP", new()
            {
                new("Black Frost", 41, false, false),
                new("Dis", 42, false, false)
            }),
            new("Matarukaja", "Increases Attack for 3 turns (party).", "24 SP", new()
            {
                new("Kushinada", 0, false, false),
                new("Taowu", 0, false, false),
                new("Hachiman", 0, false, false),
                new("Futsunushi", 0, true, false),
                new("Neko Shogun", 35, false, false),
                new("Raja Naga", 38, false, false),
                new("Cu Chulainn", 47, false, false),
                new("Melchizedek", 68, false, false),
                new("Horus", 71, false, false)
            }),
            new("Matarunda", "Decreases all foes' Attack for 3 turns.", "24 SP", new()
            {
                new("Samael", 0, false, false),
                new("Loa", 0, false, false),
                new("Decarabia", 0, false, false),
                new("Seiryu", 0, false, false),
                new("Shiki-Ouji", 0, false, false)
            }),
            new("Mazio", "Deals light Elec damage to all foes.", "10 SP", new()
            {
                new("Titan", 0, false, false),
                new("Xiezhai", 0, false, false),
                new("Andra", 0, false, false),
                new("Shiisaa", 0, false, false),
                new("High Pixie", 0, false, false),
                new("Take-Minakata", 0, false, false),
                new("Oberon", 16, false, false)
            }),
            new("Maziodyne", "Deals heavy Elec damage to all foes.", "22 SP", new()
            {
                new("Mother Harlot", 0, false, false),
                new("Belphegor", 0, false, false),
                new("Kartikeya", 0, false, false),
                new("Hachiman", 0, false, false),
                new("Lilith", 55, false, false),
                new("Thor", 68, false, false),
                new("Barong", 72, false, false),
                new("Ishtar", 73, true, false),
                new("Tzitzimitl", 76, false, false),
                new("Odin", 78, true, false),
                new("Kohryu", 78, true, false),
                new("Baal Zebul", 79, false, false),
                new("Beelzebub", 79, true, false),
                new("Shiva", 82, true, false)
            }),
            new("Mazionga", "Deals medium Elec damage to all foes.", "16 SP", new()
            {
                new("Thoth", 0, false, false),
                new("Seiryu", 0, false, false),
                new("Queen Mab", 29, false, false),
                new("Unicorn", 34, false, false),
                new("Mothman", 37, false, false),
                new("Raja Naga", 42, false, false),
                new("Dominion", 42, false, false),
                new("Okuninushi", 44, false, false)
            }),
            new("Me Patra", "Dispels Rage, Fear, and Confusion (party).", "6 SP", new()
            {
                new("Sylph", 0, false, false),
                new("High Pixie", 0, false, false),
                new("Nigi Mitama", 0, false, false),
                new("Gorgon", 0, false, false),
                new("Leanan Sidhe", 0, false, false),
                new("Barong", 0, false, false),
                new("Pixie", 4, false, false),
                new("Apsaras", 6, false, false)
            }),
            new("Media", "Slightly restores party's HP.", "7 SP", new()
            {
                new("Sarasvati", 0, false, false),
                new("Ame No Uzume", 0, false, false),
                new("Andra", 0, false, false),
                new("Valkyrie", 10, false, false),
                new("Senri", 11, false, false),
                new("Archangel", 12, false, false),
                new("Sylph", 13, false, false),
                new("Saki Mitama", 14, false, false),
                new("Oberon", 14, false, false),
                new("Principality", 22, false, false)
            }),
            new("Mediarahan", "Fully restores party's HP.", "30 SP", new()
            {
                new("Melchizedek", 0, false, false),
                new("Ishtar", 0, true, false),
                new("Kaguya", 0, false, false),
                new("Kohryu", 0, true, false),
                new("Isis", 0, true, false),
                new("Raphael", 59, false, false),
                new("Hariti", 61, false, false),
                new("Cybele", 70, false, false),
                new("Yurlungur", 72, false, false),
                new("Ardha", 94, false, false)
            }),
            new("Mediarama", "Moderately restores party's HP.", "12 SP", new()
            {
                new("Alraune", 0, false, false),
                new("Leanan Sidhe", 0, false, false),
                new("Gabriel", 0, false, false),
                new("Kushinada", 0, false, false),
                new("Kikuri-Hime", 0, false, false),
                new("Kingu", 0, false, false),
                new("Cybele", 0, false, false),
                new("Ganga", 33, false, false),
                new("Neko Shogun", 34, false, false),
                new("Undine", 36, false, false),
                new("Parvati", 39, false, false),
                new("Thoth", 47, false, false)
            }),
            new("Megido", "Deals medium Almighty damage to all foes.", "18 SP", new()
            {
                new("Taotie", 0, false, false),
                new("Thoth", 0, false, false),
                new("Samael", 39, false, false)
            }),
            new("Megidola", "Deals heavy Almighty damage to all foes.", "32 SP", new()
            {
                new("Raphael", 0, false, false),
                new("Trumpeter", 0, false, false),
                new("Michael", 0, false, false),
                new("Decarabia", 50, false, false),
                new("Anubis", 62, false, false),
                new("Chernobog", 68, false, false),
                new("Alice", 76, false, false)
            }),
            new("Megidolaon", "Deals severe Almighty damage to all foes.", "60 SP", new()
            {
                new("Vishnu", 0, true, false),
                new("Satan", 0, false, false),
                new("Helel", 0, true, false),
                new("Izanagi-No-Okami", 0, false, true),
                new("Trumpeter", 70, false, false),
                new("Michael", 74, false, false),
                new("Atavaka", 75, false, false),
                new("Sraosha", 80, true, false),
                new("Shiva", 84, true, false),
                new("Metatron", 86, false, false),
                new("Ardha", 91, false, false)
            }),
            new("Mighty Swing", "Deals medium Phys damage to 1 foe.", "14% HP", new()
            {
                new("Hanuman", 0, false, false),
                new("Girimehkala", 0, false, false)
            }),
            new("Mind Charge", "Next Fire, Ice, Elec, Wind, or Almighty magical attack will be 250% greater in power.", "15 SP", new()
            {
                new("Izanagi-No-Okami", 0, false, true),
                new("Lucifer", 0, true, false),
                new("Jack Frost", 25, false, false),
                new("Titania", 32, false, false),
                new("Taotie", 38, false, false),
                new("Black Frost", 40, false, false),
                new("Dis", 44, false, false),
                new("Cu Chulainn", 48, false, false),
                new("Throne", 51, false, false),
                new("Yatsufusa", 55, false, false),
                new("Nebiros", 65, false, false),
                new("Atropos", 67, false, false),
                new("Atavaka", 76, false, false),
                new("Alice", 77, false, false),
                new("Kohryu", 79, true, false),
                new("Odin", 80, true, false),
                new("Mahakala", 80, true, false),
                new("Scathach", 85, true, false)
            }),
            new("Mind Slice", "Deals medium Phys damage to all foes with a chance of Confusion.", "14% HP", new()
            {
                new("Incubus", 0, false, false),
                new("Pale Rider", 0, false, false),
                new("Taotie", 0, false, false),
                new("Ganga", 31, false, false)
            }),
            new("Morning Star", "Deals massive Almighty damage to all foes.", "72 SP", new()
            {
                new("Helel", 94, true, false)
            }),
            new("Mudo", "Darkness: low chance of instant kill, 1 foe. (40% chance)", "8 SP", new()
            {
                new("Lilim", 0, false, false),
                new("Berith", 0, false, false),
                new("Ippon-Datara", 0, false, false),
                new("Legion", 0, false, false),
                new("Yomotsu-Shikome", 10, false, false)
            }),
            new("Mudo Boost", "Darkness-based attacks are 1.5 times more effective.", "", new()
            {
                new("Alice", 0, false, false),
                new("Berith", 17, false, false),
                new("Ippon-Datara", 22, false, false),
                new("Matador", 26, false, false),
                new("Samael", 40, false, false),
                new("Loa", 45, false, false),
                new("Succubus", 47, false, false),
                new("Mot", 50, false, false),
                new("Baphomet", 53, false, false),
                new("Mother Harlot", 62, false, false),
                new("White Rider", 67, false, false),
                new("Nebiros", 67, false, false),
                new("Baal Zebul", 80, false, false),
                new("Beelzebub", 80, true, false),
                new("Mahakala", 85, true, false)
            }),
            new("Mudoon", "Darkness: high chance of instant kill, 1 foe. (60% chance)", "15 SP", new()
            {
                new("Samael", 0, false, false),
                new("Pazuzu", 0, false, false),
                new("Loa", 0, false, false),
                new("Succubus", 0, false, false),
                new("Mot", 0, false, false),
                new("Kali", 0, false, false),
                new("Abaddon", 0, false, false),
                new("White Rider", 0, false, false),
                new("Anubis", 0, false, false),
                new("Belial", 0, false, false),
                new("Pale Rider", 37, false, false),
                new("Black Frost", 44, false, false),
                new("Pabilsag", 55, false, false),
                new("Hell Biker", 69, false, false)
            }),
            new("Mustard Bomb", "Deals medium Phys damage to all foes with a chance of Enervation.", "16% HP", new()
            {
                new("Ganesha", 0, false, false),
                new("Tzitzimitl", 0, false, false),
                new("Triglav", 46, false, false),
                new("Rangda", 51, false, false),
                new("Anubis", 61, false, false)
            }),
            new("Mutudi", "Cures Silence (1 ally).", "3 SP", new()
            {
                new("Clotho", 0, false, false),
                new("Ishtar", 0, true, false)
            }),
            new("Muzzle Shot", "Deals light Phys damage to 1 foe with a chance of Silence.", "9% HP", new()
            {
                new("Gurr", 0, false, false),
                new("Archangel", 13, false, false),
                new("Obariyon", 14, false, false)
            }),
            new("Myriad Arrows", "Deals heavy Phys damage to all foes 1x to 3x.", "22% HP", new()
            {
                new("Belial", 0, false, false),
                new("Mahakala", 0, true, false),
                new("Chernobog", 64, false, false),
                new("Cybele", 67, false, false),
                new("Kartikeya", 69, false, false),
                new("Masakado", 71, false, false)
            }),
            new("Navas Nebula", "Deals medium Phys damage to all foes with a chance of Exhaustion.", "18% HP", new()
            {
                new("Hokuto Seikun", 0, false, false),
                new("Shiki-Ouji", 0, false, false),
                new("Pazuzu", 41, false, false),
                new("Clotho", 45, false, false)
            }),
            new("Nervundi", "Cures Exhaustion and Enervation (1 ally).", "3 SP", new()
            {
                new("Lamia", 0, false, false),
                new("Unicorn", 0, false, false),
                new("Parvati", 0, false, false),
                new("Yatagarasu", 0, false, false)
            }),
            new("Niflheim", "Deals severe Ice damage to 1 foe.", "48 SP", new()
            {
                new("Loki", 70, true, false)
            }),
            new("Null Confuse", "Become immune to Confusion attacks.", "", new()
            {
                new("Jatayu", 0, false, false),
                new("Power", 33, false, false),
                new("Gorgon", 36, false, false),
                new("Raja Naga", 40, false, false),
                new("Kingu", 59, false, false)
            }),
            new("Null Dark", "Becomes immune to Darkness attacks. (Overwrites Resist Dark)", "", new()
            {
                new("Dominion", 44, false, false),
                new("Uriel", 64, false, false),
                new("Lakshmi", 68, false, false)
            }),
            new("Null Dizzy", "Cannot become Dizzy after being knocked down.", "", new()
            {
                new("Triglav", 47, false, false),
                new("Raphael", 57, false, false),
                new("Futsunushi", 83, true, false),
                new("Ardha", 92, false, false)
            }),
            new("Null Elec", "Becomes immune to Elec attacks. (Overwrites Resist Elec)", "", new()
            {
                new("Isis", 86, true, false)
            }),
            new("Null Enervate", "Become immune to Enervation attacks.", "", new()
            {
                new("Nozuchi", 32, false, false),
                new("Taotie", 40, false, false),
                new("Alraune", 45, false, false),
                new("Clotho", 50, false, false),
                new("Taowu", 58, false, false)
            }),
            new("Null Exhaust", "Become immune to Exhaustion attacks.", "", new()
            {
                new("Fuu-Ki", 49, false, false),
                new("Ananta", 64, false, false)
            }),
            new("Null Fear", "Become immune to Fear attacks.", "", new()
            {
                new("Arahabaki", 0, false, false),
                new("Yatagarasu", 43, false, false)
            }),
            new("Null Fire", "Becomes immune to Fire attacks. (Overwrites Resist Fire)", "", new()
            {
                new("King Frost", 27, false, false),
                new("Setanta", 40, false, false),
                new("Kushinada", 48, false, false),
                new("Loki", 69, true, false)
            }),
            new("Null Ice", "Becomes immune to Ice attacks. (Overwrites Resist Ice)", "", new()
            {
                new("Orthrus", 45, false, false),
                new("Surt", 76, false, false)
            }),
            new("Null Light", "Becomes immune to Light attacks. (Overwrites Resist Light)", "", new()
            {
                new("Nebiros", 69, false, false),
                new("Seth", 72, false, false)
            }),
            new("Null Mute", "Become immune to Silence attacks.", "", new()
            {
                new("Mithra", 37, false, false),
                new("Thoth", 49, false, false)
            }),
            new("Null Physical", "Become immune to Phys attacks. (Overwrites Resist Phys)", "", new()
            {
                new("Abaddon", 62, false, false),
                new("Shiki-Ouji", 62, false, false),
                new("Jinn", 67, false, false),
                new("Thor", 69, false, false),
                new("Ardha", 96, false, false)
            }),
            new("Null Poison", "Become immune to Poison attacks.", "", new()
            {
                new("Lamia", 29, false, false),
                new("Nozuchi", 31, false, false),
                new("Kingu", 60, false, false),
                new("Vasuki", 73, false, false)
            }),
            new("Null Rage", "Become immune to Rage attacks.", "", new()
            {
                new("Saki Mitama", 16, false, false),
                new("Shiisaa", 26, false, false)
            }),
            new("Null Wind", "Becomes immune to Wind attacks. (Overwrites Resist Wind)", "", new()
            {
                new("Sarasvati", 23, false, false),
                new("Okuninushi", 47, false, false),
                new("Satan", 82, false, false)
            }),
            new("Old One", "Enervates all foes (30% chance).", "12 SP", new()
            {
                new("Alraune", 0, false, false),
                new("Abaddon", 0, false, false),
                new("Baal Zebul", 0, false, false),
                new("Beelzebub", 0, true, false),
                new("Narcissus", 25, false, false),
                new("Lilith", 54, false, false),
                new("Belphegor", 65, false, false)
            }),
            new("Panta Rhei", "Deals severe Wind damage to 1 foe.", "48 SP", new()
            {
                new("Odin", 81, true, false)
            }),
            new("Patra", "Dispels Rage, Fear, and Confusion (1 ally).", "3 SP", new()
            {
                new("Pixie", 0, false, false),
                new("Angel", 0, false, false),
                new("Apsaras", 0, false, false),
                new("Archangel", 0, false, false),
                new("Sarasvati", 0, false, false)
            }),
            new("Poisma", "Poisons 1 foe (40% chance). (-5% HP/turn, -50% STR)", "5 SP", new()
            {
                new("Yomotsu-Shikome", 0, false, false),
                new("Ghoul", 0, false, false),
                new("Forneus", 8, false, false)
            }),
            new("Poison Arrow", "Deals medium Phys damage to 1 foe with a chance of Poison.", "14% HP", new()
            {
                new("Hitokoto-Nushi", 0, false, false),
                new("Anubis", 60, false, false)
            }),
            new("Poison Boost", "Increases odds of inflicting Poison (1.5x).", "", new()
            {
                new("Ghoul", 14, false, false),
                new("Gurr", 25, false, false),
                new("Yomotsu-Ikusa", 27, false, false),
                new("Lamia", 28, false, false),
                new("Ose", 34, false, false)
            }),
            new("Poison Mist", "Poisons all foes (30% chance).", "12 SP", new()
            {
                new("Lamia", 0, false, false),
                new("Nozuchi", 0, false, false),
                new("Samael", 0, false, false),
                new("Girimehkala", 0, false, false),
                new("Barong", 0, false, false),
                new("Omoikane", 8, false, false),
                new("Yomotsu-Ikusa", 26, false, false),
                new("Ose", 33, false, false),
                new("Seiryu", 50, false, false)
            }),
            new("Poison Skewer", "Deals light Phys damage to 1 foe with a chance of Poison.", "9% HP", new()
            {
                new("Eligor", 0, false, false),
                new("Ghoul", 12, false, false)
            }),
            new("Posumudi", "Neutralizes Poison (1 ally).", "3 SP", new()
            {
                new("Undine", 0, false, false),
                new("Virtue", 0, false, false),
                new("Kikuri-Hime", 0, false, false)
            }),
            new("Power Charge", "Next physical attack, physical skill, or Almighty physical attack will be 250% greater in power.", "15 SP", new()
            {
                new("Ose", 0, false, false),
                new("Girimehkala", 0, false, false),
                new("Sui-Ki", 0, false, false),
                new("Siegfried", 0, false, false),
                new("Sraosha", 0, true, false),
                new("Yoshitsune", 0, false, false),
                new("Mahakala", 0, true, false),
                new("Futsunushi", 0, true, false),
                new("Zaou Gongen", 0, true, false),
                new("Rakshasa", 28, false, false),
                new("Ares", 30, false, false),
                new("Oni", 35, false, false),
                new("Setanta", 38, false, false),
                new("Hanuman", 48, false, false),
                new("Triglav", 49, false, false),
                new("Yatsufusa", 52, false, false),
                new("Ganesha", 52, false, false),
                new("Kali", 55, false, false),
                new("Tam Lin", 55, false, false),
                new("Kin-Ki", 60, false, false),
                new("Taowu", 60, false, false),
                new("Mara", 63, false, false),
                new("Vishnu", 78, true, false)
            }),
            new("Power Slash", "Deals medium Phys damage to 1 foe.", "14% HP", new()
            {
                new("Ose", 0, false, false),
                new("Power", 30, false, false)
            }),
            new("Pralaya", "Deals severe Phys damage to all foes with a high chance of instant kills. (50% chance)", "25% HP", new()
            {
                new("Shiva", 87, true, false)
            }),
            new("Primal Force", "Deals severe Phys damage to 1 foe.", "20% HP", new()
            {
                new("Futsunushi", 0, true, false),
                new("Asura", 0, true, false),
                new("Ardha", 0, false, false),
                new("Kartikeya", 75, false, false)
            }),
            new("Pulinpa", "Confuses 1 foe (40% chance). (May attack ally, lose turn, or waste 3% money)", "5 SP", new()
            {
                new("Sandman", 0, false, false),
                new("Cu Sith", 0, false, false),
                new("Ukobach", 4, false, false)
            }),
            new("Rage Boost", "Increases odds of inflicting Rage (1.5x).", "", new()
            {
                new("Mokoi", 16, false, false),
                new("Mothman", 38, false, false)
            }),
            new("Ragnarok", "Deals severe Fire damage to 1 foe.", "48 SP", new()
            {
                new("Surt", 74, false, false)
            }),
            new("Rainy Death", "Deals heavy Phys damage to 1 foe.", "20% HP", new()
            {
                new("Chernobog", 0, false, false),
                new("Siegfried", 68, false, false)
            }),
            new("Rakukaja", "Increases 1 ally's Defense for 3 turns. (Raises one ally's physical/magical defensive strength for three turns.)", "12 SP", new()
            {
                new("Izanagi", 0, false, false),
                new("Cu Sith", 0, false, false),
                new("Hua Po", 0, false, false),
                new("Fortuna", 0, false, false),
                new("Pazuzu", 0, false, false),
                new("Loki", 0, true, false),
                new("Shiisaa", 22, false, false),
                new("King Frost", 23, false, false),
                new("Nozuchi", 30, false, false)
            }),
            new("Rakunda", "Decreases 1 foe's Defense for 3 turns. (Reduces one enemy's physical and magic defensive power for three turns.)", "12 SP", new()
            {
                new("Nata Taishi", 0, false, false),
                new("Valkyrie", 0, false, false),
                new("Xiezhai", 0, false, false),
                new("Yaksini", 0, false, false),
                new("Ara Mitama", 0, false, false),
                new("Hanuman", 0, false, false),
                new("Izanagi", 3, false, false),
                new("Apsaras", 5, false, false),
                new("Forneus", 7, false, false),
                new("Ghoul", 13, false, false)
            }),
            new("Rampage", "Deals light Phys damage to all foes 1x to 3x.", "12% HP", new()
            {
                new("Xiezhai", 19, false, false),
                new("Ippon-Datara", 21, false, false),
                new("Legion", 23, false, false),
                new("Matador", 27, false, false),
                new("Ares", 28, false, false)
            }),
            new("Re Patra", "Recovers 1 ally from Knockdown or Dizzy status.", "3 SP", new()
            {
                new("Nigi Mitama", 0, false, false),
                new("Hua Po", 0, false, false),
                new("Ame No Uzume", 21, false, false)
            }),
            new("Rebellion", "Increases Critical rate for 3 turns (1 ally).", "5 SP", new()
            {
                new("Seiten Taisei", 0, false, false)
            }),
            new("Recarm", "Revives 1 ally with 50% HP.", "8 SP", new()
            {
                new("Hanuman", 0, false, false),
                new("Cybele", 0, false, false),
                new("Nigi Mitama", 25, false, false),
                new("Queen Mab", 26, false, false),
                new("Unicorn", 33, false, false),
                new("Lachesis", 53, false, false)
            }),
            new("Red Wall", "Add Fire resistance to 1 ally (for 3 turns).", "18 SP", new()
            {
                new("Yamata-No-Orochi", 0, false, false),
                new("Kushinada", 0, false, false),
                new("Slime", 4, false, false),
                new("Anzu", 18, false, false),
                new("Titania", 27, false, false),
                new("Kurama Tengu", 52, false, false),
                new("Lachesis", 56, false, false)
            }),
            new("Regenerate 1", "Restores 2% of max HP each turn in battle.", "", new()
            {
                new("Angel", 8, false, false),
                new("Sylph", 12, false, false)
            }),
            new("Regenerate 2", "Recovers 4% of max HP each turn in battle.", "", new()
            {
                new("Andra", 23, false, false),
                new("Titania", 31, false, false),
                new("Genbu", 42, false, false),
                new("Throne", 53, false, false),
                new("Cerberus", 55, false, false),
                new("Sui-Ki", 59, false, false)
            }),
            new("Regenerate 3", "Recovers 6% of max HP each turn in battle.", "", new()
            {
                new("Siegfried", 66, false, false),
                new("Alilat", 72, false, false),
                new("Tzitzimitl", 73, false, false),
                new("Seiten Taisei", 74, false, false),
                new("Vishnu", 75, true, false),
                new("Odin", 77, true, false),
                new("Satan", 77, false, false)
            }),
            new("Repel Dark", "Repels Darkness attacks. (Overwrites Resist/Null Dark)", "", new()
            {
                new("Michael", 76, false, false),
                new("Sandalphon", 90, true, false)
            }),
            new("Repel Elec", "Repels Elec attacks. (Overwrites Resist/Null Elec)", "", new()
            {
                new("Jatayu", 65, false, false),
                new("Tzitzimitl", 77, false, false),
                new("Yoshitsune", 78, false, false),
                new("Metatron", 88, false, false)
            }),
            new("Repel Fire", "Repels Fire attacks. (Overwrites Resist/Null Fire)", "", new()
            {
                new("Skadi", 59, false, false),
                new("Metatron", 89, false, false)
            }),
            new("Repel Ice", "Repels Ice attacks. (Overwrites Resist/Null Ice)", "", new()
            {
                new("Skadi", 57, false, false),
                new("Metatron", 87, false, false)
            }),
            new("Repel Light", "Repels Light attacks. (Overwrites Resist/Null Light)", "", new()
            {
                new("Yurlungur", 75, false, false),
                new("Lucifer", 96, true, false)
            }),
            new("Repel Physical", "Repels Phys attacks. (Overwrites Resist/Null Phys)", "", new()
            {
                new("Rangda", 55, false, false),
                new("Girimehkala", 56, false, false),
                new("Arahabaki", 80, false, false)
            }),
            new("Repel Wind", "Repels Wind attacks. (Overwrites Resist/Null Wind)", "", new()
            {
                new("Garuda", 62, false, false),
                new("Helel", 91, true, false)
            }),
            new("Resist Confuse", "Reduces chance of being Confused.", "", new()
            {
                new("Berith", 20, false, false),
                new("Principality", 23, false, false),
                new("Queen Mab", 30, false, false)
            }),
            new("Resist Dark", "Reduces chance of instant death from Darkness attacks. (Voids Dark weakness)", "", new()
            {
                new("Virtue", 39, false, false),
                new("Kikuri-Hime", 53, false, false),
                new("Throne", 54, false, false)
            }),
            new("Resist Dizzy", "Reduces chance of being Dizzy.", "", new()
            {
                new("Nata Taishi", 9, false, false),
                new("Orobas", 11, false, false)
            }),
            new("Resist Elec", "Reduces damage from Elec attacks. (Voids Elec weakness)", "", new()
            {
                new("Omoikane", 12, false, false),
                new("Kurama Tengu", 53, false, false),
                new("Kumbhanda", 59, false, false)
            }),
            new("Resist Enervate", "Reduces chance of being Enervated.", "", new()
            {
                new("Nigi Mitama", 29, false, false),
                new("Yamata-No-Orochi", 38, false, false)
            }),
            new("Resist Exhaust", "Reduces chance of being Exhausted.", "", new()
            {
                new("Eligor", 17, false, false),
                new("Dominion", 41, false, false),
                new("Hokuto Seikun", 48, false, false),
                new("Seiryu", 53, false, false),
                new("Lachesis", 57, false, false)
            }),
            new("Resist Fear", "Lessens instances of succumbing to Fear attacks.", "", new()
            {
                new("Titan", 19, false, false)
            }),
            new("Resist Fire", "Reduces damage from Fire attacks. (Voids Fire weakness)", "", new()
            {
                new("Ukobach", 6, false, false),
                new("Shiisaa", 25, false, false),
                new("Narcissus", 26, false, false),
                new("Hitokoto-Nushi", 45, false, false),
                new("Mother Harlot", 64, false, false),
                new("Lakshmi", 70, false, false)
            }),
            new("Resist Ice", "Reduces damage from Ice attacks. (Voids Ice weakness)", "", new()
            {
                new("Makami", 33, false, false),
                new("Pyro Jack", 38, false, false),
                new("Suzaku", 58, false, false)
            }),
            new("Resist Light", "Reduces chance of instant death from Light attacks. (Voids Light weakness)", "", new()
            {
                new("Kaiwan", 27, false, false),
                new("Succubus", 49, false, false)
            }),
            new("Resist Mute", "Reduces chance of being Silenced.", "", new()
            {
                new("Makami", 31, false, false)
            }),
            new("Resist Physical", "Reduces damage from Phys attacks. (Voids Phys weakness)", "", new()
            {
                new("Slime", 7, false, false),
                new("Obariyon", 17, false, false),
                new("Gurr", 27, false, false),
                new("Oni", 33, false, false),
                new("Genbu", 45, false, false),
                new("Decarabia", 52, false, false),
                new("Nidhoggr", 60, false, false),
                new("Jinn", 65, false, false)
            }),
            new("Resist Poison", "Reduces chance of being Poisoned.", "", new()
            {
                new("Omoikane", 11, false, false)
            }),
            new("Resist Rage", "Reduces chance of being Enraged.", "", new()
            {
                new("Sarasvati", 20, false, false)
            }),
            new("Resist Wind", "Reduces damage from Wind attacks. (Voids Wind weakness)", "", new()
            {
                new("Omoikane", 9, false, false),
                new("Chernobog", 66, false, false)
            }),
            new("Revolution", "Greatly increases Critical rate for 3 turns (all).", "5 SP", new()
            {
                new("Shiki-Ouji", 0, false, false),
                new("Kali", 53, false, false),
                new("Kin-Ki", 59, false, false),
                new("Hachiman", 75, false, false),
                new("Ongyo-Ki", 86, true, false)
            }),
            new("Salvation", "Fully restores party's HP. Cures ailments.", "40 SP", new()
            {
                new("Ishtar", 78, true, false),
                new("Kohryu", 83, true, false),
                new("Isis", 85, true, false),
                new("Helel", 88, true, false)
            }),
            new("Samarecarm", "Revives 1 ally with full HP.", "18 SP", new()
            {
                new("Ishtar", 0, true, false),
                new("Kohryu", 0, true, false),
                new("Sandalphon", 0, true, false),
                new("Leanan Sidhe", 46, false, false),
                new("Kikuri-Hime", 50, false, false),
                new("Hariti", 64, false, false),
                new("Cybele", 68, false, false),
                new("Yurlungur", 74, false, false),
                new("Attis", 86, true, false)
            }),
            new("Samsara", "Light: very high chance of instant kill, all foes. (60% chance)", "44 SP", new()
            {
                new("Daisoujou", 67, false, false)
            }),
            new("Seal Bomb", "Deals medium Phys damage to all foes with a chance of Silence.", "14% HP", new()
            {
                new("Mithra", 0, false, false),
                new("Kin-Ki", 57, false, false)
            }),
            new("Sharp Student", "Lowers odds of sustaining crit dmg.", "", new()
            {
                new("Setanta", 0, false, false),
                new("Loki", 0, true, false),
                new("Orobas", 12, false, false),
                new("Archangel", 14, false, false),
                new("Ara Mitama", 21, false, false)
            }),
            new("Silence Boost", "Increases odds of inflicting Silence (1.5x).", "", new()
            {
                new("Obariyon", 15, false, false),
                new("Xiezhai", 18, false, false),
                new("Shiisaa", 24, false, false),
                new("Pabilsag", 54, false, false),
                new("Tzitzimitl", 71, false, false)
            }),
            new("Single Shot", "Deals light Phys damage to 1 foe.", "8% HP", new()
            {
                new("Berith", 0, false, false),
                new("Obariyon", 18, false, false)
            }),
            new("Skewer", "Deals light Phys damage to 1 foe.", "5% HP", new()
            {
                new("Forneus", 0, false, false),
                new("Yomotsu-Shikome", 0, false, false)
            }),
            new("Skull Cracker", "Deals light Phys damage to 1 foe with a chance of Confusion.", "9% HP", new()
            {
                new("Titan", 0, false, false),
                new("Sandman", 6, false, false)
            }),
            new("Sonic Punch", "Deals light Phys damage to 1 foe.", "8% HP", new()
            {
                new("Obariyon", 0, false, false),
                new("Mokoi", 0, false, false),
                new("Nata Taishi", 7, false, false)
            }),
            new("Soul Break", "Exhausts 1 foe (40% chance). (-10% SP/turn)", "5 SP", new()
            {
                new("Kusi Mitama", 0, false, false),
                new("Nata Taishi", 10, false, false),
                new("Eligor", 16, false, false),
                new("Mokoi", 18, false, false),
                new("Lamia", 30, false, false)
            }),
            new("Spell Master", "Halves SP cost for magic skills.", "", new()
            {
                new("Skadi", 60, false, false),
                new("Nebiros", 70, false, false),
                new("Ishtar", 76, true, false),
                new("Kaguya", 80, false, false),
                new("Saturnus", 81, false, false),
                new("Kohryu", 82, true, false),
                new("Shiva", 83, true, false),
                new("Asura", 90, true, false),
                new("Lucifer", 95, true, false)
            }),
            new("Spirit Drain", "Drains 30 SP from 1 foe.", "3 SP", new()
            {
                new("Kaiwan", 29, false, false),
                new("Incubus", 32, false, false),
                new("Succubus", 48, false, false)
            }),
            new("Stagnant Air", "Increase all foe's susceptibility to ailments and Light/Dark skills.", "5 SP", new()
            {
                new("Kaiwan", 26, false, false),
                new("Incubus", 30, false, false),
                new("Pazuzu", 39, false, false),
                new("Pabilsag", 53, false, false),
                new("Nidhoggr", 59, false, false),
                new("Baal Zebul", 82, false, false),
                new("Beelzebub", 82, true, false)
            }),
            new("Sukukaja", "Increases 1 ally's Hit/Evasion rates for 3 turns.", "12 SP", new()
            {
                new("Sylph", 0, false, false),
                new("Andra", 0, false, false),
                new("High Pixie", 0, false, false),
                new("Angel", 6, false, false),
                new("Ghoul", 10, false, false),
                new("Lilim", 13, false, false)
            }),
            new("Sukunda", "Decreases 1 foe's Hit/Evasion rates for 3 turns.", "12 SP", new()
            {
                new("Ukobach", 0, false, false),
                new("Omoikane", 0, false, false),
                new("Saki Mitama", 0, false, false),
                new("Makami", 0, false, false),
                new("Yomotsu-Shikome", 9, false, false)
            }),
            new("Survive Dark", "50% chance of surviving instant death 1 time from a Darkness attack with 1 HP.", "", new()
            {
                new("Archangel", 15, false, false),
                new("Principality", 24, false, false),
                new("Power", 32, false, false),
                new("Kusi Mitama", 32, false, false),
                new("Dominion", 43, false, false),
                new("Gabriel", 47, false, false)
            }),
            new("Survive Light", "50% chance of surviving instant death 1 time from a Light attack with 1 HP.", "", new()
            {
                new("Legion", 26, false, false),
                new("Take-Minakata", 29, false, false),
                new("Matador", 30, false, false),
                new("Kusi Mitama", 31, false, false),
                new("Ose", 36, false, false),
                new("Pale Rider", 39, false, false),
                new("Samael", 41, false, false),
                new("Loa", 42, false, false),
                new("Mot", 48, false, false)
            }),
            new("Swift Strike", "Deals light Phys damage to all foes 1x to 2x.", "12% HP", new()
            {
                new("Matador", 0, false, false),
                new("Yaksini", 20, false, false),
                new("Gurr", 22, false, false)
            }),
            new("Tarukaja", "Increases 1 ally's Attack for 3 turns. (Raises one ally's physical/magical offensive strength for three turns.)", "12 SP", new()
            {
                new("Forneus", 0, false, false),
                new("Obariyon", 0, false, false),
                new("Flauros", 0, false, false),
                new("Izanagi", 5, false, false),
                new("Ara Mitama", 20, false, false)
            }),
            new("Tarunda", "Decreases 1 foe's Attack for 3 turns. (Reduces one enemy's physical/offensive magic strength for three turns.)", "12 SP", new()
            {
                new("Omoikane", 0, false, false),
                new("Pyro Jack", 0, false, false),
                new("Slime", 3, false, false)
            }),
            new("Tempest Slash", "Deals heavy Phys damage to 1 foe 1x to 2x.", "15% HP", new()
            {
                new("Narasimha", 0, false, false),
                new("Masakado", 0, false, false)
            }),
            new("Tentarafoo", "Confuses* all foes (30% chance).", "12 SP", new()
            {
                new("Legion", 0, false, false),
                new("Narcissus", 0, false, false),
                new("Queen Mab", 0, false, false),
                new("Power", 0, false, false),
                new("Raja Naga", 0, false, false),
                new("Mot", 0, false, false),
                new("Rangda", 0, false, false),
                new("Leanan Sidhe", 43, false, false),
                new("Baal Zebul", 78, false, false),
                new("Beelzebub", 78, true, false)
            }),
            new("Tetra Break", "Negates all foes' Tetrakarn.", "18 SP", new()
            {
                new("Chernobog", 0, false, false),
                new("Mithra", 33, false, false),
                new("Abaddon", 60, false, false),
                new("Sui-Ki", 60, false, false)
            }),
            new("Tetraja", "Nullifies instant kill attack once (1 ally).", "24 SP", new()
            {
                new("Principality", 25, false, false),
                new("Loa", 47, false, false),
                new("Girimehkala", 52, false, false),
                new("Kumbhanda", 61, false, false),
                new("Kaguya", 75, false, false)
            }),
            new("Tetrakarn", "Barrier that reflects phys dmg once. (1 ally)", "36 SP", new()
            {
                new("Kaiwan", 0, false, false),
                new("Decarabia", 0, false, false),
                new("Isis", 0, true, false),
                new("Arahabaki", 76, false, false)
            }),
            new("Thunder Reign", "Deals severe Elec damage to 1 foe.", "48 SP", new()
            {
                new("Thor", 70, false, false)
            }),
            new("Torrent Shot", "Deals medium Phys damage to 1 foe 2x to 3x.", "12% HP", new()
            {
                new("Fuu-Ki", 0, false, false),
                new("Raja Naga", 39, false, false),
                new("Taotie", 41, false, false)
            }),
            new("Traesto", "Instantly escape from a dungeon. (Not available during combat)", "18 SP", new()
            {
                new("Sandman", 11, false, false),
                new("Cu Sith", 15, false, false),
                new("Kusi Mitama", 33, false, false)
            }),
            new("Trafuri", "Enables escape from most battles. (100% chance to escape normal battles)", "24 SP", new()
            {
                new("Pixie", 8, false, false),
                new("Senri", 14, false, false),
                new("Ame No Uzume", 24, false, false),
                new("High Pixie", 27, false, false),
                new("Unicorn", 32, false, false),
                new("Sati", 34, false, false)
            }),
            new("Twin Shot", "Deals light Phys damage to 1 foe 2x.", "10% HP", new()
            {
                new("Principality", 0, false, false),
                new("Phoenix", 22, false, false)
            }),
            new("Unshaken Will", "Protects user from Rage/Fear/Silence/Enervation/Confusion.", "", new()
            {
                new("Asura", 92, true, false)
            }),
            new("Valiant Dance", "Enrages all foes (30% chance).", "12 SP", new()
            {
                new("Mothman", 0, false, false),
                new("Mokoi", 15, false, false),
                new("Jinn", 68, false, false)
            }),
            new("Vicious Strike", "Deals heavy Phys damage to all foes.", "18% HP", new()
            {
                new("Kurama Tengu", 0, false, false),
                new("Sui-Ki", 0, false, false),
                new("Cybele", 0, false, false),
                new("Arahabaki", 0, false, false),
                new("Cerberus", 53, false, false),
                new("Kingu", 62, false, false)
            }),
            new("Victory Cry", "Recover full HP and SP after a successful battle.", "", new()
            {
                new("Izanagi-No-Okami", 0, false, true),
                new("Lucifer", 99, true, false)
            }),
            new("Vile Assault", "Deals heavy Phys damage to 1 foe. Bonus damage to foes that are knocked down.", "18% HP", new()
            {
                new("Kin-Ki", 0, false, false)
            }),
            new("Virus Wave", "Deals heavy Phys damage to all foes with a chance of Poison.", "16% HP", new()
            {
                new("Yurlungur", 0, false, false),
                new("Tzitzimitl", 0, false, false),
                new("Vasuki", 0, false, false)
            }),
            new("Vorpal Blade", "Deals heavy Phys damage to all foes.", "25% HP", new()
            {
                new("Michael", 0, false, false),
                new("Seiten Taisei", 76, false, false),
                new("Zaou Gongen", 96, true, false)
            }),
            new("White Wall", "Add Ice resistance to 1 ally (for 3 turns).", "18 SP", new()
            {
                new("Ananta", 0, false, false),
                new("Cu Sith", 14, false, false),
                new("Cu Chulainn", 49, false, false)
            }),
            new("Wind Amp", "Strengthens Wind attacks by 50%.", "", new()
            {
                new("Cu Chulainn", 53, false, false),
                new("Quetzalcoatl", 57, false, false),
                new("Atropos", 70, false, false),
                new("Horus", 70, false, false),
                new("Seth", 73, false, false),
                new("Norn", 76, true, false),
                new("Odin", 76, true, false),
                new("Suparna", 80, false, false),
                new("Scathach", 84, true, false),
                new("Izanagi-No-Okami", 99, false, true)
            }),
            new("Wind Boost", "Strengthens Wind attacks by 25%.", "", new()
            {
                new("Atropos", 0, false, false),
                new("Fortuna", 40, false, false),
                new("Fuu-Ki", 47, false, false),
                new("Clotho", 48, false, false),
                new("Kurama Tengu", 51, false, false)
            }),
            new("Wind Break", "Nullifies 1 foe's Wind resistance (for 3 turns).", "15 SP", new()
            {
                new("Seth", 71, false, false)
            }),
            new("Zio", "Deals light Elec damage to 1 foe.", "4 SP", new()
            {
                new("Izanagi", 0, false, false),
                new("Omoikane", 0, false, false),
                new("Lilim", 0, false, false),
                new("Oberon", 0, false, false),
                new("Xiezhai", 0, false, false),
                new("Pixie", 3, false, false)
            }),
            new("Ziodyne", "Deals heavy Elec damage to 1 foe.", "12 SP", new()
            {
                new("Lilith", 0, false, false),
                new("Tam Lin", 0, false, false),
                new("Barong", 0, false, false),
                new("Thor", 0, false, false),
                new("Trumpeter", 0, false, false),
                new("Tzitzimitl", 0, false, false),
                new("Odin", 0, true, false),
                new("Yoshitsune", 0, false, false),
                new("Kohryu", 0, true, false),
                new("Shiva", 0, true, false),
                new("Ongyo-Ki", 0, true, false),
                new("Loa", 43, false, false),
                new("Seiryu", 49, false, false),
                new("Thoth", 51, false, false),
                new("Hokuto Seikun", 51, false, false),
                new("Sraosha", 76, true, false),
                new("Vasuki", 77, false, false),
                new("Izanagi-No-Okami", 94, false, true)
            }),
            new("Zionga", "Deals medium Elec damage to 1 foe.", "8 SP", new()
            {
                new("Queen Mab", 0, false, false),
                new("Take-Minakata", 0, false, false),
                new("Kusi Mitama", 0, false, false),
                new("Unicorn", 0, false, false),
                new("Neko Shogun", 0, false, false),
                new("Mothman", 0, false, false),
                new("Setanta", 0, false, false),
                new("Dominion", 0, false, false),
                new("Okuninushi", 0, false, false),
                new("Hokuto Seikun", 0, false, false),
                new("Shiisaa", 23, false, false),
                new("Andra", 24, false, false),
                new("High Pixie", 24, false, false),
                new("Power", 29, false, false),
                new("Nozuchi", 29, false, false),
                new("Hitokoto-Nushi", 43, false, false)
            })
        };
    }
}
