/* Напишите программу, которая принимает на вход число (N)
 * и выдает таблицу кубов чисел от 1 до N
 */

const int MaxValue = 10;

Random random = new Random();
int num = random.Next(MaxValue);

GetCubeTable(num);


void GetCubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} x {i} x {i} = {Math.Pow(i, 3)}");
    }
}