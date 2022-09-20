// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int GetCount(int[] arr)
{
    int count = 0; //счётчик чётных чисел
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}
Random rand = new Random();
int randomSize = rand.Next(5, 10);
int[] array = GetArray(randomSize, 100, 999);
Console.WriteLine(string.Join(", ", array));
int count = GetCount(array);
Console.WriteLine($"Kоличество чётных чисел в массиве = {count}");