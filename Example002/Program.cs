// Написать программу, кот.выводит случ.трехзначное число и удаляет 2 цифру этого числа.
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int total = Total(number);
Console.WriteLine(total);

int Total(int arg)
{
    int firstDigit = arg/100;
    int lastDigit = arg % 10;
    return firstDigit*10 + lastDigit;
}