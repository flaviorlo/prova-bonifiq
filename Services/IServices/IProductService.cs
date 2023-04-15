using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services.IServices
{
    public interface IProductService
    {
       public ItemsList ListProducts(int page);       
    }
}
