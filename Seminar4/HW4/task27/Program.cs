// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int num)
{
    int sum = 0;
    int count = 0;
    if (num == 0) sum = 0;
    while(num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
        count++;
    }
    return sum;
}

int number = ReadNumber("Введите число:");
int sum = GetSum(number);
Console.WriteLine(sum);
