using TF.Models.Entities;

namespace TF.BusinessLogic
{
    public class UserLogic : DbLogic
    {
        public void Add(UserDbTable user)
        {
            if (user != null)
            {
                user.Id = Guid.NewGuid();
                _dbcontext.Users.Add(user);
                _dbcontext.SaveChanges();
            }
        }

        public List<UserDbTable> GetUsers()
        {
            return _dbcontext.Users.ToList();
        }

        public UserDbTable? GetUserById(Guid? id) // GetEntityById
        {
            return id != null ? _dbcontext.Users
                .FirstOrDefault(m => m.Id == id) : null;
        }

        // GetUserByUsername (return Id, maybe by email not username)

        public void RemoveUserbyId(Guid? id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                _dbcontext.Users.Remove(user);
                _dbcontext.SaveChanges();
            }
        }
    }
}