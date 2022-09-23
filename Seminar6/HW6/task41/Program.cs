// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Вводите числа либо stop для подсчёта положительных чисел");
int countOfPositive = 0;
while (true)
{
    string input = Console.ReadLine() ??"";
    if (input  == "stop")
    {
        break;
    }
    else
    {
        int number = Convert.ToInt32(input);
        if (number > 0)
        {
            countOfPositive++;
        }
    }
}
Console.WriteLine(countOfPositive);