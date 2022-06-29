/* Программа, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным */

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha15(number);

void Zadacha15 (int arg)
{
    if (arg >= 1 && arg <= 5) Console.WriteLine ("НЕТ, не выходной");
    else if (arg == 6 || arg == 7) Console.WriteLine ("ДА, это выходной!");
    else Console.WriteLine ("Введено неверное по условиям число");
}