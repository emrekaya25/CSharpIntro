IPersonManager employeeManager = new EmployeeManager();
employeeManager.add();
IPersonManager productManager = new ProductManager();
productManager.update();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(employeeManager);
projectManager.Add(new InternManager());


class Person
{

}

class Customer:Person // customer miras alır person'ı
{

}

class PersonManager
{
    public void Add()
    {
        Console.WriteLine("Eklendi");
    }
}

class CustomerManager:PersonManager
{
    // yukarıdaki add burdada var
}

interface IPersonManager
{
    void add();
    void update();
}

// inherits - class .-------------. implements - interface
class EmployeeManager : IPersonManager
{
    public void add()
    {
        Console.WriteLine("Çalışan Eklendi");
    }

    public void update()
    {
        Console.WriteLine("Çalışan güncellendi");
    }
}

// interfaceler newlenemez

class ProductManager : IPersonManager
{
    public void add()
    {
        Console.WriteLine("ürün Eklendi");
    }

    public void update()
    {
        Console.WriteLine("ürün güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.add();
    }
}

class InternManager : IPersonManager
{
    public void add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}


