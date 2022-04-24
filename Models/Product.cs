using System;
using System.Collections.Generic;
using System.Text;
using hometaks2233.Enums;

namespace hometaks2233.Models
{
    class Product
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double DiscountPrice { get; set; }

        public double TotalCount { get; set; }

        public static int Count { get; set; }

        public static int Codee { get; set; } = 1000;

        public Product(ProductType type, string name, double price)
        {
            Codee++;
            Count++;
            Name = name;
            Price = price;
            Code = type.ToString().Substring(0, 1) + Codee.ToString();
        }

        public Product()
        {
        }

        public void Test()
        {
            Console.WriteLine($"{Name} {""} {Price} {"Manat"} {Codee}");
        }
    }
}

