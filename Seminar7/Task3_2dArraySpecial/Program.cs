Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, colums];
PrintArray(array);
int[,] arrayRandom = FillArrayRandom(array);
PrintArray(arrayRandom);
arrayRandom = ChangeElementsWithEvenIndexes(arrayRandom);
PrintArray(arrayRandom);



int[,] FillArrayRandom(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(2, 10);
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
            Console.Write($"{col[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeElementsWithEvenIndexes(int[,] arr)
{
    for (int i = 2; i < arr.GetLength(0); i += 2)
    {
        for (int j = 2; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
    return arr;
}