namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents an arcana fusion.</summary>
    public class ArcanaFusionResult
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The fusion type.</summary>
        public FusionType FusionType { get; }

        /// <summary>The result arcana of the fusion.</summary>
        public string ResultArcana { get; }

        /// <summary>The source arcanas of the fusion.</summary>
        public List<string> SourceArcanas { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="fusionType">The fusion type.</param>
        /// <param name="resultArcana">The result arcana of the fusion.</param>
        /// <param name="sourceArcanas">The source arcanas of the fusion.</param>
        public ArcanaFusionResult(FusionType fusionType, string resultArcana, List<string> sourceArcanas)
        {
            FusionType = fusionType;
            ResultArcana = resultArcana;
            SourceArcanas = sourceArcanas ?? new();
        }
    }
}
