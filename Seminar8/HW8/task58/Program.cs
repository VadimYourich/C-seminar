// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int range = ReadNumber("Введите диапазон: от 1 до ");
int[,] matr = GetMatrix(m, n, range);
int[,] matr2 = GetMatrix(m, n, range);
int[,] compositionMatrs = GetMatrixСomposition(matr, matr2);
Console.WriteLine();
PrintMatrix(matr);
Console.WriteLine("и");
PrintMatrix(matr2);
Console.WriteLine("Их произведение будет равно следующему массиву:");
PrintMatrix(compositionMatrs);

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
int[,] GetMatrixСomposition(int[,] matr, int[,] matr2)
{
    int[,] matrix = new int[m, n];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matr[i,j] * matr2[i,j];
        }
    }
    return matrix;
}