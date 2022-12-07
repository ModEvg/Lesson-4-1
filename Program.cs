// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Write($"Введите число А: \n");
int A = int.Parse(Console.ReadLine()!);
int sum = 0;
int ostatok = 1;

 while (ostatok > 0 || A > 0)
{
    ostatok = A%10;
    A = A/10;
    sum = sum+ostatok;
}
Console.Write($"Сумма цифр числа А равна {sum} \n");

