// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();

bool[] a = {true, false};
bool R = true;

for (int i = 0; i < a.Length; i++)
{
    for(int j = 0; j <a.Length; j++)
    {
        if( !(a[i] ||  a[j]) == (!a[i] && !a[j]))
        {
            Console.WriteLine($"Для x = {a[i]}, y = {a[j]} выражение верно");
        }
        else
        {
            R = false;
            break;
        }
    }
}

if(R)
{
    Console.WriteLine("Доказано, что утверждение истинно");
}
else
{
    Console.WriteLine("Доказано что выражение ложно");
}
