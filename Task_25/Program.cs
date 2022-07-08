/* Напишите цикл, который принимает на вход два числа (A и B)
 * и возводит число A в натуральную степень B
 */

const int minValue = -10;
const int maxValue = 10;

Random random = new Random();

int numA = random.Next(minValue, maxValue);
int numB = random.Next(minValue, maxValue);

Console.WriteLine($"{numA} в натуральной степени {numB} = {calcRate(numA, numB)}");


int calcRate(int numA, int numB)
{
    int result = 1;

    for (int i = 1; i <= Math.Abs(numB); i++)
    {
        result *= numA;
    }

    return result;
}