using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    /// <summary>Metadata about an exam answer.</summary>
    public class Answer
    {
        /// <summary>The id.</summary>
        public int Id { get; set; }

        /// <summary>The month the question is asked.</summary>
        public Month Month { get; set; }

        /// <summary>The date the question is asked.</summary>
        public string DateAsked { get; set; }

        /// <summary>The question asked.</summary>
        public string QuestionAsked { get; set; }

        /// <summary>The correct answer.</summary>
        public string QuestionAnswer { get; set; }
    }
}
