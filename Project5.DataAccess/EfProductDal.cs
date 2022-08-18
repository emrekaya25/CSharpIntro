using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _productDal;
        public EfProductDal()
        {
            _productDal = new List<Product>()
            {
                new Product(){Id=1,ProductName="Toyota Supra",UnitPrice=280000,UnitsInStock="8"},
                new Product(){Id=2,ProductName="Honda Civic",UnitPrice=30000,UnitsInStock="20"},
                new Product(){Id=3,ProductName="Hyundai i20",UnitPrice=26000,UnitsInStock="15"},
                new Product(){Id=4,ProductName="Ford Mustang",UnitPrice=18000,UnitsInStock="6"},
                new Product(){Id=5,ProductName="Volvo XC60",UnitPrice=50000,UnitsInStock="9"},
            };
        }
        public void Add()
        {
            Console.WriteLine("EF ile eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("EF ile silindi.");
        }

        public List<Product> GetAll()
        {
            return _productDal;
        }

        public void Update()
        {
            Console.WriteLine("EF ile güncellendi.");
        }
    }
}
