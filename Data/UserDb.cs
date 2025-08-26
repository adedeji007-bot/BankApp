
using bankApp.IRepository;
using BankApp.Entities;

namespace BankApp.Data
{
    public static class UserDb : IUserRepository
    {
        private List<User> _user;  //asumme all the users in our databse    
        public UserDb()
        {
            _user = new List<User>();
        }
        public User AddUser(User user)
        {
            _user.Add(user);
            return user;
        }
        public User UpdateUser(User user)
        {
            _user.Add(user);
            return user;
        }
        public User? GetUser(int id)
        {
            var user = new User();
            foreach (var u in _user)
            {
                if (u.id == id)
                {
                    user = u;
                }
            }
            return user;
        }
        public List<User> GetAllUsers()
        {
            return _user;
        }
        public void DeleteUser(int id)
        {
            foreach (var u in _user)
            {
                if (u.id == id)
                {
                    _user.Remove(u);
                }
            }
        }
        public int Counter()
        {
            return _user.Count;
        }
    }
}