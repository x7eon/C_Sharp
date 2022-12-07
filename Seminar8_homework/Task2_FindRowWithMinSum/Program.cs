/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] arrayByUser = new int[rows, columns];
arrayByUser = FillArrayRandom(arrayByUser, 0, 10);
Console.WriteLine();
PrintArray(arrayByUser);
Console.WriteLine();

int rowResult = RowWithMinSum(arrayByUser);
Console.WriteLine($"Наименьшая сумма элементов в строке: {rowResult}");

//int resultMax = maxSumInColumns(arrayByUser);
//Console.WriteLine($"Наибольшая сумма элементов: {resultMax}");

//int resultMin = minSumInColumns(arrayByUser);
//Console.WriteLine($"Наименьшая сумма элементов: {resultMin}");

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

int RowWithMinSum(int[,] col)

{
    int rowWithMinSum = 0;
    int minSum = 0;

    for (int k = 0; k < col.GetLength(1); k++)
    {
        minSum += col[0, k];
    }
    for (int i = 0; i < col.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < col.GetLength(1); j++)
        {
            temp += col[i, j];
        }
        if (temp < minSum)
        {
            minSum = temp;
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum + 1;
}

/*
Задача своя
Задайте прямоугольный массив. Напишите программу, которая будет находить максимальную сумму по столбцам. 
*/
/*
int maxSumInColumns(int[,] col)

{
    int sum = 0;
    for (int j = 0; j < col.GetLength(1); j++)
    {   
        int tempSum = 0;
        for (int i = 0; i < col.GetLength(0); i++)
        {
            tempSum += col[i, j];
        }
        if(tempSum > sum)
        {   
            sum = tempSum;
        }
    }
return sum;
}
*/

/*
Задача своя
Задайте прямоугольный массив. Напишите программу, которая будет находить минимальную сумму по столбцам. 
*/

/*
int minSumInColumns(int[,] col)
{   
    int minSum = 0;
    for(int k = 0; k < col.GetLength(0); k++)
    {
        minSum += col[k, 0];
    }
    for (int j = 1; j < col.GetLength(1); j ++)
    {   
        int tempSum = 0;
        for(int i = 0; i < col.GetLength(0); i ++)
        {
            tempSum += col[i, j];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
        }
    }
    return minSum;
}
*/