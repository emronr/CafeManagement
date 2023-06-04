using System.Net;
using System.Text.Json;
using CafeManagement.Common.Exceptions;
using CafeManagement.Common.Models.ResponseModels;

namespace CafeManagement.API.Decorators.ExceptionFormatter;

public class ValidationExceptionFormatDecorator : IExceptionFormatBase
{
    public string FormatException(Exception exception, HttpContext context)
    {
        var validationException = (ValidationException) exception;
        var response = new BaseResponse(validationException.ValidationErrors);

        context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
        return JsonSerializer.Serialize(response,
            new JsonSerializerOptions() {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
    }
}