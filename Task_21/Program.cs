/* Напишите программу, которая принимает на вход координаты двух точек
 * и находит расстояние меэжу ними в 3D пространстве
 */

const int minValue = -10;
const int maxValue = 10;

int[] firstPoint = GenerateCoordinates(minValue, maxValue);
int[] secondPoint = GenerateCoordinates(minValue, maxValue);

Console.WriteLine($"Координаты первой точки - [{PrintCoordinates(firstPoint)}]");
Console.WriteLine($"Координаты второй точки - [{PrintCoordinates(secondPoint)}]");

Console.WriteLine($"Расстояние между точками = {CalcDistance(firstPoint, secondPoint):0.##}");


double CalcDistance(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(
        Math.Pow(secondPoint[0] - firstPoint[0], 2)
        + Math.Pow(secondPoint[1] - firstPoint[1], 2)
        + Math.Pow(secondPoint[2] - firstPoint[2], 2)
        );
}

string PrintCoordinates(int[] firstPoint)
{
    string result = string.Empty;

    foreach (int coord in firstPoint)
        result += $"{coord} ";

    return result.Trim();
}

int[] GenerateCoordinates(int minValue, int maxValue)
{
    int[] result = new int[3];
    Random random = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(minValue, maxValue);
    }

    return result;
}