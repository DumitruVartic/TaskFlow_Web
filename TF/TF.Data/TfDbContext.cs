using System.Data.Entity;

namespace TF.Data
{
    public class TfDbContext : DbContext
    {
        public TfDbContext()
            : base("TfDbContext")
        {
        }

        public DbSet<Models.Entities.TaskDbTable> Tasks { get; set; }
        public DbSet<Models.Entities.UserDbTable> Users { get; set; }
        public DbSet<Models.Entities.UserTaskDbTable> UserTasks { get; set; }
        public DbSet<Models.Entities.UserNoteDbTable> UserNotes { get; set; }
    }
}
