using Microsoft.AspNetCore.Mvc;
using TF.Models.Entities;
using TF.Web.Models;

namespace TF.Web.Controllers
{
    public class TaskController : Controller
    {
        protected readonly BusinessLogic.BusinessLogic _businessLogic;

        public TaskController()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
        }

        [Route("Tasks")]
        public IActionResult Index()
        {
            var tasks = _businessLogic.GetTasks();
            List<TaskViewModel> tasksViewModel = new List<TaskViewModel>();

            foreach (var task in tasks)
            {
                var taskViewModel = new TaskViewModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Deadline = task.Deadline,
                    Content = task.Content.Length > 10 ? task.Content.Substring(0, 10) : task.Content
                };

                tasksViewModel.Add(taskViewModel);
            }

            return View(tasksViewModel); 
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = _businessLogic.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Deadline,Content")] TaskDbTable task)
        {
            if (ModelState.IsValid)
            {
                _businessLogic.Add(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Movies/Edit/id
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = _businessLogic.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Movies/Edit/id
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid? id, [Bind("Id,Title,Deadline,Content")] TaskDbTable task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _businessLogic.AddOrUpdate(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = _businessLogic.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid? id)
        {
            _businessLogic.RemoveTaskbyId(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
