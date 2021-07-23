using Persona4GoldenHelper.Shared.Models.Calculator;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data.Calculator
{
    /// <summary>The special persona fusion data.</summary>
    public static class SpecialFusionResultData
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The special persona fusion data.</summary>
        public static List<SpecialFusionResult> SpecialFusionResults { get; } = new()
        {
            new("Alice", new() { "Nebiros", "Belial" }),
            new("Ukobach", new() { "Vetala", "Lilim" }),
            new("Shiva", new() { "Rangda", "Barong" }),
            new("Izanagi", new() { "Obariyon", "Yomotsu-Shikome" }),
            new("Pixie", new() { "Jack Frost", "Orobas" }),
            new("Ardha", new() { "Shiva", "Parvati" }),
            new("Slime", new() { "Eligor", "Nata Taishi" }),
            new("Norn", new() { "Clotho", "Lachesis", "Atropos" }),
            new("Neko Shogun", new() { "Saki Mitama", "Ara Mitama", "Kusi Mitama", "Nigi Mitama" }),
            new("Tam Lin", new() { "Phoenix", "Gdon", "Yatagarasu", "Narasimha" }),
            new("Ongyo-Ki", new() { "Oni", "Fuu-Ki", "Kin-Ki", "Sui-Ki" }),
            new("Kohryu", new() { "Genbu", "Seiryu", "Suzaku", "Byakko" }),
            new("Black Frost", new() { "Jack Frost", "Pyro Jack", "King Frost", "Pixie", "Ghoul" }),
            new("Futsunushi", new() { "Ares", "Triglav", "Kin-Ki", "Atavaka", "Neko Shogun" }),
            new("Yatsufusa", new() { "Makami", "Orthrus", "Mothman", "Thoth", "Narasimha" }),
            new("Yoshitsune", new() { "Masakado", "Shiki-Ouji", "Okuninushi", "Hachiman", "Hitokoto-Nushi" }),
            new("Mahakala", new() { "Matador", "White Rider", "Mother Harlot", "Daisoujou", "Hell Biker", "Trumpeter" }),
            new("Beelzebub", new() { "Pazuzu", "Belphegor", "Belial", "Mot", "Seth", "Baal Zebul" }),
            new("Trumpeter", new() { "Matador", "White Rider", "Daisoujou", "Taotie", "Pabilsag", "Taowu" }),
            new("Lucifer", new() { "Ananta", "Anubis", "Trumpeter", "Michael", "Satan", "Metatron" }),
            new("Izanagi-No-Okami", new() { "Izanagi", "Sandman", "Nata Taishi", "Girimehkala", "Norn", "Okuninushi", "Orthrus", "Kartikeya", "Mithra", "Tzitzimitl", "Cu Chulainn", "Legion" })
        };
    }
}
