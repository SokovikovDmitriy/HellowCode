
string[,] table = new string[2, 5];


// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colomns = 0; colomns < 5; colomns++)
//     {
//         Console.WriteLine($"{table[rows, colomns]}");
//     }
// }



// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int l = 0; l < matr.GetLength(1); l++)
//         {
//             matr[i, l] = new Random().Next(1,10);
//         }
//     }
// }

// Console.Clear();
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

int F(int n)
{
    if(n==1 || n == 2) return 1;
    else return F(n-1) + F(n-2);
}

for (int i = 0; i < 10; i++)
{
   Console.WriteLine($"F({i}) = {F(i)}");
}