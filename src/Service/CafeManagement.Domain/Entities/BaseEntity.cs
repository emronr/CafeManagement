using System;

namespace CafeManagement.Domain.Entities
{
    public class BaseEntity<TKey>
        where TKey : IComparable
    {
        public TKey Id { get; set; }
    }
}