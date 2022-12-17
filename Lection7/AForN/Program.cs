﻿//Вычислить a в степени n.
Console.Clear();

Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()?? "");
int result = AForN(a, n);
Console.WriteLine($"{a} в степени {n} = {result}");
Console.WriteLine();
int resultRec = AForNRec(a, n);
Console.WriteLine($"(рекурсия) {a} в степени {n} = {resultRec}");


//итеративный подход, решение

int AForN(int a, int n)
{
    int result = 1;
    for(int i = 0; i < n; i++)
    {
        result = result * a;
    }
    return result;
}

// Рекурсивный подход, решение с помощью рекурсии

int AForNRec(int a, int n)
{
    if (n == 0) return 1;
    else return AForN(a, n - 1) * a;
}
