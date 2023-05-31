using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;

namespace CafeManagement.Business.Services.Management
{
    public interface IManagementService
    {
        /// <summary>
        /// Kafe içindeki masaları getirir.
        /// </summary>
        /// <returns></returns>
        Task<List<TableDto>> GetTables();
        
        /// <summary>
        /// Sipariş ekler
        /// </summary>
        /// <param name="createOrderInput"></param>
        /// <returns></returns>
        Task<int> CreateOrder(CreateOrderInput createOrderInput);

        /// <summary>
        /// Masaya ait aktif siparişi kapatır.
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        Task CloseOrder(int tableId);

        /// <summary>
        /// Masadaki aktif siparişi getirir.
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        Task<OrderDto> GetActiveOrder(int tableId);
    }
}