int number = new Random().Next(100, 1000);

int firstChar = number / 10;
int result = firstChar % 10;

Console.WriteLine(number);
Console.WriteLine(result);