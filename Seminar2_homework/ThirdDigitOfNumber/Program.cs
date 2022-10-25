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


/*
int number = new Random().Next(1, 10);
Console.WriteLine(number);

string num = number.ToString();
if (num.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine(num[2]);
}
*/
