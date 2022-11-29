int rows = GetUserNumber("Введите M: ", "Ошибка ввода");
int colums = GetUserNumber("Введите N: ", "Ошибка ввода");

int[,] userArray = new int[rows, colums];

PrintArray(userArray);
userArray = FillArrayRandom(userArray);
PrintArray(userArray);

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


int[,] FillArrayRandom(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 10);
        }
    }
    return collection;
}


void PrintArray(int[,] col)
{   
    Console.WriteLine();
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
    Console.WriteLine();
    }
}