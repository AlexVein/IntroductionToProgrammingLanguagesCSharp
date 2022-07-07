/* Напишите программу, которая на вход принимает два числа
 * и выдает, какое число большее, а какое меньшее.
 */

Console.Write("Введите первое целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (firstNum == secondNum)
{
    Console.WriteLine("Числа равны.");
}
else
{
    if (firstNum > secondNum)
    {
        Console.WriteLine("Первое число больше второго.");
    }
    else
    {
        Console.WriteLine("Второе число больше первого.");
    }
}