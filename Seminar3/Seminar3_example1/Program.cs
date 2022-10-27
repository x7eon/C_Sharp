Console.Clear();
int x, y;

try
{
    Console.WriteLine("Введите X: ");
    x = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите Y: ");
    y = int.Parse(Console.ReadLine() ?? "");
}

catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if (x == 0 || y == 0)
    {
        Console.WriteLine("Ошибка, точка находится в начале координат");
    }
    if (x > 0 && y < 0) Console.WriteLine("Точка находится в плоскости 4");
    else if (x > 0 && y > 0) Console.WriteLine("Точка находится в плоскости 1");
    else if (x < 0 && y > 0)  Console.WriteLine("Точка находится в плоскости 2");
    else if (x < 0 && y < 0) Console.WriteLine("Точка находится в плоскости 3");

