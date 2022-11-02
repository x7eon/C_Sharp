int num = GetNumFromUser("Введите число: ", "Ошибка ввода");
int numberOfDigits = GetNumberOfDigits(num);
Console.WriteLine($"Количество чисел в числе {num} = {numberOfDigits}");

int GetNumFromUser(string massege, string errorMassage)
{
    while(true)
    {
        Console.WriteLine(massege);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNum);
        if(isCorrect) return userNum;
        Console.WriteLine(errorMassage);
    }
}

int GetNumberOfDigits(int number)
{
    int count = 1;
    if (number > 0)
    {
        while(number > 9)
        {
            count += 1;
            number /= 10; 
        }
    return count;
    }
    else
    {
        while(number < -9)
        {
            count++;
            number /= 10;
        }
    return count;
    }
}