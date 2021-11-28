// Показать числа от -N до N

Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());

for (int x = a; x < b +1;x++)
{
    Console.WriteLine(x);
}