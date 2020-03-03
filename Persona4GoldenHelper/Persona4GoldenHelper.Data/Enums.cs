namespace Persona4GoldenHelper.Data.Enums
{
    /// <summary>The element affinity enumerator for shadows and personas.</summary>
    public enum ElementAffinity
    {
        Weak,
        None,
        Resistant,
        Null,
        Reflect,
        Absorb
    }

    /// <summary>The gender enumerator for armor.</summary>
    public enum Gender
    {
        Unisex,
        Male,
        Female
    }

    /// <summary>The month enumerator for exam answers.</summary>
    public enum Month
    {
        January = 1,
        February,
        April = 4, // skip march as you don't get asked a question then
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    /// <summary>The skill enumerator for shadow and persona skills.</summary>
    public enum SkillType
    {
        Physical,
        Magical,
        Support,
        Passive
    }

    /// <summary>The arcana fusion types for arcana fusions.</summary>
    public enum FusionType
    {
        Arcana2,
        Arcana3
    }

    /// <summary>The type enumerator for shadows.</summary>
    public enum ShadowType
    {
        Normal,
        MiniBoss,
        Boss
    }

    /// <summary>The user enumerator for weapons.</summary>
    public enum User
    {
        Protagonist,
        Yosuke,
        Chie,
        Yukiko,
        Kanji,
        Teddie,
        Naoto
    }
}
