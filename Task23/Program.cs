// Показать таблицу квадратов чисел от 1 до N
Console.Clear();

Console.Write("Enter number - ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i<=N; i++)
{
    Console.WriteLine($"{i} x {i} = {Math.Pow(i, 2)}");
}
