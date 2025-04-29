using System.Data;

namespace Task_10_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserServise();

            var userservice = new UserServise();

            userservice.Update(user);
        }


    }


    public class User { }
    

    public class Account : User { }
    

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class UserServise : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
