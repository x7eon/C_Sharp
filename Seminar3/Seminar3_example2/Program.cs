Console.Clear();
int X = 0, Y = 0;

InitCoordinatsByUser(ref X, ref Y);
PrintQuarterByCoordinats(X, Y);


void InitCoordinatsByUser(ref int x, ref int y)
{
    try
    {
        Console.WriteLine("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
        
    }

    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
        return;
    } 
}

void PrintQuarterByCoordinats(int x, int y)
{   
    if (x > 0 && y < 0) Console.WriteLine("Точка находится в плоскости 4");
    else if (x > 0 && y > 0) Console.WriteLine("Точка находится в плоскости 1");
    else if (x < 0 && y > 0)  Console.WriteLine("Точка находится в плоскости 2");
    else if (x < 0 && y < 0) Console.WriteLine("Точка находится в плоскости 3");
    else Console.WriteLine("Ошибка, точка находится в начале координат");
}

