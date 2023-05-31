namespace CafeManagement.Domain.Entities.Cafe
{
    public class Table : BaseEntity<int>
    {
        public string TableName { get; set; }
        public bool IsFull { get; set; }
    }
}
