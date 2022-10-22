int firstNum = new Random().Next(1, 100);
int secondNum = new Random().Next(1, 10);
Console.WriteLine(firstNum);
Console.WriteLine(secondNum);

if (firstNum % secondNum == 0) 
{
    Console.WriteLine($"{secondNum} является кратным {firstNum}");
}
else
{
    Console.WriteLine(firstNum % secondNum);
}
