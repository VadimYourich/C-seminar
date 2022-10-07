// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int range = ReadNumber("Введите диапазон: от 1 до ");
int[,] matr = GetMatrix(m, n, range);
Console.WriteLine();
PrintMatrix(matr);
SumLineElements(matr);
int sumLineOne = SumLineElements(matr);
MinSumLineElements(matr);

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

int SumLineElements(int[,] matrix)
{
    int sumLineOne = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sumLineOne += matrix[0,j];
    } 
    return sumLineOne;
}        
void MinSumLineElements(int[,] matrix)
{
    int minSumLine = 0;
    int minRow = 0; //индекс строки с мин. суммой элементов    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            minSumLine += matrix[i,j];   
        } 
        if (minSumLine < sumLineOne) 
            {
                sumLineOne = minSumLine;
                minRow = i;  
            }
        minSumLine = 0;
    }
    Console.WriteLine($"\n{minRow + 1} - строкa с наименьшей суммой элементов: {sumLineOne}");
}