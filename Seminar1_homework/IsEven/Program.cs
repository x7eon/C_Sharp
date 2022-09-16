Console.WriteLine("Введите число: ");

if (double.TryParse(Console.ReadLine(), out double Number))
{
    if (Number == 0) 
    {
        Console.WriteLine("Введите число, отличное от нуля");
    }
    else if (Number % 2 == 0) 
    {
        Console.WriteLine("Число " + Number + " четное");
    }
    else 
    {
        Console.WriteLine("Число " + Number + " нечетное");
    }
}
else Console.WriteLine("Ошибка ввода! Введите число!");