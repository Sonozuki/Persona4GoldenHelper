using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class PersonaElements
    {
        public ElementAffinity Physical { get; private set; }
        public ElementAffinity Fire { get; private set; }
        public ElementAffinity Ice { get; private set; }
        public ElementAffinity Electricity { get; private set; }
        public ElementAffinity Wind { get; private set; }
        public ElementAffinity Light { get; private set; }
        public ElementAffinity Darkness { get; private set; }

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
