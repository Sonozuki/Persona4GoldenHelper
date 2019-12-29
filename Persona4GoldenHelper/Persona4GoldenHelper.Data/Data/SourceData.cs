using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    public class SourceData
    {
        public static List<Source> Sources { get; set; } = new List<Source>()
        {
            new Source() {
                Information = "Personas",
                Link = "https://megamitensei.fandom.com/wiki/List_of_Persona_4_Personas & https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Personas"
            },
            new Source() {
                Information = "Persona Fusion Calculator",
                Link = "Code was based on: https://github.com/arantius/persona-fusion-calculator & http://persona4.wikidot.com/fusiontutor & https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/map/8037-fusion-chart"
            },
            new Source() {
                Information = "Skills",
                Link = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Skill_List"
            },
            new Source() {
                Information = "Books",
                Link = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/65714"
            },
            new Source() {
                Information = "Exam Answers",
                Link = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/65427"
            },
            new Source() {
                Information = "Quests",
                Link = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/68730 & https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Quests"
            },
            new Source() {
                Information = "Lunches",
                Link = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Boxed_Lunches"
            },
            new Source() {
                Information = "Skill Cards",
                Link = "https://docs.google.com/file/d/0BwDCz_Mqaf8RTmJac1hMS1dQOUU/edit?pli=1"
            }
        };
    }
}
