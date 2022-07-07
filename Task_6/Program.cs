/* Напишите программу, которая на вход принимает число
 * и выдает, является ли число четным
 */

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число четное.");
}
else
{
    Console.WriteLine("Число нечетное.");
}