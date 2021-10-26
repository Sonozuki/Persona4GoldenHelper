using Persona4GoldenHelper.Attributes;

namespace Persona4GoldenHelper.Extensions
{
    /// <summary>The extension methods for <see cref="Enum"/>.</summary>
    public static class EnumExtensions
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Retrieves the display name of an enum value.</summary>
        /// <param name="enum">The enum value whose display name should be retrieved.</param>
        /// <returns>The display name of <paramref name="enum"/>.</returns>
        public static string GetDisplayName(this Enum @enum)
        {
            var displayName = @enum.ToString();

            // set the display name to what's specified in the display name attribute (if it has one)
            var memberInfo = @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault();
            var displayNameAttribute = (DisplayNameAttribute)memberInfo?.GetCustomAttributes(typeof(DisplayNameAttribute), false).FirstOrDefault();
            if (displayNameAttribute != null)
                displayName = displayNameAttribute.DisplayName;

            return displayName;
        }
    }
}
