using System.Collections.Generic;

namespace Exam.Web.Models
{
    public class ExamTakeViewModel
    {
        public string? SubjectName { get; set; }
        public int DurationMinutes { get; set; }
        public List<QuestionViewModel> Questions { get; set; } = new();
    }
}