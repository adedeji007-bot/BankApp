using bankapp.Enums;
using BankApp.Entities;

namespace bankapp.Entities
{

    public abstract class Account : BaseEntity
    {
        public Account(int id) : base(id)
        {

        }
        public int CustomerId { get; set; } = 0;
        public string AccountNumber { get; set; } = string.Empty;
        public AccountType Type { get; set; }
        public AccountStatus Status { get; set; } = AccountStatus.Active;
        public string Currency { get; set; } = "NGN";
        public decimal Balance { get; set; }
        public DateTime OpenedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ClosedAt { get; set; }
    }

}