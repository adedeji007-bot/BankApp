namespace BankApp.IServices
{
    public interface ITransferService
    {
        void Transfer(int fromAccountId, int toAccountId, decimal amount, string description = "Transfer");
    }
}