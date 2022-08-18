using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{

    // methods
    internal class ProductManager : Product
    {

        public ProductManager(Product product)
        {
            Console.WriteLine(product + " Eklendi");
        }

        public ProductManager(string productName)
        {
            productName = "ahmet";
            //ProductName = productName;
        }

        public void Add(Product product) 
        {
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);
        }

        public void Remove(Product product)
        {
            Console.WriteLine("Ürün Kaldırıldı : " + product.ProductName);
        }

    }
}
