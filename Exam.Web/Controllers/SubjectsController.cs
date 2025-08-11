using Exam.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Web.Controllers
{
    public class SubjectsController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View(new SubjectViewModel());
        }

        [HttpPost]
        public IActionResult Create(SubjectViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Build", "Exams", new { subjectId = model.SubjectId, subjectName = model.SubjectName });
        }
    }
}