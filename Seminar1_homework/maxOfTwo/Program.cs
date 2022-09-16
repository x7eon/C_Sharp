Console.WriteLine("Ввдеите первое число");
string? firstNumber = Console.ReadLine();
double firstNumberDouble;

Console.WriteLine("Ввдеите второе число");
string? secondNumber = Console.ReadLine();
double secondNumberDouble;

if (double.TryParse(firstNumber, out firstNumberDouble)) 
{
    if(double.TryParse(secondNumber, out secondNumberDouble)) 
    {
        if(firstNumberDouble > secondNumberDouble) 
        {
            Console.WriteLine("Первое число больше второго");
        }
        else if(firstNumberDouble == secondNumberDouble) 
        {
            Console.WriteLine("Числа равны");
        }
        else 
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
    else 
    {
         Console.WriteLine("Ошибка! Введите число");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите число");
}






