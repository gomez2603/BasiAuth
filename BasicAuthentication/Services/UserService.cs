using BasicAuthentication.Models;

namespace BasicAuthentication.Security
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
            
            new User() { Email = "usuario1@gmail.com", Password = "1234" },
            new User() { Email = "usuario2@gmail.com", Password = "1234" },
            new User() { Email = "kzzko.jg@gmai.com", Password = "1234"}
        };
        
        public bool IsUser(string email, string pass)
        {
           

          return  users.Where(u => u.Email == email && u.Password == pass).Count() > 0;
        }


    }
}
