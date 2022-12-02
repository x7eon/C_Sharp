Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() ?? "");

double[,] userArray = FillArray(m, n);
PrintArray(userArray);

double[,] FillArray(int rows, int colums)
{
    double[,] array = new double[rows, colums];
    for (int k = 0; k < rows; k++)
    {
        for (int l = 0; l < colums; l++)
        {
            array[k, l] = new Random().NextDouble() * 20 - 10;
        }
    }
    return array;
}

void PrintArray(double[,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            double alignNum = Math.Round(collection[i, j], 1);
            Console.Write($"{alignNum}\t");
        }
    Console.WriteLine();
    }
}