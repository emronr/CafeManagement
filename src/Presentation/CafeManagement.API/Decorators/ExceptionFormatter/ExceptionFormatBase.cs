namespace CafeManagement.API.Decorators.ExceptionFormatter;

public class ExceptionFormatBase
{
    private readonly IExceptionFormatBase exceptionFormatBase;
    public ExceptionFormatBase(IExceptionFormatBase exceptionFormatBase)
    {
        this.exceptionFormatBase = exceptionFormatBase;
    }
    public string FormatException(Exception exception, HttpContext context)
    {
        return exceptionFormatBase.FormatException(exception, context);
    }
}