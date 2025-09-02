using bankapp.Enums;
using BankApp.Entities;

namespace bankapp.Entities
{
    public class Transaction : BaseEntity
    {
        public Transaction(int id) : base(id)
        {

        }
        public int AccountId { get; set; } = default;
        public int? OtherPartyAccountId { get; set; }
        public string? ExternalBankName { get; set; } // to other bank
        public TransactionType Type { get; set; }
        public TransactionStatus Status { get; set; } = TransactionStatus.Completed;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "NGN";
        public string Description { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}