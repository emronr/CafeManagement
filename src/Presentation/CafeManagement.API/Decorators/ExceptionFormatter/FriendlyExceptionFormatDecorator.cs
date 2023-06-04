using System.Text.Json;
using CafeManagement.Common.Exceptions;
using CafeManagement.Common.Models.ResponseModels;

namespace CafeManagement.API.Decorators.ExceptionFormatter;

public class FriendlyExceptionFormatDecorator : IExceptionFormatBase
{
    public string FormatException(Exception exception, HttpContext context)
    {
        var userFriendlyException = (FriendlyException)exception;
        var errorMessage = userFriendlyException.ErrorMessage;
        var response = new BaseResponse(errorMessage);

        context.Response.StatusCode = (int)userFriendlyException.HttpStatusCode;
        return JsonSerializer.Serialize(response,
            new JsonSerializerOptions() {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
    }
}