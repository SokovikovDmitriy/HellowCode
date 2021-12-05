// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

Console.Write("Enter the quarter number (1-4) - ");
double q = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if (q=1) Console.WriteLine("All points in the range x > 0, y > 0");
else if (q=2) Console.WriteLine("All points in the range x < 0, y > 0");
else if (q=3) Console.WriteLine("All points in the range x < 0, y < 0");
else if (q=4) Console.WriteLine("All points in the range x > 0, y < 0");
