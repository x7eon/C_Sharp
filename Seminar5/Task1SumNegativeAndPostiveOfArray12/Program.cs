int[] collection = new int[12];


void FillArray()
{   
    Console.WriteLine("");
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-9, 10);
    }
}


void PrintArray()
{   
    
    for (int j = 0; j < collection.Length; j++)
    {
        Console.Write($" {collection[j]}");
    }
}


void FindSumPositiveNumbers()
{   
    
    int sum = 0;
    for(int i = 0; i < collection.Length; i++)
    {
        int currentNumber = collection[i];
        
        if(collection[i] > 0)
        {
            sum += collection[i];
        }
    }
Console.WriteLine(sum);
}

void FindSumNegativeNumbers()
{   
    
    int sum = 0;
    for(int i = 0; i < collection.Length; i++)
    {
        int currentNumber = collection[i];
        
        if(collection[i] < 0)
        {
            sum += collection[i];
        }
    }
Console.WriteLine(sum);
}




PrintArray();
Console.WriteLine("");
FillArray();
PrintArray();
Console.WriteLine("");
Console.WriteLine("");
FindSumPositiveNumbers();
FindSumNegativeNumbers();