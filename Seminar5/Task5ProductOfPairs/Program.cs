//int size = new Random().Next(5, 10);
int[] arr = new int[7];
Console.WriteLine(String.Join(" ", arr));

int[] newArrayRandom = FillArray(arr);
Console.WriteLine(String.Join(" ", newArrayRandom));

//int[] arrayProduct = ProductOfNumbers(newArrayRandom);
//Console.WriteLine(String.Join(" ", arrayProduct));

Go(newArrayRandom);

int[] FillArray(int[] collection)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return collection;
}

НЕ РЕШЕНО!!!!!!!!!!!!!!!
/*
int[] ProductOfNumbers(int[] arr)
{   
    Console.WriteLine((arr.Length / 2) % 10);
    int sizeProduct = 0;
    if ((arr.Length / 2) % 10 == 0 )
    {
        sizeProduct = arr.Length / 2;
    }
    else
    {
        sizeProduct = (arr.Length / 2) + 1;
    }
    int[] product = new int[sizeProduct];
    Console.WriteLine($"Размер массива для результата {sizeProduct}");

    for (int i = 0; i < arr.Length / 2; i++)
    {
        for (int j = arr.Length - 1; j > arr.Length / 2; j--)
        {
            for (int y = 0; y < sizeProduct; y++)
            {
                if(i == j) 
                {
                    product[y] = arr[i];
                    return product;
                }
                product[y] = arr[i] * arr[j];
                Console.WriteLine(product[y]);
                i++;
                j--;
            }
        }
    }

    return product;
}

*/