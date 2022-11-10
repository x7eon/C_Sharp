int firstSide = GetUserNumber("Введите длинну стороны треугольника", "Ошибка ввода!");
int secondSide = GetUserNumber("Введите длинну стороны треугольника", "Ошибка ввода!");
int thirdSide = GetUserNumber("Введите длинну стороны треугольника", "Ошибка ввода!");
IsRealTriangle(firstSide, secondSide, thirdSide);

int GetUserNumber(string msg, string errorMsg)
{
    while (true)
    {
        Console.WriteLine(msg);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        else
        {
            Console.WriteLine(errorMsg);
        }
    }
}


void IsRealTriangle(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
    {
        Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, {side3} существует");
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, {side3} не существует");
    }
}