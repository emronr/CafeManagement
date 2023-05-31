using System.Threading.Tasks;
using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Order
{
    public interface IOrderRepository : IBaseRepository<Entities.Order.Order, int>
    {
        Task<Entities.Order.Order> GetActiveOrder(int tableId);

    }
}