// Найти сумму чисел одномерного массива 
//стоящих на нечетной позиции
Console.Clear();

int[]array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1 && i != 0)
    {
        Console.Write(array[i] + " + ");
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Sum odd numbers = " + sum);