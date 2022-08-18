string[] krediler = new string[7];
krediler[0] = "Hızlı Kredi";
krediler[1] = "Kredi 2";
krediler[2] = "Kredi 3";
krediler[3] = "Kredi 4";
krediler[4] = "Kredi 5";
krediler[5] = "Kredi 6";
krediler[6] = "Kredi 7";

int number = 5;

for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);
}

Console.WriteLine("For döngüsü bitti.");

foreach (var kredi in krediler)
{
    Console.WriteLine(kredi);
}

Console.WriteLine("Foreach döngüsü bitti.");

while (number >= 0)
{
    Console.WriteLine("Emre.");
    number--;
}

Console.WriteLine("While döngüsü bitti.");

int number2 = 5;

do
{
    Console.WriteLine("Emre.");         // do-while ==> şart geçerli değilse bile alttan üste olduğu için 1 kere çalışıyor.
    number2--;
} while (number2 >= 0);

Console.WriteLine("do-while döngüsü bitti.");

