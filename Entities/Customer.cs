using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Entities;

namespace bankapp.Entities
{
    public partial class Customer : User
    {
        public Customer(int id,
            string firstname,
                string lastname,
                string email,
                string password,
                string role) : base(id, firstname, lastname, email, password, role)
        {

        }
    }
}