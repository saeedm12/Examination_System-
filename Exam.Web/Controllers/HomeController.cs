using Microsoft.AspNetCore.Mvc;

namespace Exam.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}