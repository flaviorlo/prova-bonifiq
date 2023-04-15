using ProvaPub.Models;

namespace ProvaPub.Services.IServices
{
    public interface ICustomerService
    {
        public ItemsList ListCustomers(int page);
        Task<bool> CanPurchase(int customerId, decimal purchaseValue);
    }
}
