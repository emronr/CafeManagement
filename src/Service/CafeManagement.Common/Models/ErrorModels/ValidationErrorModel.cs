namespace CafeManagement.Common.Models.ErrorModels;

public class ValidationErrorModel
{
    public ValidationErrorModel(string key, List<string> errors)
    {
        Key = key;
        Errors = errors;
    }

    public string Key { get; set; }

    public List<string> Errors { get; set; }
}