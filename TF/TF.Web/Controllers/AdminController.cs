using Microsoft.AspNetCore.Mvc;

namespace TF.Web.Controllers
{
    public class AdminController : TFController
    {
        [Route("Users")]
        public IActionResult Users()
        {
            var users = _businessLogic.user.GetUsers();

            return View(users);
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _businessLogic.user.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = _businessLogic.user.GetUserById(id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid? id)
        {
            _businessLogic.user.RemoveUserbyId(id);
            return RedirectToAction(nameof(Users));
        }
    }
}
