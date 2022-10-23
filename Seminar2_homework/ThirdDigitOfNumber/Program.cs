int number = new Random().Next(1, 100000);
Console.WriteLine(number);

if(number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
while(number / 1000 !=0)
{
    number = number / 10;
}
int result = number % 10;
Console.WriteLine(result);