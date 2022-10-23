int number = new Random().Next(1, 10000);
Console.WriteLine(number);

if(number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
int newNumber = number;
while(newNumber / 1000 !=0)
{
    newNumber = newNumber / 10;
}
int result = newNumber % 10;
Console.WriteLine(result);