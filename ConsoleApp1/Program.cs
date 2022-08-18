double piyasaBugun  = 116000;
double piyasaDun = 115000.06;
bool result = piyasaBugun > piyasaDun;

string messageIncrease = "Artis oku";
string messageDecrease = "Azalis oku";

if (result == true)
{
    Console.WriteLine(messageIncrease);
  
}

if (result != true)
{
    Console.WriteLine(messageDecrease); 
    
}
