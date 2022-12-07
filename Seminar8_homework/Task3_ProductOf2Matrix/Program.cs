/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] arrayByUser1 = new int[rows, columns];
arrayByUser1 = FillArrayRandom(arrayByUser1, 0, 10);
Console.WriteLine();
PrintArray(arrayByUser1);
Console.WriteLine();

int[,] arrayByUser2 = new int[rows, columns];
arrayByUser2 = FillArrayRandom(arrayByUser2, 0, 10);
Console.WriteLine();
PrintArray(arrayByUser2);
Console.WriteLine();

int[,] productOf2Matrix = ProductOf2Matrix(arrayByUser1, arrayByUser2);
PrintArray(productOf2Matrix);

int[,] FillArrayRandom(int[,] collection, int minValue, int maxValue)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return collection;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ProductOf2Matrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}