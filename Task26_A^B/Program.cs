// Возведите число А в натуральную степень B используя цикл
Console.Clear();

Console.Write("Enter number - ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter number - ");
int B = int.Parse(Console.ReadLine());
int M = 1;
 //Console.WriteLine(Math.Pow(A, B));

for (int i =1; i <= B; i++)
{

    M = M * A;
}
Console.WriteLine(M);