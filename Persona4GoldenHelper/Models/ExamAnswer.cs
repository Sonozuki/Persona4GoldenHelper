namespace Persona4GoldenHelper.Models
{
    /// <summary>Represents an exam answer.</summary>
    public class ExamAnswer
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The month the question is asked in.</summary>
        public Month Month { get; }

        /// <summary>The date the question is asked.</summary>
        public string DateAsked { get; }

        /// <summary>The question asked.</summary>
        public string QuestionAsked { get; }

        /// <summary>The correct answer.</summary>
        public string QuestionAnswer { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="month">The month the question is asked in.</param>
        /// <param name="dateAsked">The date the question is asked.</param>
        /// <param name="questionAsked">The question asked.</param>
        /// <param name="questionAnswer">The correct answer.</param>
        public ExamAnswer(Month month, string dateAsked, string questionAsked, string questionAnswer)
        {
            Month = month;
            DateAsked = dateAsked;
            QuestionAsked = questionAsked;
            QuestionAnswer = questionAnswer;
        }
    }
}
