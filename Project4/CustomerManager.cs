using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class CustomerManager:Customer
    {
        public CustomerManager()
        {
            customers = new List<Customer>() {
                new Customer{Id=1,FirstName="Emre",LastName="Kaya",City="Corum",Email="emre@"},
                new Customer{Id=2,FirstName="Gözde",LastName="Kaya",City="Corum",Email="gozde@"},
                new Customer{Id=3,FirstName="Kamil",LastName="Kaya",City="Corum",Email="kamil@"},
                new Customer{Id=4,FirstName="Hayri",LastName="Zengin",City="Giresun",Email="hayri@"},
                new Customer{Id=5,FirstName="Cagri",LastName="Aslan",City="Yozgat",Email="Cagri@"},
                new Customer{Id=6,FirstName="Ayse",LastName="Cantal",City="Balıkesir",Email="ayse@"}
            };
        }


        List<Customer> customers;// ekle fonksiyonunda kullanmak içi dışarı koyduk.
        public List<Customer> GetCustomers()
        {
            
            return customers;
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
            MessageBox.Show("Eklendi");
        }
    }
}
