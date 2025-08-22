using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Entities
{
    public class User
    {
        public static int LoggedInUserId;
        public int Id { get; set; }
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Role { get; set; } = default!;

        public User(
            int id,
            string firstname,
                string lastname,
                string email,
                string password,
                string role
        )
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}