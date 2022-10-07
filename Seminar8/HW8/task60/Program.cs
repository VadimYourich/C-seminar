// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int d = ReadNumber("Введите длину массива");
int sh = ReadNumber("Введите ширину массива");
int g = ReadNumber("Введите глубину массива");
Console.WriteLine($"Массив размером {d} x {sh} x {g}");
int[,,] matr = GetMatrix(d, sh, g);

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetMatrix(int length, int width, int depth, int leftRange = 1, int rightRange = 1000)
{
    Random rand = new Random();
    int[] random = new int[rightRange];
    for(int i = 0; i < random.Length; i++)
    {
        int number = rand.Next(leftRange, rightRange + 1);
        if (random.Contains(number)) i--; 
        else random[i] = number;
    }
    int count = 0;
    int[,,] matrix = new int[length, width, depth];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(1); z++)
            {
                matrix[i,j,z] = random[count];
                count++; 
                Console.WriteLine($"{matrix[i,j,z]} ({i}, {j}, {z})");
            }
        }
    }
    return matrix;
}