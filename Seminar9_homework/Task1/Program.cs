Console.WriteLine("Введите число m: ");
int firstNum = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n: ");
int secondNum = int.Parse(Console.ReadLine()?? "");

int answer = SumOfDigit(firstNum, secondNum);
Console.WriteLine(answer);

int SumOfDigit(int m, int n) 
{
    if (m > n) return 0;
    else return m + SumOfDigit(m + 1, n);
}
