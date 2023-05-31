using System.Linq;
using CafeManagement.Domain.Context;
using CafeManagement.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Domain.Repositories.Order
{
    public class OrderRepository : BaseRepository<Entities.Order.Order, int>, IOrderRepository 
    {
        public OrderRepository(CafeManagementContext context) : base(context)
        {
        }
        public Entities.Order.Order GetActiveOrder(int tableId)
        {
            var activeOrder = _context.Set<Entities.Order.Order>()
                .Include(x => x.OrderDetails.Select(y => y.Product))
                .Include(x => x.Table)
                .FirstOrDefault(x => x.TableId == tableId && x.PaymentDate == null);

            return activeOrder;
        }
    }
}