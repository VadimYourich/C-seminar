// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
if number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    double count = number % 10;
    Console.WriteLine(count);
} 
else
{
    Console.WriteLine("Введите не трёхзначное число: ");
}