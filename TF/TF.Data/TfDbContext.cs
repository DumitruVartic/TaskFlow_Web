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
    }
}
