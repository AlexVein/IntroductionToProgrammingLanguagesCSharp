/* Напишите программу, которая на вход принимает число (N),
 * а на выъоде показывает все четные числа от 1 до N
 */

Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write($"Четные числа последовательности от 1 до {N}: ");

while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}