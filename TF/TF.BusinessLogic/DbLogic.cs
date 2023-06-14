using TF.Data;

namespace TF.BusinessLogic
{
    public class DbLogic
    {
        protected readonly TfDbContext _dbcontext;
        public DbLogic()
        {
            _dbcontext = new TfDbContext();
        }
    }
}
