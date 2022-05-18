// Написать программу, кот.выводит случ.число из отрезка [10, 99] и показывает наибольшую цифру числа
int number = RandomInt(10, 100);
int first = number/10;
int second = number%10;
Console.WriteLine(number);

int max = MaxNumber(first, second);
Console.WriteLine(max);

int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}

int MaxNumber(int number1, int number2)
{
    int max = number1;
    if(number2 > number1)
    {
        max = number2;
    }
    return max;
}
