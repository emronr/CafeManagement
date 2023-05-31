namespace CafeManagement.Business.DTOs;

public class TableDto : BaseDTO
{
    public string TableName { get; set; }
    public bool IsFull { get; set; }
}