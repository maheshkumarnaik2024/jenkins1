using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" &&
                model.Password == "admin123")
            {
                ViewBag.Message = "Login Successful";
            }
            else
            {
                ViewBag.Message = "Invalid Credentials";
            }

            return View();
        }
    }
}