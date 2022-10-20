using LearnAspDotNet2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnAspDotNet2.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Login page";
            return View();
        }

        public ActionResult VerifyAccount(string username,string password)
        {
            UserModel user = new UserModel();

            if(username == user.userName && password == user.password)
            {
                return RedirectToAction("Index","Space");
            }
            else
            {
                return RedirectToAction("Index", "Error");
            }


        }
    }
}
