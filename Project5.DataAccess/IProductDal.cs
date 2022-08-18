using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll(); // liste döndürmemiz lazım bütün hepsini göstermek için
        void Add();
        void Update();
        void Delete();
    }
}
