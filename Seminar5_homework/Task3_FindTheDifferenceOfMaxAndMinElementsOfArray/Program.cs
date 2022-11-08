/*Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] arr = new int[5];
Console.WriteLine(String.Join(" ", arr));

int[] filledArrRnd = FillArr(arr);
Console.WriteLine(String.Join(" ", filledArrRnd));

int res = DiffOfMaxAndMin(filledArrRnd);
Console.WriteLine(res);


int[] FillArr(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}


int DiffOfMaxAndMin(int[] col)
{   
    int max = col[0];
    int min = col[1];
    
    if (col[0] < col[1])
    {
        max = col[1];
        min = col[0];
    }
    for(int i = 2; i < col.Length; i++) 
    {
        if(col[i] > max) max = col[i];
        else if (col[i] < min) min = col[i];        
    }
    int diff = max - min;

    return diff;
}