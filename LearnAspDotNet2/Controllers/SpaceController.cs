using Microsoft.AspNetCore.Mvc;

namespace LearnAspDotNet2.Controllers
{
    public class SpaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
