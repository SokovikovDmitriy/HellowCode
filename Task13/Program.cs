// Выяснить, кратно ли число заданному, 
// если нет, вывести остаток

// int n = new Random().Next(1, 10000);
// Console.WriteLine(n);
// int m = new Random().Next(1, 1000);
// Console.WriteLine(m);

Random x = new Random();
int n = x.Next();
int m = x.Next();



if (n > 99 && n < 1000 && m > 9 && m < 100)
    if (n % m == 0)
    {
        Console.WriteLine($"Yes = {n / m}");
    }
    else
    {
    Console.WriteLine($"No. Remainder = {n % m}");
    }
else
    {
     Console.WriteLine("Take another numbers");
    }
