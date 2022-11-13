int userNumber = GetUserNumber("Введите число", "Ошибка ввода!");
Fibonacci(userNumber);

int GetUserNumber(string msg, string errorMsg)
{
    while (true)
    {
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) return userNumber;
        Console.WriteLine(errorMsg);
    }
}


void Fibonacci(int num)
{
    if (num == 0) return;
    else if (num == 1)
    {
        Console.WriteLine(0);
        return;
    }
    else
    {
        int num0 = 0;
        int num1 = 1;
        Console.Write($"{num0} ");
        Console.Write($"{num1} ");
        for (int i = 2; i < num; i++)
        {
            int num2 = num0 + num1;
            Console.Write($"{num2} ");
            num0 = num1;
            num1 = num2;
        }
    }
}