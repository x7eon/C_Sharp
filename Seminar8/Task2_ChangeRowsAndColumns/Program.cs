int rows = GetUserNumber("Введите число строк: ", "Ошибка ввода!");
int columns = GetUserNumber("Введите число стоблцов: ", "Ошибка ввода!");

int[,] userArrayRandomElements = CreateAndFillArray(rows, columns, 0, 10);
PrintArray(userArrayRandomElements);
Console.WriteLine();
int[,] changedArray = ChangeRowsAndColumnsArray(userArrayRandomElements, rows, columns);
PrintArray(changedArray);


int GetUserNumber(string massage, string errorMassage)
{
    while (true)
    {
        Console.WriteLine(massage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) return userNumber;
        Console.WriteLine(errorMassage);
    }
}

int[,] CreateAndFillArray(int rows, int cloumns, int minValue, int maxValue)
{
    int[,] arrayByUser = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayByUser[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arrayByUser;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] ChangeRowsAndColumnsArray(int[,] array, int rows, int columns)
{
    if (rows == columns)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                int box = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = box;
            }
        }
        return array;
    }
    else
    {
        Console.WriteLine("Ошибка! Строки и стоблцы не совпадают!");
        return array;
    }
}

