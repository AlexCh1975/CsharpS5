/*
    Задача 37: Найдите произведение пар чисел в одномерном массиве.
    Парой считаем первый и последний элемент, второй и предпоследний
    и т.д. Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21
*/

//Console.Clear();

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(length);
int[] newArray = GetWorkNumberInArray(array);
PrintArray(array, newArray);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] GetWorkNumberInArray(int[] array)
{ 
    int lengthNewArray;

    if (array.Length % 2 == 0) lengthNewArray = array.Length / 2; 
    else lengthNewArray = array.Length / 2 + 1;

    int[] newArray = new int[lengthNewArray];

    for (int i = 0; i < lengthNewArray; i++)
    {
        int n = array.Length - 1;

        if (i == lengthNewArray -1 && array.Length % 2 != 0) newArray[i] = array[i];
        else newArray[i] = array[i] * array[n - i];
    }
    return newArray;
}

void PrintArray(int[] array, int[] newArray)
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
    Console.ResetColor();


    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" -> ");
    Console.Write("[ ");

    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == newArray.Length -1)
        {
            Console.Write($"{newArray[i]} ");
        }
        else 
        {
            Console.Write($"{newArray[i]}, ");
        }
    }

    Console.WriteLine("]");
    Console.ResetColor();
}