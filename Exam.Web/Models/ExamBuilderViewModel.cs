using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Web.Models
{
    public class ExamBuilderViewModel
    {
        [Required]
        [Display(Name = "Exam Type")]
        public int ExamType { get; set; } = 1; // 1 Final, 2 Practical

        [Range(1, 180)]
        [Display(Name = "Exam Duration (minutes)")]
        public int DurationMinutes { get; set; } = 60;

        [Required]
        [Display(Name = "Number of Questions")]
        [Range(1, 100)]
        public int NumberOfQuestions { get; set; } = 3;

        public int? SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public List<QuestionViewModel> Questions { get; set; } = new();
    }
}