Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] userArray = new int[m, n];
userArray = FillArray(userArray);
PrintArray(userArray);

int[,] FillArray(int[,] collection)
{
    for (int k = 0; k < collection.GetLength(0); k++)
    {
        for (int z = 0; z < collection.GetLength(1); z++)
        {
            collection[k, z] = k + z;
        }
    }
    return collection;
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
    Console.WriteLine();    
    }
}