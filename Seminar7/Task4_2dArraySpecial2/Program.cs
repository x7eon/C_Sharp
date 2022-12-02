Console.WriteLine("Введите количество строк и столбцов: ");
int rows = int.Parse(Console.ReadLine() ?? "");
int colums = rows;

int[,] arrayByUser = CreateAndFillArrayRandom2d(rows, colums, 0, 10);
PrintArray(arrayByUser);

int sumOfElementsOfDiagonal = FindSumOfDiagonal(arrayByUser);
Console.WriteLine();
Console.WriteLine(sumOfElementsOfDiagonal);

int[,] CreateAndFillArrayRandom2d(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for (int k = 0; k < rows; k++)
    {
        for (int l = 0; l < colums; l++)
        {
            array[k, l] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int FindSumOfDiagonal(int[,] collection)
{
    int i = 0;
    int j = 0;
    int sum = 0;
    while (i < collection.GetLength(0) && j < collection.GetLength(1))
    {
        sum += collection[i, j];
        i++;
        j++;
    }
    return sum;
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i,j]}\t");
        }
    Console.WriteLine();
    }
}