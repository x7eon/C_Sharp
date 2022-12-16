/*
Задача 61. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
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

    for (int i = 0; i < n / 2; i++)
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

/*
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
*/

//Задача. Написать программу, которая будет заполнять массив m x n, по спирали. Начиная слева направо, сверху вниз. 


Console.Clear();
int n = 5;
int m = 6;
int[,] array = new int[n, m];
PrintArray(array);
Console.WriteLine();
array = FillArraySpiral(array);
PrintArray(array);

int[,] FillArraySpiral(int[,] col)
{
    int x = 0;
    int y = -1;
    int moveX = 0;
    int moveY = 1;

    int count = 1;
    while (count <= n * m)
    {
        if (y + moveY < m &&
            y + moveY >= 0 &&
            x + moveX < n &&
            x + moveX >= 0 &&
            col[x + moveX, y + moveY] == 0)
        {
            x = x + moveX;
            y = y + moveY;
            col[x, y] = count;
            count++;
        }
        else
        {
            if (moveY == 1)
            {
                moveY = 0;
                moveX = 1;
            }
            else if (moveX == 1)
            {
                moveX = 0;
                moveY = -1;
            }
            else if (moveY == -1)
            {
                moveX = -1;
                moveY = 0;
            }
            else if (moveX == -1)
            {
                moveY = 1;
                moveX = 0;
            }
        }
    }
    return col;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(String.Format("{0:00\t}", array[i, j]));
        }
        Console.WriteLine();
    }
}