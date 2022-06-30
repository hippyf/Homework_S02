/* Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц
размер вклада увелиивается на 1,5% от имеющиеся суммы. Определить размер депозита
через n месяцев */

Console.WriteLine("Введите сумму первоначального вклада");
double initDeposit = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество месяцев");
double countMonth = Convert.ToDouble(Console.ReadLine());
Zadacha3(initDeposit, countMonth);

void Zadacha3 (double Depo, double Month)
{
    double rate = 1.5;
    double count = 0;
    while (count < Month)
    {
        Depo = Depo + Depo*(rate/100);
        count++;
    }
    Console.WriteLine(Depo);
}