namespace Persona4GoldenHelper.Attributes
{
    /// <summary>Indicates the display name of a member.</summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class DisplayNameAttribute : Attribute
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The display name of the member.</summary>
        public string DisplayName { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="displayName">The display name of the member.</param>
        public DisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
