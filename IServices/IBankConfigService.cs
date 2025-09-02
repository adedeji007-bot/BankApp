using bankapp.Entities;

namespace BankApp.IServices
{
    public interface IBankConfigService
    {
        BankConfig Get();
        void Update(BankConfig cfg);
    }
}