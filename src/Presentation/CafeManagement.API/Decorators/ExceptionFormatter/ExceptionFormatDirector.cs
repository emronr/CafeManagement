using CafeManagement.Common.Exceptions;

namespace CafeManagement.API.Decorators.ExceptionFormatter;

public class ExceptionFormatDirector
{
    public string FormatException(Exception exception, HttpContext context)
    {
        var response = string.Empty;
        if (exception is FriendlyException)
        {
            response = new ExceptionFormatBase(
                new FriendlyExceptionFormatDecorator()).FormatException(exception, context);
        }
        else if (exception is ValidationException)
        {
            response =
                new ExceptionFormatBase(new ValidationExceptionFormatDecorator()).FormatException(exception, context);
        }
        else
        {
            response =
                new ExceptionFormatBase(new UnHandledExceptionFormatDecorator()).FormatException(exception, context);
        }

        return response;
    }
}