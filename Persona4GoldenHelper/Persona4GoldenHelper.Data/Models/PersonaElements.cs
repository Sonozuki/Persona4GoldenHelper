using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class PersonaElements
    {
        public ElementAffinity Physical { get; set; }
        public ElementAffinity Fire { get; set; }
        public ElementAffinity Ice { get; set; }
        public ElementAffinity Electricity { get; set; }
        public ElementAffinity Wind { get; set; }
        public ElementAffinity Light { get; set; }
        public ElementAffinity Darkness { get; set; }

        public PersonaElements(ElementAffinity physical, ElementAffinity fire, ElementAffinity ice, ElementAffinity electricity, ElementAffinity wind, ElementAffinity light, ElementAffinity darkness)
        {
            Physical = physical;
            Fire = fire;
            Ice = ice;
            Electricity = electricity;
            Wind = wind;
            Light = light;
            Darkness = darkness;
        }
    }
}
