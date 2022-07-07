/* Напишите программу,которая принимает на вход цифру,
 * обозначающую день недели, и проверяет,
 * является ли этот день выходным
 */


Console.Write("Введите цифру, обозначающую порядковый день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write($"День является выходным? - {isWeekend(day)}");


string isWeekend(int day)
{
    if (day < 1 || day > 7) 
        return "Нет такого дня. В неделе семь дней.";

    string result = (day > 0 && day < 6) ? "Нет" : "Да";

    return result;
}