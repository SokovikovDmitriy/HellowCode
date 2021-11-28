// Выяснить является ли число чётным

Console.Write("Введите число -  ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 1)
{
Console.WriteLine("Число не четное");
}
else
{
    Console.WriteLine("Число четное");
}