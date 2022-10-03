// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int columnsCount = 5;
int rowsCount = 5; 
int[,] matr = GetMatrix(rowsCount, columnsCount);
PrintMatrix(matr);
int m = ReadNumber("Введите строку");
int n = ReadNumber("Введите столбец");
ElementSearch(matr);

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ElementSearch(int[,] matrix)
{
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение заданного элемента: {matrix[m, n]}");
    }
    else
    {
        Console.WriteLine($"Элемента с позицией: {m} {n} в заданном массиве нет");
    }
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
   
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
