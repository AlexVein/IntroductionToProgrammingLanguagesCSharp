/* Задайте массив заполненный случайными положительными трехзначными числами.
 * Напишите программу, которая покажет количество четных чисел в массиве
 */

const int MinValue = 100;
const int MaxValue = 999;
const int MaxCountElements = 10;

int[] array = GenerateArray(MaxCountElements, MinValue, MaxValue);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Количество четных элементов в массиве = {GetSummEven(array)}");


int[] GenerateArray(int maxCountElements, int minValue, int maxValue)
{
    Random random = new Random();

    int[] result = new int[random.Next(maxCountElements)];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(minValue, maxValue);
    }

    return result;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element}\t");
}

int GetSummEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) continue;

        count++;
    }

    return count;
}