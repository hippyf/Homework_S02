Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int rightNum1 = number%10;
int rightNum2 = (number%100)/10;
int max = 0;
int min = 0;
int i = 1000;
if (rightNum1 > rightNum2) 
{
    max = rightNum1;
    min = rightNum2;
}
else
{
    max = rightNum2;
    min = rightNum1;
}
while (number/i > 0)
{
    int nextNum = (number%i)/(i/10);
    if (nextNum > max) max = nextNum;
    if (nextNum < min) min = nextNum;
    i = i*10;
}
int nextNum2 = (number%i)/(i/10);
if (nextNum2 > max) max = nextNum2;
if (nextNum2 < min) min = nextNum2;
while (number/i < number)
{
    int leftMinMaxNum = (number%i)/(i/10);
    if (leftMinMaxNum == max || leftMinMaxNum == min)
    {
        if (leftMinMaxNum == max) Console.WriteLine("Левее расположена максимальная цифра");
        if (leftMinMaxNum == min) Console.WriteLine("Левее расположена минимальная цифра");
        break;
    }
    i = i/10;
}
