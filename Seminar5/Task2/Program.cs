//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ChangeNumberSignInArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] *= -1;
    }
    return col;
}

int[] GetArray(int size, int min, int max)
{
    int[] collection = new int[size];
    for (int i = 0; i < size; i++)
    {
        collection[i] = new Random().Next(min, max + 1);
    }
    return collection;
}

int[] newArrayRandom = GetArray(5, -9, 9);
Console.WriteLine(String.Join(" ", newArrayRandom));

int[] changedArray = ChangeNumberSignInArray(newArrayRandom);
Console.WriteLine(String.Join(" ", changedArray));

