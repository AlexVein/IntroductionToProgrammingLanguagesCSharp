/* Задайте двумерный массив размером MxN,
 * заполненный случайными вещественными числами
 */

const int MaxRows = 10;
const int MaxColumns = 10;
Random random = new Random();

var rows = random.Next(MaxRows);
var columns = random.Next(MaxColumns);

var array = GenerateArray(rows, columns, random);

Console.WriteLine($"Rows = {rows}, Columns = {columns}");
ShowArray(array);


double[,] GenerateArray(int rows, int columns, Random random)
{
    var result = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = random.NextDouble() * 100;
        }
    }

    return result;
}


void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:0.##}\t");
        }
        Console.WriteLine();
    }
}