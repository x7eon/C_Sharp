int number = GetNumberFromUser("Введите число","Ошибка ввода!");
int productFromOneToNumber = ProductFromOneToNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {productFromOneToNumber}");


int GetNumberFromUser(string msg, string errorMsg)
{
    while(true)
    {
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMsg);
    }
}


int ProductFromOneToNumber(int number)
{   
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    return product;
}

/*
int Factorial(int number)
{
    if (number == 1) return 1;
    else return number * Factorial(number - 1);
}
*/