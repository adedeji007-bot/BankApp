
using bankApp.IRepository;
using BankApp.Data;
using BankApp.Entities;
using BankApp.IServices;

namespace BankApp.Manager
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager()
        {
            _userRepository = new UserDb();
        }
        public User Register(string firstname, string lastname, string email, string password)
        {
            bool userExists = Exist(email);
            if (userExists)
            {
                System.Console.WriteLine("user already exist");
                return null;
            }
            int id = _userRepository.Counter() + 1;
            User user = new User(
                id,
                firstname,
                lastname,
                email,
                password,
                "Customer");
            _userRepository.AddUser(user);
            return user;
        }

        public User? Login(string email, string password)
        {
            var users = _userRepository.GetAllUsers();
            foreach (var user in users)
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
            var users = _userRepository.GetAllUsers();
            foreach (var user in users)
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
            return _userRepository.GetUser(userId);
        }
        private bool Exist(string email)
        {
            var users = _userRepository.GetAllUsers();
            foreach (var user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public User ViewTransactions(int Id, int account)
        {
            var transactions = GetTransactions(Id, account);

            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Transaction ID: {transaction.Id}");
                Console.WriteLine($"Date: {transaction.Date}");
                Console.WriteLine($"Amount: {transaction.Amount}");
                Console.WriteLine($"Description: {transaction.Description}");
                Console.WriteLine("------------------------");
            }
        }
        
    public List<User> GetAllUsers()
        {
            return UserDb.UserDatabase;
        }
    }
    }