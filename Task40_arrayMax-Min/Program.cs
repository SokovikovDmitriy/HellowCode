// В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом
Console.Clear();

double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine($"max - min =" + (max - min));
