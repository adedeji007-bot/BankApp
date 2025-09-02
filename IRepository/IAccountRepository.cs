using bankapp.Entities;

namespace bankApp.IRepository
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        Task<Account?> GetByAccountNumberAsync(string accountNumber);
        Task<IReadOnlyList<Account>> GetByCustomerIdAsync(string customerId);
    }
}