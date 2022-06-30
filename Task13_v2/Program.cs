int number = 2754854;
int digit = 0;
while (number/100 > 0)
{
    digit = number%10;
    number = number/10;
}
Console.WriteLine(digit);