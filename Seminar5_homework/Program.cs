//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[new Random().Next(3, 16)];
Console.WriteLine(String.Join(" ", array));
int[] myCol = FillArrayRandomDigit3(array);
Console.WriteLine(String.Join(" ", myCol));
int numberOfEven = FindEvenNumbersInArray(myCol);
Console.WriteLine(numberOfEven);



int[] FillArrayRandomDigit3(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
    return collection;
}

int FindEvenNumbersInArray(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {

        if (collection[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}