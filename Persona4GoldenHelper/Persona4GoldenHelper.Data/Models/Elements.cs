using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Elements
    {
        public int Id { get; set; }
        public ElementAffinity Physical { get; set; }
        public ElementAffinity Fire { get; set; }
        public ElementAffinity Ice { get; set; }
        public ElementAffinity Electricity { get; set; }
        public ElementAffinity Wind { get; set; }
        public ElementAffinity Light { get; set; }
        public ElementAffinity Darkness { get; set; }
    }
}
