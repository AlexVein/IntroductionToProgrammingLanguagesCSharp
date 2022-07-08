/* Напишите программу, которая принимает на вход пятизначое число
 * и проверяет, является ли оно палиндромом
 */

const int minValue = 10000;
const int maxValue = 99999;

Random random = new Random();

int num = random.Next(minValue, maxValue);
int verificationNum = 12321;

Console.WriteLine($"На вход подано число {num}");
Console.WriteLine($"Число является палиндромом? - {isPalindrome(num)}");

Console.WriteLine();
Console.WriteLine($"Число для проерки {verificationNum}");
Console.WriteLine($"Проверочное число является палиндромом? - {isPalindrome(verificationNum)}");



string isPalindrome(int num)
{
    string temp = num.ToString();

    for (int i = 0, j = temp.Length - 1; i < 2 && j > 2; i++, j-- )
    {
        if (temp[i].Equals(temp[j])) continue;

        return "Нет";
    }

    return "Да";
}