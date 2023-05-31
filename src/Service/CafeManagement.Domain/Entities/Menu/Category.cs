using System.Collections.Generic;

namespace CafeManagement.Domain.Entities.Menu
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}