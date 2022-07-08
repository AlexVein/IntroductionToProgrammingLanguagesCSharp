/* Задайте массив вещественных чисел.
 * Найдите разницу между максимальным и минимальным элементов массива.
 */

const double MaxValue = 100.0;
const int ArrSize = 10;

double[] arr = GenerateArray(ArrSize, MaxValue);
PrintArray(arr);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами = {GetDiff(arr):0.##}");


double[] GenerateArray(int arrSize, double maxValue)
{
    Random random = new Random();
    double[] result = new double[arrSize];

    for (int i = 0; i < arrSize; i++)
    {
        result[i] = random.NextDouble() * maxValue;
    }

    return result;
}

void PrintArray(double[] arr)
{
    foreach (double element in arr)
    {
        Console.Write($"{element:0.##}\t");
    }
}

double GetDiff(double[] arr)
{
    double min = arr[0], max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        min = (arr[i] < min) ? arr[i] : min;
        max = (arr[i] > max) ? arr[i] : max;
    }

    return max - min;
}