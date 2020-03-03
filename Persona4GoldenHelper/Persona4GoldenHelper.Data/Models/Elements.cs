using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about element affinity for shadows and personas.</summary>
    public class Elements
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The physical damage affinity.</summary>
        public ElementAffinity Physical { get; set; }

        /// <summary>The fire damage affinity</summary>
        public ElementAffinity Fire { get; set; }

        /// <summary>The ice damage affinity.</summary>
        public ElementAffinity Ice { get; set; }

        /// <summary>The electricity damage affinity.</summary>
        public ElementAffinity Electricity { get; set; }

        /// <summary>The wind damage affinity.</summary>
        public ElementAffinity Wind { get; set; }

        /// <summary>The light damage affinity.</summary>
        public ElementAffinity Light { get; set; }

        /// <summary>The darkness damage affinity.</summary>
        public ElementAffinity Darkness { get; set; }
    }
}
