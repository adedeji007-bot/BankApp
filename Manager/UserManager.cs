
using BankApp.Entities;
using Batch29ConsoleApp.Data;

namespace BankApp.Manager
{
    public class UserManager
    {
        public User Register(
        string firstname,
        string lastname,
        string email,
        string password
        )
        {
            bool userExists = Exist(email);
            if (userExists)
            {
                System.Console.WriteLine("user already exist");
                return null;
            }
           
            User user = new User(
                UserDb.UserDatabase.Count + 1,
                firstname,
                lastname,
                email,
                password,
                "Customer");
            UserDb.UserDatabase.Add(user);
            return user;
        }

        public User? Login(string email, string password)
        {
            foreach (var user in UserDb.UserDatabase)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        private bool Exist(string email)
        {
            foreach (var user in UserDb.UserDatabase)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}