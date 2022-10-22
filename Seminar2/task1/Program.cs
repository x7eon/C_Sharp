int number = new Random().Next(100, 1000);

Console.WriteLine(number);
int first = number / 100;
int last = number % 10;

Console.WriteLine($"{first}{last}");