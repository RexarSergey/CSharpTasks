using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_1
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int code, string name, double price) 
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }
}
