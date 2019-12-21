using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;
using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Context
{
    public class ExamAnswerContext
    {
        public List<Answer> Answers { get; } = new List<Answer>()
        {
            new Answer(
                month: Month.April,
                dateAsked: "4/14",
                questionAsked: "What is the year before 1 AD called?",
                questionAnswer: "1 B.C."
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/18",
                questionAsked: "The word \"alphabet\" comes from the the word \"alpha\" and what other one?",
                questionAnswer: "Beta"
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/20",
                questionAsked: "[Player Name]! C'mon, man, help me here!",
                questionAnswer: "Three"
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/23",
                questionAsked: "What's this ergonomic bubble she's asking about!?",
                questionAnswer: "Tulip mania"
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/25",
                questionAsked: "... what's it called when you gain more muscle after getting sore through excercise?",
                questionAnswer: "Overcompensation"
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/26",
                questionAsked: "I don't think I've heard of any of these!",
                questionAnswer: "Marriage numbers"
            ),
            new Answer(
                month: Month.April,
                dateAsked: "4/30",
                questionAsked: "What is the greatest canyon in the solar system?",
                questionAnswer: "Valles Marineris"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/7",
                questionAsked: "Do you know how Soseki Natsume translated the English phrase \"I love you\" into Japanese?",
                questionAnswer: "The moon is beautiful, isn't it?"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/9",
                questionAsked: "What is it called when muscles grow after excercise?",
                questionAnswer: "Overcompensation"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/9",
                questionAsked: "What is the year before 1 A.D. called?",
                questionAnswer: "1 B.C."
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/10",
                questionAsked: "Which of these types of numbers does not exist?",
                questionAnswer: "Marriage numbers"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/10",
                questionAsked: "Who translated \"I love you\" as \"The moon is beautiful, isn't it\"?",
                questionAnswer: "Soseki Natsume"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/11",
                questionAsked: "Who said \"As soon as laws are necessary for men, they are no longer fit for freedom\"?",
                questionAnswer: "Pythagoras"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/11",
                questionAsked: "Which of the following is the highest mountain in the solar system?",
                questionAnswer: "Olympus Mons"
            ),
            new Answer(
                month: Month.May,
                dateAsked: "5/26",
                questionAsked: "Something about laborers?",
                questionAnswer: "Attendance logs"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/8",
                questionAsked: "What sport is \"heikin-dai\"?",
                questionAnswer: "Balance Beam"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/13",
                questionAsked: "What kind of excercise is a sprint classified as?",
                questionAnswer: "Anaerobics"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/15",
                questionAsked: "Sorry, [Player Name], tell me what morale is!?",
                questionAnswer: "Cheerfulness of a group"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/20",
                questionAsked: "What period did Japan first implement bonus pay?",
                questionAnswer: "Meiji"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/27",
                questionAsked: "Answer this: What is identity?",
                questionAnswer: "Individuality"
            ),
            new Answer(
                month: Month.June,
                dateAsked: "6/30",
                questionAsked: "Which one of these is the name of a real river?",
                questionAnswer: "Pis Pis River"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/4",
                questionAsked: "You gotta help me out?",
                questionAnswer: "Pascal"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/7",
                questionAsked: "What is the beginning of \"Gakumon no Susume\" a reference to?",
                questionAnswer: "The U.S. Declaration of Independence"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/13",
                questionAsked: "What is the medical term for brainfreeze!?",
                questionAnswer: "Sphenopalatine ganglioneuralgia"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/14",
                questionAsked: "Which famous Heian-ero monk famously used a wrong version of the \"応\" kanji?",
                questionAnswer: "Kuukai"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/15",
                questionAsked: "Which line can a typhoon never cross?",
                questionAnswer: "The equator"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/16",
                questionAsked: "... what makes the king of hearts look different from the other kings in a standard deck of cards?",
                questionAnswer: "He has no mustache"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/19",
                questionAsked: "What is morale?",
                questionAnswer: "Cheerfulness in a group"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/19",
                questionAsked: "What sport is \"heikin-dai\"?",
                questionAnswer: "Balance Beam"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/20",
                questionAsked: "It is said, \"Even Kobo made mistakes in writing.\" Which kanji did he make a mistake on?",
                questionAnswer: "応 (The first one)"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/20",
                questionAsked: "In which period did Japan first implement bonus pay?",
                questionAnswer: "Meiji"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/21",
                questionAsked: "Which king in a deck of cards is missing a mustache?",
                questionAnswer: "King of Hearts"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/21",
                questionAsked: "Who said this: \"Man is but a reed, the most feeble thing in nature; but he is a thinking reed\"?",
                questionAnswer: "Pascal"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/22",
                questionAsked: "Which one of these is the name of real river?",
                questionAnswer: "Pis Pis River"
            ),
            new Answer(
                month: Month.July,
                dateAsked: "7/22",
                questionAsked: "What is the beginning of \"Gakumon no Susume\" a reference to?/",
                questionAnswer: "The U.S. Declaration of Independence"
            ),
            new Answer(
                month: Month.August,
                dateAsked: "8/28",
                questionAsked: "NOTE:Study with Justice to be asked.\nIs it the male or female platypus that has the poison claws?",
                questionAnswer: "Male"
            ),
            new Answer(
                month: Month.August,
                dateAsked: "8/29",
                questionAsked: "NOTE:Study with Justice to be asked.\nDid it rain the day that we worked on my art homework?",
                questionAnswer: "It stopped raining by then"
            ),
            new Answer(
                month: Month.September,
                dateAsked: "9/1",
                questionAsked: "\"Venison\" is the meat of what animal?",
                questionAnswer: "All of the above"
            ),
            new Answer(
                month: Month.September,
                dateAsked: "9/5",
                questionAsked: "Which of the following is a kigo for fall?",
                questionAnswer: "Brisk"
            ),
            new Answer(
                month: Month.September,
                dateAsked: "9/17",
                questionAsked: "How short was history's shortest war?",
                questionAnswer: "40 minutes"
            ),
            new Answer(
                month: Month.September,
                dateAsked: "9/20",
                questionAsked: "What do you call somebody who's between ninety and one hundred years old?",
                questionAnswer: "A nonagenarian"
            ),
            new Answer(
                month: Month.September,
                dateAsked: "9/28",
                questionAsked: "Do you know the answer?",
                questionAnswer: "Throat"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/4",
                questionAsked: "Which of these sports also uses an anchor?",
                questionAnswer: "Tug-of-War"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/5",
                questionAsked: "Do you know the answer, [Player Name]?",
                questionAnswer: "The right edge"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/8",
                questionAsked: "Tell me what bird's name means \"coward\" in English!",
                questionAnswer: "Chicken"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/11",
                questionAsked: "What did Napoleon have invented?",
                questionAnswer: "Glass jars"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/12",
                questionAsked: "Do you know what vegetables was used to make the first jack-o'-latern?",
                questionAnswer: "Turnips"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/13",
                questionAsked: "What kind of fish was I just talking about?",
                questionAnswer: "Ojisan"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/14",
                questionAsked: "What part of the body contains the \"Adam's apple\"?",
                questionAnswer: "Throat"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/14",
                questionAsked: "Where would you find Japan on a map made in a foreign country?",
                questionAnswer: "The right edge"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/15",
                questionAsked: "How short was history's shortest war?",
                questionAnswer: "40 minutes"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/15",
                questionAsked: "\"Venison\" is the meat of what animal?",
                questionAnswer: "All of the above"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/17",
                questionAsked: "What is the Japanese name for \"panda\"?",
                questionAnswer: "Black and white bears"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/17",
                questionAsked: "Which bird is falsely known for being cowardly in the English phrase to stick one's head in the sand",
                questionAnswer: "Ostrich"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/18",
                questionAsked: "What was the name of the Wasan textbook that came out in the Edo period?",
                questionAnswer: "Math Girl"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/18",
                questionAsked: "What did Napoleon have invented?",
                questionAnswer: "Glass jars"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/19",
                questionAsked: "Which season is the adjective \"brisk\" a kigo for?",
                questionAnswer: "Fall"
            ),
            new Answer(
                month: Month.October,
                dateAsked: "10/19",
                questionAsked: "What is \"Dragon's Blood\"?",
                questionAnswer: "Plant resin"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/1",
                questionAsked: "Tell me what the \"figure\" in \"figure skating\" refer to!",
                questionAnswer: "Geometric shapes"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/4",
                questionAsked: "Sorry [Player Name], I have no idea",
                questionAnswer: "A cuckoo"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/7",
                questionAsked: "Which country do you think the South Pole belongs to?",
                questionAnswer: "No country"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/11",
                questionAsked: "What desert is the Welwitschia from?",
                questionAnswer: "Namib"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/17",
                questionAsked: "Is that even in a textbook? The roots of \"bridal\"? What..?",
                questionAnswer: "Bride ale"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/22",
                questionAsked: "Do you know what an \"atlast\" is?",
                questionAnswer: "A book of maps"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/24",
                questionAsked: "0, 1, 2, 3, 5, 8, 13... What is this sequence called?",
                questionAnswer: "Fibonacci sequence"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/25",
                questionAsked: "There are over 130 ancient pyramids in Egypt, but do you know who's buried in the biggest one?",
                questionAnswer: "Khufu"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/26",
                questionAsked: "Which of these is considered a \"rice cake\"?",
                questionAnswer: "Mochi"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/28",
                questionAsked: "What does French food stem from?",
                questionAnswer: "Italian food"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/28",
                questionAsked: "What does the \"figure\" in \"figure saking\" refer to?",
                questionAnswer: "Geometric shapes"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/29",
                questionAsked: "Who is buried in the biggest pyramid in Egypt?",
                questionAnswer: "Khufu"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/29",
                questionAsked: "What is a book of maps called?",
                questionAnswer: "Atlas"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/30",
                questionAsked: "What word has the words \"bride ale\" as its roots?",
                questionAnswer: "Bridal"
            ),
            new Answer(
                month: Month.November,
                dateAsked: "11/30",
                questionAsked: "What kind of bird is a \"kanko-dori\"?",
                questionAnswer: "A cuckoo"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/1",
                questionAsked: "Which country does the South Pole belong to?",
                questionAnswer: "No country"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/1",
                questionAsked: "0, 1, 1, 2, 3, 5, 8, 13... What is this sequence called?",
                questionAnswer: "The Fibonacci sequence"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/2",
                questionAsked: "What desert is the Welwitschia found in?",
                questionAnswer: "Namib"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/2",
                questionAsked: "Which of these is considered a \"rice cake\"?",
                questionAnswer: "Mochi"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/9",
                questionAsked: "Do you know what color a fuzzy-wuzzy polar bear's fur really is?",
                questionAnswer: "Transparent"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/10",
                questionAsked: "What determines whether a hair grows curly or straight?",
                questionAnswer: "The cross-section"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/17",
                questionAsked: "Huh? What? I wasn't listening... [Player Name]-kun, help!",
                questionAnswer: "Compassion makes you look better"
            ),
            new Answer(
                month: Month.December,
                dateAsked: "12/21",
                questionAsked: "[Player Name], will you tell me if you know the answer?",
                questionAnswer: "VII"
            ),
            new Answer(
                month: Month.January,
                dateAsked: "1/10",
                questionAsked: "Tell me, what are you supposed to put on top of a kagami mochi?",
                questionAnswer: "An orange"
            ),
            new Answer(
                month: Month.January,
                dateAsked: "1/14",
                questionAsked: "\"Toso\" is a traditional drink for the new year, but what does that name mean?",
                questionAnswer: "Bury the demons"
            ),
            new Answer(
                month: Month.January,
                dateAsked: "1/19",
                questionAsked: "In the Thai and Vietnamese zodiacs, which animal is used in the place of the rabbit?",
                questionAnswer: "Cat"
            ),
            new Answer(
                month: Month.January,
                dateAsked: "1/25",
                questionAsked: "European snow in spring...? Do you know, [Player Name]-kun?",
                questionAnswer: "Red"
            ),
            new Answer(
                month: Month.January,
                dateAsked: "1/30",
                questionAsked: "What's the next unit of measurement up from a terabyte?",
                questionAnswer: "Petabyte"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/1",
                questionAsked: "What color were the pyramids originally?",
                questionAnswer: "White"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/6",
                questionAsked: "The word \"alphabet\" comes from the words \"alpha\" and what other one?",
                questionAnswer: "Beta"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/6",
                questionAsked: "How was the theory that the pyramids were built by slaves disproven?",
                questionAnswer: "Attendance logs"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/7",
                questionAsked: "What drink name means \"bury demons\"?",
                questionAnswer: "Toso"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/7",
                questionAsked: "What is the medical term for brainfreeze?",
                questionAnswer: "Sphenopalatine ganglioneuralgia"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/8",
                questionAsked: "What is the Japanese zodiac equivalent to the \"cat\" in the Thai and Vietnamese zodiacs?",
                questionAnswer: "Rabbit"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/8",
                questionAsked: "What vegetable was used to make the first jack-o'-laterns?",
                questionAnswer: "Turnips"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/9",
                questionAsked: "What color were the pyramids when they were first built?",
                questionAnswer: "White"
            ),
            new Answer(
                month: Month.February,
                dateAsked: "2/9",
                questionAsked: "What gets mixed with snow in Europe that sometimes causes it to turn red?",
                questionAnswer: "The Sahara Desert sand"
            )
        };
    }
}
