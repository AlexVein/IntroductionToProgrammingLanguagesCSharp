/* Задайте одномерный массив, заполненный случайными числами.
 * Найдите сумму элементов, стоящих на нечетных позициях
 */

const int MinValue = -10;
const int MaxValue = 10;
const int MaxElements = 10;

int[] array = GenerateArray(MaxElements, MinValue, MaxValue);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSummElem(array)}");


int[] GenerateArray(int maxElements, int minValue, int maxValue)
{
    Random random = new Random();
    int[] result = new int[random.Next(maxElements)];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(minValue, maxValue);
    }

    return result;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write($"{element}\t");
    }
}

int GetSummElem(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) continue;

        result += array[i];
    }

    return result;
}