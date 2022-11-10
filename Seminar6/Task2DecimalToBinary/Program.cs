int userNumber = GetUserNumber("Введите число", "Ошибка ввода!");
char[] binaryOfUserNumber = GetBinary(userNumber);
Console.WriteLine(binaryOfUserNumber);

int GetUserNumber(string msg, string errorMsg)
{
    while(true)
    {
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        else Console.WriteLine(errorMsg);
    }
}



char[] GetBinary(int num) //65
{   
    string answer = String.Empty;
    while(num > 0)
    {
    answer += num % 2;
    num /= 2;
    }
    return answer.Reverse().ToArray();;
}