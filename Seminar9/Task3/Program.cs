Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine()?? "");
int answer = SumOfDigit(num);
Console.WriteLine(answer);

int SumOfDigit(int number) 
{
if (number / 10 == 0) return number % 10;
else return number % 10 + SumOfDigit(number / 10);
}

