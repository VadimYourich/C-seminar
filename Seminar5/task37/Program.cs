// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = { 1, 2, 3, 4, 5 };
int[] arrnew = new int[(arr.Length + 1) / 2];

for (int i = 0; i < arrnew.Length; i++)
{
    arrnew[i] = arr[i] * arr[arr.Length - 1 - i];
    if (i == arr.Length - 1 - i)
    {
        arrnew[i] = arr[i];
    }
}

Console.WriteLine(string.Join(", ", arrnew));
