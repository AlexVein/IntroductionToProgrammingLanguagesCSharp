/* Напишите программу, которая задает массив из 8 элементов,
 * заполеннный псевдослучайными числами и выводит их на экран
 */

const int MaxValue = 10;
const int CountElem = 8;

int[] arr = GenerateArray(CountElem, MaxValue);
PrintArray(arr);


int[] GenerateArray(int countElem, int maxValue)
{
    int[] result = new int[countElem];
    Random random = new Random();

    for (int i = 0; i < countElem; i++)
    {
        result[i] = random.Next(MaxValue);
    }

    return result;
}

void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.Write($"{element} ");
    }
}