Matematik matematik = new Matematik();
int sonuc = matematik.Toplama(5,8);
Console.WriteLine(sonuc);
int sonuc2 = matematik.Toplama(sayi1:5,sayi2:5,sayi3:20); // default değer atadık sayi2 100 olacak
Console.WriteLine(sonuc2);

int sonuc3 = matematik.ToplamaParams(5,6,7,8,2,5,1,4,6); // istediğimiz kadar sayıyı yazabiliyoruz.
Console.WriteLine(sonuc3);
int sonuc4 = matematik.ToplamaParams(new int[] { 23, 5, 1, 2, 3, 4, 1 });
Console.WriteLine(sonuc4);


matematik.Cikarma(5,8);
matematik.Bölme(15, 5);
matematik.Carpma(5, 20);




class Matematik
{
    public int Toplama(int sayi1,int sayi2=100) 
    {
        return sayi1 + sayi2;               // return yaparsak method başındaki void i int veya farklı bi veri tipi yapmamız gerekiyor.
    }
    
    public int Toplama(int sayi1,int sayi2,int sayi3)  // aynı adda istediğimiz kada method yazabiliriz sadece girdiğimiz parametreler farklı olmalı.
    {
        return sayi1 + sayi2 + sayi3;
    }

    public int ToplamaParams(params int[] sayilar) // array gönderir gibi gönderiyoruz paramsta
    {
        int sonuc = 0;
        foreach (int sayi in sayilar)
        {
            sonuc += sayi;
        }
        // return sonuc;
        return sayilar.Sum(); // bu yapı arraydaki sayiları topla demek.
    }

    public void Cikarma(int sayi1,int sayi2)
    {
        Console.WriteLine(sayi1-sayi2);
    }

    public void Bölme(int sayi1,int sayi2)
    {
        Console.WriteLine(sayi1/sayi2);
    }
    
    public void Carpma(int sayi1,int sayi2)
    {
        Console.WriteLine(sayi1*sayi2);
    }


}
