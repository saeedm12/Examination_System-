using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Web.Models
{
    public class QuestionViewModel
    {
        [Required]
        [Display(Name = "Question Header")]
        public string? Header { get; set; }

        [Display(Name = "Question Body")]
        public string? Body { get; set; }

        [Range(1, 100)]
        public int Mark { get; set; } = 1;

        [Required]
        [Display(Name = "Question Type")]
        public QuestionType Type { get; set; } = QuestionType.MultipleChoice;

        public int? SelectedAnswerIndex { get; set; }

        public List<AnswerViewModel> Answers { get; set; } = new List<AnswerViewModel>
        {
            new AnswerViewModel{ Text = "Choice 1" },
            new AnswerViewModel{ Text = "Choice 2" }
        };
    }
}