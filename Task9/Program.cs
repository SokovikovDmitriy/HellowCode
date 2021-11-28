// Показать последнюю цифру трёхзначного числа
int n = new Random().Next(100, 999);
Console.WriteLine(n);
int m = n % 10;
Console.WriteLine($"Last number - {m}");