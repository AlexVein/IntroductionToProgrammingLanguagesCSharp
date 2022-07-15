/* Пользователь вводит с клавиатуры M чисел.
 * Посчитайте, сколько чисел больше 0 ввёл пользователь
 */

Console.Write("Введите произвольные целые числе через пробел: ");
var userInput = Console.ReadLine().Split();

Console.WriteLine($"В последовательности количество чисел больше нуля = {CountPositiveNumbers(userInput)}");


int CountPositiveNumbers(string[] userInput)
{
    var count = 0;

    foreach (var element in userInput)
        if (Convert.ToInt32(element) > 0) count++;

    return count;
}