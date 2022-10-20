using Microsoft.AspNetCore.Mvc;

namespace LearnAspDotNet2.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
