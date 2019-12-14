using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreevaHatGame
{
    public struct User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class Users
    {

        public List<User> listOfUsers = new List<User> { new User() { Login = "admin", Password = "admin"} };
        public void setUser(string login, string password)
        {
            User user = new User();

            user.Login = login;
            user.Password = password;

            listOfUsers.Add(user);
        }

        public List<User> getListOfUsers()
        {
            return listOfUsers;
        }
        


    }

   
}
