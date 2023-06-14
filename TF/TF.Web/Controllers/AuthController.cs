using Microsoft.AspNetCore.Mvc;
using TF.Models.Entities;

namespace TF.Web.Controllers
{
    public class AuthController : TFController
    {
        [Route("User")]
        public IActionResult User()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserDbTable user)
        {
            if (ModelState.IsValid)
            {
                _businessLogic.user.Add(user);
                return RedirectToAction(nameof(User));
            }
            return View(user);
        }

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
