using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Entities
{
    public class BaseEntity
    {
        public BaseEntity(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}