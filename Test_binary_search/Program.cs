Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[n];

Console.WriteLine("Введите значение, индекс которого нужно найти: ");
int value = int.Parse(Console.ReadLine() ?? "");

array = FillArrayFrom1ToN(array);
PrintArray(array);

int answer = FindIndexBinary(array, value);
Console.WriteLine($"Индекс элемента {value} = {answer}");



int[] FillArrayFrom1ToN(int[] col)
{
    int count = 1;
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = count;
        count++;
    }
    return col;
}


void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
Console.WriteLine();
}

int FindIndexBinary(int[] array, int num)
{
    int startPoint = 0;
    int endPoint = array.Length - 1;
    while (startPoint <= endPoint)
    {
        int mid = (startPoint + endPoint) / 2;
        int guess = array[mid];
        if (guess == num)
        {
            return mid;
        }
        else if (guess < num)
        {
            startPoint = mid + 1;
        }
        else if (guess > num)
        {
            endPoint = mid - 1;
        }
    }
return -1;
}