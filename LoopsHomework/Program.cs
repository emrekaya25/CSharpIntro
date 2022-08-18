int sayi1;

int sayi2;

int sayac1 = 0;

int sayac2 = 0;

Console.WriteLine("Birinci sayıyı giriniz: ");

sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz: ");

sayi2 = int.Parse(Console.ReadLine());

for (int i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        sayac1 += i;
    }
}

for (int j = 1; j < sayi2; j++)
{
    if (sayi2 % j == 0)
    {
        sayac2 += j;
    }
}

if (sayac1 == sayi2 && sayac2 == sayi1)
{
    Console.WriteLine("Birinci ve ikinci sayı arkadas sayidir.");
}
else{
    Console.WriteLine("Arkadas sayi degiller.");
}
