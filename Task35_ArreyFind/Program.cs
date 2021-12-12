// Определить, присутствует ли в заданном массиве,
//  некоторое число
Console.Clear();
Console.Write("Какое число из массива показать? - ");
int find = int.Parse(Console.ReadLine());
int i = 0;
int[] array = new int[10];
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

bool position = false;

for (i = 0; i < array.Length; i++)
{
    if (array[i] == find)
    {
        position = true;
        break;
    }
}
if (position)
{
    Console.WriteLine($"{find} стоит на {i + 1} месте массива");
}
else
{
    Console.WriteLine("No " + find);
}


// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;

//     while (index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//         }
//         return position;
// }