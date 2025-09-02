
using System.Transactions;

namespace BankApp.IServices
{
    public interface IStatementService
    {
        IReadOnlyList<Transaction> GetStatement(int accountId, DateTime? start = null, DateTime? end = null);
    }
}