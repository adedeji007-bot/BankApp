using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Entities;

namespace bankApp.IRepository
{
    public interface IUserRepository
    {
        User AddUser(User user);
        User UpdateUser(User user);
        User? GetUser(int id);
        List<User> GetAllUsers();
        void DeleteUser(int id);
        int Counter();
    }
}