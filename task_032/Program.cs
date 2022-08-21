/*
    Задача 32: Напишите программу замена элементов
    массива: положительные элементы замените на
    соответствующие отрицательные, и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = CreateArray(length);
int[] transformArray = GetTransformArray(array);
PrintArray(array, transformArray);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] GetTransformArray(int[] array)
{
    int[] transformArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        transformArray[i] = array[i] * -1;
       
    }
    return transformArray;
}

void PrintArray(int[] array, int[] transformArray)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
    Console.Write(" -> ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("[ ");

    for (int i = 0; i < transformArray.Length; i++)
    {
        if (i == transformArray.Length -1)
        {
            Console.Write($"{transformArray[i]} ");
        }
        else 
        {
            Console.Write($"{transformArray[i]}, ");
        }
    }

    Console.WriteLine("]");
    Console.ResetColor();
}
