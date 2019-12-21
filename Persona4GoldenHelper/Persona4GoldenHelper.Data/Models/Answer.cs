using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Answer
    {
        public Month Month { get; private set; }
        public string DateAsked { get; private set; }
        public string QuestionAsked { get; private set; }
        public string QuestionAnswer { get; private set; }

        public Answer(Month month, string dateAsked, string questionAsked, string questionAnswer)
        {
            Month = month;
            DateAsked = dateAsked;
            QuestionAsked = questionAsked;
            QuestionAnswer = questionAnswer;
        }
    }
}
