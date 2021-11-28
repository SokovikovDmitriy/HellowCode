// Показать четные числа от 1 до N
Console.Write("Write N = ");
int N = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x <= N;x++)
{
    if(x % 2 == 0)

    {
            Console.WriteLine(x);
    }
}
