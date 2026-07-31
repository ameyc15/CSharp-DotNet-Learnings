namespace Day28_DependencyInjection.Repository
{
    public class UserReposiotry
    {
        public UserReposiotry() { }

        public void AddUser()
        {
            Console.WriteLine("User Added to Repository");
        }
        public void DeleteUser()
        {
            Console.WriteLine("User Removed from Database");
        }
    }
}
