//Найти третью цифру числа или сообщить, что её нет

Console.Write("input the number - ");
string stringX = Console.ReadLine();
int x = Convert.ToInt32(stringX);
Console.WriteLine();

if (x > 99 || x < -99)
{
    Console.WriteLine($"{stringX[2]}");
}
else
{
    Console.WriteLine($"No third namber. {x}");
}