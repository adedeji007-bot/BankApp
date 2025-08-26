
using BankApp.Data;
using BankApp.Entities;
using BankApp.IServices;

namespace BankApp.Manager
{
    public class UserManager : IUserService
    {
            public User Register(string firstname, string lastname, string email,string password )
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

        public User? UpdateProfile(int userId, string newFirstname, string newLastname, string newEmail)
        {
            foreach (var user in UserDb.UserDatabase)
            {
                if (user.Id == userId)
                {
                    user.Firstname = newFirstname;
                    user.Lastname = newLastname;
                    user.Email = newEmail;
                    return user;
                }
            }
            return null;
        }
        public User? GetUserById(int userId)
        {
            return UserDb.UserDatabase.FirstOrDefault(u => u.Id == userId);
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