Console.Write("Введите номер дня: ");
string? userInputStringDay = Console.ReadLine();
int userInputNumberDay;

if (int.TryParse(userInputStringDay, out userInputNumberDay))
{
    if (userInputNumberDay == 1) {
        Console.WriteLine("Понедельник");
    }
    if (userInputNumberDay == 2) {
        Console.WriteLine("Вторник");
    }
    if (userInputNumberDay == 3) {
        Console.WriteLine("Среда");
    }
    if (userInputNumberDay == 4) {
        Console.WriteLine("Четверг");
    }
    if (userInputNumberDay == 5) {
        Console.WriteLine("Пятница");
    }
    if (userInputNumberDay == 6) {
        Console.WriteLine("Суббота");
    }
    if (userInputNumberDay == 7) {
        Console.WriteLine("Воскресенье");
    }
    
else
    Console.WriteLine("Ошибка! Введите номер дня!");
}

