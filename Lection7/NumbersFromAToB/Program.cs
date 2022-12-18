//Собрать строку с числами от a до b, a <= b

//итеративный подход

/*
Console.Clear();
Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine()?? "");

string numbers = FillStringAToB(a, b);
Console.WriteLine(numbers);

string FillStringAToB(int a, int b)
{
    string result = string.Empty;
    int i = a;
    while(i <= b)
    {
        result += $"{i} ";
        i++;
    }
    return result;
}
*/

// Рекурсивный подход

Console.Clear();
Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine()?? "");

Console.WriteLine(StringNumFromAToBRec(a, b));

string StringNumFromAToBRec(int a, int b)
{   
    if(a <= b) return $"{a} " + StringNumFromAToBRec(a + 1, b);
    else return String.Empty;
}

