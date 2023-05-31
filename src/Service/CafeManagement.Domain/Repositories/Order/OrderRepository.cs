using System.Linq;
using System.Threading.Tasks;
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
    }
}