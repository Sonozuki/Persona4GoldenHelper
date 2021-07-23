using System.Collections.Generic;

namespace Persona4GoldenHelper.Shared.Models.Calculator
{
    /// <summary>Represents a special persona fusion.</summary>
    public class SpecialFusionResult
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The result persona.</summary>
        public string ResultPersona { get; }

        /// <summary>The source personas.</summary>
        public List<string> SourcePersonas { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="resultPersona">The result persona.</param>
        /// <param name="sourcePersonas">The source personas.</param>
        public SpecialFusionResult(string resultPersona, List<string> sourcePersonas)
        {
            ResultPersona = resultPersona;
            SourcePersonas = sourcePersonas ?? new();
        }
    }
}
