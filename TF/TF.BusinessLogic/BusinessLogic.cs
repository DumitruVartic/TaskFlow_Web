namespace TF.BusinessLogic
{
    public class BusinessLogic
    {
        public readonly TaskLogic task;
        public readonly UserLogic user;

        public BusinessLogic()
        {
            task = new TaskLogic();
            user = new UserLogic();
        }
    }
}