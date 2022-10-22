int number = new Random().Next(100, 1000); // 124

Console.WriteLine(number);
int first = number / 100;
int second = number % 10;

Console.WriteLine($"{first}{second}");