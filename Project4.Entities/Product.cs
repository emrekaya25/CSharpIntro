using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Entities
{
    public class Product // diğer katmanlardan kullanacağımız için internal olan kısmı public yaptık.
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; } // ürün açıklaması
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
