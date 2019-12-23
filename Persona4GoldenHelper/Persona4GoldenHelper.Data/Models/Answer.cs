using static Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Data.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public Month Month { get; set; }
        public string DateAsked { get; set; }
        public string QuestionAsked { get; set; }
        public string QuestionAnswer { get; set; }
    }
}
