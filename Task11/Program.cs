// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


//Console.Write("Ведите число - ");
//int n = Convert.ToInt32(Console.ReadLine());

int n = new Random().Next(10, 99);
Console.WriteLine(n);

int m1 = n / 10;
Console.WriteLine($"First number - {m1}");

int m2 = n % 10;
Console.WriteLine($"Last number - {m2}");

if (m1 > m2)
{
    Console.WriteLine($"Max namber - {m1}");
}
else
{
    Console.WriteLine($"Max namber - {m2}");
}