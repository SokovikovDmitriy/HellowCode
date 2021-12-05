// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

Console.Write("Ведите число - ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите Второе число - ");
double m = Convert.ToDouble(Console.ReadLine());


if (n == m * m || m == n * n)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}


