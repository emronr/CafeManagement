namespace CafeManagement.API.Decorators.ExceptionFormatter;

public interface IExceptionFormatBase
{
    string FormatException(Exception exception, HttpContext context);
}