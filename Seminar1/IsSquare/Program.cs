Console.WriteLine("Введите первое число: ");
string? a = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? b = Console.ReadLine();

double num1;
double num2;

if (double.TryParse(a, out num1) && double.TryParse(b, out num2)) 
{
    if (num1 == num2 * num2) 
    {
        Console.WriteLine(num1 + " является квадратом " + num2);
    }
    else
    {
        Console.WriteLine(num1 + " НЕ является квадратом " + num2);
    }
}
else
{
    Console.WriteLine("Ошибка! Введенное значение или значения не являются числами. Введите два числа.");
}
