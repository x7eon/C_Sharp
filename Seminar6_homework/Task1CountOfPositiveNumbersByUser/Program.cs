int length = GetUserNumber("Введите число элементов: ", "Ошибка ввода!");
int[] array = new int[length];

int[] userArray = FillArrayByUser(array);
Console.WriteLine(String.Join(" ", userArray));
int countPositiveNumbers = CountPositiveNumbersInUserArray(userArray);
Console.WriteLine($"Количество введенных положительных чисел: {countPositiveNumbers}");


int GetUserNumber(string msg, string errorMsg)
{
    while(true)
    {
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMsg);
    }
}

int[] FillArrayByUser(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetUserNumber("Введите число: ", "Ошибка ввода!");
    }
    return arr;
}

int CountPositiveNumbersInUserArray(int[] collection)
{   
    int count = 0;
    for(int i = 0; i < collection.Length; i++)
    {
        if(collection[i] > 0)
        {
            count++;
        }
    }
    return count;
}