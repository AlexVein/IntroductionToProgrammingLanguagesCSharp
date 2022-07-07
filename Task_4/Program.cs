/* Напишите программу, которая принимает на вход три числа
 * и выдает максимальное из этих чисел
 */

Console.Write("Введите первое целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int maxNum = (firstNum > secondNum && firstNum > thirdNum) ?
    firstNum : (secondNum > thirdNum) ? secondNum : thirdNum;

Console.WriteLine();

Console.WriteLine($"Наибольшим введенным числом является число {maxNum}");