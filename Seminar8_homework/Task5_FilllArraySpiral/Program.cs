/*
Задача 61. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int n = 4;
int[,] array = new int[n, n];
PrintArray(array);
Console.WriteLine();
int[,] arraySpiral = FillArraySpiral(array);
PrintArray(arraySpiral);
Console.WriteLine();

int[,] FillArraySpiral(int[,] collection)
{

    int n = collection.GetLength(0);
    int count = 1;

    for (int i = 0; i < n / 1; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            collection[i, j] = count;
            count++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            collection[k, n - 1 - i] = count;
            count++;
        }
        for (int l = n - 2 - i; l >= i; l--)
        {
            collection[n - 1 - i, l] = count;
            count++;
        }
        for (int m = n - 2 - i; m >= i + 1; m--)
        {
            collection[m, i] = count;
            count++;
        }

    }
    return collection;


}

/*
[0, 0, 0, 0, 0, 0]   [0, 0, 0, 0, 0, 0]   
[0, 1, 1, 1, 1, 0]   [0, 0, 0, 0, 0, 0]   
[0, 1, 2, 2, 1, 0]   [0, 0, 0, 0, 0, 0]   
[0, 1, 2, 2, 1, 0]
[0, 1, 1, 1, 1, 0]
[0, 0, 0, 0, 0, 0]
*/

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {   

            Console.Write(String.Format("{0:00\t}", array[i, j]));
        }
        Console.WriteLine();
    }
}