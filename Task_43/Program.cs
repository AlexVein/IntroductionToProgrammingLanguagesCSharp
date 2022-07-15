/* Напишите программу, которая найдет точку пересечения двух прямых,
 * заданных уравнениями:
 * y = k1 * x + b1
 * y = k2 * x + b2
 * 
 * Значения b1, k1, b2, k2 задаются пользователем.
 */

double b1, k1, b2, k2, y1, y2;

GetUserData(out b1, out b2, out k1, out k2);
CalculateIntersectionPoint(b1, b2, k1, k2, out y1, out y2);

Console.WriteLine($"Точка пересечения прямых = ({y1:0.#}; {y2:0.#})");


void CalculateIntersectionPoint(double b1, double b2, double k1, double k2, out double y1, out double y2)
{
    var x = (b2 - b1) / (k1 - k2);
    y1 = k1 * x + b1;
    y2 = k2 * x + b2;
}


void GetUserData(out double b1, out double b2, out double k1, out double k2)
{
    Console.Write("Введите значение b1: ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k1: ");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b2: ");
    b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k2: ");
    k2 = Convert.ToDouble(Console.ReadLine());
}