void WhatsSector (int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Ошибка, x и/или y = 0");
    }
    if (x > 0 && y < 0) Console.WriteLine("Точка находится в плоскости 4");
    else if (x > 0 && y > 0) Console.WriteLine("Точка находится в плоскости 1");
    else if (x < 0 && y > 0)  Console.WriteLine("Точка находится в плоскости 2");
    else if (x < 0 && y < 0) Console.WriteLine("Точка находится в плоскости 3");
}

WhatsSector(4, 5);
WhatsSector(4, -5);
WhatsSector(-4, 5);
WhatsSector(-4, -5);

WhatsSector(-0, -5);
WhatsSector(0, 0);
WhatsSector(-5, 0);