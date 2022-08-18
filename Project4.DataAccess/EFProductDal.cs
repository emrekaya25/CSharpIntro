using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {

        List<Product> _products; 
        public EFProductDal()
        {
            _products = new List<Product>() 
            {
                new Product{ProductId = 1, ProductName ="Acer ef Bilgisayar",QuantityPerUnit= "32 GB Ram",UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId = 2, ProductName ="Asus ef Bilgisayar",QuantityPerUnit= "16 GB Ram",UnitPrice=8000,UnitsInStock=1 },
                new Product{ProductId = 3, ProductName ="Hp ef Bilgisayar",QuantityPerUnit= "8 GB Ram",UnitPrice=6000,UnitsInStock=0},
                new Product{ProductId = 4, ProductName ="Mac ef Bilgisayar",QuantityPerUnit= "4 GB Ram",UnitPrice=12000,UnitsInStock=3},
                new Product{ProductId = 5, ProductName ="Dell ef Bilgisayar",QuantityPerUnit= "8+2 GB Ram",UnitPrice=9000,UnitsInStock=10}
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("Entity Framework ile eklendi.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
