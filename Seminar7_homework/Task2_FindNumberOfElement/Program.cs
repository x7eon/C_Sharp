Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите индекс строки искомого элемента: ");
int i = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите индекс столбца искомого элемента: ");
int j = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, columns];
int[,] arrayRandom = FillArrayRandom(array);
PrintArray(arrayRandom);
PrintValue(arrayRandom, i, j);


int[,] FillArrayRandom(int[,] array)
{
    for (int m = 0; m < rows; m++)
    {
        for (int n = 0; n < columns; n++)
        {
            array[m, n] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] col)
{
    for (int k = 0; k < col.GetLength(0); k++)
    {
        for (int l = 0; l < col.GetLength(1); l++)
        {
            Console.Write($"{col[k, l]}\t");
        }
    Console.WriteLine();
    }
}


void PrintValue(int[,] collection, int i, int j)
{
    if(i >= 0 && i <= collection.GetLength(0) &&
       j >= 0 && j <= collection.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива с индексом [{i},{j}] равно {collection[i, j]}");
    }
    else
    {
        Console.WriteLine($"Элемента с индексом [{i},{j}] в массиве нет");
    }
}