// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем
Console.WriteLine("Введите длину массива");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
for (int n = 0; n < m; n++)
{
    Console.WriteLine("Введите элементы массива");
    array[n] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введённый массив: ");
for (int n = 0; n < m; n++)
{
    Console.Write(array[n]);
}