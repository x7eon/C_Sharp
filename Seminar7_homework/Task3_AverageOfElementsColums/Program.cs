Console.Clear();

int[,] collection = new int[5, 6];
collection = FillCollectionRandom(collection);
PrintArray(collection);

double[] averageOfElementsColumns = FindAverageOfColumns(collection);
Console.WriteLine();
Console.WriteLine(String.Join("\t", averageOfElementsColumns));


int[,] FillCollectionRandom(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i, j] = new Random().Next(0, 10);
        }
    }
    return col;
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]}\t");
        }
        Console.WriteLine();
    }
}


double[] FindAverageOfColumns(int[,] arr)
{
    int size = arr.GetLength(1);
    double[] result = new double[size];
    int z = 0;
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        result[z] = sum / arr.GetLength(0);
        z += 1;
        sum = 0;
    }
    return result;

}
