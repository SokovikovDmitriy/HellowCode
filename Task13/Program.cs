// Выяснить, кратно ли число заданному, 
// если нет, вывести остаток

int n = new Random().Next(1, 10000);
Console.WriteLine(n);
int m = new Random().Next(1, 1000);
Console.WriteLine(m);


// for (int n = 10, n < 1000, n++)
// {
    
    if (n % m == 0)
    {
        Console.WriteLine($"Yes = {n / m}");
    }
    else
    {
    Console.WriteLine($"No. Remainder = {n % m}");
    }
// else
//     {
//      Console.WriteLine("Take another numbers");
//     }
// }
// }
// for (10 > n > 1000, 1 > m > 9)
// {
//     Console.WriteLine("Take another numbers");
// }