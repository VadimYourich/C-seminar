// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int range = ReadNumber("Введите диапазон: от 1 до ");
int[,] matr = GetMatrix(m, n, range);
Console.WriteLine();
PrintMatrix(matr);
Console.WriteLine("В итоге получается вот такой массив:");
SortMatr(matr);
PrintMatrix(matr);

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int rightRange, int leftRange = 1)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortMatr(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 1; j < matrix.GetLength(1); j++)
        {
            int temp = 0;
            if (matrix[i,j] < matrix[i,j - 1])
            {
                temp = matrix[i,j - 1];
                matrix[i,j - 1] = matrix[i,j];
                matrix[i,j] = temp;
                j = 0;
            }    
        }
    }
    return matrix;
}