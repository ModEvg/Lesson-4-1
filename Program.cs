// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write($"Введите числа А и В: \n");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
double C = Math.Pow(A,B);
Console.Write($"Результат возведения числа А в натуральную степень В равен {C}");
