// Показать вторую цифру трёхзначного числа
int n = new Random().Next(100, 999);
Console.WriteLine(n);
int m = n % 100;
Console.WriteLine($"Last number - {m/10}");