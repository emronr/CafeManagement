using System.Net;
using System.Text.Json;
using CafeManagement.Common.Models.ErrorModels;
using CafeManagement.Common.Models.ResponseModels;

namespace CafeManagement.API.Decorators.ExceptionFormatter;

public class UnHandledExceptionFormatDecorator : IExceptionFormatBase
{
    public string FormatException(Exception exception, HttpContext context)
    {
        var errorMessage = new ErrorMessage()
        {
            Message = exception.Message
        };
        var response = new BaseResponse(errorMessage);

        context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
        return JsonSerializer.Serialize(response,
            new JsonSerializerOptions() {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
    }
}