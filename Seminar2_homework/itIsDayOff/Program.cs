int day = new Random().Next(1, 8);

if(day == 6 | day == 7)
{
    Console.WriteLine($"{day} - выходной день");
}
else
{
    Console.WriteLine($"{day} - не выходной день");
}