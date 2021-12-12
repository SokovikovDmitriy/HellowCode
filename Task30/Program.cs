// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

int N = new Random().Next(1, 100);
Console.WriteLine(N);
Console.WriteLine();

int M = N % 10;

if (M == 1) 
{
    Console.WriteLine("Последняя цифра не четная");
}
else 
{
    Console.WriteLine($"Куб {N} = {Math.Pow(N, 3)}");
}
