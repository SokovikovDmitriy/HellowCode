// Программа проверяет пятизначное число на палиндром.

Console.Clear();

void FillArray(int[] collection)
{
    int L = collection.Length;
    int index = 0;
    // collection[0]  > 0;
    while (index < L)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
        
    }
}

    void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int[]Num = new int[5];
FillArray(Num);
PrintArray(Num);
Console.WriteLine();

if(Num[0] == Num[4] && Num[1] == Num[3])
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}