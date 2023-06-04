using CafeManagement.Common.Models.ErrorModels;

namespace CafeManagement.Common.Models.ResponseModels;

public class BaseResponse
{
    public ErrorMessage ErrorMessage { get; set; }
    public List<ValidationErrorModel> ValidationErrors { get; set; }

    public bool IsSuccess
    {
        get => ErrorMessage == null || ValidationErrors == null;
    }

    public BaseResponse()
    {
        
    }

    public BaseResponse(ErrorMessage errorMessage)
    {
        ErrorMessage = errorMessage;
    }
    
    public BaseResponse(List<ValidationErrorModel> ValidationErrors)
    {
        ValidationErrors = ValidationErrors;
    }
}

public class BaseResponse<T> : BaseResponse
{
    public T Result { get; set; }

    public BaseResponse()
    {
    }

    public BaseResponse(T result)
    {
        Result = result;
    }
    
    public BaseResponse(ErrorMessage errorMessage) : base(errorMessage)
    {

    }

    public BaseResponse(List<ValidationErrorModel> validationErrors) : base(validationErrors)
    {

    }
}