// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
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

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

void ArithmeticMean(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        double mean = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
            mean = Math.Round(sum / matrix.GetLength(0), 1);
        }
        Console.Write($"{mean}; ");
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.Write("Среднее арифметическое каждого столбца: "); 
ArithmeticMean(matr);
