// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.Write("Enter number - ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
int M = 1;

Console.WriteLine($"Mul from 1 to {N}:");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{(M)} * {i} = {(M = M * i)}");
}
Console.WriteLine();