using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.IServices
{
    public interface IUserService
    {
        bool Exist(string email);
        User? GetUserById(int userId);
        User? UpdateProfile(int userId, string newFirstname,
         string newLastname, string newEmail);
        User? Login(string email, string password);
        User Register(string firstname, string lastname, string email,
           string password);
    }
}