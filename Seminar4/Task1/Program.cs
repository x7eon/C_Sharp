/* Напишите программу, которая принимает на вход число (А) и выдаёт
а) сумму чисел от 1 до А
	4 -> 10 (1+2+3+4=10)
	7 -> 28	
	8 -> 36;
б) сумму цифр в числе
	4321 -> 10 (4+3+2+1=10) 
*/

void SumsFrom1ToNAndSumsOfNuumbers ()
{
    Console.WriteLine("Введите число: "); //5
    int.TryParse(Console.ReadLine(), out int num); // 5
    int result = 0;
    Console.WriteLine();
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
        
    }
Console.WriteLine(result);

    Console.WriteLine();
    int result2 = 0;
    int length = num.ToString().Length;
    for (int i = 0; i < length; i++) // 4321
    {
        result2 = result2 + num % 10; 
        num = num / 10; 
    }
Console.WriteLine(result2);

}

SumsFrom1ToNAndSumsOfNuumbers();

