/*
    Задача 33: Задайте массив. Напишите программу, которая
    определяет, присутствует ли заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет
    -3; массив [6, 7, 19, 345, 3] -> да
*/

//Console.Clear();

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(length);
bool result = IsNumberInArray(array, number);
PrintArray(array, result, number);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

bool IsNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

void PrintArray(int[] array, bool result, int number)
{
    string res;
    if (result == true) res = "присутствует";
    else res = "не присутствует";

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write($"{number} {res} в массиве -> ");
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

    Console.WriteLine("]");
    Console.ResetColor();
}
