// Найти сумму чисел от 1 до А
Console.Clear();

Console.Write("Enter number - ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine();
int Sum = 0;

Console.WriteLine($"Sum from 1 to {A}:");
for (int i = 1; i<=A; i++)
{
    
    //Sum += i;
    //Console.WriteLine(Sum)

    Console.WriteLine($"{(Sum)} + {i} = {(Sum += i)}");
   
}
 Console.WriteLine();