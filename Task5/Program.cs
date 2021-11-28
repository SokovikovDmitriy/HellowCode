// Написать программу вычисления значения функции y = f(a)

static double f( double x)
{
    double result = ((x - 1) * (x + 1));
    return result;
}

Console.Write(" int x - ");

double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"y = ({x} - 1) * ({x} + 1) = {f(x)}");