using bankapp.Entities;

namespace bankApp.IRepository
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Task<Customer?> GetByEmailAsync(string email);
    }
}