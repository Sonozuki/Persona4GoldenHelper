namespace Persona4GoldenHelper.Data.Models
{
    public class Answer
    {
        public string DateAsked { get; private set; }
        public string QuestionAsked { get; private set; }
        public string QuestionAnswer { get; private set; }

        public Answer(string dateAsked, string questionAsked, string questionAnswer)
        {
            DateAsked = dateAsked;
            QuestionAsked = questionAsked;
            QuestionAnswer = questionAnswer;
        }
    }
}
