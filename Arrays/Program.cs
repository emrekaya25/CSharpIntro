string kredi1 = "Hizli kredi";
string kredi2 = "Maasini Halkbank'tan alanlara ozel";

string[] krediler = new string[2];
krediler[0] = kredi1;
krediler[1] = kredi2;
krediler[2] = "Tasit kredisi";

// string[] deneme = new string[3] {"emre","kaya","hayri" }; // böylede yazılabilir.

foreach (string kredi in krediler)
{
    Console.WriteLine(kredi);
}
