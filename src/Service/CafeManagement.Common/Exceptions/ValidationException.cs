using CafeManagement.Common.Models.ErrorModels;

namespace CafeManagement.Common.Exceptions;

public class ValidationException : Exception
{
    public List<ValidationErrorModel> ValidationErrors { get; set; }
    public ValidationException(List<ValidationErrorModel> validationErrors)
    {
        ValidationErrors = validationErrors;
    }
}