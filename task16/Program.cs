﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квардратом другого.

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

bool square(int a1, int b1)
{
    return a1 * a1 ==b1 || b1 * b1 ==a1;

}
bool result = square(a, b);

if (result) Console. WriteLine($"Правда");
else Console.WriteLine($"Ложь");
