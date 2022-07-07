/* Напишите программу, которая выводиттретью цифру заданного числа
 * или сообщает, что третьей цифры нет
 */

const int DigitPos = 3;
const int NumsInterval = 1500;

Random rand = new Random();
int num = rand.Next(NumsInterval);

if (num.ToString().Length < DigitPos)
{
    Console.WriteLine($"В числе {num} третьей цифры нет.");
}
else
{
    Console.WriteLine($"Третьей цифрой в числе {num} является - {FindNum(num, DigitPos)}");
}


char FindNum(int num, int digitPos)
{
    return num.ToString()[--digitPos];
}