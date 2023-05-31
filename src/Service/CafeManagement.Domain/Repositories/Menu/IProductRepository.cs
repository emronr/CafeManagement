using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Menu
{
    public interface IProductRepository : IBaseRepository<Product, int>
    {
    }
}