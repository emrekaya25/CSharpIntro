string[] sehirler = new string[] {"Ankara","İstanbul","İzmir" };
Console.WriteLine(sehirler.Length);

// sehirler[3] = "Bursa"; // hata verir , dizinin sınırlarının dışında kaldı. 

// list yapısı

List<string> sehirler2 = new List<string>() { "Corum","Eskisehir"};
sehirler2.Add("Ankara");
sehirler2.Add("İstanbul");
sehirler2.Add("İzmir");
sehirler2.Remove(sehirler2[3]);
sehirler2.Remove("Corum");
foreach (string sehir in sehirler2)
{
    Console.WriteLine(sehir);
}

bool result = sehirler2.Contains("Eskisehir"); // doğruluk kontrol eder, listede var mı yok mu ?
Console.WriteLine(result);

