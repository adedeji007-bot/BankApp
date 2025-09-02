using bankapp.Entities;

namespace bankApp.IRepository
{
    public interface ITransactionRepository : IBaseRepository<Transaction>
    {
        Task<IReadOnlyList<Transaction>> GetByAccountIdAsync(string accountId, DateTime? start = null, DateTime? end = null);
    }
}