// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();

Console.Write("Ведите координату х - ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату у - ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 & y > 0) Console.Write("Точка находится в 1 четверти");
else if (x < 0 & y > 0) Console.Write("Точка находится в 2 четверти");
else if (x < 0 & y < 0) Console.Write("Точка находится в 3 четверти");
else if (x > 0 & y < 0) Console.Write("Точка находится в 4 четверти");
else Console.Write("Введите другие координаты");