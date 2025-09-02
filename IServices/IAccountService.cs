using bankapp.Entities;

namespace BankApp.IServices
{
    public interface IAccountService
    {
        Account OpenCurrentc(int customerId, decimal openingDeposit, decimal overdraftLimit = 0m, string? currency = null);
        Account OpenSavings(int customerId, decimal openingDeposit, decimal interestRateAnnual, string? currency = null);
        void CloseAccountc(int accountId);
        void Deposit(int accountId, decimal amount, string description = "Cash deposit");
        void Withdraw(int accountId, decimal amount, string description = "Cash withdrawal");
        Account Getc(int accountId);
        Account GetByAccountNumber(int accountNumber);
        IReadOnlyList<Account> GetByCustomer(int customerId);
    }
}