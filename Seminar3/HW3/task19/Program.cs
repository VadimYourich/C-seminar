// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    int first = number / 10000;
    int fifth = number % 10;
    int second = (number / 1000) % 10;
    int fourth = (number / 10) % 10;
    if (first == fifth && second == fourth)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Число не пятизначное!");
}