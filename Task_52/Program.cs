/* Задайте двумерный массив из целых чисел.
 * Найдите среднее арифметическое элементов в каждом столбце.
 */

const int MaxRows = 10;
const int MaxColumns = 10;
const int MinMaxValue = 10;
Random random = new Random();

var rows = random.Next(MaxRows);
var columns = random.Next(MaxColumns);

var array = GenerateArray(rows, columns, MinMaxValue, random);

Console.WriteLine($"Rows = {rows}, Columns = {columns}");
ShowArray(array);

ShowArithmeticMeanColumns(array);


int[,] GenerateArray(int rows, int columns, int minMaxValue, Random random)
{
    var result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = random.Next(-minMaxValue, minMaxValue);
        }
    }

    return result;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ShowArithmeticMeanColumns(int[,] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp += array[i, j];
        }
        Console.WriteLine($"{j + 1} столбец = {temp / array.GetLength(0):0.##}");
    }
}