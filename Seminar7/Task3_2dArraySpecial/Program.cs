Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, colums];
PrintArray(array);
int[,] arrayRandom = FillArrayRandom(array);
PrintArray(arrayRandom);
arrayRandom = ChangeArray(arrayRandom);
PrintArray(arrayRandom);



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
            Console.Write($"{col[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i > 0 && j > 0 && i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}