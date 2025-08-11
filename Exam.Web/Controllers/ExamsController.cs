using Exam.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Web.Controllers
{
    public class ExamsController : Controller
    {
        [HttpGet]
        public IActionResult Build(int? subjectId, string? subjectName)
        {
            var model = new ExamBuilderViewModel
            {
                SubjectId = subjectId,
                SubjectName = subjectName,
                Questions = new List<QuestionViewModel> { new QuestionViewModel() }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Build(ExamBuilderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.Questions.Count == 0)
                {
                    model.Questions.Add(new QuestionViewModel());
                }
                return View(model);
            }

            var take = new ExamTakeViewModel
            {
                SubjectName = model.SubjectName,
                DurationMinutes = model.DurationMinutes,
                Questions = model.Questions
            };
            return View("Take", take);
        }

        [HttpGet]
        public IActionResult Take()
        {
            var demo = new ExamTakeViewModel
            {
                SubjectName = "Sample Subject",
                DurationMinutes = 30,
                Questions = new List<QuestionViewModel>
                {
                    new QuestionViewModel{ Header = "2 + 2 = ?", Type = QuestionType.MultipleChoice, Answers = new(){ new AnswerViewModel{ Text = "3" }, new AnswerViewModel{ Text = "4", IsCorrect = true }, new AnswerViewModel{ Text = "5" } } },
                    new QuestionViewModel{ Header = "The sky is blue.", Type = QuestionType.TrueOrFalse, Answers = new(){ new AnswerViewModel{ Text = "True" }, new AnswerViewModel{ Text = "False" } } }
                }
            };
            return View(demo);
        }

        [HttpPost]
        public IActionResult Submit(ExamTakeViewModel model)
        {
            return View("Review", model);
        }
    }
}