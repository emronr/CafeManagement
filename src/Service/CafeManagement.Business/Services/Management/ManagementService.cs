using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;
using CafeManagement.Domain.Entities.Order;
using CafeManagement.Domain.Repositories.Cafe;
using CafeManagement.Domain.Repositories.Order;
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Business.Services.Management
{
    public class ManagementService : IManagementService
    {
        private readonly ITableRepository _tableRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        
        public ManagementService(
            ITableRepository tableRepository,
            IOrderRepository orderRepository, IMapper mapper)
        {
            _tableRepository = tableRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        
        public async Task CloseOrder(int tableId)
        {
            var activeOrder =  await GetActiveOrderFromDb(tableId);
            if (activeOrder == null)
                return;

            activeOrder.PaymentDate = DateTime.Now;
            activeOrder.Table.IsFull = false;

            _orderRepository.Update(activeOrder);
        }

        public async Task<OrderDto> GetActiveOrder(int tableId)
        {
            var activeOrder = await GetActiveOrderFromDb(tableId);
                
            return _mapper.Map<OrderDto>(activeOrder);
        }

        public async Task<List<TableDto>> GetTables()
        {
            var tables = await _tableRepository.GetAllAsync();
            return _mapper.Map<List<TableDto>>(tables);
        }

        public async Task<int> CreateOrder(CreateOrderInput createOrderInput)
        {
            var activeOrder = await GetActiveOrderFromDb(createOrderInput.TableId);

            if (activeOrder != null)
            {
                var existProduct = activeOrder.OrderDetails.FirstOrDefault(x => x.ProductId == createOrderInput.ProductId);
                if (existProduct != null)
                {
                    existProduct.Quantity += createOrderInput.Quantity;
                }
                else
                {
                    activeOrder.OrderDetails.Add(new OrderDetail()
                    {
                        ProductId = createOrderInput.ProductId,
                        Quantity = createOrderInput.Quantity
                    });
                }
                activeOrder.LastOrderDate = DateTime.Now;
                _orderRepository.Update(activeOrder);
                return activeOrder.Id;
            }

            var newOrder = new Order()
            {
                TableId = createOrderInput.TableId,
                CreateDate = DateTime.Now,
                LastOrderDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
                {
                    new ()
                    {
                        ProductId = createOrderInput.ProductId,
                        Quantity = createOrderInput.Quantity
                    }
                },

            };
            await _orderRepository.CreateAsync(newOrder);


            var table = await _tableRepository.FindAsync(createOrderInput.TableId);
            table.IsFull = true;
            _tableRepository.Update(table);
            return newOrder.Id;
        }

        private async Task<Order?> GetActiveOrderFromDb(int tableId)
        {
            return
                await _orderRepository.Query().FirstOrDefaultAsync(x => x.TableId == tableId && x.PaymentDate == null);
        }
    }
}