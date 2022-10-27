void FindDistanceOf2Points()
{
    Console.Clear();
    double x1 = 0;
    double y1 = 0;
    double x2 = 0;
    double y2 = 0;
    try 
    {
        Console.WriteLine("Введите первую x координату: ");
        x1 = double.Parse(Console.ReadLine()?? "");
        Console.WriteLine("Введите первую y координату: ");
        y1 = double.Parse(Console.ReadLine()?? "");
        Console.WriteLine("Введите вторую x координату: ");
        x2 = double.Parse(Console.ReadLine()?? "");
        Console.WriteLine("Введите вторую y координату: ");
        y2 = double.Parse(Console.ReadLine()?? "");

    }
    catch (Exception exc)
    {
        Console.WriteLine("Ошибка ввода: " + exc.Message);
        return;
    }
    double result = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    Console.WriteLine($"Расстояние равно " + result.ToString("0.00"));
}
FindDistanceOf2Points();



/*
void FindDistanceOf2Points(double x1, double y1, double x2, double y2)
{
    Console.Clear();
    double result = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    Console.WriteLine($"Расстояние равно " + result.ToString("0.00"));
}
FindDistanceOf2Points(7, -5, 1, -1);
*/
