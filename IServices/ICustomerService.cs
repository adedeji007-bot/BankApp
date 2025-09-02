using bankapp.Entities;

namespace BankApp.IServices
{
    public interface ICustomerService
    {
        Customer Register(string fullName, string email, string phone);
        Customer Get(string id);
        IReadOnlyList<Customer> List();
    }
}