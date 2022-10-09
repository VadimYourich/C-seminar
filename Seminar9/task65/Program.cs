// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintMtoN(int m, int n)
{
    if(n < m)
    {
        if (m == n - 1)
        {
            return;
        }
        Console.Write(m + " ");
        PrintMtoN(m - 1, n);
    }
    else if(n > m)
    {
        if(n == m - 1)
        {
            return;
        }
        PrintMtoN(m, n - 1);
        Console.Write(n + " ");
    }
    else if(n == m) Console.Write(n + " ");
}

int M = ReadNumber("Введите M");
int N = ReadNumber("Введите N");

PrintMtoN(M, N);