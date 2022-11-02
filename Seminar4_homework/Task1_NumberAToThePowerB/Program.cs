int numberByUser1 = GetNumberByUser("Введите первое число: ", "Ошибка ввода");
int numberByUser2 = GetNumberByUser("Введите второе число: ", "Ошибка ввода");
int result = NumberToPower(numberByUser1, numberByUser2);
Console.WriteLine($"Число {numberByUser1} в степени {numberByUser2} = {result}");



int GetNumberByUser(string msg, string errorMsg)
{   
    while(true)
    { 
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) 
            return userNumber;
        Console.WriteLine(errorMsg);

    }
}

int NumberToPower(int number1, int number2)
{   
    int count = 1;
    int powerResult = 1;
    while(count <= number2)
    {   
        powerResult *= number1;
        count++;
    }
    return powerResult;
}