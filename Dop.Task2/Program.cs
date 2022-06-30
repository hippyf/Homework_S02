/* На вход подаются год, номер месяца и день рождения человека. Определить возраст
человека на 1 июля 2022 года */
Console.WriteLine("Введите год рождения");
int birthYear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения");
int birthMonth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения");
int birthDay = Convert.ToInt32(Console.ReadLine());

DopTask2(birthYear, birthMonth, birthDay);

void DopTask2 (int bYear, int bMonth, int bDay)
{
   int currentYear = 2022;
   int currentMonth = 07;
   int currentDay = 01;
   int age = 0;
   if (bYear > 2022 || bMonth > 12 || bDay > 31) Console.WriteLine("Введено неверное значение");
   else if (bYear == 2022 && bMonth > 07 && bDay > 01) Console.WriteLine("Введено неверное значение");
   else if (currentMonth - bMonth == 0)
   {
    if (currentDay - bDay >= 0)
    {
        age = currentYear - birthYear;
        Console.WriteLine("Возраст - " + age + " лет");
    }
    else 
    {
        age = currentYear - birthYear - 1;
        Console.WriteLine("Возраст - " + age + " лет");
    }
   }
   else if (currentMonth - birthMonth > 0)
   {
    age = currentYear - birthYear;
    Console.WriteLine("Возраст - " + age + " лет");
   }
   else 
   {
    age = currentYear - birthYear - 1;
    Console.WriteLine("Возраст - " + age + " лет");
   }
}