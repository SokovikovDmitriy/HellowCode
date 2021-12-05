//Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();

Console.Write("Введите число - ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 7 == 0 && x % 23 == 0)
{
    Console.Write("Кратно");
}
else if (x % 7 == 0 && x % 23 != 0)
{
    Console.Write("Не кратно 23");
}

else if (x % 7 != 0 && x % 23 == 0)
{
    Console.Write("Не кратно 7");
}
else
{
    Console.Write("Не кратно");
}