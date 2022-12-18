//Вычислить a в степени n.
Console.Clear();

Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()?? "");
int result = PowerFor(a, n);
Console.WriteLine($"{a} в степени {n} = {result}");
Console.WriteLine();
int resultRec = PowerForRec(a, n);
Console.WriteLine($"(рекурсия) {a} в степени {n} = {resultRec}");
Console.WriteLine();
int resultRecMath = PowerForRecMath(a, n);
Console.WriteLine($"(рекурсия математич.) {a} в степени {n} = {resultRec}");

//итеративный подход, решение

int PowerFor(int a, int n)
{
    int result = 1;
    for(int i = 0; i < n; i++)
    {
        result = result * a;
    }
    return result;
}

// Рекурсивный подход, решение с помощью рекурсии

int PowerForRec(int a, int n)
{   
    return n == 0 ? 1: PowerForRec(a, n - 1)* a;
    //if (n == 0) return 1;
    //else return PowerForRec(a, n - 1) * a;
}

// Оптимизированное решение

int PowerForRecMath (int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerForRecMath(a * a, n / 2);
    else return PowerForRecMath(a, n - 1) * a;
}
