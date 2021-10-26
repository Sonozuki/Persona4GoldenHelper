using Persona4GoldenHelper.Attributes;

namespace Persona4GoldenHelper
{
    /// <summary>The types of shadows.</summary>
    public enum ShadowType
    {
        /// <summary>A regular shadow that's found when exploring.</summary>
        Normal,

        /// <summary>A mini-boss that's required to kill before completing some dungeons.</summary>
        [DisplayName("Mini Boss")]
        MiniBoss,

        /// <summary>A boss at the end of a dungeon.</summary>
        Boss
    }
}
