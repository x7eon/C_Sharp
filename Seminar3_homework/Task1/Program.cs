/*
void IsNumberPolindrom ()
{   
    Console.Clear();
    Console.WriteLine("Введите пятизначное число: "); 
    string number = Console.ReadLine();
    int x = 0;
    if (int.TryParse(number, out x) == false)
    {   
        Console.WriteLine("Ошибка! Введено не число");
        return;
    }
    int length = number.Length;
    if( length > 5 || length < 5)
    {
        Console.WriteLine("Ошибка, введите пятизначное число!");
        return;
    } 
    int i = 0;                    
    for (int j = length - 1; j > length / 2; j--)
    {   
        int current1 = number[i];         
        int current2 = number[j];        

        if (current1 != current2)
        {
            Console.WriteLine($"Число {number} НЕ является полиндромом");  
            return;             
        } 
    i++;
    }
    
Console.WriteLine($"Число {number} является полиндромом");
}

IsNumberPolindrom();
*/

// Вариант без массива

/*
void IsNumberPolindrom()
{   
    Console.Clear();
    Console.WriteLine("Введите пятизначное число: ");
    int number = 0;

    try
    {
        number = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine("Ошибка ввода: " + exc.Message);
        return;
    }

    if (number / 10000 == 0 || number / 10000 > 9)
    {
        Console.WriteLine("Ошибка ввода, введите пятизначное число!");
        return;
    }
    
    int firstChar = number / 10000;
    int secondChar = (number / 1000 ) % 10;
    int lastChar = number % 10;
    int penultChar = (number % 100) / 10;

    if (firstChar == lastChar && secondChar == penultChar)
    {
        Console.WriteLine($"Число {number} - полиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} - НЕ полиндром");
    }
}

IsNumberPolindrom();
*/

void IsNumberPolindrom ()
{   
    Console.WriteLine("Введите пятизначное число: ");
    string number = Console.ReadLine() ??"";
    
    if (number.Length < 5 || number.Length > 5)
    {
    Console.WriteLine("Ошибка ввода, введите пятизначное число!");
    return;
    } 

    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} полиндром");
    }
    else
    {
        Console.WriteLine("Число не полиндром");
    }
      
}
IsNumberPolindrom();