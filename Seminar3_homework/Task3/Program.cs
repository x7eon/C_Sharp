void TableOfCube ()
{
    Console.WriteLine("Введите число: ");
    int number = 0;
    int.TryParse(Console.ReadLine(), out number);
    for (int i = 1; i <= number; i++)
    {
        int result = (i * i * i);
        Console.WriteLine(result);
    }
}

TableOfCube();