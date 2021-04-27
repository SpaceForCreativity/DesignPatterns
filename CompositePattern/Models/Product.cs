using CompositePattern.Base;
using System;

namespace CompositePattern.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; } = Guid.NewGuid().ToString();
    }
}
