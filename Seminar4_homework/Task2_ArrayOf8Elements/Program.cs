int[] array = new int[8];
FillArray();
PrintArray();

int GetNumberByUser(string msg, string errorMsg)
{   
    Console.WriteLine(msg);
    while(true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) 
            return userNumber;
        Console.WriteLine(errorMsg);
    }
}

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumberByUser("Введите число " , "Ошибка ввода!");
    }
}



void PrintArray()
{   
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}



