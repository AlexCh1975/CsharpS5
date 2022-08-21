/*
    Задача 35: Задайте одномерный массив из 123 случайных чисел.
    Найдите количество элементов массива, значения которых лежат в
    отрезке [10,99].
    Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
    123
    [5, 18, 123, 6, 2] -> 1
    [1, 2, 3, 6, 2] -> 0
    [10, 11, 12, 13, 14] -> 5
*/

Console.Clear();

int[] array = CreateArray();
int count = GetNumberArrayElementsInInterval(array);
PrintArray(array, count);

int[] CreateArray()
{
    int[] array = new int[123];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
    return array;
}

int GetNumberArrayElementsInInterval(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

void PrintArray(int[] array, int count)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            Console.Write($"{array[i]} ");
        }
        else 
        {
            Console.Write($"{array[i]}, ");
        }
    }

    Console.Write("]");
    Console.WriteLine($" -> в массиве {count} элемента от 10 до 99.");
    Console.ResetColor();
}

