/* Напишите программу, которая принимает на вход число
 * и выдает сумму цифр в числе
 */

const int MaxValue = 1000;

Random random = new Random();

int num = random.Next(MaxValue);

Console.WriteLine($"Сумма цифр в числе {num} = {GetSumm(num)}");


int GetSumm(int num)
{
    int result = 0;

    for (int i = num; i > 0; )
    {
        if (i > 0) result += i % 10;
        else break;

        i /= 10;
    }

    return result;
}