double userNum;

while(true) 
{
    Console.WriteLine("Введите число");
    if (double.TryParse(Console.ReadLine(), out userNum))
    {
        break;
    }
    Console.WriteLine("Ошибка ввода, введите число");
}

Console.WriteLine($"A={userNum}");