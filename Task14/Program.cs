//Найти третью цифру числа или сообщить, что её нет

Console.Write("input the number - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (x > 99)
{

    Console.WriteLine($"{x.ToString()[2]}");
}
else
{
    Console.WriteLine("No third namber");
}