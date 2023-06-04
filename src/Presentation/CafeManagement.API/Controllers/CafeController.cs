using System.Net;
using CafeManagement.Business.DTOs;
using CafeManagement.Business.Services.Management;
using CafeManagement.Common.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.API.Controllers;

[ApiController]
[Route("api/v1/cafe-management")]
[ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest)]
public class CafeController : ControllerBase
{
    private readonly IManagementService _managementService;

    public CafeController(IManagementService managementService)
    {
        _managementService = managementService;
    }

    [HttpGet("tables")]
    [ProducesResponseType(typeof(BaseResponse<List<TableDto>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetTables()
    {
        return Ok(new BaseResponse<List<TableDto>>(await _managementService.GetTables()));
    }
    
    [HttpGet("tables/{tableId}/active-order")]
    [ProducesResponseType(typeof(BaseResponse<OrderDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetActiveOrder(int tableId)
    {
        return Ok(new BaseResponse<OrderDto>(await _managementService.GetActiveOrder(tableId)));
    }
    
    [HttpGet("tables/{tableId}/active-order/close")]
    [ProducesResponseType(typeof(BaseResponse<string>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> CloseOrder(int tableId)
    {
        await _managementService.CloseOrder(tableId);
        return Ok(new BaseResponse<string>("OK"));
    }
}