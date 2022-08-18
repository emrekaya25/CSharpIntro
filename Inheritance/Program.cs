// inheritance == miras demek.

PersonManager personManager = new PersonManager();
personManager.Add();

CustomerManager customerManager = new CustomerManager();
customerManager.Update();
customerManager.GetBestCustomer();

EmployeeManager employeeManager = new EmployeeManager();
employeeManager.Add();
employeeManager.GetBestEmployee(); 

class PersonManager
{
    public void Add()
    {
        Console.WriteLine("Eklendi");
    }
    public void Update()
    {
        Console.WriteLine("Güncellendi");
    }

}

class CustomerManager : PersonManager  // (inheritance syntax) açıklamasıda şu şekilde customer manager miras alır person managerdan
{
    public void GetBestCustomer()
    {
        Console.WriteLine("Ayın müşterisi");
    }
}

class EmployeeManager : PersonManager
{
    public void GetBestEmployee()
    {
        Console.WriteLine("Ayın elemanı");
    }
}

class Person
{
    public int Id { get; set; } // database id
    public string NationalIdentity { get; set; } // tcno
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber { get; set; }
}