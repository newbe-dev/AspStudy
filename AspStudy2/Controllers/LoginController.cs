using AspStudy2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspStudy2.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return RedirectToAction("Home", "Index");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            return RedirectToAction("Home", "Index");
        }
    }
}
