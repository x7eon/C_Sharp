int GetUserNumber(string msg, string errorMsg)
{   
    Console.WriteLine(msg);
    while(true)
    {   
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(IsCorrect)
            return userNumber;
        Console.WriteLine(errorMsg);
    }
}

int FindTheNumberOfElementsRange10To99(int[] array)
{   
    int numberOfElementsOfRange10to99 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            numberOfElementsOfRange10to99 += 1;
        }
    }
    return numberOfElementsOfRange10to99;
}

int[] newArrayRandomUserSize(int size, int min, int max)
{
    int[] block = new int[size];
    for (int i = 0; i < size; i++)
    {
        block[i] = new Random().Next(min, max + 1);
    }
    return block;
}


int userNumber = GetUserNumber("Ввдеите число элементов массива: " , "Ошибка! Введите число");
int minNumberRange = GetUserNumber("Ввдеите минимальное значение: " , "Ошибка! Введите число");
int maxNumberRange = GetUserNumber("Ввдеите максимальное значение: " , "Ошибка! Введите число");

int[] block = newArrayRandomUserSize(userNumber, minNumberRange, maxNumberRange);
Console.Write(String.Join(" ", block));
int anwser = FindTheNumberOfElementsRange10To99(block);
Console.WriteLine();
Console.WriteLine(anwser);