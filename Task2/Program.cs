// Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое число - ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число - ");
double b = Convert.ToDouble(Console.ReadLine());
double max = a;
double min = b;
if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);

