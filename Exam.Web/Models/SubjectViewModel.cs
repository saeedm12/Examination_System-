using System.ComponentModel.DataAnnotations;

namespace Exam.Web.Models
{
    public class SubjectViewModel
    {
        [Required]
        [Display(Name = "Subject ID")]
        public int? SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Subject Name")]
        public string? SubjectName { get; set; }
    }
}