int num = GetUserNumber("Введите число", "Ошибка ввода: ");
Console.WriteLine(NumbersFrom1ToN(1, num));

string NumbersFrom1ToN(int start, int n)
{   
    if (start > n) return String.Empty;
    else
    {
        return $"{start}" + NumbersFrom1ToN(start + 1, n);
    }
}

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

