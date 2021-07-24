using Persona4GoldenHelper.Shared;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The exam answers data.</summary>
    public static class ExamAnswerData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The exam answers data.</summary>
        public static List<ExamAnswer> ExamAnswers { get; } = new()
        {
            new(Month.April, "4/14", "What is the year before 1 AD called?", "1 B.C."),
            new(Month.April, "4/18", "The word \"alphabet\" comes from the the word \"alpha\" and what other one?", "Beta"),
            new(Month.April, "4/20", "[Player Name]! C'mon, man, help me here!", "Three"),
            new(Month.April, "4/23", "What's this ergonomic bubble she's asking about!?", "Tulip mania"),
            new(Month.April, "4/25", "... what's it called when you gain more muscle after getting sore through excercise?", "Overcompensation"),
            new(Month.April, "4/26", "I don't think I've heard of any of these!", "Marriage numbers"),
            new(Month.April, "4/30", "What is the greatest canyon in the solar system?", "Valles Marineris"),
            new(Month.May, "5/7", "Do you know how Soseki Natsume translated the English phrase \"I love you\" into Japanese?", "The moon is beautiful, isn't it?"),
            new(Month.May, "5/9", "What is it called when muscles grow after excercise?", "Overcompensation"),
            new(Month.May, "5/9", "What is the year before 1 A.D. called?", "1 B.C."),
            new(Month.May, "5/10", "Which of these types of numbers does not exist?", "Marriage numbers"),
            new(Month.May, "5/10", "Who translated \"I love you\" as \"The moon is beautiful, isn't it\"?", "Soseki Natsume"),
            new(Month.May, "5/11", "Who said \"As soon as laws are necessary for men, they are no longer fit for freedom\"?", "Pythagoras"),
            new(Month.May, "5/11", "Which of the following is the highest mountain in the solar system?", "Olympus Mons"),
            new(Month.May, "5/26", "Something about laborers?", "Attendance logs"),
            new(Month.June, "6/8", "What sport is \"heikin-dai\"?", "Balance Beam"),
            new(Month.June, "6/13", "What kind of excercise is a sprint classified as?", "Anaerobics"),
            new(Month.June, "6/15", "Sorry, [Player Name], tell me what morale is!?", "Cheerfulness of a group"),
            new(Month.June, "6/20", "What period did Japan first implement bonus pay?", "Meiji"),
            new(Month.June, "6/27", "Answer this: What is identity?", "Individuality"),
            new(Month.June, "6/30", "Which one of these is the name of a real river?", "Pis Pis River"),
            new(Month.July, "7/4", "You gotta help me out?", "Pascal"),
            new(Month.July, "7/7", "What is the beginning of \"Gakumon no Susume\" a reference to?", "The U.S. Declaration of Independence"),
            new(Month.July, "7/13", "What is the medical term for brainfreeze!?", "Sphenopalatine ganglioneuralgia"),
            new(Month.July, "7/14", "Which famous Heian-ero monk famously used a wrong version of the \"応\" kanji?", "Kuukai"),
            new(Month.July, "7/15", "Which line can a typhoon never cross?", "The equator"),
            new(Month.July, "7/16", "... what makes the king of hearts look different from the other kings in a standard deck of cards?", "He has no mustache"),
            new(Month.July, "7/19", "What is morale?", "Cheerfulness in a group"),
            new(Month.July, "7/19", "What sport is \"heikin-dai\"?", "Balance Beam"),
            new(Month.July, "7/20", "It is said, \"Even Kobo made mistakes in writing.\" Which kanji did he make a mistake on?", "応 (The first one)"),
            new(Month.July, "7/20", "In which period did Japan first implement bonus pay?", "Meiji"),
            new(Month.July, "7/21", "Which king in a deck of cards is missing a mustache?", "King of Hearts"),
            new(Month.July, "7/21", "Who said this: \"Man is but a reed, the most feeble thing in nature; but he is a thinking reed\"?", "Pascal"),
            new(Month.July, "7/22", "Which one of these is the name of real river?", "Pis Pis River"),
            new(Month.July, "7/22", "What is the beginning of \"Gakumon no Susume\" a reference to?/", "The U.S. Declaration of Independence"),
            new(Month.August, "8/28", "NOTE: Study with Justice to be asked.\nIs it the male or female platypus that has the poison claws?", "Male"),
            new(Month.August, "8/29", "NOTE: Study with Justice to be asked.\nDid it rain the day that we worked on my art homework?", "It stopped raining by then"),
            new(Month.September, "9/1", "\"Venison\" is the meat of what animal?", "All of the above"),
            new(Month.September, "9/5", "Which of the following is a kigo for fall?", "Brisk"),
            new(Month.September, "9/17", "How short was history's shortest war?", "40 minutes"),
            new(Month.September, "9/20", "What do you call somebody who's between ninety and one hundred years old?", "A nonagenarian"),
            new(Month.September, "9/28", "Do you know the answer?", "Throat"),
            new(Month.October, "10/4", "Which of these sports also uses an anchor?", "Tug-of-War"),
            new(Month.October, "10/5", "Do you know the answer, [Player Name]?", "The right edge"),
            new(Month.October, "10/8", "Tell me what bird's name means \"coward\" in English!", "Chicken"),
            new(Month.October, "10/11", "What did Napoleon have invented?", "Glass jars"),
            new(Month.October, "10/12", "Do you know what vegetables was used to make the first jack-o'-latern?", "Turnips"),
            new(Month.October, "10/13", "What kind of fish was I just talking about?", "Ojisan"),
            new(Month.October, "10/14", "What part of the body contains the \"Adam's apple\"?", "Throat"),
            new(Month.October, "10/14", "Where would you find Japan on a map made in a foreign country?", "The right edge"),
            new(Month.October, "10/15", "How short was history's shortest war?", "40 minutes"),
            new(Month.October, "10/15", "\"Venison\" is the meat of what animal?", "All of the above"),
            new(Month.October, "10/17", "What is the Japanese name for \"panda\"?", "Black and white bears"),
            new(Month.October, "10/17", "Which bird is falsely known for being cowardly in the English phrase to stick one's head in the sand", "Ostrich"),
            new(Month.October, "10/18", "What was the name of the Wasan textbook that came out in the Edo period?", "Math Girl"),
            new(Month.October, "10/18", "What did Napoleon have invented?", "Glass jars"),
            new(Month.October, "10/19", "Which season is the adjective \"brisk\" a kigo for?", "Fall"),
            new(Month.October, "10/19", "What is \"Dragon's Blood\"?", "Plant resin"),
            new(Month.November, "11/1", "Tell me what the \"figure\" in \"figure skating\" refer to!", "Geometric shapes"),
            new(Month.November, "11/4", "Sorry [Player Name], I have no idea", "A cuckoo"),
            new(Month.November, "11/7", "Which country do you think the South Pole belongs to?", "No country"),
            new(Month.November, "11/11", "What desert is the Welwitschia from?", "Namib"),
            new(Month.November, "11/17", "Is that even in a textbook? The roots of \"bridal\"? What..?", "Bride ale"),
            new(Month.November, "11/22", "Do you know what an \"atlast\" is?", "A book of maps"),
            new(Month.November, "11/24", "0, 1, 2, 3, 5, 8, 13... What is this sequence called?", "Fibonacci sequence"),
            new(Month.November, "11/25", "There are over 130 ancient pyramids in Egypt, but do you know who's buried in the biggest one?", "Khufu"),
            new(Month.November, "11/26", "Which of these is considered a \"rice cake\"?", "Mochi"),
            new(Month.November, "11/28", "What does French food stem from?", "Italian food"),
            new(Month.November, "11/28", "What does the \"figure\" in \"figure saking\" refer to?", "Geometric shapes"),
            new(Month.November, "11/29", "Who is buried in the biggest pyramid in Egypt?", "Khufu"),
            new(Month.November, "11/29", "What is a book of maps called?", "Atlas"),
            new(Month.November, "11/30", "What word has the words \"bride ale\" as its roots?", "Bridal"),
            new(Month.November, "11/30", "What kind of bird is a \"kanko-dori\"?", "A cuckoo"),
            new(Month.December, "12/1", "Which country does the South Pole belong to?", "No country"),
            new(Month.December, "12/1", "0, 1, 1, 2, 3, 5, 8, 13... What is this sequence called?", "The Fibonacci sequence"),
            new(Month.December, "12/2", "What desert is the Welwitschia found in?", "Namib"),
            new(Month.December, "12/2", "Which of these is considered a \"rice cake\"?", "Mochi"),
            new(Month.December, "12/9", "Do you know what color a fuzzy-wuzzy polar bear's fur really is?", "Transparent"),
            new(Month.December, "12/10", "What determines whether a hair grows curly or straight?", "The cross-section"),
            new(Month.December, "12/17", "Huh? What? I wasn't listening... [Player Name]-kun, help!", "Compassion makes you look better"),
            new(Month.December, "12/21", "[Player Name], will you tell me if you know the answer?", "VII"),
            new(Month.January, "1/10", "Tell me, what are you supposed to put on top of a kagami mochi?", "An orange"),
            new(Month.January, "1/14", "\"Toso\" is a traditional drink for the new year, but what does that name mean?", "Bury the demons"),
            new(Month.January, "1/19", "In the Thai and Vietnamese zodiacs, which animal is used in the place of the rabbit?", "Cat"),
            new(Month.January, "1/25", "European snow in spring...? Do you know, [Player Name]-kun?", "Red"),
            new(Month.January, "1/30", "What's the next unit of measurement up from a terabyte?", "Petabyte"),
            new(Month.February, "2/1", "What color were the pyramids originally?", "White"),
            new(Month.February, "2/6", "The word \"alphabet\" comes from the words \"alpha\" and what other one?", "Beta"),
            new(Month.February, "2/6", "How was the theory that the pyramids were built by slaves disproven?", "Attendance logs"),
            new(Month.February, "2/7", "What drink name means \"bury demons\"?", "Toso"),
            new(Month.February, "2/7", "What is the medical term for brainfreeze?", "Sphenopalatine ganglioneuralgia"),
            new(Month.February, "2/8", "What is the Japanese zodiac equivalent to the \"cat\" in the Thai and Vietnamese zodiacs?", "Rabbit"),
            new(Month.February, "2/8", "What vegetable was used to make the first jack-o'-laterns?", "Turnips"),
            new(Month.February, "2/9", "What color were the pyramids when they were first built?", "White"),
            new(Month.February, "2/9", "What gets mixed with snow in Europe that sometimes causes it to turn red?", "The Sahara Desert sand")
        };
    }
}