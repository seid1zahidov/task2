using System;
using hometaks2233.Models;

namespace hometaks2233
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(Enums.ProductType.Fish, "Farel" , 20);
            product.Test();
            Product product1 = new Product(Enums.ProductType.Bakery, "Balati", 0.70);
            product1.Test();
            Product product2 = new Product(Enums.ProductType.Drink, "Corona", 30);
            product2.Test();
            Product product3 = new Product(Enums.ProductType.Meat, "Kfc sef burger menu", 6.99);
            product3.Test();
        }
    }
}
