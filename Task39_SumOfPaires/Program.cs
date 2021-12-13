// Найти произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент,
//второй и предпоследний и т.д.
Console.Clear();

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int mult = 0;
for (int i = 0; i < array.Length / 2;)
{
    for (int j = array.Length-1; j > i;)
    {
        mult = array[i] * array[j];
        Console.Write(array[i] +" ");
        i++;        
        Console.Write(array[j] +" ");
        j--;
        Console.WriteLine(mult);
    }
   
}

