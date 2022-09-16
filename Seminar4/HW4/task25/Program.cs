// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Не использовать Math.Pow() и аналоги!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int compositionA = 1;

for (int i = 1; i <= B; i++)
{
    compositionA = compositionA * A;
}
Console.WriteLine(compositionA);
