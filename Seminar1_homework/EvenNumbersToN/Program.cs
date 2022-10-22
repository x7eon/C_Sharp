Console.WriteLine("Введите число: ");
dynamic evenNum = 2;
if(double.TryParse(Console.ReadLine(), out double Number))
{
    if(Number > 1)
    {   while(evenNum <= Number)
    {
        Console.WriteLine(evenNum);
        evenNum = evenNum +2;
    }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число больше 1");
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Введите число");
}
