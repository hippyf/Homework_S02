/* Написать программу, которая определяется,является ли треугольник со сторонами
a, b и с равнобедренным */

//Условия существования треугольника: a+b > c; a+c > b; b+c > a
//Длина стороны треугольника не может быть меньше или равна 0.

Console.WriteLine("Введите сторону треугольника a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника c");
int c = Convert.ToInt32(Console.ReadLine());
DopTask1(a, b, c);

void DopTask1 (int a, int b, int c)
{
    if (c > a+b || b > a+c || a > b+c) Console.WriteLine("Треугольник не существует");
    else if (a <= 0 || b <= 0 || c <= 0) Console.WriteLine("Введены неверные данные");
    else if (a == b && a == c) Console.WriteLine("Треугольник равносторонний");
    else if (a == b || a == c || c == b) Console.WriteLine ("Треугольник равнобедренный");
    else Console.WriteLine ("Треугольник не является ни равнобедренным, ни равносторонним");
}
