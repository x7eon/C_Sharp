int num = GetNumberFromUser("Введите число: " , "Ошибка ввода!");
Console.WriteLine("сумма чисел от 1 до N");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"\t{num} -> {sumNumbers}");
Console.WriteLine("сумма цифр в числе равна");
Console.WriteLine($"\t{num} -> {GetSumDigits(num)}");


int GetNumberFromUser(string msg , string errorMsg)
{
    while(true)
    {   
        Console.Write(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMsg);
    }
}

int GetSumNumbers(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num;
        num --;
    }
    return sum;
}

int GetSumDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}