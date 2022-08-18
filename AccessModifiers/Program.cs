using AccessModifiers;

House house = new House();
house.Id = 1;
house.City = "Ankara";


internal class Customer // internal etiketi sadece AccessModifiers namespace inde kullanabilirsin demek.
{                       // class in default hali internaldır.

}
