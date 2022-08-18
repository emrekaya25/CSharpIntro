int[] numbers = new int[3];
numbers[0] = 8;
numbers[1] = 20;
numbers[2] = 45;

int highest = numbers[0];
int lowest = numbers[0];
int middle = 0;

for (int i = 1; i<=2 ; i++)
{
    if (numbers[i] > highest)
        highest = numbers[i];
}

for (int i = 1; i <= 2; i++)
{
    if (numbers[i] < lowest)
        lowest = numbers[i];
}

for (int i = 0; i < 3; i++)
{
    if (numbers[i] > lowest && numbers[i] < highest)
        middle = numbers[i];    
}

Console.WriteLine("En buyuk : "+highest);
Console.WriteLine("En kucuk : "+lowest);
Console.WriteLine("Ortanca : "+middle);

Array.Sort(numbers); // bu kodda direk sıralıyor :D

