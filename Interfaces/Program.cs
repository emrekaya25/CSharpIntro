interface IPersonManager
{
    // unimplemented operation
    void Add();
    void Remove();
    void Update();

}


// inherits / class ------------- implements / interface


class PersonManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi.");
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme kodları
        Console.WriteLine("Personel eklendi.");
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}


IPersonManager personManager = new PersonManager(); // interfaceler newlenemez
