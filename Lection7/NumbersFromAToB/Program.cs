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
Console.WriteLine(ReverseNums(a, b));
Console.WriteLine(Nums(a, b));

//от a до b
string StringNumFromAToBRec(int a, int b)
{   
    if(a <= b) return $"{a} " + StringNumFromAToBRec(a + 1, b);
    else return String.Empty;
}

// от b до а
string ReverseNums(int a, int b)
{
    if (a <= b) return ReverseNums(a + 1, b) + $"{a} ";
    else return String.Empty;
}

// или так:
string Nums(int a, int b)
{   
    if(a <= b) return $"{b} " + StringNumFromAToBRec(a, b - 1);
    else return String.Empty;
}