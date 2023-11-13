using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("added to cart  : " + product.Name );
            Console.WriteLine("kalan stok :" + product.Stock);
        }

        public void Add2(string productName, string description, double price )
        {
            Console.WriteLine("tebrikler sepete eklendi : " + productName + " " + description + " " + price);
        }
    }
}
