Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()?? "");

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] collection = new int[n, m];
    for(int i = 0; i < n; i ++)
    {
        for(int j = 0; j < m; j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return collection;
}

void PrintArray(int[,] col)
{
    for(int i = 0; i < col.GetLength(0); i++)
    {
        for(int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
    Console.WriteLine();
    }
}