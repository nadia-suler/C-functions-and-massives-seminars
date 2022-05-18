// Напишите программу, кот.будет на вход принимать 2 числа и выводить, явл.ли 2е число кратным 1му
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA % numberB == 0)
{
    Console.WriteLine("Число " + numberA + " кратно числу " + numberB);
}
else{
    int result = numberA % numberB;
    Console.WriteLine(result);
}