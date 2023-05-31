using CafeManagement.Domain.Context;
using CafeManagement.Domain.Entities.Cafe;
using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Cafe
{
    public class TableRepository : BaseRepository<Table, int>, ITableRepository
    {
        public TableRepository(CafeManagementContext context) : base(context)
        {
        }
    }
}