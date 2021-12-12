// В одномерном массиве из 123 чисел 
//найти количество элементов из отрезка [10,99]
Console.Clear();

int[]array = new int[123];
int count = 0;
for (int i = 10; i < 100; i++)
{
    count = count + 1;
}
Console.WriteLine(count);