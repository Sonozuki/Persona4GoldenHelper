namespace Persona4GoldenHelper
{
    /// <summary>The affinity to an element a persona or shadow has.</summary>
    public enum ElementAffinity
    {
        /// <summary>The persona or shadow gets knocked down.</summary>
        Weak,

        /// <summary>The persona or shadow has no negative or positive effects.</summary>
        None,

        /// <summary>The persona or shadow receives reduced damage.</summary>
        Resistant,

        /// <summary>The persona or shadow receives no damage.</summary>
        Null,

        /// <summary>The persona or shadow reflects damage back to the dealer.</summary>
        Reflect,

        /// <summary>The persona or shadow gains health when receiving damage.</summary>
        Absorb
    }
}
