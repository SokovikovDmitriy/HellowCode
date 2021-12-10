// Подсчитать сумму цифр в числе
Console.Clear();

Console.Write("Enter number - ");
string A = Convert.ToString(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= A.Length; i++)
{
    // Console.WriteLine(sum += i);
    sum += i;
}
Console.WriteLine(sum);
