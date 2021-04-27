using CompositePattern.Models;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainContainer = new Box("main");

            #region Boxes

            var box1 = new Box("box1");
            var box2 = new Box("box2");
            var box3 = new Box("box3");

            #endregion

            #region Products

            var product1 = new Product();
            var product2 = new Product();
            var product3 = new Product();
            var product4 = new Product();
            var product5 = new Product();
            var product6 = new Product();
            var product7 = new Product();

            #endregion

            box1.Products.Add(product1);
            box1.Products.Add(product2);
            box1.Products.Add(product3);
            box2.Products.Add(box1);
            box2.Products.Add(product4);
            box3.Products.Add(product5);
            box3.Products.Add(product6);
            box3.Products.Add(product7);

            mainContainer.Products.Add(box2);
            mainContainer.Products.Add(box3);

            mainContainer.ShowContent();
        }
    }
}
