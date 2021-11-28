int[] array = { 1, 12, 31, 4, 15, 17, 18};

int n = array.Length;
int x = 17;

int index = 0;

while (index < n)
{
    if(array[index] == x)
    {
    Console.WriteLine(index);
    break;
    index++;
    }
}
