using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal:IProductDal // Dal == Data Access Layer ( javada Dao == data access object)
    {
        List<Product> _products; // ürünleri kontrol etmek için kullanıcaz.
        public ProductDal()
        {
            _products = new List<Product>() // veri tabanı varmış gibi bir kaç ürün oluşturduk.
            { 
                new Product{ProductId = 1, ProductName ="Acer Bilgisayar",QuantityPerUnit= "32 GB Ram",UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId = 2, ProductName ="Asus Bilgisayar",QuantityPerUnit= "16 GB Ram",UnitPrice=8000,UnitsInStock=1 },
                new Product{ProductId = 3, ProductName ="Hp Bilgisayar",QuantityPerUnit= "8 GB Ram",UnitPrice=6000,UnitsInStock=0},
                new Product{ProductId = 4, ProductName ="Mac Bilgisayar",QuantityPerUnit= "4 GB Ram",UnitPrice=12000,UnitsInStock=3},
                new Product{ProductId = 5, ProductName ="Dell Bilgisayar",QuantityPerUnit= "8+2 GB Ram",UnitPrice=9000,UnitsInStock=10}
            };
        }

        

        public List<Product> GetAll()
        {
            return _products;
        } 

        public void Add(Product product)
        {
            Console.WriteLine("Ado.Net ile eklendi.");
        }
    }
}
