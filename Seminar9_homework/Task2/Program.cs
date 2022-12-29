Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine() ?? "");

int solve = Akkerman(m, n);
Console.WriteLine(solve);

int Akkerman(int m, int n)
{   
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return -1;
}