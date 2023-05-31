using CafeManagement.Domain.Context;
using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Menu
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(CafeManagementContext context) : base(context)
        {
        }
    }
}