// int,decimal,float,enum,boolean --> bunlar value types ( değer tipler) dir.
// yani sadece değerlerle işlem yapılır adreslerle işlemler yapılmaz.

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;

sayi2 = 100;

Console.WriteLine("sayi1 = " + sayi1);

// değerlerin tutulduğu yere '' stack '' adı verilir

// arrays,classes,interfaces bunlar reference types ( referans tipler) dir.
// referans tiplerde bellekte ekstradan ''Heap'' adı verilen bellek vardır. Adres burda tutulur.

int[] sayilar1 = new int[] {1,2,3};
int[] sayilar2 = new int[] {10, 20, 30 };      // new lediğimizde heapta stack in karşılığında bir adres oluşuyor.

sayilar1 = sayilar2; // burda sayilar 1 in adresi sayılar 2 nin adresi oldu.
sayilar2[0] = 1000;

Console.WriteLine("sayilar1[0] = "+ sayilar1[0]);

// --------------------------------------------------------------------------------------------------

// class da referans tip örnekleri

Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Emre";
person2 = person1;
person1.FirstName = "Ege";
Console.WriteLine(person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "Hayri";
customer.CreditCardNumber = "5234";
Employee employee = new Employee();

// customer = employee;  --> böyle bişey yazamazsın çünkü farklı tipler int ve string gibi
Person person3 = new Person();
person3 = customer;   // person'a customer ı atayabildik çünkü customer aslında bi person'dır.
Console.WriteLine(person3.FirstName);
Console.WriteLine(((Customer)person3).CreditCardNumber); // bu şekilde person dan customerdaki creditcardnumber a erişebiliyoruz.

PersonManager personManager = new PersonManager();
personManager.Add(customer);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person            // base class = Person 
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person) // burda person isteyerek hem customer hem de employee ile çalışabiliriz.
    {
        Console.WriteLine(person.FirstName+" Eklendi");
    }
}



