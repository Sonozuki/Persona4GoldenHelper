namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents the element affinities of a shadow or persona.</summary>
    public class ElementAffinities : FilterableModelBase
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The affinity to physical damage.</summary>
        public ElementAffinity Physical { get; }

        /// <summary>The affinity to fire damage.</summary>
        public ElementAffinity Fire { get; }

        /// <summary>The affinity to ice damage.</summary>
        public ElementAffinity Ice { get; }

        /// <summary>The affinity to electricity damage.</summary>
        public ElementAffinity Electricity { get; }

        /// <summary>The affinity to wind damage.</summary>
        public ElementAffinity Wind { get; }

        /// <summary>The affinity to light damage.</summary>
        public ElementAffinity Light { get; }

        /// <summary>The affinity to darkness damage.</summary>
        public ElementAffinity Darkness { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="physical">The affinity to physical damage.</param>
        /// <param name="fire">The affinity to fire damage.</param>
        /// <param name="ice">The affinity to ice damage.</param>
        /// <param name="electricity">The affinity to electricity damage.</param>
        /// <param name="wind">The affinity to wind damage.</param>
        /// <param name="light">The affinity to light damage.</param>
        /// <param name="darkness">The affinity to darkness damage.</param>
        public ElementAffinities(ElementAffinity physical, ElementAffinity fire, ElementAffinity ice, ElementAffinity electricity, ElementAffinity wind, ElementAffinity light, ElementAffinity darkness)
        {
            Physical = physical;
            Fire = fire;
            Ice = ice;
            Electricity = electricity;
            Wind = wind;
            Light = light;
            Darkness = darkness;
        }

        /// <inheritdoc/>
        public override bool DoesModelPassFilter(string filter) =>
            Utilities.ConvertElementAffinityToShortHand(Physical).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Fire).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Ice).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Electricity).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Wind).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Light).Contains(filter, StringComparison.OrdinalIgnoreCase)
            || Utilities.ConvertElementAffinityToShortHand(Darkness).Contains(filter, StringComparison.OrdinalIgnoreCase);

        /// <inheritdoc/>
        public override bool Equals(object obj) =>
            obj is ElementAffinities affinities
             && Physical == affinities.Physical
             && Fire == affinities.Fire
             && Ice == affinities.Ice
             && Electricity == affinities.Electricity
             && Wind == affinities.Wind
             && Light == affinities.Light
             && Darkness == affinities.Darkness;

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(Physical, Fire, Ice, Electricity, Wind, Light, Darkness);
    }
}
