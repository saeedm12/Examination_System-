using System.ComponentModel.DataAnnotations;

namespace Exam.Web.Models
{
    public class AnswerViewModel
    {
        [Required]
        public string? Text { get; set; }

        public bool IsCorrect { get; set; }
    }
}