Console.Write("Напишите число, квадрат которого хоите узнать: ");
if (double.TryParse(Console.ReadLine(), out double number))
    Console.WriteLine(number * number); 
else
    Console.WriteLine("Ошибка! Введите число!");