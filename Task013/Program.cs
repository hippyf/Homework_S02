/* Программа, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры не существует */

Console.WriteLine("Введите число");
string number = Console.ReadLine();
Zadacha13 (number);

void Zadacha13 (string arg)
{
    int length = arg.Length;
    if (length >= 3)
    {
        Console.WriteLine("В числе " + arg + " третья цифра равна " + arg[2]);
    }
    else Console.WriteLine("В числе " + arg + " третьей цифры не существует");
}