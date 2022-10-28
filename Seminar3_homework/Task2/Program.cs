void DistanceOfTwoPoints3D ()
{
    Console.WriteLine("Введите x-координату первой точки: ");
    int x1 = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите y-координату первой точки: ");
    int y1 = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите z-координату первой точки: ");
    int z1 = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите x-координату второй точки: ");
    int x2 = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите y-координату второй точки: ");
    int y2 = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите z-координату второй точки: ");
    int z2 = int.Parse(Console.ReadLine()?? "");

    double result = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    Console.WriteLine($"Расстояние между точками равно {result.ToString("0.00")}");
    
}

DistanceOfTwoPoints3D();