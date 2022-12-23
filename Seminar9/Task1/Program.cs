int num = GetUserNumber("Введите число", "Ошибка ввода: ");

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(String.Join(" ", i));
}


string NumbersFrom1ToN(int n)
{
    int i = 1;
    if (i <= n) return $"{i}" + NumbersFrom1ToN(n - 1);
    else return String.Empty;
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

