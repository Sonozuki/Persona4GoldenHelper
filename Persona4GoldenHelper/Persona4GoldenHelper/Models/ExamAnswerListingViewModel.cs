using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Models
{
    /// <summary>The listing view model for the exam answers listing view.</summary>
    public class ExamAnswerListingViewModel
    {
        /// <summary>The collection of answers to render.</summary>
        public List<Answer> Answers { get; set; }
    }
}
