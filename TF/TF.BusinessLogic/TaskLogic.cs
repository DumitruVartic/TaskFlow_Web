using System.Data.Entity.Migrations;
using TF.Models.Entities;

namespace TF.BusinessLogic
{
    public class TaskLogic : DbLogic
    {
        public void AddOrUpdate(TaskDbTable task)
        {
            if (task != null)
            {
                _dbcontext.Tasks.AddOrUpdate(task);
                _dbcontext.SaveChanges();
            }
        }

        public void Add(TaskDbTable task)
        {
            if (task != null)
            {
                task.Id = Guid.NewGuid();
                _dbcontext.Tasks.Add(task);
                _dbcontext.SaveChanges();
            }
        }

        public TaskDbTable? GetTaskById(Guid? id) // GetEntityById
        {
            return id != null ? _dbcontext.Tasks
                .FirstOrDefault(m => m.Id == id) : null;
        }

        public List<TaskDbTable> GetTasks()
        {
            var tasksDb = _dbcontext.Tasks.ToList();

            return _dbcontext.Tasks.ToList();
        }

        public void RemoveTaskbyId(Guid? id)
        {
            var task = GetTaskById(id);
            if (task != null)
            {
                _dbcontext.Tasks.Remove(task);
                _dbcontext.SaveChanges();
            }
        }
    }
}