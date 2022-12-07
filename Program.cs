// Задача 27: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write($"Даны 8 случайных чисел от 0 до 100 \n");
int [] massiv = new int[8];

for (int i = 0; i<7; i++)
{
    massiv[i] = new Random().Next(0,100);
    Console.Write($" {massiv[i]},");
}
massiv[7] = new Random().Next(0,100);
Console.Write($" {massiv[7]}\n");
Console.Write($"Преобразуем числа в массив -> [");
for (int i = 0; i<7; i++)
{
   Console.Write($"{massiv[i]},"); 
}
Console.Write($"{massiv[7]}]");
