/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 * и возвращает значение этого элемента или же указание, что такого элемента нет.
 */

const int MaxRows = 10;
const int MaxColumns = 10;
Random random = new Random();

var rows = random.Next(MaxRows);
var columns = random.Next(MaxColumns);

var array = GenerateArray(rows, columns, random);
Console.WriteLine($"Rows = {rows}, Columns = {columns}");
ShowArray(array);

Console.WriteLine();
Console.Write("Введите позицию искомого элемента (два целых числа через пробел): ");
var userCoordinates = Console.ReadLine().Split();
GetElement(userCoordinates, array);


int[,] GenerateArray(int rows, int columns, Random random)
{
    const int MinMaxValue = 100;
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = random.Next(-MinMaxValue, MinMaxValue);
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


void GetElement(string[] userCoordinates, int[,] array)
{
    int[] temp = { Convert.ToInt32(userCoordinates[0]), Convert.ToInt32(userCoordinates[1]) };
    if (temp[0] >= array.GetLength(0) || temp[1] >= array.GetLength(1))
        Console.WriteLine("В массиве нет такого элемента.");
    else
        Console.WriteLine($"Значение элемента = {array[temp[0], temp[1]]}");
}