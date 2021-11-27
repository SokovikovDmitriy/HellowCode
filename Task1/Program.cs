int n = new Random().Next(2, 100);
Console.WriteLine (n);
int m = new Random().Next(1, 10);
Console.WriteLine (m);

if (n == m * m)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
