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
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://megamitensei.fandom.com/wiki/List_of_Persona_4_Personas"
                    },
                    new Link() {
                        URL = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Personas"
                    }
                }
            },
            new Source() {
                Information = "Persona Fusion Calculator",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://github.com/arantius/persona-fusion-calculator"
                    },
                    new Link() {
                        URL = "http://persona4.wikidot.com/fusiontutor"
                    },
                    new Link() {
                        URL = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/map/8037-fusion-chart"
                    }
                }
            },
            new Source() {
                Information = "Skills",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Skill_List"
                    }
                }
            },
            new Source() {
                Information = "Books",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/65714"
                    }
                }
            },
            new Source() {
                Information = "Exam Answers",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/65427"
                    }
                }
            },
            new Source() {
                Information = "Quests",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://gamefaqs.gamespot.com/vita/641695-persona-4-golden/faqs/68730"
                    },
                    new Link() {
                        URL = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Quests"
                    }
                }
            },
            new Source() {
                Information = "Shadows",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://megamitensei.fandom.com/wiki/Category:Persona_4_Golden_Shadows"
                    }
                }
            },
            new Source() {
                Information = "Lunches",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://uk.ign.com/wikis/shin-megami-tensei-persona-4-golden/Boxed_Lunches"
                    }
                }
            },
            new Source() {
                Information = "Skill Cards",
                Links = new List<Link>() {
                    new Link() {
                        URL = "https://docs.google.com/file/d/0BwDCz_Mqaf8RTmJac1hMS1dQOUU/edit?pli=1"
                    }
                }
            }
        };
    }
}
