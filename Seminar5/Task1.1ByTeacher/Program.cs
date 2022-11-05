
int[] array = GetArrayRandom(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);
Console.WriteLine($"Сумма положительных числел в массиве равна {positiveSum}, сумма отрицательных равна {negativeSum}");

int[] GetArrayRandom(int size, int min, int max)
    
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

int GetPositiveSum(int[] array)
{   
    int sumPositives = 0;
    foreach(int el in array)
    {   
        if (el > 0) sumPositives += el;
    }
    return sumPositives;
}

int GetNegativeSum(int[] array)
{
    int sumNegatives = 0;
    foreach(int el in array)
    {
        sumNegatives += el < 0 ? el: 0;
    }
    return sumNegatives;
}