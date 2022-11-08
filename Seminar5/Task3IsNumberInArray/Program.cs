int[] arrayRandom = GetArrayRandom(6, -9, 9);
Console.WriteLine(String.Join(" ", arrayRandom));
int number = -5;
bool answer = IsNumberInArray(arrayRandom, number);
string solve = PrintAnswer(answer);
Console.WriteLine(solve);

int[] GetArrayRandom(int size, int min, int max)
{
    int[] collection = new int[size];
    for(int i = 0; i < size; i ++)
    {
        collection[i] = new Random().Next(min, max + 1);
    }
    return collection;
}

bool IsNumberInArray(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            return true;
        }   
    }
    return false;
}

string PrintAnswer(bool TrueOrFalse)
{
    if (TrueOrFalse == true) return "Да";
    else return "Нет";
}
