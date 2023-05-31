using CafeManagement.Domain.Context;
using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Menu
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(CafeManagementContext context) : base(context)
        {
        }
    }
}