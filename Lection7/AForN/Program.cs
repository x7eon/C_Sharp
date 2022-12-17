//Вычислить a в степени n.
Console.Clear();

Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()?? "");
int result = AForN(a, n);
Console.WriteLine($"{a} в степени {n} = {result}");

//итеративный подход, решение

int AForN(int a, int n)
{
    int result = 1;
    int i = 0;
    while(i < n)
    {
        result = result * a;
        i++;
    }
    return result;
}

