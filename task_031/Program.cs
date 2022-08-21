/*
    Задача 31: Задайте массив из 12 элементов, заполненный
    случайными числами из промежутка [-9, 9]. Найдите сумму
    отрицательных и положительных элементов массива.
    Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
    положительных чисел равна 29, сумма отрицательных равна
    -20.
*/

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());

int sumPositiveNumbers;

int[] array = CreateArray(length);
int sumNegativeNumber = GetNumberSign(array, out sumPositiveNumbers);
PrintArray(array, sumPositiveNumbers, sumNegativeNumber);

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int GetNumberSign(int[] array, out int sumPositiveNumbers)
{
    sumPositiveNumbers = 0;
    int sumNegativeNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) 
        {
            sumNegativeNumbers += array[i];
        }
        else
        {
            sumPositiveNumbers += array[i];
        }
    }
    return sumNegativeNumbers;
}

void PrintArray(int[] array, int sumPositiveNumbers, int sumNegativeNumbers)
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
    Console.WriteLine($" Сумма отрицательных элементов = {sumNegativeNumbers}; сумма положительных элементов = {sumPositiveNumbers}");
    Console.ResetColor();
}