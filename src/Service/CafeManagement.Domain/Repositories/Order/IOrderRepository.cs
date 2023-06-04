using CafeManagement.Domain.Repositories.Base;

namespace CafeManagement.Domain.Repositories.Order
{
    public interface IOrderRepository : IBaseRepository<Entities.Order.Order, int>
    {
    }
}