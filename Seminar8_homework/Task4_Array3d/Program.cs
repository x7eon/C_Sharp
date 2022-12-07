/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();

Console.WriteLine("Введите размер 3х-мерног омассива: ");
int sizeArray = int.Parse(Console.ReadLine() ?? "");

int[,,] array3d = new int[sizeArray, sizeArray, sizeArray];
array3d = FillArrayRandom(array3d);
PrintArrayWithIndex(array3d);


int[,,] FillArrayRandom(int[,,] collection)
{
    for (int k = 0; k < collection.GetLength(2); k++)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                collection[i, j, k] = new Random().Next(0, 100) + new Random().Next(0, 100);
            }
        }
    }
    return collection;
}

void PrintArrayWithIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i}{j}{k})\t");
            }
         Console.WriteLine();
        }
       
    }
}