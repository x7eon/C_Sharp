/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] collection = new int[7];
Console.WriteLine(string.Join(" ", collection));

int[] newRandomCollection = FillArray(collection);
Console.WriteLine(string.Join(" ", newRandomCollection));

int sumElementsOfOddIndex = SumElementsOfOddIndex(collection);
Console.WriteLine(sumElementsOfOddIndex);

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}


int SumElementsOfOddIndex(int[] col)
{
    int sum = 0;
    for (int i = 1; i < col.Length; i += 2)
    {
        sum += col[i];
    }
    return sum;
}