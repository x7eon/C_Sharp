Console.Write("Введите первое число: ");
string firstNum = Console.ReadLine()?? "";

Console.Write("Введите второе число: ");
string secondNum = Console.ReadLine()?? "";

Console.Write("Введите третье число: ");
string thirdNum = Console.ReadLine()?? "";

double firstNumDouble;
double secondNumDouble;
double thirdNumDouble;

if(double.TryParse(firstNum, out firstNumDouble) && double.TryParse(secondNum, out secondNumDouble) && double.TryParse(thirdNum, out thirdNumDouble)) 
{
    double max = firstNumDouble;
    if(secondNumDouble > firstNumDouble) 
    {
        max = secondNumDouble;
    }
    if(thirdNumDouble > max) 
    {
        max = thirdNumDouble;
    }
    Console.WriteLine("max = "+ max);
}
else
{
    Console.WriteLine("Ошибка ввода! Введите корректно все числа!");
}
