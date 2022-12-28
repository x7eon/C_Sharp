Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()?? "");
int result = APowerBRec(a, b, 0);
Console.WriteLine(result);

int APowerBRec(int a, int b, int count)
{
    if (count == b) return 1;
    else return a * APowerBRec(a, b, count + 1);
}