Customer customer = new Customer(1,"Emre","Kaya","Çorum");
Customer customer2 = new Customer() { Id = 2,FirstName = "Aysenur", LastName = "Saylan", City = "İstanbul"}; 



class Customer {

    public Customer()    // constructor yapısı
    {
        Console.WriteLine("Yapıcı blok calisti.");
    }
    public Customer(int id,string firstname,string lastname,string city)  
    {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        City = city;
    }

    public int Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}
