/* Напишите программу, которая принимает на вход трехзначное число
 * и на выходе показывает вторую цифру этого числа
 */

const int Size = 3;
int num;

Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine();


if (CheckNum(userInput, Size))
{
    num = Convert.ToInt32(userInput);
    Console.WriteLine($"Вторая цифра введенного числа - {num / 10 % 10}");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}



bool CheckNum(string userInput, int size)
{
    if (userInput.Length != size) return false;

    return int.TryParse(userInput, out int _);
}