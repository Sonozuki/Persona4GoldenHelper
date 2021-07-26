namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents a lunch.</summary>
    public class Lunch
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the lunch.</summary>
        public string Name { get; }

        /// <summary>The correct method to create the lunch.</summary>
        public string Method { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the lunch.</param>
        /// <param name="method">The correct method to create the lunch.</param>
        public Lunch(string name, string method)
        {
            Name = name;
            Method = method;
        }
    }
}
