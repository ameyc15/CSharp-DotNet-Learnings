using Day28_DependencyInjection.Repository;

namespace Day28_DependencyInjection.Managers
{
    public class UserManager
    {
        public UserManager() { }

        public void CreateUser()
        {
            // will invoke repository method
            UserReposiotry userReposiotry = new UserReposiotry();
            userReposiotry.AddUser();
        }

        public void RemoveUser()
        {
            // will invoke repository method
            UserReposiotry userReposiotry = new UserReposiotry();
            userReposiotry.DeleteUser();
        }
    }
}
