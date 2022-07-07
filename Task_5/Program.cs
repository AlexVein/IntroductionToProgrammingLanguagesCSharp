/* Напишите программу, которая на вход принимает одно число (N),
 * а на выходе показывает все целые числа в промежутке от -N до N
 */

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;

Console.Write($"\nПоследовательность целых чисел в интервале [-{N}..{N}]: ");

while (count <= N)
{
    Console.Write($"{count++} ");
}