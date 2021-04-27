using System.Collections.Generic;
using System;

namespace CompositePattern.Base
{
    public abstract class ContainerBase : IProduct
    {
        public string Name { get; set; }

        public IList<IProduct> Products { get; set; } = new List<IProduct>();


        public void ShowContent()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.Name);

                if (product is ContainerBase container)
                {
                    container.ShowContent();
                }
            }
        }
    }
}
