// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

(int, int) GetMaxAndMin(int[] arr)
{
    int Max = arr[0];
    int Min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max)
        {
            Max = arr[i];
        }
        if (arr[i] < Min)
        {
            Min = arr[i];
        }
    }
    return (Max, Min);
}

Random rand = new Random();
int randomSize = rand.Next(5, 10);
int[] array = GetArray(randomSize, 10, 99);
Console.WriteLine(string.Join(", ", array));
(int Max, int Min) = GetMaxAndMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Max - Min}");