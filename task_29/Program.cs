/*
29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Сделала ручной ввод размера массива, ограничила случайные числа [0, 100)

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99);
    }
    return result;
}

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат: [{String.Join("; ", GetArray(arraySize))}]");